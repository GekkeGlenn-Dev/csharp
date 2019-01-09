namespace RivaCompanySoftware
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rivaVitaButton = new System.Windows.Forms.Button();
            this.rivaMeatButton = new System.Windows.Forms.Button();
            this.rivaCompanyButton = new System.Windows.Forms.Button();
            this.rivaDrinksButton = new System.Windows.Forms.Button();
            this.rivaAccesButton = new System.Windows.Forms.Button();
            this.homePageButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.activeButton = new System.Windows.Forms.Panel();
            this.navBarCompany = new RivaCompanySoftware.NavBarCompany();
            this.homePage = new RivaCompanySoftware.HomePage();
            this.navBarStores = new RivaCompanySoftware.NavBarStores();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.rivaVitaButton);
            this.panel1.Controls.Add(this.rivaMeatButton);
            this.panel1.Controls.Add(this.rivaCompanyButton);
            this.panel1.Controls.Add(this.rivaDrinksButton);
            this.panel1.Controls.Add(this.rivaAccesButton);
            this.panel1.Controls.Add(this.homePageButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 561);
            this.panel1.TabIndex = 0;
            // 
            // rivaVitaButton
            // 
            this.rivaVitaButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.rivaVitaButton.FlatAppearance.BorderSize = 0;
            this.rivaVitaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rivaVitaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivaVitaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rivaVitaButton.Location = new System.Drawing.Point(0, 331);
            this.rivaVitaButton.MaximumSize = new System.Drawing.Size(150, 35);
            this.rivaVitaButton.MinimumSize = new System.Drawing.Size(150, 35);
            this.rivaVitaButton.Name = "rivaVitaButton";
            this.rivaVitaButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rivaVitaButton.Size = new System.Drawing.Size(150, 35);
            this.rivaVitaButton.TabIndex = 6;
            this.rivaVitaButton.Text = "Riva Vita";
            this.rivaVitaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rivaVitaButton.UseVisualStyleBackColor = false;
            this.rivaVitaButton.Click += new System.EventHandler(this.rivaVitaButton_Click);
            // 
            // rivaMeatButton
            // 
            this.rivaMeatButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.rivaMeatButton.FlatAppearance.BorderSize = 0;
            this.rivaMeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rivaMeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivaMeatButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rivaMeatButton.Location = new System.Drawing.Point(0, 295);
            this.rivaMeatButton.MaximumSize = new System.Drawing.Size(150, 35);
            this.rivaMeatButton.MinimumSize = new System.Drawing.Size(150, 35);
            this.rivaMeatButton.Name = "rivaMeatButton";
            this.rivaMeatButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rivaMeatButton.Size = new System.Drawing.Size(150, 35);
            this.rivaMeatButton.TabIndex = 5;
            this.rivaMeatButton.Text = "Riva Meat";
            this.rivaMeatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rivaMeatButton.UseVisualStyleBackColor = false;
            this.rivaMeatButton.Click += new System.EventHandler(this.rivaMeatButton_Click);
            // 
            // rivaCompanyButton
            // 
            this.rivaCompanyButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.rivaCompanyButton.FlatAppearance.BorderSize = 0;
            this.rivaCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rivaCompanyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivaCompanyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rivaCompanyButton.Location = new System.Drawing.Point(0, 187);
            this.rivaCompanyButton.MaximumSize = new System.Drawing.Size(150, 35);
            this.rivaCompanyButton.MinimumSize = new System.Drawing.Size(150, 35);
            this.rivaCompanyButton.Name = "rivaCompanyButton";
            this.rivaCompanyButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rivaCompanyButton.Size = new System.Drawing.Size(150, 35);
            this.rivaCompanyButton.TabIndex = 2;
            this.rivaCompanyButton.Text = "Riva Company";
            this.rivaCompanyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rivaCompanyButton.UseVisualStyleBackColor = false;
            this.rivaCompanyButton.Click += new System.EventHandler(this.rivaCompanyButton_Click);
            // 
            // rivaDrinksButton
            // 
            this.rivaDrinksButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.rivaDrinksButton.FlatAppearance.BorderSize = 0;
            this.rivaDrinksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rivaDrinksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivaDrinksButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rivaDrinksButton.Location = new System.Drawing.Point(0, 259);
            this.rivaDrinksButton.MaximumSize = new System.Drawing.Size(150, 35);
            this.rivaDrinksButton.MinimumSize = new System.Drawing.Size(150, 35);
            this.rivaDrinksButton.Name = "rivaDrinksButton";
            this.rivaDrinksButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rivaDrinksButton.Size = new System.Drawing.Size(150, 35);
            this.rivaDrinksButton.TabIndex = 4;
            this.rivaDrinksButton.Text = "Riva Drinks";
            this.rivaDrinksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rivaDrinksButton.UseVisualStyleBackColor = false;
            this.rivaDrinksButton.Click += new System.EventHandler(this.rivaDrinksButton_Click);
            // 
            // rivaAccesButton
            // 
            this.rivaAccesButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.rivaAccesButton.FlatAppearance.BorderSize = 0;
            this.rivaAccesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rivaAccesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rivaAccesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rivaAccesButton.Location = new System.Drawing.Point(0, 223);
            this.rivaAccesButton.MaximumSize = new System.Drawing.Size(150, 35);
            this.rivaAccesButton.MinimumSize = new System.Drawing.Size(150, 35);
            this.rivaAccesButton.Name = "rivaAccesButton";
            this.rivaAccesButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rivaAccesButton.Size = new System.Drawing.Size(150, 35);
            this.rivaAccesButton.TabIndex = 3;
            this.rivaAccesButton.Text = "Riva Acces";
            this.rivaAccesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rivaAccesButton.UseVisualStyleBackColor = false;
            this.rivaAccesButton.Click += new System.EventHandler(this.rivaAccesButton_Click);
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.homePageButton.FlatAppearance.BorderSize = 0;
            this.homePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.homePageButton.Location = new System.Drawing.Point(0, 151);
            this.homePageButton.MaximumSize = new System.Drawing.Size(150, 35);
            this.homePageButton.MinimumSize = new System.Drawing.Size(150, 35);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.homePageButton.Size = new System.Drawing.Size(150, 35);
            this.homePageButton.TabIndex = 1;
            this.homePageButton.Text = "Home Page";
            this.homePageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 1;
            // 
            // activeButton
            // 
            this.activeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.activeButton.Location = new System.Drawing.Point(150, 151);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(5, 35);
            this.activeButton.TabIndex = 1;
            // 
            // navBarCompany
            // 
            this.navBarCompany.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.navBarCompany.Location = new System.Drawing.Point(150, 0);
            this.navBarCompany.Name = "navBarCompany";
            this.navBarCompany.Size = new System.Drawing.Size(1034, 50);
            this.navBarCompany.TabIndex = 2;
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(150, 0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(1034, 561);
            this.homePage.TabIndex = 4;
            // 
            // navBarStores
            // 
            this.navBarStores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.navBarStores.Location = new System.Drawing.Point(150, 0);
            this.navBarStores.Name = "navBarStores";
            this.navBarStores.Size = new System.Drawing.Size(1034, 50);
            this.navBarStores.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.navBarCompany);
            this.Controls.Add(this.activeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.navBarStores);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RivaCompany | Software";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button rivaCompanyButton;
        private System.Windows.Forms.Button rivaDrinksButton;
        private System.Windows.Forms.Button rivaAccesButton;
        private System.Windows.Forms.Button homePageButton;
        private System.Windows.Forms.Button rivaVitaButton;
        private System.Windows.Forms.Button rivaMeatButton;
        private System.Windows.Forms.Panel activeButton;
        private NavBarCompany navBarCompany;
        private NavBarStores navBarStores;
        private HomePage homePage;
    }
}

