namespace ProjectEDP
{
    partial class Form3
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblExplore = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.panelHero = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.picChairs = new System.Windows.Forms.PictureBox();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChairs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.panelSearch);
            this.panelNav.Controls.Add(this.picLogo);
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1188, 70);
            this.panelNav.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(30, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(110, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelSearch
            // 
            this.panelSearch.Location = new System.Drawing.Point(160, 15);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(350, 40);
            this.panelSearch.TabIndex = 1;
            // 
            // lblExplore
            // 
            this.lblExplore.AutoSize = true;
            this.lblExplore.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplore.Location = new System.Drawing.Point(800, 25);
            this.lblExplore.Name = "lblExplore";
            this.lblExplore.Size = new System.Drawing.Size(66, 23);
            this.lblExplore.TabIndex = 1;
            this.lblExplore.Text = "Explore";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Location = new System.Drawing.Point(890, 25);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(30, 16);
            this.lblSell.TabIndex = 2;
            this.lblSell.Text = "Sell";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(1080, 25);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(45, 16);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = "Profile";
            // 
            // panelHero
            // 
            this.panelHero.Controls.Add(this.picChairs);
            this.panelHero.Controls.Add(this.lblMainTitle);
            this.panelHero.Location = new System.Drawing.Point(30, 100);
            this.panelHero.Name = "panelHero";
            this.panelHero.Size = new System.Drawing.Size(1140, 320);
            this.panelHero.TabIndex = 4;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(486, 52);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "La Liga 2026-27 Tickets";
            // 
            // picChairs
            // 
            this.picChairs.Location = new System.Drawing.Point(20, 100);
            this.picChairs.Name = "picChairs";
            this.picChairs.Size = new System.Drawing.Size(220, 150);
            this.picChairs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChairs.TabIndex = 1;
            this.picChairs.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.panelHero);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblExplore);
            this.Controls.Add(this.panelNav);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHero.ResumeLayout(false);
            this.panelHero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblExplore;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel panelHero;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.PictureBox picChairs;
    }
}