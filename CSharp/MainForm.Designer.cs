namespace LargeImageViewerDemo
{
    partial class MainForm
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
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard1 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.statusStripPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageLoadProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomComboBox = new System.Windows.Forms.ComboBox();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxZoomToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeModeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.rotateViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMapSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showScrollbarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanelAlwaysVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.colorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCounterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.statusStripPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.topPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 564);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.statusStripPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 503);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.imageViewer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 480);
            this.panel5.TabIndex = 1;
            // 
            // imageViewer1
            // 
            this.imageViewer1.Clipboard = winFormsSystemClipboard1;
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.imageViewer1.ImageRotationAngle = 0;
            this.imageViewer1.IsFocusPointFixed = false;
            this.imageViewer1.IsKeyboardNavigationEnabled = true;
            this.imageViewer1.KeyboardNavigationScrollStep = 20;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.RendererCacheSize = 256F;
            this.imageViewer1.Size = new System.Drawing.Size(784, 480);
            this.imageViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.imageViewer1.TabIndex = 0;
            this.imageViewer1.Text = "imageViewer1";
            this.imageViewer1.ImageLoadingProgress += new System.EventHandler<Vintasoft.Imaging.ProgressEventArgs>(this.imageViewer1_FocusedImageLoadingProgress);
            this.imageViewer1.ZoomChanged += new System.EventHandler<Vintasoft.Imaging.UI.ZoomChangedEventArgs>(this.imageViewer1_ZoomChanged);
            // 
            // statusStripPanel
            // 
            this.statusStripPanel.Controls.Add(this.statusStrip1);
            this.statusStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripPanel.Location = new System.Drawing.Point(0, 480);
            this.statusStripPanel.Name = "statusStripPanel";
            this.statusStripPanel.Size = new System.Drawing.Size(784, 23);
            this.statusStripPanel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageLoadProgressBar,
            this.statusStripLabel,
            this.imageInfoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imageLoadProgressBar
            // 
            this.imageLoadProgressBar.Name = "imageLoadProgressBar";
            this.imageLoadProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imageLoadProgressBar.Visible = false;
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(759, 17);
            this.statusStripLabel.Spring = true;
            // 
            // imageInfoToolStripStatusLabel
            // 
            this.imageInfoToolStripStatusLabel.Name = "imageInfoToolStripStatusLabel";
            this.imageInfoToolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.imageInfoToolStripStatusLabel.Text = " ";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.zoomComboBox);
            this.topPanel.Controls.Add(this.zoomTrackBar);
            this.topPanel.Controls.Add(this.mainMenu);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(784, 61);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "%";
            // 
            // zoomComboBox
            // 
            this.zoomComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomComboBox.FormattingEnabled = true;
            this.zoomComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "75",
            "100",
            "200",
            "300",
            "500",
            "1000"});
            this.zoomComboBox.Location = new System.Drawing.Point(678, 34);
            this.zoomComboBox.Name = "zoomComboBox";
            this.zoomComboBox.Size = new System.Drawing.Size(71, 21);
            this.zoomComboBox.TabIndex = 2;
            this.zoomComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomComboBox_SelectedIndexChanged);
            this.zoomComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zoomComboBox_KeyDown);
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrackBar.Location = new System.Drawing.Point(3, 29);
            this.zoomTrackBar.Maximum = 1000;
            this.zoomTrackBar.Minimum = 1;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(669, 45);
            this.zoomTrackBar.TabIndex = 1;
            this.zoomTrackBar.TickFrequency = 10;
            this.zoomTrackBar.Value = 1;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.visualToolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomViewToolStripMenuItem,
            this.rotateViewToolStripMenuItem,
            this.toolStripSeparator2,
            this.imageViewerSettingsToolStripMenuItem,
            this.imageMapSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.fullScreenToolStripMenuItem,
            this.showScrollbarsToolStripMenuItem,
            this.topPanelAlwaysVisibleToolStripMenuItem,
            this.toolStripSeparator5,
            this.colorManagementToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomViewToolStripMenuItem
            // 
            this.zoomViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxZoomToolStripMenuItem,
            this.toolStripSeparator3,
            this.sizeModeToolStripComboBox});
            this.zoomViewToolStripMenuItem.Name = "zoomViewToolStripMenuItem";
            this.zoomViewToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.zoomViewToolStripMenuItem.Text = "Zoom";
            // 
            // maxZoomToolStripMenuItem
            // 
            this.maxZoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxZoomToolStripComboBox});
            this.maxZoomToolStripMenuItem.Name = "maxZoomToolStripMenuItem";
            this.maxZoomToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.maxZoomToolStripMenuItem.Text = "Max Zoom";
            // 
            // maxZoomToolStripComboBox
            // 
            this.maxZoomToolStripComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "75",
            "100",
            "200",
            "300",
            "500",
            "1000"});
            this.maxZoomToolStripComboBox.Name = "maxZoomToolStripComboBox";
            this.maxZoomToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.maxZoomToolStripComboBox.Text = "100";
            this.maxZoomToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.maxZoomToolStripComboBox_SelectedIndexChanged);
            this.maxZoomToolStripComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxZoomToolStripComboBox_KeyDown);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // sizeModeToolStripComboBox
            // 
            this.sizeModeToolStripComboBox.Name = "sizeModeToolStripComboBox";
            this.sizeModeToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.sizeModeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeModeToolStripComboBox_SelectedIndexChanged);
            // 
            // rotateViewToolStripMenuItem
            // 
            this.rotateViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateClockwiseToolStripMenuItem,
            this.rotateCounterclockwiseToolStripMenuItem});
            this.rotateViewToolStripMenuItem.Name = "rotateViewToolStripMenuItem";
            this.rotateViewToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.rotateViewToolStripMenuItem.Text = "Rotate View";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // imageViewerSettingsToolStripMenuItem
            // 
            this.imageViewerSettingsToolStripMenuItem.Name = "imageViewerSettingsToolStripMenuItem";
            this.imageViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.imageViewerSettingsToolStripMenuItem.Text = "Image Viewer Settings...";
            this.imageViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageViewerSettingsToolStripMenuItem_Click);
            // 
            // imageMapSettingsToolStripMenuItem
            // 
            this.imageMapSettingsToolStripMenuItem.Name = "imageMapSettingsToolStripMenuItem";
            this.imageMapSettingsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.imageMapSettingsToolStripMenuItem.Text = "Image Map Settings...";
            this.imageMapSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageMapSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.fullScreenToolStripMenuItem_CheckedChanged);
            // 
            // showScrollbarsToolStripMenuItem
            // 
            this.showScrollbarsToolStripMenuItem.CheckOnClick = true;
            this.showScrollbarsToolStripMenuItem.Name = "showScrollbarsToolStripMenuItem";
            this.showScrollbarsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.showScrollbarsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.showScrollbarsToolStripMenuItem.Text = "Show Scrollbars";
            this.showScrollbarsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showScrollbarsToolStripMenuItem_CheckedChanged);
            // 
            // topPanelAlwaysVisibleToolStripMenuItem
            // 
            this.topPanelAlwaysVisibleToolStripMenuItem.CheckOnClick = true;
            this.topPanelAlwaysVisibleToolStripMenuItem.Name = "topPanelAlwaysVisibleToolStripMenuItem";
            this.topPanelAlwaysVisibleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.topPanelAlwaysVisibleToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.topPanelAlwaysVisibleToolStripMenuItem.Text = "Top Panel Always Visible";
            this.topPanelAlwaysVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topPanelAlwaysVisibleToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(218, 6);
            // 
            // colorManagementToolStripMenuItem
            // 
            this.colorManagementToolStripMenuItem.Name = "colorManagementToolStripMenuItem";
            this.colorManagementToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.colorManagementToolStripMenuItem.Text = "Color Management...";
            this.colorManagementToolStripMenuItem.Click += new System.EventHandler(this.colorManagementToolStripMenuItem_Click);
            // 
            // visualToolsToolStripMenuItem
            // 
            this.visualToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.zoomToSelectionToolStripMenuItem,
            this.panToolStripMenuItem,
            this.magnifierToolStripMenuItem});
            this.visualToolsToolStripMenuItem.Name = "visualToolsToolStripMenuItem";
            this.visualToolsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.visualToolsToolStripMenuItem.Text = "Visual Tools";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // zoomToSelectionToolStripMenuItem
            // 
            this.zoomToSelectionToolStripMenuItem.Name = "zoomToSelectionToolStripMenuItem";
            this.zoomToSelectionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.zoomToSelectionToolStripMenuItem.Text = "Zoom Selection";
            this.zoomToSelectionToolStripMenuItem.Click += new System.EventHandler(this.zoomToSelectionToolStripMenuItem_Click);
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.panToolStripMenuItem.Text = "Pan";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // magnifierToolStripMenuItem
            // 
            this.magnifierToolStripMenuItem.Name = "magnifierToolStripMenuItem";
            this.magnifierToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.magnifierToolStripMenuItem.Text = "Magnifier";
            this.magnifierToolStripMenuItem.Click += new System.EventHandler(this.magnifierToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rotateClockwiseToolStripMenuItem
            // 
            this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Plus";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
            this.rotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.rotateClockwiseToolStripMenuItem.Text = "Clockwise";
            this.rotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateClockwiseToolStripMenuItem_Click);
            // 
            // rotateCounterclockwiseToolStripMenuItem
            // 
            this.rotateCounterclockwiseToolStripMenuItem.Name = "rotateCounterclockwiseToolStripMenuItem";
            this.rotateCounterclockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Minus";
            this.rotateCounterclockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.OemMinus)));
            this.rotateCounterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.rotateCounterclockwiseToolStripMenuItem.Text = "Counterclockwise";
            this.rotateCounterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateCounterclockwiseToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Large Image Viewer Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.statusStripPanel.ResumeLayout(false);
            this.statusStripPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem imageViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageMapSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualToolsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox zoomComboBox;
        private System.Windows.Forms.ToolStripMenuItem maxZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox maxZoomToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel5;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.Panel statusStripPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel imageInfoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar imageLoadProgressBar;
        private System.Windows.Forms.ToolStripMenuItem magnifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ToolStripComboBox sizeModeToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showScrollbarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topPanelAlwaysVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem colorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCounterclockwiseToolStripMenuItem;
    }
}
