namespace Algem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnDivPoly = new System.Windows.Forms.Button();
            this.btnGCDpoly = new System.Windows.Forms.Button();
            this.btnRevRes = new System.Windows.Forms.Button();
            this.btnGCDnum = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSumProizPoly = new System.Windows.Forms.Button();
            this.btnPrimeNum = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRoots = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cbxDer = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.cbxZ = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnRoots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAliquot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxRing = new System.Windows.Forms.GroupBox();
            this.rbtZero = new System.Windows.Forms.RadioButton();
            this.rbtPlus = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxPoly = new System.Windows.Forms.GroupBox();
            this.rbtCoef = new System.Windows.Forms.RadioButton();
            this.rbtFull = new System.Windows.Forms.RadioButton();
            this.lblZpt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxRing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxPoly.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(121, 212);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(300, 30);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Visible = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnDivPoly
            // 
            this.btnDivPoly.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnDivPoly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivPoly.Location = new System.Drawing.Point(278, 101);
            this.btnDivPoly.Name = "btnDivPoly";
            this.btnDivPoly.Size = new System.Drawing.Size(125, 70);
            this.btnDivPoly.TabIndex = 6;
            this.btnDivPoly.Text = "Деление многочленов";
            this.btnDivPoly.UseVisualStyleBackColor = true;
            this.btnDivPoly.Click += new System.EventHandler(this.btnDivPoly_Click);
            // 
            // btnGCDpoly
            // 
            this.btnGCDpoly.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnGCDpoly.Location = new System.Drawing.Point(409, 101);
            this.btnGCDpoly.Name = "btnGCDpoly";
            this.btnGCDpoly.Size = new System.Drawing.Size(125, 70);
            this.btnGCDpoly.TabIndex = 7;
            this.btnGCDpoly.Text = "НОД многочленов";
            this.btnGCDpoly.UseVisualStyleBackColor = true;
            this.btnGCDpoly.Click += new System.EventHandler(this.btnGCDpoly_Click);
            // 
            // btnRevRes
            // 
            this.btnRevRes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnRevRes.Location = new System.Drawing.Point(209, 22);
            this.btnRevRes.Name = "btnRevRes";
            this.btnRevRes.Size = new System.Drawing.Size(125, 70);
            this.btnRevRes.TabIndex = 2;
            this.btnRevRes.Text = "Обратные по модулю";
            this.btnRevRes.UseVisualStyleBackColor = true;
            this.btnRevRes.Click += new System.EventHandler(this.btnRevRes_Click);
            // 
            // btnGCDnum
            // 
            this.btnGCDnum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnGCDnum.Location = new System.Drawing.Point(340, 22);
            this.btnGCDnum.Name = "btnGCDnum";
            this.btnGCDnum.Size = new System.Drawing.Size(125, 70);
            this.btnGCDnum.TabIndex = 3;
            this.btnGCDnum.Text = "НОД/НОК чисел";
            this.btnGCDnum.UseVisualStyleBackColor = true;
            this.btnGCDnum.Click += new System.EventHandler(this.btnGCDnum_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(470, 203);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 23);
            this.btnMenu.TabIndex = 22;
            this.btnMenu.Text = "в меню";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "by Romanov Sergey, MPB-804";
            // 
            // btnSumProizPoly
            // 
            this.btnSumProizPoly.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSumProizPoly.Location = new System.Drawing.Point(16, 101);
            this.btnSumProizPoly.Name = "btnSumProizPoly";
            this.btnSumProizPoly.Size = new System.Drawing.Size(125, 70);
            this.btnSumProizPoly.TabIndex = 4;
            this.btnSumProizPoly.Text = "Сум./Произ. многочленов";
            this.btnSumProizPoly.UseVisualStyleBackColor = true;
            this.btnSumProizPoly.Click += new System.EventHandler(this.btnSumProizPoly_Click);
            // 
            // btnPrimeNum
            // 
            this.btnPrimeNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrimeNum.Location = new System.Drawing.Point(78, 22);
            this.btnPrimeNum.Name = "btnPrimeNum";
            this.btnPrimeNum.Size = new System.Drawing.Size(125, 70);
            this.btnPrimeNum.TabIndex = 1;
            this.btnPrimeNum.Text = "Простые числа";
            this.btnPrimeNum.UseVisualStyleBackColor = true;
            this.btnPrimeNum.Click += new System.EventHandler(this.btnPrimeNum_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(43, 203);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(55, 40);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "помочь разрабу";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn1.Location = new System.Drawing.Point(121, 213);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(151, 28);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "Сложить";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn2.Location = new System.Drawing.Point(278, 212);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(143, 29);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "Умножить";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnRoots
            // 
            this.btnRoots.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnRoots.Location = new System.Drawing.Point(147, 101);
            this.btnRoots.Name = "btnRoots";
            this.btnRoots.Size = new System.Drawing.Size(125, 70);
            this.btnRoots.TabIndex = 5;
            this.btnRoots.Text = "Корни многочлена";
            this.btnRoots.UseVisualStyleBackColor = true;
            this.btnRoots.Click += new System.EventHandler(this.btnRootsPoly_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeader.Location = new System.Drawing.Point(41, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(460, 30);
            this.lblHeader.TabIndex = 27;
            this.lblHeader.Text = "Деление многочленов";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(253, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 23);
            this.progressBar1.TabIndex = 50;
            this.progressBar1.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.Visible = false;
            // 
            // cbxDer
            // 
            this.cbxDer.Location = new System.Drawing.Point(450, 75);
            this.cbxDer.Name = "cbxDer";
            this.cbxDer.Size = new System.Drawing.Size(80, 65);
            this.cbxDer.TabIndex = 21;
            this.cbxDer.Text = "1-й мн./чл. и его про- изводная";
            this.cbxDer.UseVisualStyleBackColor = true;
            this.cbxDer.Visible = false;
            this.cbxDer.CheckedChanged += new System.EventHandler(this.cbxDer_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(455, 101);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(27, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(455, 75);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(70, 20);
            this.txtZ.TabIndex = 19;
            this.txtZ.Visible = false;
            // 
            // cbxZ
            // 
            this.cbxZ.AutoSize = true;
            this.cbxZ.Location = new System.Drawing.Point(450, 52);
            this.cbxZ.Name = "cbxZ";
            this.cbxZ.Size = new System.Drawing.Size(70, 17);
            this.cbxZ.TabIndex = 18;
            this.cbxZ.Text = "В поле Z";
            this.cbxZ.UseVisualStyleBackColor = true;
            this.cbxZ.Visible = false;
            this.cbxZ.CheckedChanged += new System.EventHandler(this.cbxZ_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Многочлены вводятся, начиная со старшей степени";
            this.label5.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(300, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(300, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Остаток";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Частное";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Делитель";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Делимое";
            this.label1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 129;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(13, 76);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 121);
            this.listBox1.TabIndex = 48;
            this.listBox1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnRoots,
            this.ColumnAliquot});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(104, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(334, 115);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // ColumnRoots
            // 
            this.ColumnRoots.Text = "Корни";
            this.ColumnRoots.Width = 220;
            // 
            // ColumnAliquot
            // 
            this.ColumnAliquot.Text = "Кратность";
            this.ColumnAliquot.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.groupBoxRing);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.groupBoxPoly);
            this.groupBox1.Controls.Add(this.lblZpt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(148, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(372, 86);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxRing
            // 
            this.groupBoxRing.Controls.Add(this.rbtZero);
            this.groupBoxRing.Controls.Add(this.rbtPlus);
            this.groupBoxRing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRing.Location = new System.Drawing.Point(186, 1);
            this.groupBoxRing.Name = "groupBoxRing";
            this.groupBoxRing.Size = new System.Drawing.Size(186, 60);
            this.groupBoxRing.TabIndex = 17;
            this.groupBoxRing.TabStop = false;
            this.groupBoxRing.Text = "Вывод коэффициентов в кольце";
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
            this.rbtZero.TabIndex = 10;
            this.rbtZero.TabStop = true;
            this.rbtZero.Text = "ближе к нулю";
            this.rbtZero.UseVisualStyleBackColor = true;
            // 
            // rbtPlus
            // 
            this.rbtPlus.AutoSize = true;
            this.rbtPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtPlus.Location = new System.Drawing.Point(6, 35);
            this.rbtPlus.Name = "rbtPlus";
            this.rbtPlus.Size = new System.Drawing.Size(106, 17);
            this.rbtPlus.TabIndex = 11;
            this.rbtPlus.Text = "положительные";
            this.rbtPlus.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(234, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            16,
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
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBoxPoly
            // 
            this.groupBoxPoly.Controls.Add(this.rbtCoef);
            this.groupBoxPoly.Controls.Add(this.rbtFull);
            this.groupBoxPoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPoly.Location = new System.Drawing.Point(0, 1);
            this.groupBoxPoly.Name = "groupBoxPoly";
            this.groupBoxPoly.Size = new System.Drawing.Size(186, 60);
            this.groupBoxPoly.TabIndex = 16;
            this.groupBoxPoly.TabStop = false;
            this.groupBoxPoly.Text = "Вывод многочленов";
            // 
            // rbtCoef
            // 
            this.rbtCoef.AutoSize = true;
            this.rbtCoef.Checked = true;
            this.rbtCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbtCoef.Location = new System.Drawing.Point(6, 35);
            this.rbtCoef.Name = "rbtCoef";
            this.rbtCoef.Size = new System.Drawing.Size(140, 17);
            this.rbtCoef.TabIndex = 9;
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
            this.rbtFull.TabIndex = 8;
            this.rbtFull.Text = "полный";
            this.rbtFull.UseVisualStyleBackColor = true;
            // 
            // lblZpt
            // 
            this.lblZpt.AutoSize = true;
            this.lblZpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblZpt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZpt.Location = new System.Drawing.Point(104, 64);
            this.lblZpt.Name = "lblZpt";
            this.lblZpt.Size = new System.Drawing.Size(124, 13);
            this.lblZpt.TabIndex = 10;
            this.lblZpt.Text = "Знаков после запятой:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(542, 271);
            this.Controls.Add(this.cbxZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cbxDer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnRoots);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnGCDnum);
            this.Controls.Add(this.btnPrimeNum);
            this.Controls.Add(this.btnRevRes);
            this.Controls.Add(this.btnGCDpoly);
            this.Controls.Add(this.btnSumProizPoly);
            this.Controls.Add(this.btnDivPoly);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algem assistant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRing.ResumeLayout(false);
            this.groupBoxRing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxPoly.ResumeLayout(false);
            this.groupBoxPoly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnDivPoly;
        private System.Windows.Forms.Button btnGCDpoly;
        private System.Windows.Forms.Button btnRevRes;
        private System.Windows.Forms.Button btnGCDnum;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSumProizPoly;
        private System.Windows.Forms.Button btnPrimeNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRoots;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox cbxDer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.CheckBox cbxZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnRoots;
        private System.Windows.Forms.ColumnHeader ColumnAliquot;
        private System.Windows.Forms.GroupBox groupBoxRing;
        private System.Windows.Forms.RadioButton rbtZero;
        private System.Windows.Forms.RadioButton rbtPlus;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBoxPoly;
        private System.Windows.Forms.RadioButton rbtCoef;
        private System.Windows.Forms.RadioButton rbtFull;
        private System.Windows.Forms.Label lblZpt;
    }
}

