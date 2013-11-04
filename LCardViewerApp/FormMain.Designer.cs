namespace WindowsFormsGraphickOpenGL
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowGrap = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.ReCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveReportAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuST = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSFExperimentTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSFKadrsNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSFInputTimeInSec = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowGraph = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveReport = new System.Windows.Forms.ToolStripButton();
            this.saveFileReportDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerTreeFilePath = new System.Windows.Forms.SplitContainer();
            this.explorerTreeMain = new WindowsExplorer.ExplorerTree();
            this.splitContainerFileList_FileProp = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFileProp = new System.Windows.Forms.DataGridView();
            this.NumberChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorChannel = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageGraphFile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelGraphMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGraphData = new System.Windows.Forms.PictureBox();
            this.OpenGlControlGraph = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.tableLayoutPanelScroll = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripGraphTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGraphZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGraphZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGraphFullView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGraphSave = new System.Windows.Forms.ToolStripButton();
            this.hScrollBarGraph = new System.Windows.Forms.HScrollBar();
            this.saveFileDialogGraph = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTreeFilePath)).BeginInit();
            this.splitContainerTreeFilePath.Panel1.SuspendLayout();
            this.splitContainerTreeFilePath.Panel2.SuspendLayout();
            this.splitContainerTreeFilePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFileList_FileProp)).BeginInit();
            this.splitContainerFileList_FileProp.Panel1.SuspendLayout();
            this.splitContainerFileList_FileProp.Panel2.SuspendLayout();
            this.splitContainerFileList_FileProp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileProp)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageGraphFile.SuspendLayout();
            this.tableLayoutPanelGraphMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphData)).BeginInit();
            this.tableLayoutPanelScroll.SuspendLayout();
            this.toolStripGraphTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShowGrap,
            this.ToolStripMenuItemSaveGraph,
            this.ToolStripMenuItemCalc,
            this.ReCalcToolStripMenuItem,
            this.findEventsToolStripMenuItem,
            this.ToolStripMenuItemSaveReportAs,
            this.ToolStripMenuItemExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.файлToolStripMenuItem.Text = "Операции";
            // 
            // menuShowGrap
            // 
            this.menuShowGrap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuShowGrap.Name = "menuShowGrap";
            this.menuShowGrap.Size = new System.Drawing.Size(274, 22);
            this.menuShowGrap.Text = "Построить график исходных данных";
            this.menuShowGrap.Click += new System.EventHandler(this.menuShowGrap_Click);
            // 
            // ToolStripMenuItemSaveGraph
            // 
            this.ToolStripMenuItemSaveGraph.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItemSaveGraph.Name = "ToolStripMenuItemSaveGraph";
            this.ToolStripMenuItemSaveGraph.Size = new System.Drawing.Size(274, 22);
            this.ToolStripMenuItemSaveGraph.Text = "Сохранить график исходных данных";
            this.ToolStripMenuItemSaveGraph.Click += new System.EventHandler(this.ToolStripMenuItemSaveGraph_Click);
            // 
            // ToolStripMenuItemCalc
            // 
            this.ToolStripMenuItemCalc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItemCalc.Name = "ToolStripMenuItemCalc";
            this.ToolStripMenuItemCalc.Size = new System.Drawing.Size(274, 22);
            this.ToolStripMenuItemCalc.Text = "Вычислить";
            this.ToolStripMenuItemCalc.Click += new System.EventHandler(this.calcToolStripMenuItem_Click);
            // 
            // ReCalcToolStripMenuItem
            // 
            this.ReCalcToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReCalcToolStripMenuItem.Name = "ReCalcToolStripMenuItem";
            this.ReCalcToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.ReCalcToolStripMenuItem.Text = "Пересчитать";
            this.ReCalcToolStripMenuItem.Click += new System.EventHandler(this.ReCalcToolStripMenuItem_Click);
            // 
            // findEventsToolStripMenuItem
            // 
            this.findEventsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.findEventsToolStripMenuItem.Name = "findEventsToolStripMenuItem";
            this.findEventsToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.findEventsToolStripMenuItem.Text = "Найти события";
            this.findEventsToolStripMenuItem.Click += new System.EventHandler(this.findEventsToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemSaveReportAs
            // 
            this.ToolStripMenuItemSaveReportAs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItemSaveReportAs.Name = "ToolStripMenuItemSaveReportAs";
            this.ToolStripMenuItemSaveReportAs.Size = new System.Drawing.Size(274, 22);
            this.ToolStripMenuItemSaveReportAs.Text = "Сохранить отчёт";
            this.ToolStripMenuItemSaveReportAs.Click += new System.EventHandler(this.ToolStripMenuItemSaveReportAs_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(274, 22);
            this.ToolStripMenuItemExit.Text = "Выход";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSA,
            this.mnuST,
            this.toolStripMenuItem1,
            this.mnuSD,
            this.mnuSN,
            this.mnuSF,
            this.toolStripMenuItem2,
            this.mnuSFExperimentTime,
            this.mnuSFKadrsNumber,
            this.mnuSFInputTimeInSec,
            this.toolStripMenuItem3});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // mnuSA
            // 
            this.mnuSA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuSA.Checked = true;
            this.mnuSA.CheckOnClick = true;
            this.mnuSA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSA.Name = "mnuSA";
            this.mnuSA.Size = new System.Drawing.Size(196, 22);
            this.mnuSA.Text = "Адресная строка";
            this.mnuSA.Click += new System.EventHandler(this.mnuSA_Click);
            // 
            // mnuST
            // 
            this.mnuST.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuST.Checked = true;
            this.mnuST.CheckOnClick = true;
            this.mnuST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuST.Name = "mnuST";
            this.mnuST.Size = new System.Drawing.Size(196, 22);
            this.mnuST.Text = "Панель инструментов";
            this.mnuST.Click += new System.EventHandler(this.mnuST_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuSD
            // 
            this.mnuSD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuSD.Checked = true;
            this.mnuSD.CheckOnClick = true;
            this.mnuSD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSD.Name = "mnuSD";
            this.mnuSD.Size = new System.Drawing.Size(196, 22);
            this.mnuSD.Text = "Мои документы";
            this.mnuSD.Click += new System.EventHandler(this.mnuSD_Click);
            // 
            // mnuSN
            // 
            this.mnuSN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuSN.Checked = true;
            this.mnuSN.CheckOnClick = true;
            this.mnuSN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSN.Name = "mnuSN";
            this.mnuSN.Size = new System.Drawing.Size(196, 22);
            this.mnuSN.Text = "Сетевое окружение";
            this.mnuSN.Click += new System.EventHandler(this.mnuSN_Click);
            // 
            // mnuSF
            // 
            this.mnuSF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuSF.Checked = true;
            this.mnuSF.CheckOnClick = true;
            this.mnuSF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSF.Name = "mnuSF";
            this.mnuSF.Size = new System.Drawing.Size(196, 22);
            this.mnuSF.Text = "Избранное";
            this.mnuSF.Click += new System.EventHandler(this.mnuSF_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuSFExperimentTime
            // 
            this.mnuSFExperimentTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuSFExperimentTime.Checked = true;
            this.mnuSFExperimentTime.CheckOnClick = true;
            this.mnuSFExperimentTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSFExperimentTime.Name = "mnuSFExperimentTime";
            this.mnuSFExperimentTime.Size = new System.Drawing.Size(196, 22);
            this.mnuSFExperimentTime.Text = "Время эксперимента";
            this.mnuSFExperimentTime.Click += new System.EventHandler(this.mnuSFExperimentTime_Click);
            // 
            // mnuSFKadrsNumber
            // 
            this.mnuSFKadrsNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuSFKadrsNumber.Checked = true;
            this.mnuSFKadrsNumber.CheckOnClick = true;
            this.mnuSFKadrsNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSFKadrsNumber.Name = "mnuSFKadrsNumber";
            this.mnuSFKadrsNumber.Size = new System.Drawing.Size(196, 22);
            this.mnuSFKadrsNumber.Text = "Число кадров";
            this.mnuSFKadrsNumber.Click += new System.EventHandler(this.mnuSFKadrsNumber_Click);
            // 
            // mnuSFInputTimeInSec
            // 
            this.mnuSFInputTimeInSec.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuSFInputTimeInSec.Checked = true;
            this.mnuSFInputTimeInSec.CheckOnClick = true;
            this.mnuSFInputTimeInSec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSFInputTimeInSec.Name = "mnuSFInputTimeInSec";
            this.mnuSFInputTimeInSec.Size = new System.Drawing.Size(196, 22);
            this.mnuSFInputTimeInSec.Text = "Длительность записи";
            this.mnuSFInputTimeInSec.Click += new System.EventHandler(this.mnuSFInputTimeInSec_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 6);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelp,
            this.ToolStripMenuItemAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemHelp.Text = "Справка";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAbout.Text = "О программе";
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMainMenu.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCalc,
            this.toolStripButtonReCalc,
            this.toolStripButtonFindEvent,
            this.toolStripButtonShowGraph,
            this.toolStripButtonSaveReport});
            this.toolStripMainMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(1276, 25);
            this.toolStripMainMenu.TabIndex = 14;
            this.toolStripMainMenu.Text = "toolStrip1";
            // 
            // toolStripButtonCalc
            // 
            this.toolStripButtonCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCalc.Image")));
            this.toolStripButtonCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalc.Name = "toolStripButtonCalc";
            this.toolStripButtonCalc.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCalc.Text = "Вычислить";
            this.toolStripButtonCalc.Click += new System.EventHandler(this.toolStripButtonCalc_Click);
            // 
            // toolStripButtonReCalc
            // 
            this.toolStripButtonReCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReCalc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReCalc.Image")));
            this.toolStripButtonReCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReCalc.Name = "toolStripButtonReCalc";
            this.toolStripButtonReCalc.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReCalc.Text = "toolStripButton1";
            this.toolStripButtonReCalc.ToolTipText = "Пересчитать";
            this.toolStripButtonReCalc.Click += new System.EventHandler(this.toolStripButtonReCalc_Click);
            // 
            // toolStripButtonFindEvent
            // 
            this.toolStripButtonFindEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindEvent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindEvent.Image")));
            this.toolStripButtonFindEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFindEvent.Name = "toolStripButtonFindEvent";
            this.toolStripButtonFindEvent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindEvent.Text = "Найти события";
            this.toolStripButtonFindEvent.Click += new System.EventHandler(this.toolStripButtonFindEvent_Click);
            // 
            // toolStripButtonShowGraph
            // 
            this.toolStripButtonShowGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowGraph.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowGraph.Image")));
            this.toolStripButtonShowGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowGraph.Name = "toolStripButtonShowGraph";
            this.toolStripButtonShowGraph.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowGraph.Text = "Построить график исходных данных";
            this.toolStripButtonShowGraph.Click += new System.EventHandler(this.toolStripButtonShowGraph_Click);
            // 
            // toolStripButtonSaveReport
            // 
            this.toolStripButtonSaveReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveReport.Image")));
            this.toolStripButtonSaveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveReport.Name = "toolStripButtonSaveReport";
            this.toolStripButtonSaveReport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveReport.Text = "Сохранить отчёт";
            this.toolStripButtonSaveReport.Click += new System.EventHandler(this.toolStripButtonSaveReport_Click);
            // 
            // saveFileReportDialog
            // 
            this.saveFileReportDialog.DefaultExt = "rtf";
            this.saveFileReportDialog.FileName = "отчёт";
            this.saveFileReportDialog.Filter = "rtf files|*.rtf";
            this.saveFileReportDialog.RestoreDirectory = true;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerTreeFilePath);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMain.Size = new System.Drawing.Size(1276, 714);
            this.splitContainerMain.SplitterDistance = 252;
            this.splitContainerMain.TabIndex = 17;
            this.splitContainerMain.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainerMain_SplitterMoving);
            this.splitContainerMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerMain_SplitterMoved);
            // 
            // splitContainerTreeFilePath
            // 
            this.splitContainerTreeFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTreeFilePath.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTreeFilePath.Name = "splitContainerTreeFilePath";
            this.splitContainerTreeFilePath.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTreeFilePath.Panel1
            // 
            this.splitContainerTreeFilePath.Panel1.Controls.Add(this.explorerTreeMain);
            // 
            // splitContainerTreeFilePath.Panel2
            // 
            this.splitContainerTreeFilePath.Panel2.Controls.Add(this.splitContainerFileList_FileProp);
            this.splitContainerTreeFilePath.Size = new System.Drawing.Size(252, 714);
            this.splitContainerTreeFilePath.SplitterDistance = 339;
            this.splitContainerTreeFilePath.TabIndex = 0;
            // 
            // explorerTreeMain
            // 
            this.explorerTreeMain.BackColor = System.Drawing.Color.White;
            this.explorerTreeMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.explorerTreeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerTreeMain.Location = new System.Drawing.Point(0, 0);
            this.explorerTreeMain.Name = "explorerTreeMain";
            this.explorerTreeMain.SelectedPath = "C:\\Program Files (x86)\\Microsoft Visual Studio 10.0\\Common7\\IDE";
            this.explorerTreeMain.ShowAddressbar = true;
            this.explorerTreeMain.ShowMyDocuments = true;
            this.explorerTreeMain.ShowMyFavorites = true;
            this.explorerTreeMain.ShowMyNetwork = true;
            this.explorerTreeMain.ShowToolbar = true;
            this.explorerTreeMain.Size = new System.Drawing.Size(252, 339);
            this.explorerTreeMain.TabIndex = 0;
            this.explorerTreeMain.PathChanged += new WindowsExplorer.ExplorerTree.PathChangedEventHandler(this.explorerTreeMain_PathChanged);
            // 
            // splitContainerFileList_FileProp
            // 
            this.splitContainerFileList_FileProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFileList_FileProp.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFileList_FileProp.Name = "splitContainerFileList_FileProp";
            this.splitContainerFileList_FileProp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFileList_FileProp.Panel1
            // 
            this.splitContainerFileList_FileProp.Panel1.Controls.Add(this.dataGridViewFiles);
            // 
            // splitContainerFileList_FileProp.Panel2
            // 
            this.splitContainerFileList_FileProp.Panel2.Controls.Add(this.dataGridViewFileProp);
            this.splitContainerFileList_FileProp.Size = new System.Drawing.Size(252, 371);
            this.splitContainerFileList_FileProp.SplitterDistance = 185;
            this.splitContainerFileList_FileProp.TabIndex = 12;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToOrderColumns = true;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            this.dataGridViewFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiles.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFiles.Size = new System.Drawing.Size(252, 185);
            this.dataGridViewFiles.TabIndex = 11;
            this.dataGridViewFiles.SelectionChanged += new System.EventHandler(this.dataGridViewFiles_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 73;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 73;
            // 
            // dataGridViewFileProp
            // 
            this.dataGridViewFileProp.AllowDrop = true;
            this.dataGridViewFileProp.AllowUserToOrderColumns = true;
            this.dataGridViewFileProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberChannel,
            this.ColorChannel});
            this.dataGridViewFileProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFileProp.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFileProp.Name = "dataGridViewFileProp";
            this.dataGridViewFileProp.RowHeadersVisible = false;
            this.dataGridViewFileProp.Size = new System.Drawing.Size(252, 182);
            this.dataGridViewFileProp.TabIndex = 0;
            // 
            // NumberChannel
            // 
            this.NumberChannel.HeaderText = "№ канала";
            this.NumberChannel.Name = "NumberChannel";
            this.NumberChannel.ReadOnly = true;
            // 
            // ColorChannel
            // 
            this.ColorChannel.HeaderText = "Цвет";
            this.ColorChannel.Name = "ColorChannel";
            this.ColorChannel.ReadOnly = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGraphFile);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1020, 714);
            this.tabControlMain.TabIndex = 17;
            // 
            // tabPageGraphFile
            // 
            this.tabPageGraphFile.Controls.Add(this.tableLayoutPanelGraphMain);
            this.tabPageGraphFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraphFile.Name = "tabPageGraphFile";
            this.tabPageGraphFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraphFile.Size = new System.Drawing.Size(1012, 688);
            this.tabPageGraphFile.TabIndex = 0;
            this.tabPageGraphFile.Text = "График исходных данных";
            this.tabPageGraphFile.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelGraphMain
            // 
            this.tableLayoutPanelGraphMain.ColumnCount = 1;
            this.tableLayoutPanelGraphMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGraphMain.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelGraphMain.Controls.Add(this.tableLayoutPanelScroll, 0, 1);
            this.tableLayoutPanelGraphMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGraphMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelGraphMain.Name = "tableLayoutPanelGraphMain";
            this.tableLayoutPanelGraphMain.RowCount = 2;
            this.tableLayoutPanelGraphMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGraphMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelGraphMain.Size = new System.Drawing.Size(1006, 682);
            this.tableLayoutPanelGraphMain.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxGraphData);
            this.panel1.Controls.Add(this.OpenGlControlGraph);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 636);
            this.panel1.TabIndex = 12;
            // 
            // pictureBoxGraphData
            // 
            this.pictureBoxGraphData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGraphData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGraphData.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGraphData.Name = "pictureBoxGraphData";
            this.pictureBoxGraphData.Size = new System.Drawing.Size(1000, 636);
            this.pictureBoxGraphData.TabIndex = 4;
            this.pictureBoxGraphData.TabStop = false;
            // 
            // OpenGlControlGraph
            // 
            this.OpenGlControlGraph.AccumBits = ((byte)(0));
            this.OpenGlControlGraph.AutoCheckErrors = false;
            this.OpenGlControlGraph.AutoFinish = false;
            this.OpenGlControlGraph.AutoMakeCurrent = true;
            this.OpenGlControlGraph.AutoSwapBuffers = true;
            this.OpenGlControlGraph.BackColor = System.Drawing.Color.White;
            this.OpenGlControlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpenGlControlGraph.ColorBits = ((byte)(32));
            this.OpenGlControlGraph.DepthBits = ((byte)(16));
            this.OpenGlControlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenGlControlGraph.Location = new System.Drawing.Point(0, 0);
            this.OpenGlControlGraph.Name = "OpenGlControlGraph";
            this.OpenGlControlGraph.Size = new System.Drawing.Size(1000, 636);
            this.OpenGlControlGraph.StencilBits = ((byte)(0));
            this.OpenGlControlGraph.TabIndex = 3;
            this.OpenGlControlGraph.SizeChanged += new System.EventHandler(this.OpenGlControlGraph_SizeChanged);
            this.OpenGlControlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenGlControlGraph_Paint);
            this.OpenGlControlGraph.Resize += new System.EventHandler(this.OpenGlControlGraph_Resize);
            // 
            // tableLayoutPanelScroll
            // 
            this.tableLayoutPanelScroll.ColumnCount = 2;
            this.tableLayoutPanelScroll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelScroll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelScroll.Controls.Add(this.toolStripGraphTools, 1, 0);
            this.tableLayoutPanelScroll.Controls.Add(this.hScrollBarGraph, 0, 0);
            this.tableLayoutPanelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelScroll.Location = new System.Drawing.Point(3, 645);
            this.tableLayoutPanelScroll.Name = "tableLayoutPanelScroll";
            this.tableLayoutPanelScroll.RowCount = 1;
            this.tableLayoutPanelScroll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelScroll.Size = new System.Drawing.Size(1000, 34);
            this.tableLayoutPanelScroll.TabIndex = 4;
            // 
            // toolStripGraphTools
            // 
            this.toolStripGraphTools.AutoSize = false;
            this.toolStripGraphTools.CanOverflow = false;
            this.toolStripGraphTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripGraphTools.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStripGraphTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGraphZoomIn,
            this.toolStripButtonGraphZoomOut,
            this.toolStripButtonGraphFullView,
            this.toolStripButtonGraphSave});
            this.toolStripGraphTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripGraphTools.Location = new System.Drawing.Point(870, 0);
            this.toolStripGraphTools.Name = "toolStripGraphTools";
            this.toolStripGraphTools.Size = new System.Drawing.Size(130, 34);
            this.toolStripGraphTools.TabIndex = 17;
            this.toolStripGraphTools.Text = "toolStripGraph";
            // 
            // toolStripButtonGraphZoomIn
            // 
            this.toolStripButtonGraphZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGraphZoomIn.Image")));
            this.toolStripButtonGraphZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphZoomIn.Name = "toolStripButtonGraphZoomIn";
            this.toolStripButtonGraphZoomIn.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonGraphZoomIn.Text = "Приблизить";
            this.toolStripButtonGraphZoomIn.Click += new System.EventHandler(this.toolStripButtonGraphZoomIn_Click);
            // 
            // toolStripButtonGraphZoomOut
            // 
            this.toolStripButtonGraphZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGraphZoomOut.Image")));
            this.toolStripButtonGraphZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphZoomOut.Name = "toolStripButtonGraphZoomOut";
            this.toolStripButtonGraphZoomOut.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonGraphZoomOut.Text = "Отдалить";
            this.toolStripButtonGraphZoomOut.Click += new System.EventHandler(this.toolStripButtonGraphZoomOut_Click);
            // 
            // toolStripButtonGraphFullView
            // 
            this.toolStripButtonGraphFullView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphFullView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGraphFullView.Image")));
            this.toolStripButtonGraphFullView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphFullView.Name = "toolStripButtonGraphFullView";
            this.toolStripButtonGraphFullView.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonGraphFullView.Text = "Показать весь график";
            this.toolStripButtonGraphFullView.Click += new System.EventHandler(this.toolStripButtonGraphFullView_Click);
            // 
            // toolStripButtonGraphSave
            // 
            this.toolStripButtonGraphSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGraphSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGraphSave.Image")));
            this.toolStripButtonGraphSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGraphSave.Name = "toolStripButtonGraphSave";
            this.toolStripButtonGraphSave.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonGraphSave.Text = "Сохранить график";
            this.toolStripButtonGraphSave.Click += new System.EventHandler(this.toolStripButtonGraphSave_Click);
            // 
            // hScrollBarGraph
            // 
            this.hScrollBarGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBarGraph.LargeChange = 1;
            this.hScrollBarGraph.Location = new System.Drawing.Point(0, 0);
            this.hScrollBarGraph.Maximum = 0;
            this.hScrollBarGraph.Name = "hScrollBarGraph";
            this.hScrollBarGraph.Size = new System.Drawing.Size(870, 34);
            this.hScrollBarGraph.TabIndex = 5;
            this.hScrollBarGraph.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // saveFileDialogGraph
            // 
            this.saveFileDialogGraph.DefaultExt = "bmp";
            this.saveFileDialogGraph.FileName = "bmp";
            this.saveFileDialogGraph.Filter = "bmp files|*.bmp";
            this.saveFileDialogGraph.RestoreDirectory = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 763);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Програмнный комплекс обработки L-Card данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerTreeFilePath.Panel1.ResumeLayout(false);
            this.splitContainerTreeFilePath.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTreeFilePath)).EndInit();
            this.splitContainerTreeFilePath.ResumeLayout(false);
            this.splitContainerFileList_FileProp.Panel1.ResumeLayout(false);
            this.splitContainerFileList_FileProp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFileList_FileProp)).EndInit();
            this.splitContainerFileList_FileProp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileProp)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGraphFile.ResumeLayout(false);
            this.tableLayoutPanelGraphMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphData)).EndInit();
            this.tableLayoutPanelScroll.ResumeLayout(false);
            this.toolStripGraphTools.ResumeLayout(false);
            this.toolStripGraphTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSA;
        private System.Windows.Forms.ToolStripMenuItem mnuST;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSD;
        private System.Windows.Forms.ToolStripMenuItem mnuSN;
        private System.Windows.Forms.ToolStripMenuItem mnuSF;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuSFExperimentTime;
        private System.Windows.Forms.ToolStripMenuItem mnuSFKadrsNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuSFInputTimeInSec;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCalc;
        private System.Windows.Forms.ToolStripMenuItem menuShowGrap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveGraph;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStrip toolStripMainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowGraph;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalc;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveReport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveReportAs;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.SaveFileDialog saveFileReportDialog;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerTreeFilePath;
        //private WindowsExplorer.ExplorerTree explorerTreeMain;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageGraphFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGraphMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScroll;
        private System.Windows.Forms.ToolStrip toolStripGraphTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonGraphZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripButtonGraphZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripButtonGraphFullView;
        private System.Windows.Forms.ToolStripButton toolStripButtonGraphSave;
        private System.Windows.Forms.HScrollBar hScrollBarGraph;
        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControlGraph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxGraphData;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGraph;
        private System.Windows.Forms.ToolStripButton toolStripButtonReCalc;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindEvent;
        private System.Windows.Forms.ToolStripMenuItem ReCalcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findEventsToolStripMenuItem;
        private WindowsExplorer.ExplorerTree explorerTreeMain;
        public System.Windows.Forms.SplitContainer splitContainerFileList_FileProp;
        private System.Windows.Forms.DataGridView dataGridViewFileProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberChannel;
        private System.Windows.Forms.DataGridViewImageColumn ColorChannel;
    }
}

