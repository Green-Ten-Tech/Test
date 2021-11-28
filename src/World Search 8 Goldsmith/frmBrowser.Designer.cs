namespace World_Search_8_Goldsmith
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funchionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuImageButton6 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.downloadsToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.funchionToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 158);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.Image")));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadsToolStripMenuItem.Image")));
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notepadToolStripMenuItem.Image")));
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatorToolStripMenuItem.Image")));
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // funchionToolStripMenuItem
            // 
            this.funchionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.navigateSearchToolStripMenuItem});
            this.funchionToolStripMenuItem.Name = "funchionToolStripMenuItem";
            this.funchionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funchionToolStripMenuItem.Text = "Functions";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolStripMenuItem.Image")));
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // navigateSearchToolStripMenuItem
            // 
            this.navigateSearchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("navigateSearchToolStripMenuItem.Image")));
            this.navigateSearchToolStripMenuItem.Name = "navigateSearchToolStripMenuItem";
            this.navigateSearchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.navigateSearchToolStripMenuItem.Text = " Navigate or Search";
            this.navigateSearchToolStripMenuItem.Click += new System.EventHandler(this.navigateSearchToolStripMenuItem_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLoader1);
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton4);
            this.bunifuPanel1.Controls.Add(this.bunifuTextBox1);
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton6);
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton5);
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton3);
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1565, 100);
            this.bunifuPanel1.TabIndex = 3;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // bunifuLoader1
            // 
            this.bunifuLoader1.AllowStylePresets = true;
            this.bunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader1.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader1.Customization = "";
            this.bunifuLoader1.DashWidth = 0.5F;
            this.bunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader1.Image = null;
            this.bunifuLoader1.Location = new System.Drawing.Point(247, 28);
            this.bunifuLoader1.Name = "bunifuLoader1";
            this.bunifuLoader1.NoRounding = false;
            this.bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.bunifuLoader1.ShowText = false;
            this.bunifuLoader1.Size = new System.Drawing.Size(42, 42);
            this.bunifuLoader1.Speed = 7;
            this.bunifuLoader1.TabIndex = 15;
            this.bunifuLoader1.Text = "bunifuLoader1";
            this.bunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader1.Thickness = 6;
            this.bunifuLoader1.Transparent = true;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = null;
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowBuffering = false;
            this.bunifuImageButton4.AllowToggling = false;
            this.bunifuImageButton4.AllowZooming = true;
            this.bunifuImageButton4.AllowZoomingOnFocus = false;
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ErrorImage")));
            this.bunifuImageButton4.FadeWhenInactive = false;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 7;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(35, 35);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(42, 42);
            this.bunifuImageButton4.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.InitialImage")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(247, 28);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = true;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = true;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(42, 42);
            this.bunifuImageButton4.TabIndex = 10;
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 7;
            this.bunifuImageButton4.ZoomSpeed = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 40;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconLeft")));
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconRight")));
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(295, 28);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Enter text";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(1210, 42);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 14;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "Enter text";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            this.bunifuTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuTextBox1_KeyPress_1);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.ActiveImage = null;
            this.bunifuImageButton6.AllowAnimations = true;
            this.bunifuImageButton6.AllowBuffering = false;
            this.bunifuImageButton6.AllowToggling = false;
            this.bunifuImageButton6.AllowZooming = true;
            this.bunifuImageButton6.AllowZoomingOnFocus = false;
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.ErrorImage")));
            this.bunifuImageButton6.FadeWhenInactive = false;
            this.bunifuImageButton6.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.ImageLocation = null;
            this.bunifuImageButton6.ImageMargin = 7;
            this.bunifuImageButton6.ImageSize = new System.Drawing.Size(35, 35);
            this.bunifuImageButton6.ImageZoomSize = new System.Drawing.Size(42, 42);
            this.bunifuImageButton6.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.InitialImage")));
            this.bunifuImageButton6.Location = new System.Drawing.Point(151, 28);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Rotation = 0;
            this.bunifuImageButton6.ShowActiveImage = true;
            this.bunifuImageButton6.ShowCursorChanges = true;
            this.bunifuImageButton6.ShowImageBorders = true;
            this.bunifuImageButton6.ShowSizeMarkers = false;
            this.bunifuImageButton6.Size = new System.Drawing.Size(42, 42);
            this.bunifuImageButton6.TabIndex = 13;
            this.bunifuImageButton6.ToolTipText = "";
            this.bunifuImageButton6.WaitOnLoad = false;
            this.bunifuImageButton6.Zoom = 7;
            this.bunifuImageButton6.ZoomSpeed = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.ActiveImage = null;
            this.bunifuImageButton5.AllowAnimations = true;
            this.bunifuImageButton5.AllowBuffering = false;
            this.bunifuImageButton5.AllowToggling = false;
            this.bunifuImageButton5.AllowZooming = true;
            this.bunifuImageButton5.AllowZoomingOnFocus = false;
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.ErrorImage")));
            this.bunifuImageButton5.FadeWhenInactive = false;
            this.bunifuImageButton5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.ImageLocation = null;
            this.bunifuImageButton5.ImageMargin = 7;
            this.bunifuImageButton5.ImageSize = new System.Drawing.Size(35, 35);
            this.bunifuImageButton5.ImageZoomSize = new System.Drawing.Size(42, 42);
            this.bunifuImageButton5.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.InitialImage")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(199, 28);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Rotation = 0;
            this.bunifuImageButton5.ShowActiveImage = true;
            this.bunifuImageButton5.ShowCursorChanges = true;
            this.bunifuImageButton5.ShowImageBorders = true;
            this.bunifuImageButton5.ShowSizeMarkers = false;
            this.bunifuImageButton5.Size = new System.Drawing.Size(42, 42);
            this.bunifuImageButton5.TabIndex = 12;
            this.bunifuImageButton5.ToolTipText = "";
            this.bunifuImageButton5.WaitOnLoad = false;
            this.bunifuImageButton5.Zoom = 7;
            this.bunifuImageButton5.ZoomSpeed = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 7;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(35, 35);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(42, 42);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(1511, 28);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(42, 42);
            this.bunifuImageButton3.TabIndex = 9;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.Visible = false;
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 7;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 7;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(35, 35);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(42, 42);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(103, 28);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(42, 42);
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 7;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 7;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(59, 59);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(66, 66);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 17);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(66, 66);
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 7;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 100);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1565, 686);
            this.chromiumWebBrowser1.TabIndex = 4;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel1.Location = new System.Drawing.Point(1320, 688);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(233, 20);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "This is for Evaluation Purposes Only";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(1320, 714);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(233, 60);
            this.bunifuLabel2.TabIndex = 6;
            this.bunifuLabel2.Text = "This copy of World Search 8 Goldsmith is for\r\nEvaluation Purposes only. Do notatt" +
    "empt to\r\ncopy or reles this build outside of Green Ten\r\nTech.";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.UseWaitCursor = true;
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 786);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            this.contextMenuStrip1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funchionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateSearchToolStripMenuItem;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton6;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton5;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        public Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}