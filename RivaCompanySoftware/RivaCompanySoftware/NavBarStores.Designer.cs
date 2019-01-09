namespace RivaCompanySoftware
{
    partial class NavBarStores
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
            this.purchaseButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.managmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // purchaseButton
            // 
            this.purchaseButton.FlatAppearance.BorderSize = 0;
            this.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseButton.Location = new System.Drawing.Point(497, 0);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(150, 50);
            this.purchaseButton.TabIndex = 7;
            this.purchaseButton.Text = "Inkoop";
            this.purchaseButton.UseVisualStyleBackColor = true;
            // 
            // productsButton
            // 
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Location = new System.Drawing.Point(50, 0);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(150, 50);
            this.productsButton.TabIndex = 6;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = true;
            // 
            // staffButton
            // 
            this.staffButton.FlatAppearance.BorderSize = 0;
            this.staffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffButton.Location = new System.Drawing.Point(199, 0);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(150, 50);
            this.staffButton.TabIndex = 5;
            this.staffButton.Text = "Personeel";
            this.staffButton.UseVisualStyleBackColor = true;
            // 
            // managmentButton
            // 
            this.managmentButton.FlatAppearance.BorderSize = 0;
            this.managmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managmentButton.Location = new System.Drawing.Point(348, 0);
            this.managmentButton.Name = "managmentButton";
            this.managmentButton.Size = new System.Drawing.Size(150, 50);
            this.managmentButton.TabIndex = 4;
            this.managmentButton.Text = "Managment";
            this.managmentButton.UseVisualStyleBackColor = true;
            // 
            // NavBarStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.managmentButton);
            this.Name = "NavBarStores";
            this.Size = new System.Drawing.Size(1034, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button managmentButton;
    }
}
