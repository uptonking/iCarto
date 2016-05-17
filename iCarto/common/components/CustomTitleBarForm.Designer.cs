namespace iCarto.common.components
{
    partial class CustomTitleBarForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleIcon = new FontAwesomeIcons.IconButton();
            this.closeBtn = new FontAwesomeIcons.IconButton();
            this.maxBtn = new FontAwesomeIcons.IconButton();
            this.minBtn = new FontAwesomeIcons.IconButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlePanel.Controls.Add(this.titleIcon);
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.maxBtn);
            this.titlePanel.Controls.Add(this.minBtn);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(640, 29);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.DoubleClick += new System.EventHandler(this.titlePanel_DoubleClick);
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // titleIcon
            // 
            this.titleIcon.ActiveColor = System.Drawing.Color.Black;
            this.titleIcon.BackColor = System.Drawing.Color.Transparent;
            this.titleIcon.IconType = FontAwesomeIcons.IconType.Reorder;
            this.titleIcon.InActiveColor = System.Drawing.Color.Gray;
            this.titleIcon.Location = new System.Drawing.Point(12, 6);
            this.titleIcon.Name = "titleIcon";
            this.titleIcon.Size = new System.Drawing.Size(18, 18);
            this.titleIcon.TabIndex = 4;
            this.titleIcon.TabStop = false;
            this.titleIcon.ToolTipText = null;
            // 
            // closeBtn
            // 
            this.closeBtn.ActiveColor = System.Drawing.Color.Black;
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.IconType = FontAwesomeIcons.IconType.Times;
            this.closeBtn.InActiveColor = System.Drawing.Color.Gray;
            this.closeBtn.Location = new System.Drawing.Point(610, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TabStop = false;
            this.closeBtn.Tag = "close";
            this.closeBtn.ToolTipText = null;
            this.closeBtn.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.ActiveColor = System.Drawing.Color.Black;
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.Color.Transparent;
            this.maxBtn.IconType = FontAwesomeIcons.IconType.SquareO;
            this.maxBtn.InActiveColor = System.Drawing.Color.DimGray;
            this.maxBtn.Location = new System.Drawing.Point(577, 6);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(18, 18);
            this.maxBtn.TabIndex = 2;
            this.maxBtn.TabStop = false;
            this.maxBtn.Tag = "max";
            this.maxBtn.ToolTipText = null;
            this.maxBtn.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // minBtn
            // 
            this.minBtn.ActiveColor = System.Drawing.Color.Black;
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.IconType = FontAwesomeIcons.IconType.Minus;
            this.minBtn.InActiveColor = System.Drawing.Color.Gray;
            this.minBtn.Location = new System.Drawing.Point(544, 6);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(18, 18);
            this.minBtn.TabIndex = 1;
            this.minBtn.TabStop = false;
            this.minBtn.Tag = "min";
            this.minBtn.ToolTipText = null;
            this.minBtn.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titleLabel.Location = new System.Drawing.Point(45, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(43, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // CustomTitleBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.ControlBox = false;
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomTitleBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private FontAwesomeIcons.IconButton minBtn;
        private FontAwesomeIcons.IconButton closeBtn;
        private FontAwesomeIcons.IconButton maxBtn;
        private FontAwesomeIcons.IconButton titleIcon;
    }
}