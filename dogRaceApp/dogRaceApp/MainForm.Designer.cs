namespace dogRaceApp
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
            this.bettingParlorGroubBox = new System.Windows.Forms.GroupBox();
            this.labelMinimumBets = new System.Windows.Forms.Label();
            this.labelSelectedBettor = new System.Windows.Forms.Label();
            this.labelJoesBet = new System.Windows.Forms.Label();
            this.labelAlsBet = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelBobsBet = new System.Windows.Forms.Label();
            this.labelBets = new System.Windows.Forms.Label();
            this.buttonBets = new System.Windows.Forms.Button();
            this.buttonRace = new System.Windows.Forms.Button();
            this.numericUpDownBets = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDog = new System.Windows.Forms.NumericUpDown();
            this.radioButtonJoe = new System.Windows.Forms.RadioButton();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.racer3 = new System.Windows.Forms.PictureBox();
            this.racer2 = new System.Windows.Forms.PictureBox();
            this.racer1 = new System.Windows.Forms.PictureBox();
            this.racer4 = new System.Windows.Forms.PictureBox();
            this.bettingParlorGroubBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).BeginInit();
            this.SuspendLayout();
            // 
            // bettingParlorGroubBox
            // 
            this.bettingParlorGroubBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bettingParlorGroubBox.Controls.Add(this.numericUpDownDog);
            this.bettingParlorGroubBox.Controls.Add(this.radioButtonBob);
            this.bettingParlorGroubBox.Controls.Add(this.label);
            this.bettingParlorGroubBox.Controls.Add(this.numericUpDownBets);
            this.bettingParlorGroubBox.Controls.Add(this.labelMinimumBets);
            this.bettingParlorGroubBox.Controls.Add(this.buttonRace);
            this.bettingParlorGroubBox.Controls.Add(this.radioButtonAl);
            this.bettingParlorGroubBox.Controls.Add(this.buttonBets);
            this.bettingParlorGroubBox.Controls.Add(this.radioButtonJoe);
            this.bettingParlorGroubBox.Controls.Add(this.labelBobsBet);
            this.bettingParlorGroubBox.Controls.Add(this.labelAlsBet);
            this.bettingParlorGroubBox.Controls.Add(this.labelBets);
            this.bettingParlorGroubBox.Controls.Add(this.labelSelectedBettor);
            this.bettingParlorGroubBox.Controls.Add(this.labelJoesBet);
            this.bettingParlorGroubBox.Location = new System.Drawing.Point(12, 218);
            this.bettingParlorGroubBox.Name = "bettingParlorGroubBox";
            this.bettingParlorGroubBox.Size = new System.Drawing.Size(600, 142);
            this.bettingParlorGroubBox.TabIndex = 0;
            this.bettingParlorGroubBox.TabStop = false;
            this.bettingParlorGroubBox.Text = "Betting Parlor";
            // 
            // labelMinimumBets
            // 
            this.labelMinimumBets.AutoSize = true;
            this.labelMinimumBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimumBets.Location = new System.Drawing.Point(6, 16);
            this.labelMinimumBets.Name = "labelMinimumBets";
            this.labelMinimumBets.Size = new System.Drawing.Size(142, 17);
            this.labelMinimumBets.TabIndex = 1;
            this.labelMinimumBets.Text = "Minimum bet: € 5,-";
            // 
            // labelSelectedBettor
            // 
            this.labelSelectedBettor.AutoSize = true;
            this.labelSelectedBettor.Location = new System.Drawing.Point(6, 113);
            this.labelSelectedBettor.Name = "labelSelectedBettor";
            this.labelSelectedBettor.Size = new System.Drawing.Size(44, 13);
            this.labelSelectedBettor.TabIndex = 3;
            this.labelSelectedBettor.Text = "No bets";
            // 
            // labelJoesBet
            // 
            this.labelJoesBet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJoesBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelJoesBet.Location = new System.Drawing.Point(254, 37);
            this.labelJoesBet.Name = "labelJoesBet";
            this.labelJoesBet.Padding = new System.Windows.Forms.Padding(1);
            this.labelJoesBet.Size = new System.Drawing.Size(340, 17);
            this.labelJoesBet.TabIndex = 4;
            this.labelJoesBet.Text = "Joe";
            // 
            // labelAlsBet
            // 
            this.labelAlsBet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlsBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlsBet.Location = new System.Drawing.Point(254, 83);
            this.labelAlsBet.Name = "labelAlsBet";
            this.labelAlsBet.Padding = new System.Windows.Forms.Padding(1);
            this.labelAlsBet.Size = new System.Drawing.Size(340, 17);
            this.labelAlsBet.TabIndex = 5;
            this.labelAlsBet.Text = "Al";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(198, 113);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Euro op hond nummer";
            // 
            // labelBobsBet
            // 
            this.labelBobsBet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBobsBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBobsBet.Location = new System.Drawing.Point(254, 60);
            this.labelBobsBet.Name = "labelBobsBet";
            this.labelBobsBet.Padding = new System.Windows.Forms.Padding(1);
            this.labelBobsBet.Size = new System.Drawing.Size(340, 17);
            this.labelBobsBet.TabIndex = 7;
            this.labelBobsBet.Text = "Bob";
            // 
            // labelBets
            // 
            this.labelBets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBets.AutoSize = true;
            this.labelBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBets.Location = new System.Drawing.Point(251, 16);
            this.labelBets.Name = "labelBets";
            this.labelBets.Size = new System.Drawing.Size(88, 17);
            this.labelBets.TabIndex = 8;
            this.labelBets.Text = "Inzettingen";
            // 
            // buttonBets
            // 
            this.buttonBets.Location = new System.Drawing.Point(56, 108);
            this.buttonBets.Name = "buttonBets";
            this.buttonBets.Size = new System.Drawing.Size(75, 23);
            this.buttonBets.TabIndex = 9;
            this.buttonBets.Text = "Inzetten";
            this.buttonBets.UseVisualStyleBackColor = true;
            this.buttonBets.Click += new System.EventHandler(this.buttonBets_Click);
            // 
            // buttonRace
            // 
            this.buttonRace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRace.AutoSize = true;
            this.buttonRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRace.Location = new System.Drawing.Point(519, 103);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonRace.Size = new System.Drawing.Size(75, 34);
            this.buttonRace.TabIndex = 10;
            this.buttonRace.Text = "Race!";
            this.buttonRace.UseVisualStyleBackColor = true;
            this.buttonRace.Click += new System.EventHandler(this.buttonRace_Click);
            // 
            // numericUpDownBets
            // 
            this.numericUpDownBets.Location = new System.Drawing.Point(137, 111);
            this.numericUpDownBets.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownBets.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBets.Name = "numericUpDownBets";
            this.numericUpDownBets.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownBets.TabIndex = 11;
            this.numericUpDownBets.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownDog
            // 
            this.numericUpDownDog.Location = new System.Drawing.Point(315, 111);
            this.numericUpDownDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDog.Name = "numericUpDownDog";
            this.numericUpDownDog.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownDog.TabIndex = 12;
            this.numericUpDownDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonJoe
            // 
            this.radioButtonJoe.AutoSize = true;
            this.radioButtonJoe.Location = new System.Drawing.Point(9, 36);
            this.radioButtonJoe.Name = "radioButtonJoe";
            this.radioButtonJoe.Size = new System.Drawing.Size(42, 17);
            this.radioButtonJoe.TabIndex = 13;
            this.radioButtonJoe.TabStop = true;
            this.radioButtonJoe.Text = "Joe";
            this.radioButtonJoe.UseVisualStyleBackColor = true;
            this.radioButtonJoe.CheckedChanged += new System.EventHandler(this.radioButtonJoe_CheckedChanged);
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.Location = new System.Drawing.Point(9, 82);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(34, 17);
            this.radioButtonAl.TabIndex = 14;
            this.radioButtonAl.TabStop = true;
            this.radioButtonAl.Text = "Al";
            this.radioButtonAl.UseVisualStyleBackColor = true;
            this.radioButtonAl.CheckedChanged += new System.EventHandler(this.radioButtonAl_CheckedChanged);
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.Location = new System.Drawing.Point(9, 59);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBob.TabIndex = 15;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "Bob";
            this.radioButtonBob.UseVisualStyleBackColor = true;
            this.radioButtonBob.CheckedChanged += new System.EventHandler(this.radioButtonBob_CheckedChanged);
            // 
            // raceTrack
            // 
            this.raceTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raceTrack.Image = global::dogRaceApp.Properties.Resources.afbeelding_racebaan;
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(600, 200);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.raceTrack.TabIndex = 1;
            this.raceTrack.TabStop = false;
            // 
            // racer3
            // 
            this.racer3.Image = ((System.Drawing.Image)(resources.GetObject("racer3.Image")));
            this.racer3.Location = new System.Drawing.Point(12, 124);
            this.racer3.Name = "racer3";
            this.racer3.Size = new System.Drawing.Size(75, 20);
            this.racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racer3.TabIndex = 2;
            this.racer3.TabStop = false;
            // 
            // racer2
            // 
            this.racer2.Image = ((System.Drawing.Image)(resources.GetObject("racer2.Image")));
            this.racer2.Location = new System.Drawing.Point(12, 70);
            this.racer2.Name = "racer2";
            this.racer2.Size = new System.Drawing.Size(75, 20);
            this.racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racer2.TabIndex = 3;
            this.racer2.TabStop = false;
            // 
            // racer1
            // 
            this.racer1.Image = ((System.Drawing.Image)(resources.GetObject("racer1.Image")));
            this.racer1.Location = new System.Drawing.Point(12, 21);
            this.racer1.Name = "racer1";
            this.racer1.Size = new System.Drawing.Size(75, 20);
            this.racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racer1.TabIndex = 4;
            this.racer1.TabStop = false;
            // 
            // racer4
            // 
            this.racer4.Image = ((System.Drawing.Image)(resources.GetObject("racer4.Image")));
            this.racer4.Location = new System.Drawing.Point(12, 178);
            this.racer4.Name = "racer4";
            this.racer4.Size = new System.Drawing.Size(75, 20);
            this.racer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racer4.TabIndex = 5;
            this.racer4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 372);
            this.Controls.Add(this.racer4);
            this.Controls.Add(this.racer1);
            this.Controls.Add(this.racer2);
            this.Controls.Add(this.racer3);
            this.Controls.Add(this.bettingParlorGroubBox);
            this.Controls.Add(this.raceTrack);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.bettingParlorGroubBox.ResumeLayout(false);
            this.bettingParlorGroubBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bettingParlorGroubBox;
        private System.Windows.Forms.Label labelMinimumBets;
        private System.Windows.Forms.Label labelSelectedBettor;
        private System.Windows.Forms.Label labelJoesBet;
        private System.Windows.Forms.Label labelAlsBet;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelBobsBet;
        private System.Windows.Forms.Label labelBets;
        private System.Windows.Forms.Button buttonBets;
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.NumericUpDown numericUpDownBets;
        private System.Windows.Forms.NumericUpDown numericUpDownDog;
        private System.Windows.Forms.RadioButton radioButtonJoe;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox racer3;
        private System.Windows.Forms.PictureBox racer2;
        private System.Windows.Forms.PictureBox racer1;
        private System.Windows.Forms.PictureBox racer4;
    }
}

