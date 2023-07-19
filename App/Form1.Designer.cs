namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvGoods = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuantityGoodMovement = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StockGoods = new System.Windows.Forms.TextBox();
            this.PriceGoods = new System.Windows.Forms.TextBox();
            this.CostGoods = new System.Windows.Forms.TextBox();
            this.BrandGoods = new System.Windows.Forms.TextBox();
            this.ColorGoods = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryGoods = new System.Windows.Forms.TextBox();
            this.IdGoods = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.NameConcept = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.IdConcept = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gvConcepts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gvSells = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gvSellsDetail = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DateMovement = new System.Windows.Forms.DateTimePicker();
            this.button8 = new System.Windows.Forms.Button();
            this.QuantityMovement = new System.Windows.Forms.TextBox();
            this.IdConceptMovement = new System.Windows.Forms.TextBox();
            this.IdProdMovement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.IdMovement = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.gvMovements = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvGoods)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityGoodMovement)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConcepts)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSells)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellsDetail)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // gvGoods
            // 
            this.gvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGoods.Location = new System.Drawing.Point(3, 3);
            this.gvGoods.MultiSelect = false;
            this.gvGoods.Name = "gvGoods";
            this.gvGoods.ReadOnly = true;
            this.gvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGoods.Size = new System.Drawing.Size(380, 100);
            this.gvGoods.TabIndex = 0;
            this.gvGoods.SelectionChanged += new System.EventHandler(this.gvGoods_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QuantityGoodMovement);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.StockGoods);
            this.panel1.Controls.Add(this.PriceGoods);
            this.panel1.Controls.Add(this.CostGoods);
            this.panel1.Controls.Add(this.BrandGoods);
            this.panel1.Controls.Add(this.ColorGoods);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CategoryGoods);
            this.panel1.Controls.Add(this.IdGoods);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gvGoods);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 216);
            this.panel1.TabIndex = 1;
            // 
            // QuantityGoodMovement
            // 
            this.QuantityGoodMovement.Location = new System.Drawing.Point(323, 161);
            this.QuantityGoodMovement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityGoodMovement.Name = "QuantityGoodMovement";
            this.QuantityGoodMovement.Size = new System.Drawing.Size(51, 20);
            this.QuantityGoodMovement.TabIndex = 4;
            this.QuantityGoodMovement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(267, 187);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Add";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(323, 187);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "T Out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button10_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockGoods
            // 
            this.StockGoods.Location = new System.Drawing.Point(201, 161);
            this.StockGoods.Name = "StockGoods";
            this.StockGoods.Size = new System.Drawing.Size(60, 20);
            this.StockGoods.TabIndex = 2;
            // 
            // PriceGoods
            // 
            this.PriceGoods.Location = new System.Drawing.Point(201, 131);
            this.PriceGoods.Name = "PriceGoods";
            this.PriceGoods.Size = new System.Drawing.Size(60, 20);
            this.PriceGoods.TabIndex = 2;
            // 
            // CostGoods
            // 
            this.CostGoods.Location = new System.Drawing.Point(201, 106);
            this.CostGoods.Name = "CostGoods";
            this.CostGoods.Size = new System.Drawing.Size(60, 20);
            this.CostGoods.TabIndex = 2;
            // 
            // BrandGoods
            // 
            this.BrandGoods.Location = new System.Drawing.Point(58, 135);
            this.BrandGoods.Name = "BrandGoods";
            this.BrandGoods.Size = new System.Drawing.Size(100, 20);
            this.BrandGoods.TabIndex = 2;
            // 
            // ColorGoods
            // 
            this.ColorGoods.Location = new System.Drawing.Point(58, 187);
            this.ColorGoods.Name = "ColorGoods";
            this.ColorGoods.Size = new System.Drawing.Size(100, 20);
            this.ColorGoods.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Stock";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(268, 164);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brand";
            // 
            // CategoryGoods
            // 
            this.CategoryGoods.Location = new System.Drawing.Point(58, 161);
            this.CategoryGoods.Name = "CategoryGoods";
            this.CategoryGoods.Size = new System.Drawing.Size(100, 20);
            this.CategoryGoods.TabIndex = 2;
            // 
            // IdGoods
            // 
            this.IdGoods.Location = new System.Drawing.Point(58, 109);
            this.IdGoods.Name = "IdGoods";
            this.IdGoods.ReadOnly = true;
            this.IdGoods.Size = new System.Drawing.Size(40, 20);
            this.IdGoods.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.NameConcept);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.IdConcept);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.gvConcepts);
            this.panel2.Location = new System.Drawing.Point(405, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 216);
            this.panel2.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(5, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // NameConcept
            // 
            this.NameConcept.Location = new System.Drawing.Point(58, 135);
            this.NameConcept.Name = "NameConcept";
            this.NameConcept.Size = new System.Drawing.Size(100, 20);
            this.NameConcept.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Concept";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Random";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // IdConcept
            // 
            this.IdConcept.Location = new System.Drawing.Point(58, 109);
            this.IdConcept.Name = "IdConcept";
            this.IdConcept.ReadOnly = true;
            this.IdConcept.Size = new System.Drawing.Size(40, 20);
            this.IdConcept.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Id";
            // 
            // gvConcepts
            // 
            this.gvConcepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConcepts.Location = new System.Drawing.Point(3, 3);
            this.gvConcepts.MultiSelect = false;
            this.gvConcepts.Name = "gvConcepts";
            this.gvConcepts.ReadOnly = true;
            this.gvConcepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvConcepts.Size = new System.Drawing.Size(210, 100);
            this.gvConcepts.TabIndex = 0;
            this.gvConcepts.SelectionChanged += new System.EventHandler(this.gvConcepts_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox18);
            this.panel3.Controls.Add(this.textBox19);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.gvSells);
            this.panel3.Location = new System.Drawing.Point(12, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 265);
            this.panel3.TabIndex = 1;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(58, 187);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Amount";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(58, 213);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 2;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(58, 161);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(40, 20);
            this.textBox19.TabIndex = 2;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 239);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Add Random";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Id";
            // 
            // gvSells
            // 
            this.gvSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSells.Location = new System.Drawing.Point(3, 3);
            this.gvSells.MultiSelect = false;
            this.gvSells.Name = "gvSells";
            this.gvSells.ReadOnly = true;
            this.gvSells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSells.Size = new System.Drawing.Size(155, 152);
            this.gvSells.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox11);
            this.panel4.Controls.Add(this.textBox15);
            this.panel4.Controls.Add(this.textBox10);
            this.panel4.Controls.Add(this.textBox21);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.textBox22);
            this.panel4.Controls.Add(this.textBox23);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.gvSellsDetail);
            this.panel4.Location = new System.Drawing.Point(179, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 265);
            this.panel4.TabIndex = 1;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(156, 213);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(60, 20);
            this.textBox11.TabIndex = 2;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(58, 213);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(40, 20);
            this.textBox15.TabIndex = 2;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(156, 187);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(60, 20);
            this.textBox10.TabIndex = 2;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(58, 187);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(40, 20);
            this.textBox21.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(156, 161);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 20);
            this.textBox9.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Id Prod";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(58, 239);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(40, 20);
            this.textBox22.TabIndex = 2;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(58, 161);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(40, 20);
            this.textBox23.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Amount";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 190);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Id Sell";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Price";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Id Mov";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quantity";
            // 
            // gvSellsDetail
            // 
            this.gvSellsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSellsDetail.Location = new System.Drawing.Point(3, 3);
            this.gvSellsDetail.MultiSelect = false;
            this.gvSellsDetail.Name = "gvSellsDetail";
            this.gvSellsDetail.ReadOnly = true;
            this.gvSellsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSellsDetail.Size = new System.Drawing.Size(213, 152);
            this.gvSellsDetail.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DateMovement);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.QuantityMovement);
            this.panel5.Controls.Add(this.IdConceptMovement);
            this.panel5.Controls.Add(this.IdProdMovement);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.IdMovement);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.gvMovements);
            this.panel5.Location = new System.Drawing.Point(406, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 265);
            this.panel5.TabIndex = 1;
            // 
            // DateMovement
            // 
            this.DateMovement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMovement.Location = new System.Drawing.Point(56, 213);
            this.DateMovement.Name = "DateMovement";
            this.DateMovement.Size = new System.Drawing.Size(155, 20);
            this.DateMovement.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(118, 236);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // QuantityMovement
            // 
            this.QuantityMovement.Location = new System.Drawing.Point(171, 190);
            this.QuantityMovement.Name = "QuantityMovement";
            this.QuantityMovement.Size = new System.Drawing.Size(40, 20);
            this.QuantityMovement.TabIndex = 2;
            // 
            // IdConceptMovement
            // 
            this.IdConceptMovement.Location = new System.Drawing.Point(56, 187);
            this.IdConceptMovement.Name = "IdConceptMovement";
            this.IdConceptMovement.Size = new System.Drawing.Size(40, 20);
            this.IdConceptMovement.TabIndex = 2;
            // 
            // IdProdMovement
            // 
            this.IdProdMovement.Location = new System.Drawing.Point(171, 161);
            this.IdProdMovement.Name = "IdProdMovement";
            this.IdProdMovement.Size = new System.Drawing.Size(40, 20);
            this.IdProdMovement.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(5, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Add Random";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(2, 190);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Id Cpt";
            // 
            // IdMovement
            // 
            this.IdMovement.Location = new System.Drawing.Point(24, 161);
            this.IdMovement.Name = "IdMovement";
            this.IdMovement.ReadOnly = true;
            this.IdMovement.Size = new System.Drawing.Size(40, 20);
            this.IdMovement.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(2, 216);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(124, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Id Prod";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(2, 164);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(16, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Id";
            // 
            // gvMovements
            // 
            this.gvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovements.Location = new System.Drawing.Point(3, 3);
            this.gvMovements.MultiSelect = false;
            this.gvMovements.Name = "gvMovements";
            this.gvMovements.ReadOnly = true;
            this.gvMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMovements.Size = new System.Drawing.Size(209, 152);
            this.gvMovements.TabIndex = 0;
            this.gvMovements.SelectionChanged += new System.EventHandler(this.gvMovements_SelectionChanged);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(121, 161);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(51, 23);
            this.button12.TabIndex = 3;
            this.button12.Text = "Test";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGoods)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityGoodMovement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConcepts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSells)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellsDetail)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvGoods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockGoods;
        private System.Windows.Forms.TextBox PriceGoods;
        private System.Windows.Forms.TextBox CostGoods;
        private System.Windows.Forms.TextBox BrandGoods;
        private System.Windows.Forms.TextBox ColorGoods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CategoryGoods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NameConcept;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IdConcept;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView gvConcepts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView gvSells;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gvSellsDetail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker DateMovement;
        private System.Windows.Forms.TextBox IdConceptMovement;
        private System.Windows.Forms.TextBox IdProdMovement;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox IdMovement;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView gvMovements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown QuantityGoodMovement;
        private System.Windows.Forms.TextBox QuantityMovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

