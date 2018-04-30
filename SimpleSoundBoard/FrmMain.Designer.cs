namespace SimpleSoundBoard
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbF1 = new System.Windows.Forms.Label();
            this.lbF2 = new System.Windows.Forms.Label();
            this.lbF3 = new System.Windows.Forms.Label();
            this.lbF4 = new System.Windows.Forms.Label();
            this.lbF5 = new System.Windows.Forms.Label();
            this.lbF6 = new System.Windows.Forms.Label();
            this.lbF7 = new System.Windows.Forms.Label();
            this.lbF8 = new System.Windows.Forms.Label();
            this.lbF9 = new System.Windows.Forms.Label();
            this.lbF10 = new System.Windows.Forms.Label();
            this.lbF11 = new System.Windows.Forms.Label();
            this.lbF12 = new System.Windows.Forms.Label();
            this.btF1 = new System.Windows.Forms.Button();
            this.btF2 = new System.Windows.Forms.Button();
            this.btF3 = new System.Windows.Forms.Button();
            this.btF4 = new System.Windows.Forms.Button();
            this.btF5 = new System.Windows.Forms.Button();
            this.btF6 = new System.Windows.Forms.Button();
            this.btF7 = new System.Windows.Forms.Button();
            this.btF8 = new System.Windows.Forms.Button();
            this.btF9 = new System.Windows.Forms.Button();
            this.btF10 = new System.Windows.Forms.Button();
            this.btF11 = new System.Windows.Forms.Button();
            this.btF12 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SimpleSoundBoard";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiAbout,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 76);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Image = global::SimpleSoundBoard.Properties.Resources.Application_16x;
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(107, 22);
            this.tsmiShow.Text = "&Show";
            this.tsmiShow.Click += new System.EventHandler(this.TsmiShow_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Image = global::SimpleSoundBoard.Properties.Resources.UIAboutBox_16x;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "&About";
            this.tsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::SimpleSoundBoard.Properties.Resources.CloseSolution_16x;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(107, 22);
            this.tsmiExit.Text = "&Exit";
            this.tsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 12;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel.Controls.Add(this.lbF1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF4, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF5, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF6, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF7, 6, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF8, 7, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF9, 8, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF10, 9, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF11, 10, 0);
            this.tableLayoutPanel.Controls.Add(this.lbF12, 11, 0);
            this.tableLayoutPanel.Controls.Add(this.btF1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btF2, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.btF3, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.btF4, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.btF5, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.btF6, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.btF7, 6, 1);
            this.tableLayoutPanel.Controls.Add(this.btF8, 7, 1);
            this.tableLayoutPanel.Controls.Add(this.btF9, 8, 1);
            this.tableLayoutPanel.Controls.Add(this.btF10, 9, 1);
            this.tableLayoutPanel.Controls.Add(this.btF11, 10, 1);
            this.tableLayoutPanel.Controls.Add(this.btF12, 11, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(613, 71);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lbF1
            // 
            this.lbF1.AutoSize = true;
            this.lbF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF1.Location = new System.Drawing.Point(4, 1);
            this.lbF1.Name = "lbF1";
            this.lbF1.Size = new System.Drawing.Size(44, 34);
            this.lbF1.TabIndex = 0;
            this.lbF1.Text = "F1";
            this.lbF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF2
            // 
            this.lbF2.AutoSize = true;
            this.lbF2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF2.Location = new System.Drawing.Point(55, 1);
            this.lbF2.Name = "lbF2";
            this.lbF2.Size = new System.Drawing.Size(44, 34);
            this.lbF2.TabIndex = 1;
            this.lbF2.Text = "F2";
            this.lbF2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF3
            // 
            this.lbF3.AutoSize = true;
            this.lbF3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF3.Location = new System.Drawing.Point(106, 1);
            this.lbF3.Name = "lbF3";
            this.lbF3.Size = new System.Drawing.Size(44, 34);
            this.lbF3.TabIndex = 2;
            this.lbF3.Text = "F3";
            this.lbF3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF4
            // 
            this.lbF4.AutoSize = true;
            this.lbF4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF4.Location = new System.Drawing.Point(157, 1);
            this.lbF4.Name = "lbF4";
            this.lbF4.Size = new System.Drawing.Size(44, 34);
            this.lbF4.TabIndex = 3;
            this.lbF4.Text = "F4";
            this.lbF4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF5
            // 
            this.lbF5.AutoSize = true;
            this.lbF5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF5.Location = new System.Drawing.Point(208, 1);
            this.lbF5.Name = "lbF5";
            this.lbF5.Size = new System.Drawing.Size(44, 34);
            this.lbF5.TabIndex = 4;
            this.lbF5.Text = "F5";
            this.lbF5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF6
            // 
            this.lbF6.AutoSize = true;
            this.lbF6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF6.Location = new System.Drawing.Point(259, 1);
            this.lbF6.Name = "lbF6";
            this.lbF6.Size = new System.Drawing.Size(44, 34);
            this.lbF6.TabIndex = 5;
            this.lbF6.Text = "F6";
            this.lbF6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF7
            // 
            this.lbF7.AutoSize = true;
            this.lbF7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF7.Location = new System.Drawing.Point(310, 1);
            this.lbF7.Name = "lbF7";
            this.lbF7.Size = new System.Drawing.Size(44, 34);
            this.lbF7.TabIndex = 6;
            this.lbF7.Text = "F7";
            this.lbF7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF8
            // 
            this.lbF8.AutoSize = true;
            this.lbF8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF8.Location = new System.Drawing.Point(361, 1);
            this.lbF8.Name = "lbF8";
            this.lbF8.Size = new System.Drawing.Size(44, 34);
            this.lbF8.TabIndex = 7;
            this.lbF8.Text = "F8";
            this.lbF8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF9
            // 
            this.lbF9.AutoSize = true;
            this.lbF9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF9.Location = new System.Drawing.Point(412, 1);
            this.lbF9.Name = "lbF9";
            this.lbF9.Size = new System.Drawing.Size(44, 34);
            this.lbF9.TabIndex = 8;
            this.lbF9.Text = "F9";
            this.lbF9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF10
            // 
            this.lbF10.AutoSize = true;
            this.lbF10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF10.Location = new System.Drawing.Point(463, 1);
            this.lbF10.Name = "lbF10";
            this.lbF10.Size = new System.Drawing.Size(44, 34);
            this.lbF10.TabIndex = 9;
            this.lbF10.Text = "F10";
            this.lbF10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF11
            // 
            this.lbF11.AutoSize = true;
            this.lbF11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF11.Location = new System.Drawing.Point(514, 1);
            this.lbF11.Name = "lbF11";
            this.lbF11.Size = new System.Drawing.Size(44, 34);
            this.lbF11.TabIndex = 10;
            this.lbF11.Text = "F11";
            this.lbF11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbF12
            // 
            this.lbF12.AutoSize = true;
            this.lbF12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbF12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF12.Location = new System.Drawing.Point(565, 1);
            this.lbF12.Name = "lbF12";
            this.lbF12.Size = new System.Drawing.Size(51, 34);
            this.lbF12.TabIndex = 11;
            this.lbF12.Text = "F12";
            this.lbF12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btF1
            // 
            this.btF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF1.Image = ((System.Drawing.Image)(resources.GetObject("btF1.Image")));
            this.btF1.Location = new System.Drawing.Point(4, 39);
            this.btF1.Name = "btF1";
            this.btF1.Size = new System.Drawing.Size(44, 28);
            this.btF1.TabIndex = 12;
            this.btF1.UseVisualStyleBackColor = true;
            this.btF1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF2
            // 
            this.btF2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF2.Image = ((System.Drawing.Image)(resources.GetObject("btF2.Image")));
            this.btF2.Location = new System.Drawing.Point(55, 39);
            this.btF2.Name = "btF2";
            this.btF2.Size = new System.Drawing.Size(44, 28);
            this.btF2.TabIndex = 13;
            this.btF2.UseVisualStyleBackColor = true;
            this.btF2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF3
            // 
            this.btF3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF3.Image = ((System.Drawing.Image)(resources.GetObject("btF3.Image")));
            this.btF3.Location = new System.Drawing.Point(106, 39);
            this.btF3.Name = "btF3";
            this.btF3.Size = new System.Drawing.Size(44, 28);
            this.btF3.TabIndex = 14;
            this.btF3.UseVisualStyleBackColor = true;
            this.btF3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF4
            // 
            this.btF4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF4.Image = ((System.Drawing.Image)(resources.GetObject("btF4.Image")));
            this.btF4.Location = new System.Drawing.Point(157, 39);
            this.btF4.Name = "btF4";
            this.btF4.Size = new System.Drawing.Size(44, 28);
            this.btF4.TabIndex = 15;
            this.btF4.UseVisualStyleBackColor = true;
            this.btF4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF5
            // 
            this.btF5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF5.Image = ((System.Drawing.Image)(resources.GetObject("btF5.Image")));
            this.btF5.Location = new System.Drawing.Point(208, 39);
            this.btF5.Name = "btF5";
            this.btF5.Size = new System.Drawing.Size(44, 28);
            this.btF5.TabIndex = 16;
            this.btF5.UseVisualStyleBackColor = true;
            this.btF5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF6
            // 
            this.btF6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF6.Image = ((System.Drawing.Image)(resources.GetObject("btF6.Image")));
            this.btF6.Location = new System.Drawing.Point(259, 39);
            this.btF6.Name = "btF6";
            this.btF6.Size = new System.Drawing.Size(44, 28);
            this.btF6.TabIndex = 17;
            this.btF6.UseVisualStyleBackColor = true;
            this.btF6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF7
            // 
            this.btF7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF7.Image = ((System.Drawing.Image)(resources.GetObject("btF7.Image")));
            this.btF7.Location = new System.Drawing.Point(310, 39);
            this.btF7.Name = "btF7";
            this.btF7.Size = new System.Drawing.Size(44, 28);
            this.btF7.TabIndex = 18;
            this.btF7.UseVisualStyleBackColor = true;
            this.btF7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF8
            // 
            this.btF8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF8.Image = ((System.Drawing.Image)(resources.GetObject("btF8.Image")));
            this.btF8.Location = new System.Drawing.Point(361, 39);
            this.btF8.Name = "btF8";
            this.btF8.Size = new System.Drawing.Size(44, 28);
            this.btF8.TabIndex = 19;
            this.btF8.UseVisualStyleBackColor = true;
            this.btF8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF9
            // 
            this.btF9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF9.Image = ((System.Drawing.Image)(resources.GetObject("btF9.Image")));
            this.btF9.Location = new System.Drawing.Point(412, 39);
            this.btF9.Name = "btF9";
            this.btF9.Size = new System.Drawing.Size(44, 28);
            this.btF9.TabIndex = 20;
            this.btF9.UseVisualStyleBackColor = true;
            this.btF9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF10
            // 
            this.btF10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF10.Image = ((System.Drawing.Image)(resources.GetObject("btF10.Image")));
            this.btF10.Location = new System.Drawing.Point(463, 39);
            this.btF10.Name = "btF10";
            this.btF10.Size = new System.Drawing.Size(44, 28);
            this.btF10.TabIndex = 21;
            this.btF10.UseVisualStyleBackColor = true;
            this.btF10.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF11
            // 
            this.btF11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btF11.Image = ((System.Drawing.Image)(resources.GetObject("btF11.Image")));
            this.btF11.Location = new System.Drawing.Point(514, 39);
            this.btF11.Name = "btF11";
            this.btF11.Size = new System.Drawing.Size(44, 28);
            this.btF11.TabIndex = 22;
            this.btF11.UseVisualStyleBackColor = true;
            this.btF11.Click += new System.EventHandler(this.Button_Click);
            // 
            // btF12
            // 
            this.btF12.Image = ((System.Drawing.Image)(resources.GetObject("btF12.Image")));
            this.btF12.Location = new System.Drawing.Point(565, 39);
            this.btF12.Name = "btF12";
            this.btF12.Size = new System.Drawing.Size(44, 28);
            this.btF12.TabIndex = 23;
            this.btF12.UseVisualStyleBackColor = true;
            this.btF12.Click += new System.EventHandler(this.Button_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Audio files\"|*.*";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 71);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleSoundBoard";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lbF1;
        private System.Windows.Forms.Label lbF2;
        private System.Windows.Forms.Label lbF3;
        private System.Windows.Forms.Label lbF4;
        private System.Windows.Forms.Label lbF5;
        private System.Windows.Forms.Label lbF6;
        private System.Windows.Forms.Label lbF7;
        private System.Windows.Forms.Label lbF8;
        private System.Windows.Forms.Label lbF9;
        private System.Windows.Forms.Label lbF10;
        private System.Windows.Forms.Label lbF11;
        private System.Windows.Forms.Label lbF12;
        private System.Windows.Forms.Button btF1;
        private System.Windows.Forms.Button btF2;
        private System.Windows.Forms.Button btF3;
        private System.Windows.Forms.Button btF4;
        private System.Windows.Forms.Button btF5;
        private System.Windows.Forms.Button btF6;
        private System.Windows.Forms.Button btF7;
        private System.Windows.Forms.Button btF8;
        private System.Windows.Forms.Button btF9;
        private System.Windows.Forms.Button btF10;
        private System.Windows.Forms.Button btF11;
        private System.Windows.Forms.Button btF12;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

