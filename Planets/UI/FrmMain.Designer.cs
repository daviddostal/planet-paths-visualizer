namespace Planets
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlPlanetSettings = new System.Windows.Forms.Panel();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.pnlHeadingInner = new System.Windows.Forms.Panel();
            this.lblPlanets = new System.Windows.Forms.Label();
            this.pnlPlanetsContainer = new System.Windows.Forms.Panel();
            this.tlpAddPlanet = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPlanet = new System.Windows.Forms.Button();
            this.pnlPlanets = new System.Windows.Forms.Panel();
            this.tlpDrawSettings = new System.Windows.Forms.TableLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.nudZoom = new System.Windows.Forms.NumericUpDown();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblViewFrom = new System.Windows.Forms.Label();
            this.cbxViewFrom = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblSkipPoints = new System.Windows.Forms.Label();
            this.nudStep = new System.Windows.Forms.NumericUpDown();
            this.nudDrawNthPoint = new System.Windows.Forms.NumericUpDown();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbxResult = new System.Windows.Forms.PictureBox();
            this.bgwDrawImage = new System.ComponentModel.BackgroundWorker();
            this.pnlSettings.SuspendLayout();
            this.pnlPlanetSettings.SuspendLayout();
            this.pnlHeading.SuspendLayout();
            this.pnlHeadingInner.SuspendLayout();
            this.pnlPlanetsContainer.SuspendLayout();
            this.tlpAddPlanet.SuspendLayout();
            this.tlpDrawSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawNthPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.Controls.Add(this.pnlPlanetSettings);
            this.pnlSettings.Controls.Add(this.tlpDrawSettings);
            this.pnlSettings.Location = new System.Drawing.Point(570, 9);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(285, 510);
            this.pnlSettings.TabIndex = 1;
            // 
            // pnlPlanetSettings
            // 
            this.pnlPlanetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlanetSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPlanetSettings.Controls.Add(this.pnlHeading);
            this.pnlPlanetSettings.Controls.Add(this.pnlPlanetsContainer);
            this.pnlPlanetSettings.Location = new System.Drawing.Point(3, 155);
            this.pnlPlanetSettings.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlPlanetSettings.Name = "pnlPlanetSettings";
            this.pnlPlanetSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPlanetSettings.Size = new System.Drawing.Size(279, 355);
            this.pnlPlanetSettings.TabIndex = 1;
            // 
            // pnlHeading
            // 
            this.pnlHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlHeading.Controls.Add(this.pnlHeadingInner);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(3, 3);
            this.pnlHeading.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlHeading.Size = new System.Drawing.Size(273, 28);
            this.pnlHeading.TabIndex = 2;
            // 
            // pnlHeadingInner
            // 
            this.pnlHeadingInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeadingInner.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeadingInner.Controls.Add(this.lblPlanets);
            this.pnlHeadingInner.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingInner.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeadingInner.Name = "pnlHeadingInner";
            this.pnlHeadingInner.Size = new System.Drawing.Size(273, 25);
            this.pnlHeadingInner.TabIndex = 0;
            // 
            // lblPlanets
            // 
            this.lblPlanets.AutoSize = true;
            this.lblPlanets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlanets.Location = new System.Drawing.Point(4, 0);
            this.lblPlanets.Name = "lblPlanets";
            this.lblPlanets.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblPlanets.Size = new System.Drawing.Size(49, 25);
            this.lblPlanets.TabIndex = 0;
            this.lblPlanets.Text = "Planets";
            // 
            // pnlPlanetsContainer
            // 
            this.pnlPlanetsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlanetsContainer.AutoScroll = true;
            this.pnlPlanetsContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPlanetsContainer.Controls.Add(this.tlpAddPlanet);
            this.pnlPlanetsContainer.Controls.Add(this.pnlPlanets);
            this.pnlPlanetsContainer.Location = new System.Drawing.Point(3, 31);
            this.pnlPlanetsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPlanetsContainer.Name = "pnlPlanetsContainer";
            this.pnlPlanetsContainer.Size = new System.Drawing.Size(273, 321);
            this.pnlPlanetsContainer.TabIndex = 1;
            // 
            // tlpAddPlanet
            // 
            this.tlpAddPlanet.ColumnCount = 4;
            this.tlpAddPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddPlanet.Controls.Add(this.btnAddPlanet, 1, 0);
            this.tlpAddPlanet.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAddPlanet.Location = new System.Drawing.Point(0, 0);
            this.tlpAddPlanet.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAddPlanet.Name = "tlpAddPlanet";
            this.tlpAddPlanet.RowCount = 1;
            this.tlpAddPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpAddPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpAddPlanet.Size = new System.Drawing.Size(273, 29);
            this.tlpAddPlanet.TabIndex = 1;
            // 
            // btnAddPlanet
            // 
            this.btnAddPlanet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddPlanet.SetColumnSpan(this.btnAddPlanet, 2);
            this.btnAddPlanet.Location = new System.Drawing.Point(71, 3);
            this.btnAddPlanet.Name = "btnAddPlanet";
            this.btnAddPlanet.Size = new System.Drawing.Size(130, 23);
            this.btnAddPlanet.TabIndex = 0;
            this.btnAddPlanet.Text = "Add";
            this.ttpHelp.SetToolTip(this.btnAddPlanet, "Adds a new planet.");
            this.btnAddPlanet.UseVisualStyleBackColor = true;
            this.btnAddPlanet.Click += new System.EventHandler(this.btnAddPlanet_Click);
            // 
            // pnlPlanets
            // 
            this.pnlPlanets.AutoSize = true;
            this.pnlPlanets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPlanets.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlanets.Location = new System.Drawing.Point(0, 0);
            this.pnlPlanets.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPlanets.Name = "pnlPlanets";
            this.pnlPlanets.Size = new System.Drawing.Size(273, 0);
            this.pnlPlanets.TabIndex = 0;
            // 
            // tlpDrawSettings
            // 
            this.tlpDrawSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrawSettings.ColumnCount = 4;
            this.tlpDrawSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDrawSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDrawSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDrawSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDrawSettings.Controls.Add(this.btnExport, 1, 0);
            this.tlpDrawSettings.Controls.Add(this.btnLoad, 3, 0);
            this.tlpDrawSettings.Controls.Add(this.btnSave, 2, 0);
            this.tlpDrawSettings.Controls.Add(this.btnDraw, 0, 0);
            this.tlpDrawSettings.Controls.Add(this.nudZoom, 2, 5);
            this.tlpDrawSettings.Controls.Add(this.lblZoom, 0, 5);
            this.tlpDrawSettings.Controls.Add(this.lblViewFrom, 0, 1);
            this.tlpDrawSettings.Controls.Add(this.cbxViewFrom, 2, 1);
            this.tlpDrawSettings.Controls.Add(this.lblTime, 0, 2);
            this.tlpDrawSettings.Controls.Add(this.nudTime, 2, 2);
            this.tlpDrawSettings.Controls.Add(this.lblStep, 0, 3);
            this.tlpDrawSettings.Controls.Add(this.lblSkipPoints, 0, 4);
            this.tlpDrawSettings.Controls.Add(this.nudStep, 2, 3);
            this.tlpDrawSettings.Controls.Add(this.nudDrawNthPoint, 2, 4);
            this.tlpDrawSettings.Location = new System.Drawing.Point(0, 0);
            this.tlpDrawSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDrawSettings.Name = "tlpDrawSettings";
            this.tlpDrawSettings.RowCount = 6;
            this.tlpDrawSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpDrawSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDrawSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDrawSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDrawSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDrawSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDrawSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDrawSettings.Size = new System.Drawing.Size(285, 153);
            this.tlpDrawSettings.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(73, 2);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(67, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.ttpHelp.SetToolTip(this.btnExport, "Export the drawing to an image.");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(215, 2);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(68, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Open";
            this.ttpHelp.SetToolTip(this.btnLoad, "Loads the planets and settings from a saved file.");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(144, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.ttpHelp.SetToolTip(this.btnSave, "Saves the current planets and settings to a file.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraw.Location = new System.Drawing.Point(2, 2);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(67, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.ttpHelp.SetToolTip(this.btnDraw, "Draws an image of th eplanets to the screen.");
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // nudZoom
            // 
            this.nudZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrawSettings.SetColumnSpan(this.nudZoom, 2);
            this.nudZoom.DecimalPlaces = 4;
            this.nudZoom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudZoom.Location = new System.Drawing.Point(145, 130);
            this.nudZoom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudZoom.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudZoom.Name = "nudZoom";
            this.nudZoom.Size = new System.Drawing.Size(137, 20);
            this.nudZoom.TabIndex = 8;
            this.nudZoom.ThousandsSeparator = true;
            this.ttpHelp.SetToolTip(this.nudZoom, "You can zoom the image if you want to see more details.");
            this.nudZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.tlpDrawSettings.SetColumnSpan(this.lblZoom, 2);
            this.lblZoom.Location = new System.Drawing.Point(3, 127);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblZoom.Size = new System.Drawing.Size(34, 25);
            this.lblZoom.TabIndex = 10;
            this.lblZoom.Text = "Zoom";
            this.lblZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViewFrom
            // 
            this.lblViewFrom.AutoSize = true;
            this.tlpDrawSettings.SetColumnSpan(this.lblViewFrom, 2);
            this.lblViewFrom.Location = new System.Drawing.Point(3, 27);
            this.lblViewFrom.Name = "lblViewFrom";
            this.lblViewFrom.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblViewFrom.Size = new System.Drawing.Size(53, 25);
            this.lblViewFrom.TabIndex = 7;
            this.lblViewFrom.Text = "View from";
            this.lblViewFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxViewFrom
            // 
            this.cbxViewFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrawSettings.SetColumnSpan(this.cbxViewFrom, 2);
            this.cbxViewFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxViewFrom.FormattingEnabled = true;
            this.cbxViewFrom.Location = new System.Drawing.Point(145, 30);
            this.cbxViewFrom.Name = "cbxViewFrom";
            this.cbxViewFrom.Size = new System.Drawing.Size(137, 21);
            this.cbxViewFrom.TabIndex = 4;
            this.ttpHelp.SetToolTip(this.cbxViewFrom, "The planet in the middle, from which the distances are measured.");
            this.cbxViewFrom.SelectedValueChanged += new System.EventHandler(this.cbxViewFrom_SelectedValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.tlpDrawSettings.SetColumnSpan(this.lblTime, 2);
            this.lblTime.Location = new System.Drawing.Point(3, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblTime.Size = new System.Drawing.Size(64, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time (years)";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTime
            // 
            this.nudTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrawSettings.SetColumnSpan(this.nudTime, 2);
            this.nudTime.DecimalPlaces = 4;
            this.nudTime.Location = new System.Drawing.Point(145, 55);
            this.nudTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(137, 20);
            this.nudTime.TabIndex = 5;
            this.nudTime.ThousandsSeparator = true;
            this.ttpHelp.SetToolTip(this.nudTime, "The timespan to draw (e. g. draw the movement of the planets during two years).");
            this.nudTime.Value = new decimal(new int[] {
            97,
            0,
            0,
            0});
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.tlpDrawSettings.SetColumnSpan(this.lblStep, 2);
            this.lblStep.Location = new System.Drawing.Point(3, 77);
            this.lblStep.Name = "lblStep";
            this.lblStep.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblStep.Size = new System.Drawing.Size(63, 25);
            this.lblStep.TabIndex = 5;
            this.lblStep.Text = "Step (years)";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSkipPoints
            // 
            this.lblSkipPoints.AutoSize = true;
            this.tlpDrawSettings.SetColumnSpan(this.lblSkipPoints, 2);
            this.lblSkipPoints.Location = new System.Drawing.Point(3, 102);
            this.lblSkipPoints.Name = "lblSkipPoints";
            this.lblSkipPoints.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblSkipPoints.Size = new System.Drawing.Size(108, 25);
            this.lblSkipPoints.TabIndex = 12;
            this.lblSkipPoints.Text = "Draw every n-th point";
            this.lblSkipPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudStep
            // 
            this.nudStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrawSettings.SetColumnSpan(this.nudStep, 2);
            this.nudStep.DecimalPlaces = 4;
            this.nudStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStep.Location = new System.Drawing.Point(145, 80);
            this.nudStep.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudStep.Name = "nudStep";
            this.nudStep.Size = new System.Drawing.Size(137, 20);
            this.nudStep.TabIndex = 6;
            this.nudStep.ThousandsSeparator = true;
            this.ttpHelp.SetToolTip(this.nudStep, "After how much years the program should put a next point to the trajectory. The l" +
        "ower the value, the greater the accuracy and resource consumption.");
            this.nudStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // nudDrawNthPoint
            // 
            this.nudDrawNthPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrawSettings.SetColumnSpan(this.nudDrawNthPoint, 2);
            this.nudDrawNthPoint.Location = new System.Drawing.Point(145, 105);
            this.nudDrawNthPoint.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDrawNthPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDrawNthPoint.Name = "nudDrawNthPoint";
            this.nudDrawNthPoint.Size = new System.Drawing.Size(137, 20);
            this.nudDrawNthPoint.TabIndex = 7;
            this.nudDrawNthPoint.ThousandsSeparator = true;
            this.ttpHelp.SetToolTip(this.nudDrawNthPoint, "Draw only every n-th point. For example, if your step is 1/12 (a month), then you" +
        " may draw only every 12th point to see only the years but keep the accuracy.");
            this.nudDrawNthPoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "planets";
            this.sfdSave.Filter = "Planet files|*.planets";
            // 
            // ofdLoad
            // 
            this.ofdLoad.DefaultExt = "planets";
            this.ofdLoad.Filter = "Planet files|*.planets";
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "png";
            this.sfdExport.Filter = "PNG files|*.png|BMP files|*.bmp";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 511);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(558, 8);
            this.progressBar1.TabIndex = 3;
            // 
            // pbxResult
            // 
            this.pbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxResult.Location = new System.Drawing.Point(9, 9);
            this.pbxResult.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pbxResult.Name = "pbxResult";
            this.pbxResult.Size = new System.Drawing.Size(558, 510);
            this.pbxResult.TabIndex = 0;
            this.pbxResult.TabStop = false;
            // 
            // bgwDrawImage
            // 
            this.bgwDrawImage.WorkerReportsProgress = true;
            this.bgwDrawImage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDrawImage_DoWork);
            this.bgwDrawImage.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwDrawImage_ProgressChanged);
            this.bgwDrawImage.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDrawImage_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 528);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pbxResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(585, 325);
            this.Name = "FrmMain";
            this.Text = "Planets";
            this.pnlSettings.ResumeLayout(false);
            this.pnlPlanetSettings.ResumeLayout(false);
            this.pnlHeading.ResumeLayout(false);
            this.pnlHeadingInner.ResumeLayout(false);
            this.pnlHeadingInner.PerformLayout();
            this.pnlPlanetsContainer.ResumeLayout(false);
            this.pnlPlanetsContainer.PerformLayout();
            this.tlpAddPlanet.ResumeLayout(false);
            this.tlpDrawSettings.ResumeLayout(false);
            this.tlpDrawSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawNthPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxResult;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.TableLayoutPanel tlpDrawSettings;
        private System.Windows.Forms.Panel pnlPlanetSettings;
        private System.Windows.Forms.Panel pnlPlanetsContainer;
        private System.Windows.Forms.Panel pnlPlanets;
        private System.Windows.Forms.TableLayoutPanel tlpAddPlanet;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.NumericUpDown nudStep;
        private System.Windows.Forms.Label lblViewFrom;
        private System.Windows.Forms.ComboBox cbxViewFrom;
        private System.Windows.Forms.Button btnAddPlanet;
        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.Panel pnlHeadingInner;
        private System.Windows.Forms.Label lblPlanets;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.NumericUpDown nudZoom;
        private System.Windows.Forms.NumericUpDown nudDrawNthPoint;
        private System.Windows.Forms.Label lblSkipPoints;
        private System.Windows.Forms.ToolTip ttpHelp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bgwDrawImage;
    }
}

