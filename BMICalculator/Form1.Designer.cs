namespace BMICalculator
{
    partial class Form1
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
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.AcceptsReturn = true;
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(180, 110);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(174, 29);
            this.textBoxWeight.TabIndex = 2;
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidadeInput);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.AcceptsReturn = true;
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(180, 185);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(174, 29);
            this.textBoxHeight.TabIndex = 3;
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateBMI.Location = new System.Drawing.Point(85, 264);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(308, 83);
            this.buttonCalculateBMI.TabIndex = 4;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            this.buttonCalculateBMI.Click += new System.EventHandler(this.buttonCalculateBMI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCalculateBMI);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button buttonCalculateBMI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

