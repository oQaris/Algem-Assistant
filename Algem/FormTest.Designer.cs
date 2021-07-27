namespace Algem
{
    partial class FormTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCoef = new System.Windows.Forms.RadioButton();
            this.rbtFull = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblZpt = new System.Windows.Forms.Label();
            this.rbtPlus = new System.Windows.Forms.RadioButton();
            this.rbtZero = new System.Windows.Forms.RadioButton();
            this.groupBoxPoly = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxPoly.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.groupBoxPoly);
            this.groupBox1.Controls.Add(this.lblZpt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(237, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(418, 116);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbtCoef
            // 
            this.rbtCoef.AutoSize = true;
            this.rbtCoef.Checked = true;
            this.rbtCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtCoef.Location = new System.Drawing.Point(6, 35);
            this.rbtCoef.Name = "rbtCoef";
            this.rbtCoef.Size = new System.Drawing.Size(140, 17);
            this.rbtCoef.TabIndex = 14;
            this.rbtCoef.TabStop = true;
            this.rbtCoef.Text = "только коэффициенты";
            this.rbtCoef.UseVisualStyleBackColor = true;
            // 
            // rbtFull
            // 
            this.rbtFull.AutoSize = true;
            this.rbtFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtFull.Location = new System.Drawing.Point(6, 19);
            this.rbtFull.Name = "rbtFull";
            this.rbtFull.Size = new System.Drawing.Size(63, 17);
            this.rbtFull.TabIndex = 13;
            this.rbtFull.Text = "полный";
            this.rbtFull.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(257, 90);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblZpt
            // 
            this.lblZpt.AutoSize = true;
            this.lblZpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblZpt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZpt.Location = new System.Drawing.Point(127, 92);
            this.lblZpt.Name = "lblZpt";
            this.lblZpt.Size = new System.Drawing.Size(124, 13);
            this.lblZpt.TabIndex = 10;
            this.lblZpt.Text = "Знаков после запятой:";
            // 
            // rbtPlus
            // 
            this.rbtPlus.AutoSize = true;
            this.rbtPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtPlus.Location = new System.Drawing.Point(6, 35);
            this.rbtPlus.Name = "rbtPlus";
            this.rbtPlus.Size = new System.Drawing.Size(106, 17);
            this.rbtPlus.TabIndex = 8;
            this.rbtPlus.Text = "положительные";
            this.rbtPlus.UseVisualStyleBackColor = true;
            // 
            // rbtZero
            // 
            this.rbtZero.AutoSize = true;
            this.rbtZero.Checked = true;
            this.rbtZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtZero.Location = new System.Drawing.Point(6, 19);
            this.rbtZero.Name = "rbtZero";
            this.rbtZero.Size = new System.Drawing.Size(94, 17);
            this.rbtZero.TabIndex = 7;
            this.rbtZero.TabStop = true;
            this.rbtZero.Text = "ближе к нулю";
            this.rbtZero.UseVisualStyleBackColor = true;
            // 
            // groupBoxPoly
            // 
            this.groupBoxPoly.Controls.Add(this.rbtCoef);
            this.groupBoxPoly.Controls.Add(this.rbtFull);
            this.groupBoxPoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPoly.Location = new System.Drawing.Point(6, 20);
            this.groupBoxPoly.Name = "groupBoxPoly";
            this.groupBoxPoly.Size = new System.Drawing.Size(200, 60);
            this.groupBoxPoly.TabIndex = 16;
            this.groupBoxPoly.TabStop = false;
            this.groupBoxPoly.Text = "Вывод многочленов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtZero);
            this.groupBox3.Controls.Add(this.rbtPlus);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(212, 20);
            this.groupBox3.Name = "groupBoxRing";
            this.groupBox3.Size = new System.Drawing.Size(200, 60);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод коэффициентов в кольце";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxPoly.ResumeLayout(false);
            this.groupBoxPoly.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCoef;
        private System.Windows.Forms.RadioButton rbtFull;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblZpt;
        private System.Windows.Forms.RadioButton rbtPlus;
        private System.Windows.Forms.RadioButton rbtZero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxPoly;
    }
}