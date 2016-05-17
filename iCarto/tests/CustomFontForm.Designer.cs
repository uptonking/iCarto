namespace iCarto.tests
{
    partial class CustomFontForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.MaximumSize = new System.Drawing.Size(800, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "这里是思源黑体Normal：\\r\\n思源黑体仿佛解决了我们长久以来字重不足的问题。他备有特细体至特粗体共七个字重选择，无论用在印刷还是网站作品中也绰绰有余。其中更" +
    "值得留意的，是Normal跟Regular这两个极为相近却有微妙字重分别的字重";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 259);
            this.label2.MaximumSize = new System.Drawing.Size(800, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(798, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "这里是思源黑体Regular：\\r\\n笔者认为，Normal跟Regular更多是为了解决界面设计光亮/暗色底纸互换，和不同大小屏幕间互换间所造成的字体变粗或变幼" +
    "细问题。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 470);
            this.label3.MaximumSize = new System.Drawing.Size(800, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(789, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "这里是默认字体：\\r\\n这官方答案恐怕不是资深字体研究者们所期望的、他们更喜欢许瀚文老师的说法，Normal 和 Regular 字重分别适用于不同的黑白背景排版" +
    "场合";
            // 
            // CustomFontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomFontForm";
            this.Text = "CustomFontForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}