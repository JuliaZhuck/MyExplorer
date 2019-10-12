using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FileManager;

namespace MyExplorer
{
    public partial class Form1 : Form
    {
        private string fullPathSelected = "";
        private bool sortAcending = true;
        private List<string> fullPathForCopyList = new List<string>();
        private bool mustCutItems = false;
        private NewName newNameForm;

        public Form1()
        {
            InitializeComponent();

            DriveTreeInit();
        }

        private void DriveTreeInit()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            fullPathSelected = allDrives[0].Name;
            this.treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady != true)
                {
                    TreeNode treeNodeDrive = new TreeNode(drive.Name, 4, 4);
                    treeView1.Nodes.Add(treeNodeDrive);
                }
                else
                {
                    string nodeString = drive.Name;
                    TreeNode treeNodeDrive = new TreeNode(nodeString); ;
                    switch (drive.DriveType)
                    {
                        case DriveType.Fixed:
                            treeNodeDrive.ImageIndex = 0;
                            break;
                        case DriveType.CDRom:
                            treeNodeDrive.ImageIndex = 1;
                            break;
                        case DriveType.Removable:
                            treeNodeDrive.ImageIndex = 7;
                            break;
                        case DriveType.Network:
                            treeNodeDrive.ImageIndex = 3;
                            break;
                        default:
                            treeNodeDrive.ImageIndex = 4;
                            break;
                    }

                    if (treeNodeDrive != null)
                    {
                        treeView1.Nodes.Add(treeNodeDrive);
                        GetDirs(treeNodeDrive);
                    }
                }
            }
            this.treeView1.EndUpdate();
            this.treeView1.SelectedNode = treeView1.Nodes[0];
            this.treeView1.SelectedNode.Expand();
            this.Text = fullPathSelected;
        }


        private void GetDirs(TreeNode node)
        {
            DirectoryInfo[] dirArray;
            node.Nodes.Clear();
            string pathToDir = node.FullPath;
            DirectoryInfo dir = new DirectoryInfo(pathToDir);
            try
            {
                dirArray = dir.GetDirectories();
            }
            catch
            {
                return;
            }
            foreach (DirectoryInfo dirinfo in dirArray)
            {
                TreeNode dirNode = new TreeNode(dirinfo.Name, 5, 6);
                node.Nodes.Add(dirNode);
            }
        }


        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.BeginUpdate();
            foreach (TreeNode node in e.Node.Nodes)
                GetDirs(node);
            treeView1.EndUpdate();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            fullPathSelected = selectedNode.FullPath;
            this.Text = fullPathSelected;
            LoadList();
        }

        private void LoadList()
        {
            DirectoryInfo dir = new DirectoryInfo(fullPathSelected);
            FileInfo[] fileArray;
            DirectoryInfo[] dirArray;
            try
            {
                fileArray = dir.GetFiles();
                dirArray = dir.GetDirectories();
            }
            catch
            {
                return;
            }
            listView1.Items.Clear();
            if (this.sortAcending)
            {
                foreach (DirectoryInfo dirInfo in dirArray)
                    AddFolderInList(dirInfo);
                foreach (FileInfo fileInfo in fileArray)
                    AddFileInList(fileInfo);
            }
            else
            {
                for (int i = fileArray.Length - 1; i >= 0; i--)
                    AddFileInList(fileArray[i]);
                for (int j = dirArray.Length - 1; j >= 0; j--)
                    AddFolderInList(dirArray[j]);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void AddFolderInList(DirectoryInfo dirInfo)
        {
            ListViewItem lvi = new ListViewItem(dirInfo.Name);
            lvi.SubItems.Add("");
            lvi.SubItems.Add(dirInfo.LastWriteTime.ToString());
            lvi.ImageIndex = 0;
            listView1.Items.Add(lvi);
        }

        private void AddFileInList(FileInfo fileInfo)
        {
            ListViewItem lvi = new ListViewItem(fileInfo.Name);
            lvi.SubItems.Add(fileInfo.Length.ToString());
            lvi.SubItems.Add(fileInfo.LastWriteTime.ToString());

            string filenameExtension =
              Path.GetExtension(fileInfo.Name).ToLower();

            switch (filenameExtension)
            {
                case ".exe":
                    lvi.ImageIndex = 1;
                    break;
                case ".doc":
                    lvi.ImageIndex = 2;
                    break;
                case ".txt":
                    lvi.ImageIndex = 3;
                    break;
                case ".mp3":
                    lvi.ImageIndex = 4;
                    break;
                case ".avi":
                case ".mpg":
                case ".mpeg":
                case ".mkv":
                case ".m2v":
                case ".flv":
                    lvi.ImageIndex = 5;
                    break;
                case ".jpg":
                case ".bmp":
                case ".jpeg":
                case ".gif":
                    lvi.ImageIndex = 6;
                    break;
                case ".htm":
                case ".html":
                    lvi.ImageIndex = 7;
                    break;
                case ".xml":
                    lvi.ImageIndex = 8;
                    break;
                case ".xslt":
                    lvi.ImageIndex = 9;
                    break;
                case ".cs":
                    lvi.ImageIndex = 10;
                    break;
                case ".hlp":
                    lvi.ImageIndex = 11;
                    break;
                default:
                    lvi.ImageIndex = 12;
                    break;
            }
            listView1.Items.Add(lvi);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.sortAcending = !this.sortAcending;
            switch (e.Column)
            {
                case 0:
                    this.listView1.Sorting = SortOrder.None;
                    this.listView1.ListViewItemSorter = null;
                    this.LoadList();
                    break;
                case 1:
                    this.listView1.ListViewItemSorter = new ListItemsComparer(
                      ListItemsComparer.ListItemCompareType.bySize, e.Column, this.sortAcending);
                    break;
                case 2:
                    this.listView1.ListViewItemSorter = new ListItemsComparer(
                      ListItemsComparer.ListItemCompareType.byChanged, e.Column, this.sortAcending);
                    break;
            }
        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            this.toolStripStatusLabel1.Text = Path.Combine(fullPathSelected, e.Item.Text);
            if (e.Item.SubItems[1].Text != "")
                this.toolStripStatusLabel2.Text = "Размер: " + e.Item.SubItems[1].Text + " kb";
            else
                this.toolStripStatusLabel2.Text = "Папка с файлами";
        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            this.toolStripStatusLabel2.Text = "";
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                this.toolStripMenuItemEditCut.Enabled = true;
                this.toolStripMenuItemEditCopy.Enabled = true;
                this.toolStripMenuItemFileDelete.Enabled = true;
                this.toolStripMenuItemFileRename.Enabled = true;
                this.toolStripMenuItemFileRename.Enabled = true;
                this.toolStripButtonCut.Enabled = true;
                this.toolStripButtonCopy.Enabled = true;
                this.toolStripButtonDelete.Enabled = true;
                this.toolStripContextMenuItemCopy.Enabled = true;
                this.toolStripContextMenuItemCut.Enabled = true;
                this.toolStripContextMenuItemDelete.Enabled = true;
                this.toolStripContextMenuItemRename.Enabled = true;
            }
            else
            {
                this.toolStripMenuItemFileDelete.Enabled = false;
                this.toolStripMenuItemEditCut.Enabled = false;
                this.toolStripMenuItemEditCopy.Enabled = false;
                this.toolStripMenuItemFileRename.Enabled = false;
                this.toolStripMenuItemFileRename.Enabled = false;
                this.toolStripButtonCut.Enabled = false;
                this.toolStripButtonCopy.Enabled = false;
                this.toolStripButtonDelete.Enabled = false;
                this.toolStripContextMenuItemCopy.Enabled = false;
                this.toolStripContextMenuItemCut.Enabled = false;
                this.toolStripContextMenuItemDelete.Enabled = false;
                this.toolStripContextMenuItemRename.Enabled = false;
            }
            if (this.fullPathForCopyList.Count > 0)
            {
                this.toolStripMenuItemEditPaste.Enabled = true;
                this.toolStripButtonPaste.Enabled = true;
                this.toolStripContextMenuItemPaste.Enabled = true;
            }
            else
            {
                this.toolStripMenuItemEditPaste.Enabled = false;
                this.toolStripButtonPaste.Enabled = false;
                this.toolStripContextMenuItemPaste.Enabled = false;
            }
        }

        #region MenuItem View TreeView


        private void toolStripMenuItemViewDetails_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
            CheckMenuForListView();
        }

        private void toolStripMenuItemViewList_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.List;
            CheckMenuForListView();
        }

        private void toolStripMenuItemViewLargeIcon_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
            CheckMenuForListView();
        }

        private void toolStripMenuItemViewTile_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
            CheckMenuForListView();
        }

        private void CheckMenuForListView()
        {
            if (this.listView1.View == View.Details)
                toolStripMenuItemViewDetails.Checked = true;
            else
                toolStripMenuItemViewDetails.Checked = false;
            if (this.listView1.View == View.List)
                toolStripMenuItemViewList.Checked = true;
            else
                toolStripMenuItemViewList.Checked = false;
            if (this.listView1.View == View.LargeIcon)
                toolStripMenuItemViewLargeIcon.Checked = true;
            else
                toolStripMenuItemViewLargeIcon.Checked = false;
            if (this.listView1.View == View.Tile)
                toolStripMenuItemViewTile.Checked = true;
            else
                toolStripMenuItemViewTile.Checked = false;
        }

        #endregion


        private void toolStripMenuItemViewStatusStrip_Click(object sender, EventArgs e)
        {
            this.statusStrip1.Visible = (!this.statusStrip1.Visible);
            this.toolStripMenuItemViewStatusStrip.Checked = this.statusStrip1.Visible;
        }


        #region MenuItem View Sort

        private void toolStripMenuItemSortItemsByName_Click(object sender, EventArgs e)
        {
            this.listView1.Sorting = SortOrder.None;
            this.listView1.ListViewItemSorter = null;
            this.sortAcending = !this.sortAcending;
            this.LoadList();
            foreach (ToolStripMenuItem item in this.toolStripMenuItemSortItems.DropDown.Items)
                if (item.Checked)
                    item.Checked = false;
            this.toolStripMenuItemSortItemsByName.Checked = true;
        }

        private void toolStripMenuItemSortItemsBySize_Click(object sender, EventArgs e)
        {
            this.sortAcending = !this.sortAcending;
            this.listView1.ListViewItemSorter = new ListItemsComparer(
                      ListItemsComparer.ListItemCompareType.bySize, 1, this.sortAcending);
            foreach (ToolStripMenuItem item in this.toolStripMenuItemSortItems.DropDown.Items)
                if (item.Checked)
                    item.Checked = false;
            this.toolStripMenuItemSortItemsBySize.Checked = true;
        }

        private void toolStripMenuItemSortItemByChanged_Click(object sender, EventArgs e)
        {
            this.sortAcending = !this.sortAcending;
            this.listView1.ListViewItemSorter = new ListItemsComparer(
                      ListItemsComparer.ListItemCompareType.byChanged, 2, this.sortAcending);
            foreach (ToolStripMenuItem item in this.toolStripMenuItemSortItems.DropDown.Items)
                if (item.Checked)
                    item.Checked = false;
            this.toolStripMenuItemSortItemByChanged.Checked = true;
        }

        #endregion


        #region MenuItem Edit


        private void toolStripMenuItemEditCopy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView1.SelectedItems.Count; i++)
            {
                fullPathForCopyList.Add(Path.Combine (fullPathSelected, this.listView1.SelectedItems[i].Text));
            }
        }

        private void toolStripMenuItemEditPaste_Click(object sender, EventArgs e)
        {
            if (fullPathForCopyList.Count > 0)
            {
                foreach (string source in fullPathForCopyList)
                {
                    if (Path.GetExtension(source) != String.Empty)
                    {
                        string fileName = Path.GetFileName(source);
                        try
                        {
                            if (mustCutItems)
                            {
                                File.Move(source, Path.Combine(fullPathSelected, fileName));
                                this.toolStripStatusLabel1.Text = "Перемещение файла";
                            }
                            else
                            {
                                MyFileManager.CopyFile(source, Path.Combine(fullPathSelected, fileName));
                                this.toolStripStatusLabel1.Text = "Копирование файла";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,
                                "Ошибка при копировании файла " + source,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string folderName = Path.GetFileName(source);
                        try
                        {
                            if (mustCutItems)
                            {
                                MyFileManager.MoveDirectory(source, Path.Combine(fullPathSelected, folderName));
                                this.toolStripStatusLabel1.Text = "Перемещение папки";
                            }
                            else
                            {
                                MyFileManager.CopyDirectory(source, Path.Combine(fullPathSelected, folderName));
                                this.toolStripStatusLabel1.Text = "Копирование папки";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,
                                "Ошибка при копировании папки " + source,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                LoadList();
                UpdateTreeNode(Path.GetPathRoot(fullPathForCopyList[0]));
                UpdateTreeNode(fullPathSelected);
                fullPathForCopyList.Clear();
                this.toolStripStatusLabel1.Text = "";
                mustCutItems = false;
            }
        }

        private void toolStripMenuItemEditCut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView1.SelectedItems.Count; i++)
            {
                fullPathForCopyList.Add(Path.Combine(fullPathSelected, this.listView1.SelectedItems[i].Text));
                this.listView1.SelectedItems[i].ForeColor = Color.Gray;
            }
            mustCutItems = true;
        }

        private void UpdateTreeNode(string pathToNode)
        {
            foreach (TreeNode node in this.treeView1.Nodes)
            {
                if (node.FullPath == pathToNode)
                {
                    //MessageBox.Show("I will update Node : " + node.FullPath);
                    GetDirs(node);
                }
            }
        }


        #endregion

        private void toolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemFileDelete_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in this.listView1.SelectedItems)
                {
                    string path = Path.Combine (fullPathSelected, item.Text);
                    if (Path.GetExtension(path) == String.Empty)
                    {
                        try
                        {
                            Directory.Delete(path, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,
                                "Удаление папки " + path,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        try
                        {
                            File.Delete(path);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,
                                "Удаление файла " + path,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                LoadList();
                UpdateTreeNode(fullPathSelected);
            }
        }


        private void toolStripMenuItemFileCreateFolder_Click(object sender, EventArgs e)
        {
            newNameForm = new NewName();
            newNameForm.LabelText = "Введите имя создаваемой папки";
            newNameForm.TextBoxText = "Новая папка";
            if (DialogResult.OK == newNameForm.ShowDialog()
                 && newNameForm.TextBoxText != "")
            {
                string newPath = Path.Combine(fullPathSelected, newNameForm.TextBoxText);
                try
                {
                    MyFileManager.CreateDirectory(newPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Создание папки " + newPath,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                LoadList();
                UpdateTreeNode(fullPathSelected);
            }
            
        }

        private void toolStripMenuItemFileCreateFile_Click(object sender, EventArgs e)
        {
            newNameForm = new NewName();
            newNameForm.LabelText = "Введите имя создаваемого файла";
            newNameForm.TextBoxText = "Новый текстовый документ.txt";
            if (DialogResult.OK == newNameForm.ShowDialog()
                 && newNameForm.TextBoxText != "")
            {
                string newPath = Path.Combine(fullPathSelected, newNameForm.TextBoxText);
                try
                {
                    File.Create(newPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Создание файла " + newPath,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                LoadList();
            }
        }

        private void toolStripMenuItemFileRename_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                newNameForm = new NewName();
                newNameForm.LabelText = "Введите новое имя";
                if (DialogResult.OK == newNameForm.ShowDialog()
                 && newNameForm.TextBoxText != "")
                {
                    string newPath = Path.Combine(fullPathSelected, newNameForm.TextBoxText);
                    foreach (ListViewItem item in this.listView1.SelectedItems)
                    {
                        if (Path.HasExtension(item.Text))
                        {
                            try
                            {
                                FileInfo tempFileInfo = new FileInfo(Path.Combine(fullPathSelected, item.Text));
                                tempFileInfo.MoveTo(newPath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message,
                                    "Переименование файла " + newPath,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {
                                DirectoryInfo tempDirInfo = new DirectoryInfo(Path.Combine(fullPathSelected, item.Text));
                                tempDirInfo.MoveTo(newPath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message,
                                    "Переименование папки " + newPath,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                    LoadList();
                    UpdateTreeNode(fullPathSelected);
                }
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (Path.HasExtension(item.Text) == false)
                {
                    string path = this.treeView1.SelectedNode.FullPath + "\\" + item.Text;
                    foreach (TreeNode node in this.treeView1.SelectedNode.Nodes)
                    {
                        if (node.FullPath == path)
                        {
                            treeView1.SelectedNode = node;
                            node.Expand();
                            LoadList();
                        }
                    }
                }
            }
        }


    }
}