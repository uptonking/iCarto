namespace iCarto.views
{
    partial class StartForm
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
            this.userBtn = new FontAwesomeIcons.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.userBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // userBtn
            // 
            this.userBtn.ActiveColor = System.Drawing.Color.Black;
            this.userBtn.BackColor = System.Drawing.Color.Transparent;
            this.userBtn.IconType = FontAwesomeIcons.IconType.User;
            this.userBtn.InActiveColor = System.Drawing.Color.DimGray;
            this.userBtn.Location = new System.Drawing.Point(681, 44);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(48, 48);
            this.userBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userBtn.TabIndex = 0;
            this.userBtn.TabStop = false;
            this.userBtn.ToolTipText = null;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.userBtn);
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.Text = "              iCarto 快速制图";
            ((System.ComponentModel.ISupportInitialize)(this.userBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesomeIcons.IconButton userBtn;
    }
}