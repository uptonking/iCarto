namespace iCarto
{
    partial class IndexForm
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
            this.indexPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.indexPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // indexPanel
            // 
            this.indexPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.indexPanel.Controls.Add(this.label1);
            this.indexPanel.Controls.Add(this.button1);
            this.indexPanel.Location = new System.Drawing.Point(0, 65);
            this.indexPanel.Name = "indexPanel";
            this.indexPanel.Size = new System.Drawing.Size(1280, 655);
            this.indexPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This Is Panel 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenPanel2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.Info;
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.button2);
            this.editPanel.Location = new System.Drawing.Point(-1280, 65);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(1280, 655);
            this.editPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This Is Panel 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "OpenPanel1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.indexPanel);
            this.Controls.Add(this.editPanel);
            this.Name = "IndexForm";
            this.Text = "在线制图";
            this.SizeChanged += new System.EventHandler(this.IndexForm_SizeChanged);
            this.indexPanel.ResumeLayout(false);
            this.indexPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel indexPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}