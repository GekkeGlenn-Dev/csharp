namespace RivaCompanySoftware
{
    partial class NavBarCompany
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
            this.managmentButton = new System.Windows.Forms.Button();
            this.contractFormatButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.financialStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managmentButton
            // 
            this.managmentButton.FlatAppearance.BorderSize = 0;
            this.managmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managmentButton.Location = new System.Drawing.Point(346, 0);
            this.managmentButton.Name = "managmentButton";
            this.managmentButton.Size = new System.Drawing.Size(150, 50);
            this.managmentButton.TabIndex = 0;
            this.managmentButton.Text = "Managment";
            this.managmentButton.UseVisualStyleBackColor = true;
            // 
            // contractFormatButton
            // 
            this.contractFormatButton.FlatAppearance.BorderSize = 0;
            this.contractFormatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contractFormatButton.Location = new System.Drawing.Point(197, 0);
            this.contractFormatButton.Name = "contractFormatButton";
            this.contractFormatButton.Size = new System.Drawing.Size(150, 50);
            this.contractFormatButton.TabIndex = 1;
            this.contractFormatButton.Text = "Contract Format";
            this.contractFormatButton.UseVisualStyleBackColor = true;
            // 
            // staffButton
            // 
            this.staffButton.FlatAppearance.BorderSize = 0;
            this.staffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffButton.Location = new System.Drawing.Point(48, 0);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(150, 50);
            this.staffButton.TabIndex = 2;
            this.staffButton.Text = "Personeel";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // financialStatusButton
            // 
            this.financialStatusButton.FlatAppearance.BorderSize = 0;
            this.financialStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financialStatusButton.Location = new System.Drawing.Point(495, 0);
            this.financialStatusButton.Name = "financialStatusButton";
            this.financialStatusButton.Size = new System.Drawing.Size(150, 50);
            this.financialStatusButton.TabIndex = 3;
            this.financialStatusButton.Text = "financiële status";
            this.financialStatusButton.UseVisualStyleBackColor = true;
            // 
            // NavBarCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.financialStatusButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.contractFormatButton);
            this.Controls.Add(this.managmentButton);
            this.Name = "NavBarCompany";
            this.Size = new System.Drawing.Size(1034, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managmentButton;
        private System.Windows.Forms.Button contractFormatButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button financialStatusButton;
    }
}
