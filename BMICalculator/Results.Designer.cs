namespace BMICalculator
{
    partial class Results
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBmiIndex = new System.Windows.Forms.Label();
            this.labelTier = new System.Windows.Forms.Label();
            this.labelChagingKilos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMICalculator.Properties.Resources.BMI_Chart;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelBmiIndex
            // 
            this.labelBmiIndex.AutoSize = true;
            this.labelBmiIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBmiIndex.Location = new System.Drawing.Point(260, 428);
            this.labelBmiIndex.Name = "labelBmiIndex";
            this.labelBmiIndex.Size = new System.Drawing.Size(60, 24);
            this.labelBmiIndex.TabIndex = 2;
            this.labelBmiIndex.Text = "label2";
            // 
            // labelTier
            // 
            this.labelTier.AutoSize = true;
            this.labelTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTier.Location = new System.Drawing.Point(260, 478);
            this.labelTier.Name = "labelTier";
            this.labelTier.Size = new System.Drawing.Size(60, 24);
            this.labelTier.TabIndex = 3;
            this.labelTier.Text = "label3";
            // 
            // labelChagingKilos
            // 
            this.labelChagingKilos.AutoSize = true;
            this.labelChagingKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChagingKilos.Location = new System.Drawing.Point(260, 532);
            this.labelChagingKilos.Name = "labelChagingKilos";
            this.labelChagingKilos.Size = new System.Drawing.Size(60, 24);
            this.labelChagingKilos.TabIndex = 4;
            this.labelChagingKilos.Text = "label4";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 576);
            this.Controls.Add(this.labelChagingKilos);
            this.Controls.Add(this.labelTier);
            this.Controls.Add(this.labelBmiIndex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Results";
            this.Text = "Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Results_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBmiIndex;
        private System.Windows.Forms.Label labelTier;
        private System.Windows.Forms.Label labelChagingKilos;
    }
}