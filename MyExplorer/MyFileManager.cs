using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileManager
{
   static class MyFileManager
    {

       public static void CreateDirectory(string path)
       {
           DirectoryInfo dir = new DirectoryInfo(path);
           CreateDirectory(dir);
       }

       public static bool CreateDirectory(DirectoryInfo path)
       {
           if (path.Exists == true)
           {
               if (DialogResult.OK == MessageBox.Show (
                   String.Format("Папка {0} уже существует. Заменить ее?", path.FullName),
                   "Создание папки " + path.FullName,
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                 Directory.Delete(path.FullName, true);
               else
                 return false;
           }
           Directory.CreateDirectory(path.FullName);
           return true;
       }



       public static void CopyFile(string sourceFilePath, string targetFilePath)
       {
           FileInfo fileSource = new FileInfo(sourceFilePath);
           CopyFile(fileSource, targetFilePath);
       }

       public static void CopyFile(FileInfo sourceFile, string targetFilePath)
       {
           if (!sourceFile.Exists)
               throw new FileNotFoundException (String.Format("Файл {0} не найден: ", sourceFile.FullName));
           if (File.Exists(targetFilePath) == true)
           {
               if (DialogResult.Cancel == MessageBox.Show(String.Format("Файл {0} уже существует. Заменить его?", targetFilePath),
                                  "Копирование файла " + targetFilePath,
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Question))
                   return;

           }
               sourceFile.CopyTo(targetFilePath, true);
       }



       public static void CopyDirectory(string sourceDirectoryPath, string targetDirectoryPath)
       {
           DirectoryInfo dirSource = new DirectoryInfo(sourceDirectoryPath);
           DirectoryInfo dirTarget = new DirectoryInfo(targetDirectoryPath);
           CopyAllDirectory(dirSource, dirTarget);
       }

       public static void CopyAllDirectory(DirectoryInfo dirSource, DirectoryInfo dirTarget)
       {
           if (!dirSource.Exists)
               throw new DirectoryNotFoundException(String.Format("Папка {0} не найдена: ", dirSource.FullName));
           if (!MyFileManager.CreateDirectory(dirTarget))
               return;

           foreach (FileInfo files in dirSource.GetFiles())
               CopyFile(files.FullName, Path.Combine(dirTarget.FullName, files.Name));

           foreach (DirectoryInfo subDirsSource in dirSource.GetDirectories())
           {
               CopyDirectory (subDirsSource.FullName, Path.Combine (dirTarget.FullName, subDirsSource.Name));
           }
       }


       public static void MoveDirectory(string pathSource, string pathTarget)
       {
           string patern = @"\b\S:\\";
           Match matchSource = Regex.Match(pathSource, patern, RegexOptions.IgnoreCase);
           Match matchTarget = Regex.Match(pathTarget, patern, RegexOptions.IgnoreCase);
           if ((matchSource.Length > 0 && matchTarget.Length > 0) && matchSource.Value[0] != matchTarget.Value[0])
           {
               CopyDirectory(pathSource, pathTarget);
               Directory.Delete(pathSource, true);
           }
           else
           {
               try
               {
                   Directory.Move(pathSource, pathTarget);
               }
               catch (IOException)
               {
                   throw new IOException("Папка уже существует, либо указнные пути ссылаются на один и тот же файл или каталог, либо указано неверное значение для пути.");
               }
           }
       }
    }
}
