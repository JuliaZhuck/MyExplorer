namespace MyExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileCreateFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileCreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemViewStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSortItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortItemsByName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortItemsBySize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortItemByChanged = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListForTree = new System.Windows.Forms.ImageList(this.components);
            this.toolStripFoldersInTree = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSize = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderChanged = new System.Windows.Forms.ColumnHeader();
            this.imageListForList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripButtonFileNewFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFileNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStripForlist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContextMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContextMenuItemCreateFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContextMenuItemCreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContextMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContextMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripContextMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContextMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContextMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripFoldersInTree.SuspendLayout();
            this.contextMenuStripForlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileCreate,
            this.toolStripMenuItemFileRename,
            this.toolStripMenuItemFileDelete,
            this.toolStripSeparator3,
            this.toolStripMenuItemFileExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemFileCreate
            // 
            this.toolStripMenuItemFileCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileCreateFolder,
            this.toolStripMenuItemFileCreateFile});
            this.toolStripMenuItemFileCreate.Name = "toolStripMenuItemFileCreate";
            this.toolStripMenuItemFileCreate.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemFileCreate.Text = "Создать";
            // 
            // toolStripMenuItemFileCreateFolder
            // 
            this.toolStripMenuItemFileCreateFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFileCreateFolder.Image")));
            this.toolStripMenuItemFileCreateFolder.Name = "toolStripMenuItemFileCreateFolder";
            this.toolStripMenuItemFileCreateFolder.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemFileCreateFolder.Text = "Папку";
            this.toolStripMenuItemFileCreateFolder.Click += new System.EventHandler(this.toolStripMenuItemFileCreateFolder_Click);
            // 
            // toolStripMenuItemFileCreateFile
            // 
            this.toolStripMenuItemFileCreateFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFileCreateFile.Image")));
            this.toolStripMenuItemFileCreateFile.Name = "toolStripMenuItemFileCreateFile";
            this.toolStripMenuItemFileCreateFile.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemFileCreateFile.Text = "Файл";
            this.toolStripMenuItemFileCreateFile.Click += new System.EventHandler(this.toolStripMenuItemFileCreateFile_Click);
            // 
            // toolStripMenuItemFileRename
            // 
            this.toolStripMenuItemFileRename.Enabled = false;
            this.toolStripMenuItemFileRename.Name = "toolStripMenuItemFileRename";
            this.toolStripMenuItemFileRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuItemFileRename.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemFileRename.Text = "Перименовать";
            this.toolStripMenuItemFileRename.Click += new System.EventHandler(this.toolStripMenuItemFileRename_Click);
            // 
            // toolStripMenuItemFileDelete
            // 
            this.toolStripMenuItemFileDelete.Enabled = false;
            this.toolStripMenuItemFileDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFileDelete.Image")));
            this.toolStripMenuItemFileDelete.Name = "toolStripMenuItemFileDelete";
            this.toolStripMenuItemFileDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolStripMenuItemFileDelete.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemFileDelete.Text = "Удалить";
            this.toolStripMenuItemFileDelete.Click += new System.EventHandler(this.toolStripMenuItemFileDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItemFileExit
            // 
            this.toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemFileExit.Text = "Выход";
            this.toolStripMenuItemFileExit.Click += new System.EventHandler(this.toolStripMenuItemFileExit_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditCut,
            this.toolStripMenuItemEditCopy,
            this.toolStripMenuItemEditPaste});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemEdit.Text = "Правка";
            // 
            // toolStripMenuItemEditCut
            // 
            this.toolStripMenuItemEditCut.Enabled = false;
            this.toolStripMenuItemEditCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEditCut.Image")));
            this.toolStripMenuItemEditCut.Name = "toolStripMenuItemEditCut";
            this.toolStripMenuItemEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItemEditCut.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemEditCut.Text = "Вырезать";
            this.toolStripMenuItemEditCut.Click += new System.EventHandler(this.toolStripMenuItemEditCut_Click);
            // 
            // toolStripMenuItemEditCopy
            // 
            this.toolStripMenuItemEditCopy.Enabled = false;
            this.toolStripMenuItemEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEditCopy.Image")));
            this.toolStripMenuItemEditCopy.Name = "toolStripMenuItemEditCopy";
            this.toolStripMenuItemEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItemEditCopy.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemEditCopy.Text = "Копировать";
            this.toolStripMenuItemEditCopy.Click += new System.EventHandler(this.toolStripMenuItemEditCopy_Click);
            // 
            // toolStripMenuItemEditPaste
            // 
            this.toolStripMenuItemEditPaste.Enabled = false;
            this.toolStripMenuItemEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEditPaste.Image")));
            this.toolStripMenuItemEditPaste.Name = "toolStripMenuItemEditPaste";
            this.toolStripMenuItemEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItemEditPaste.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemEditPaste.Text = "Вставить";
            this.toolStripMenuItemEditPaste.Click += new System.EventHandler(this.toolStripMenuItemEditPaste_Click);
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewDetails,
            this.toolStripMenuItemViewList,
            this.toolStripMenuItemViewLargeIcon,
            this.toolStripMenuItemViewTile,
            this.toolStripSeparator1,
            this.toolStripMenuItemViewStatusStrip,
            this.toolStripSeparator2,
            this.toolStripMenuItemSortItems});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItemView.Text = "Вид";
            // 
            // toolStripMenuItemViewDetails
            // 
            this.toolStripMenuItemViewDetails.Checked = true;
            this.toolStripMenuItemViewDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemViewDetails.Name = "toolStripMenuItemViewDetails";
            this.toolStripMenuItemViewDetails.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemViewDetails.Text = "Таблица";
            this.toolStripMenuItemViewDetails.Click += new System.EventHandler(this.toolStripMenuItemViewDetails_Click);
            // 
            // toolStripMenuItemViewList
            // 
            this.toolStripMenuItemViewList.Name = "toolStripMenuItemViewList";
            this.toolStripMenuItemViewList.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemViewList.Text = "Список";
            this.toolStripMenuItemViewList.Click += new System.EventHandler(this.toolStripMenuItemViewList_Click);
            // 
            // toolStripMenuItemViewLargeIcon
            // 
            this.toolStripMenuItemViewLargeIcon.Name = "toolStripMenuItemViewLargeIcon";
            this.toolStripMenuItemViewLargeIcon.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemViewLargeIcon.Text = "Значки";
            this.toolStripMenuItemViewLargeIcon.Click += new System.EventHandler(this.toolStripMenuItemViewLargeIcon_Click);
            // 
            // toolStripMenuItemViewTile
            // 
            this.toolStripMenuItemViewTile.Name = "toolStripMenuItemViewTile";
            this.toolStripMenuItemViewTile.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemViewTile.Text = "Плитка";
            this.toolStripMenuItemViewTile.Click += new System.EventHandler(this.toolStripMenuItemViewTile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // toolStripMenuItemViewStatusStrip
            // 
            this.toolStripMenuItemViewStatusStrip.Checked = true;
            this.toolStripMenuItemViewStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemViewStatusStrip.Name = "toolStripMenuItemViewStatusStrip";
            this.toolStripMenuItemViewStatusStrip.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemViewStatusStrip.Text = "Строка состояния";
            this.toolStripMenuItemViewStatusStrip.Click += new System.EventHandler(this.toolStripMenuItemViewStatusStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // toolStripMenuItemSortItems
            // 
            this.toolStripMenuItemSortItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSortItemsByName,
            this.toolStripMenuItemSortItemsBySize,
            this.toolStripMenuItemSortItemByChanged});
            this.toolStripMenuItemSortItems.Name = "toolStripMenuItemSortItems";
            this.toolStripMenuItemSortItems.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemSortItems.Text = "Упорядочить знаки";
            // 
            // toolStripMenuItemSortItemsByName
            // 
            this.toolStripMenuItemSortItemsByName.Checked = true;
            this.toolStripMenuItemSortItemsByName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemSortItemsByName.Name = "toolStripMenuItemSortItemsByName";
            this.toolStripMenuItemSortItemsByName.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemSortItemsByName.Text = "По имени";
            this.toolStripMenuItemSortItemsByName.Click += new System.EventHandler(this.toolStripMenuItemSortItemsByName_Click);
            // 
            // toolStripMenuItemSortItemsBySize
            // 
            this.toolStripMenuItemSortItemsBySize.Name = "toolStripMenuItemSortItemsBySize";
            this.toolStripMenuItemSortItemsBySize.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemSortItemsBySize.Text = "По размеру";
            this.toolStripMenuItemSortItemsBySize.Click += new System.EventHandler(this.toolStripMenuItemSortItemsBySize_Click);
            // 
            // toolStripMenuItemSortItemByChanged
            // 
            this.toolStripMenuItemSortItemByChanged.Name = "toolStripMenuItemSortItemByChanged";
            this.toolStripMenuItemSortItemByChanged.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemSortItemByChanged.Text = "Изменен";
            this.toolStripMenuItemSortItemByChanged.Click += new System.EventHandler(this.toolStripMenuItemSortItemByChanged_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFileNewFolder,
            this.toolStripButtonFileNewFile,
            this.toolStripSeparator4,
            this.toolStripButtonCut,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStripMenuImages";
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Enabled = false;
            this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCut.Text = "Вырезать";
            this.toolStripButtonCut.Click += new System.EventHandler(this.toolStripMenuItemEditCut_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Enabled = false;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopy.Text = "Копировать";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripMenuItemEditCopy_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Enabled = false;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPaste.Text = "Вставить";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.toolStripMenuItemEditPaste_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Enabled = false;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripMenuItemFileDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(645, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(577, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel3.Text = "              ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripFoldersInTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(645, 368);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageListForTree;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(215, 343);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageListForTree
            // 
            this.imageListForTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListForTree.ImageStream")));
            this.imageListForTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListForTree.Images.SetKeyName(0, "DRIVE.bmp");
            this.imageListForTree.Images.SetKeyName(1, "CDDRIVE.BMP");
            this.imageListForTree.Images.SetKeyName(2, "35FLOPPY.BMP");
            this.imageListForTree.Images.SetKeyName(3, "DRIVENET.BMP");
            this.imageListForTree.Images.SetKeyName(4, "DRIVEDSC.BMP");
            this.imageListForTree.Images.SetKeyName(5, "CLSDFOLD.BMP");
            this.imageListForTree.Images.SetKeyName(6, "OPENFOLD.BMP");
            this.imageListForTree.Images.SetKeyName(7, "hotplug.ico");
            // 
            // toolStripFoldersInTree
            // 
            this.toolStripFoldersInTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripFoldersInTree.Location = new System.Drawing.Point(0, 0);
            this.toolStripFoldersInTree.Name = "toolStripFoldersInTree";
            this.toolStripFoldersInTree.Size = new System.Drawing.Size(215, 25);
            this.toolStripFoldersInTree.TabIndex = 0;
            this.toolStripFoldersInTree.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Папки";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderChanged});
            this.listView1.ContextMenuStrip = this.contextMenuStripForlist;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageListForList;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 368);
            this.listView1.SmallImageList = this.imageListForList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseLeave += new System.EventHandler(this.listView1_MouseLeave);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 80;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Размер";
            // 
            // columnHeaderChanged
            // 
            this.columnHeaderChanged.Text = "Изменен";
            this.columnHeaderChanged.Width = 80;
            // 
            // imageListForList
            // 
            this.imageListForList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListForList.ImageStream")));
            this.imageListForList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListForList.Images.SetKeyName(0, "folderopen.ico");
            this.imageListForList.Images.SetKeyName(1, "app.ico");
            this.imageListForList.Images.SetKeyName(2, "document.ico");
            this.imageListForList.Images.SetKeyName(3, "textdoc.ico");
            this.imageListForList.Images.SetKeyName(4, "cdmusic.ico");
            this.imageListForList.Images.SetKeyName(5, "video.ico");
            this.imageListForList.Images.SetKeyName(6, "rc_bitmap.ico");
            this.imageListForList.Images.SetKeyName(7, "rc_html.ico");
            this.imageListForList.Images.SetKeyName(8, "Web_XML.ico");
            this.imageListForList.Images.SetKeyName(9, "Web_XSLT.ico");
            this.imageListForList.Images.SetKeyName(10, "Code_CodeFileCS.ico");
            this.imageListForList.Images.SetKeyName(11, "helpdoc.ico");
            this.imageListForList.Images.SetKeyName(12, "WINDOC.BMP");
            // 
            // toolStripButtonFileNewFolder
            // 
            this.toolStripButtonFileNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFileNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileNewFolder.Image")));
            this.toolStripButtonFileNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileNewFolder.Name = "toolStripButtonFileNewFolder";
            this.toolStripButtonFileNewFolder.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFileNewFolder.Text = "Новая папка";
            this.toolStripButtonFileNewFolder.Click += new System.EventHandler(this.toolStripMenuItemFileCreateFolder_Click);
            // 
            // toolStripButtonFileNewFile
            // 
            this.toolStripButtonFileNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFileNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileNewFile.Image")));
            this.toolStripButtonFileNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileNewFile.Name = "toolStripButtonFileNewFile";
            this.toolStripButtonFileNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFileNewFile.Text = "Новый документ";
            this.toolStripButtonFileNewFile.Click += new System.EventHandler(this.toolStripMenuItemFileCreateFile_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // contextMenuStripForlist
            // 
            this.contextMenuStripForlist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripContextMenuItemCreate,
            this.toolStripContextMenuItemRename,
            this.toolStripContextMenuItemDelete,
            this.toolStripSeparator5,
            this.toolStripContextMenuItemCut,
            this.toolStripContextMenuItemCopy,
            this.toolStripContextMenuItemPaste});
            this.contextMenuStripForlist.Name = "contextMenuStripForlist";
            this.contextMenuStripForlist.Size = new System.Drawing.Size(173, 142);
            // 
            // toolStripContextMenuItemCreate
            // 
            this.toolStripContextMenuItemCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripContextMenuItemCreateFolder,
            this.toolStripContextMenuItemCreateFile});
            this.toolStripContextMenuItemCreate.Name = "toolStripContextMenuItemCreate";
            this.toolStripContextMenuItemCreate.Size = new System.Drawing.Size(172, 22);
            this.toolStripContextMenuItemCreate.Text = "Создать";
            // 
            // toolStripContextMenuItemCreateFolder
            // 
            this.toolStripContextMenuItemCreateFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripContextMenuItemCreateFolder.Image")));
            this.toolStripContextMenuItemCreateFolder.Name = "toolStripContextMenuItemCreateFolder";
            this.toolStripContextMenuItemCreateFolder.Size = new System.Drawing.Size(152, 22);
            this.toolStripContextMenuItemCreateFolder.Text = "Папку";
            this.toolStripContextMenuItemCreateFolder.Click += new System.EventHandler(this.toolStripMenuItemFileCreateFolder_Click);
            // 
            // toolStripContextMenuItemCreateFile
            // 
            this.toolStripContextMenuItemCreateFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripContextMenuItemCreateFile.Image")));
            this.toolStripContextMenuItemCreateFile.Name = "toolStripContextMenuItemCreateFile";
            this.toolStripContextMenuItemCreateFile.Size = new System.Drawing.Size(152, 22);
            this.toolStripContextMenuItemCreateFile.Text = "Файл";
            this.toolStripContextMenuItemCreateFile.Click += new System.EventHandler(this.toolStripMenuItemFileCreateFile_Click);
            // 
            // toolStripContextMenuItemRename
            // 
            this.toolStripContextMenuItemRename.Enabled = false;
            this.toolStripContextMenuItemRename.Name = "toolStripContextMenuItemRename";
            this.toolStripContextMenuItemRename.Size = new System.Drawing.Size(172, 22);
            this.toolStripContextMenuItemRename.Text = "Переименовать";
            this.toolStripContextMenuItemRename.Click += new System.EventHandler(this.toolStripMenuItemFileRename_Click);
            // 
            // toolStripContextMenuItemDelete
            // 
            this.toolStripContextMenuItemDelete.Enabled = false;
            this.toolStripContextMenuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripContextMenuItemDelete.Image")));
            this.toolStripContextMenuItemDelete.Name = "toolStripContextMenuItemDelete";
            this.toolStripContextMenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolStripContextMenuItemDelete.Size = new System.Drawing.Size(172, 22);
            this.toolStripContextMenuItemDelete.Text = "Удалить";
            this.toolStripContextMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemFileDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripContextMenuItemCut
            // 
            this.toolStripContextMenuItemCut.Enabled = false;
            this.toolStripContextMenuItemCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripContextMenuItemCut.Image")));
            this.toolStripContextMenuItemCut.Name = "toolStripContextMenuItemCut";
            this.toolStripContextMenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripContextMenuItemCut.Size = new System.Drawing.Size(172, 22);
            this.toolStripContextMenuItemCut.Text = "Вырезать";
            this.toolStripContextMenuItemCut.Click += new System.EventHandler(this.toolStripMenuItemEditCut_Click);
            // 
            // toolStripContextMenuItemCopy
            // 
            this.toolStripContextMenuItemCopy.Enabled = false;
            this.toolStripContextMenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripContextMenuItemCopy.Image")));
            this.toolStripContextMenuItemCopy.Name = "toolStripContextMenuItemCopy";
            this.toolStripContextMenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripContextMenuItemCopy.Size = new System.Drawing.Size(172, 22);
            this.toolStripContextMenuItemCopy.Text = "Копировать";
            this.toolStripContextMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemEditCopy_Click);
            // 
            // toolStripContextMenuItemPaste
            // 
            this.toolStripContextMenuItemPaste.Enabled = false;
            this.toolStripContextMenuItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripContextMenuItemPaste.Image")));
            this.toolStripContextMenuItemPaste.Name = "toolStripContextMenuItemPaste";
            this.toolStripContextMenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripContextMenuItemPaste.Size = new System.Drawing.Size(172, 22);
            this.toolStripContextMenuItemPaste.Text = "Вставить";
            this.toolStripContextMenuItemPaste.Click += new System.EventHandler(this.toolStripMenuItemEditPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 439);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStripFoldersInTree.ResumeLayout(false);
            this.toolStripFoldersInTree.PerformLayout();
            this.contextMenuStripForlist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripFoldersInTree;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageListForTree;
        private System.Windows.Forms.ImageList imageListForList;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderChanged;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewTile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewStatusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortItemsByName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortItemsBySize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortItemByChanged;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditPaste;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileCreateFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileCreateFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileRename;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileNewFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileNewFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForlist;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemCreateFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemCreateFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripContextMenuItemPaste;
    }
}

