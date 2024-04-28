using System;

namespace Planets
{
    partial class PlanetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpPlanet = new System.Windows.Forms.TableLayoutPanel();
            this.lblOffset = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblOrbitTime = new System.Windows.Forms.Label();
            this.cbxParent = new System.Windows.Forms.ComboBox();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.chbxVisible = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.cdlColor = new System.Windows.Forms.ColorDialog();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tlpPlanet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPlanet
            // 
            this.tlpPlanet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlanet.BackColor = System.Drawing.SystemColors.Control;
            this.tlpPlanet.ColumnCount = 4;
            this.tlpPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPlanet.Controls.Add(this.lblOffset, 0, 4);
            this.tlpPlanet.Controls.Add(this.tbxName, 0, 0);
            this.tlpPlanet.Controls.Add(this.lblParent, 0, 1);
            this.tlpPlanet.Controls.Add(this.lblDistance, 0, 2);
            this.tlpPlanet.Controls.Add(this.lblOrbitTime, 0, 3);
            this.tlpPlanet.Controls.Add(this.cbxParent, 2, 1);
            this.tlpPlanet.Controls.Add(this.nudTime, 2, 3);
            this.tlpPlanet.Controls.Add(this.nudDistance, 2, 2);
            this.tlpPlanet.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tlpPlanet.Controls.Add(this.nudOffset, 2, 4);
            this.tlpPlanet.Location = new System.Drawing.Point(0, 0);
            this.tlpPlanet.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPlanet.Name = "tlpPlanet";
            this.tlpPlanet.RowCount = 5;
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPlanet.Size = new System.Drawing.Size(255, 126);
            this.tlpPlanet.TabIndex = 0;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.tlpPlanet.SetColumnSpan(this.lblOffset, 2);
            this.lblOffset.Location = new System.Drawing.Point(3, 100);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblOffset.Size = new System.Drawing.Size(35, 25);
            this.lblOffset.TabIndex = 5;
            this.lblOffset.Text = "Offset";
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlanet.SetColumnSpan(this.tbxName, 2);
            this.tbxName.Location = new System.Drawing.Point(3, 3);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(120, 20);
            this.tbxName.TabIndex = 0;
            this.ttpInfo.SetToolTip(this.tbxName, "Name");
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.tlpPlanet.SetColumnSpan(this.lblParent, 2);
            this.lblParent.Location = new System.Drawing.Point(3, 25);
            this.lblParent.Name = "lblParent";
            this.lblParent.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblParent.Size = new System.Drawing.Size(38, 25);
            this.lblParent.TabIndex = 2;
            this.lblParent.Text = "Parent";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.tlpPlanet.SetColumnSpan(this.lblDistance, 2);
            this.lblDistance.Location = new System.Drawing.Point(3, 50);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblDistance.Size = new System.Drawing.Size(70, 25);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "Distance (au)";
            // 
            // lblOrbitTime
            // 
            this.lblOrbitTime.AutoSize = true;
            this.tlpPlanet.SetColumnSpan(this.lblOrbitTime, 2);
            this.lblOrbitTime.Location = new System.Drawing.Point(3, 75);
            this.lblOrbitTime.Name = "lblOrbitTime";
            this.lblOrbitTime.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblOrbitTime.Size = new System.Drawing.Size(71, 25);
            this.lblOrbitTime.TabIndex = 4;
            this.lblOrbitTime.Text = "Sideric period";
            // 
            // cbxParent
            // 
            this.cbxParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlanet.SetColumnSpan(this.cbxParent, 2);
            this.cbxParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParent.FormattingEnabled = true;
            this.cbxParent.Location = new System.Drawing.Point(129, 28);
            this.cbxParent.Name = "cbxParent";
            this.cbxParent.Size = new System.Drawing.Size(123, 21);
            this.cbxParent.TabIndex = 2;
            this.ttpInfo.SetToolTip(this.cbxParent, "The planet, which this planet is orbiting around.");
            this.cbxParent.SelectedValueChanged += new System.EventHandler(this.cbxParent_SelectedValueChanged);
            this.cbxParent.Enter += new System.EventHandler(this.cbxParent_Enter);
            this.cbxParent.MouseEnter += new System.EventHandler(this.cbxParent_MouseEnter);
            // 
            // nudTime
            // 
            this.nudTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlanet.SetColumnSpan(this.nudTime, 2);
            this.nudTime.DecimalPlaces = 4;
            this.nudTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTime.Location = new System.Drawing.Point(129, 78);
            this.nudTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTime.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(123, 20);
            this.nudTime.TabIndex = 4;
            this.nudTime.ThousandsSeparator = true;
            this.ttpInfo.SetToolTip(this.nudTime, "The time in years it takes to go once around the parent planet.");
            // 
            // nudDistance
            // 
            this.nudDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlanet.SetColumnSpan(this.nudDistance, 2);
            this.nudDistance.DecimalPlaces = 4;
            this.nudDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDistance.Location = new System.Drawing.Point(129, 53);
            this.nudDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDistance.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(123, 20);
            this.nudDistance.TabIndex = 3;
            this.nudDistance.ThousandsSeparator = true;
            this.ttpInfo.SetToolTip(this.nudDistance, "The distance from the parent planet.");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tlpPlanet.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnMoveUp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveDown, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chbxVisible, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(126, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(129, 25);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.BackgroundImage = global::Planets.Properties.Resources.imgMoveUp;
            this.btnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveUp.Font = new System.Drawing.Font("Wingdings 3", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMoveUp.Location = new System.Drawing.Point(52, 1);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(22, 23);
            this.btnMoveUp.TabIndex = 2;
            this.ttpInfo.SetToolTip(this.btnMoveUp, "Move up");
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.BackgroundImage = global::Planets.Properties.Resources.imgMoveDown;
            this.btnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveDown.Font = new System.Drawing.Font("Wingdings 3", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMoveDown.Location = new System.Drawing.Point(77, 1);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(22, 23);
            this.btnMoveDown.TabIndex = 3;
            this.ttpInfo.SetToolTip(this.btnMoveDown, "Move down");
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(2, 1);
            this.btnColor.Margin = new System.Windows.Forms.Padding(1);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(23, 23);
            this.btnColor.TabIndex = 0;
            this.ttpInfo.SetToolTip(this.btnColor, "Color");
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // chbxVisible
            // 
            this.chbxVisible.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbxVisible.BackgroundImage = global::Planets.Properties.Resources.imgVisibility;
            this.chbxVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chbxVisible.Checked = true;
            this.chbxVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxVisible.Font = new System.Drawing.Font("Webdings", 12F);
            this.chbxVisible.Location = new System.Drawing.Point(27, 1);
            this.chbxVisible.Margin = new System.Windows.Forms.Padding(1);
            this.chbxVisible.Name = "chbxVisible";
            this.chbxVisible.Size = new System.Drawing.Size(23, 23);
            this.chbxVisible.TabIndex = 1;
            this.chbxVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpInfo.SetToolTip(this.chbxVisible, "Visibility");
            this.chbxVisible.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackgroundImage = global::Planets.Properties.Resources.imgClose;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Font = new System.Drawing.Font("Webdings", 6F);
            this.btnRemove.Location = new System.Drawing.Point(104, 1);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 23);
            this.btnRemove.TabIndex = 4;
            this.ttpInfo.SetToolTip(this.btnRemove, "Remove planet");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // nudOffset
            // 
            this.nudOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlanet.SetColumnSpan(this.nudOffset, 2);
            this.nudOffset.DecimalPlaces = 4;
            this.nudOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudOffset.Location = new System.Drawing.Point(129, 103);
            this.nudOffset.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(123, 20);
            this.nudOffset.TabIndex = 6;
            this.nudOffset.ThousandsSeparator = true;
            this.ttpInfo.SetToolTip(this.nudOffset, "The offset of the planets beginning position in years");
            // 
            // cdlColor
            // 
            this.cdlColor.AnyColor = true;
            this.cdlColor.FullOpen = true;
            // 
            // PlanetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.tlpPlanet);
            this.MinimumSize = new System.Drawing.Size(255, 104);
            this.Name = "PlanetControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(255, 129);
            this.tlpPlanet.ResumeLayout(false);
            this.tlpPlanet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPlanet;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblOrbitTime;
        public System.Windows.Forms.ComboBox cbxParent;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.ColorDialog cdlColor;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chbxVisible;
        private System.Windows.Forms.ToolTip ttpInfo;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Button btnRemove;
    }
}
