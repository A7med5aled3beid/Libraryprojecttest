namespace Librarypro.PL
{
    partial class frm_home
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
            this.pn_home = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_home
            // 
            this.pn_home.BackColor = System.Drawing.Color.White;
            this.pn_home.BackgroundImage = global::Librarypro.Properties.Resources._9;
            this.pn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_home.Location = new System.Drawing.Point(0, 0);
            this.pn_home.Name = "pn_home";
            this.pn_home.Size = new System.Drawing.Size(1280, 755);
            this.pn_home.TabIndex = 0;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "الرئيسية";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_home;

    }
}