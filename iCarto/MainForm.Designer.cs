namespace iCarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.lollipopCard1 = new LollipopCard();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(422, 122);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(281, 298);
            this.axMapControl1.TabIndex = 0;
            // 
            // lollipopCard1
            // 
            this.lollipopCard1.ButtonColor = "#33b679";
            this.lollipopCard1.ContentColor = "#444444";
            this.lollipopCard1.ContentText = "Card Content is here";
            this.lollipopCard1.Image = null;
            this.lollipopCard1.Location = new System.Drawing.Point(57, 122);
            this.lollipopCard1.Name = "lollipopCard1";
            this.lollipopCard1.Size = new System.Drawing.Size(294, 298);
            this.lollipopCard1.TabIndex = 1;
            this.lollipopCard1.Text = "lollipopCard1";
            this.lollipopCard1.TitleColor = "#33b679";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 462);
            this.Controls.Add(this.lollipopCard1);
            this.Controls.Add(this.axMapControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private LollipopCard lollipopCard1;
    }
}

