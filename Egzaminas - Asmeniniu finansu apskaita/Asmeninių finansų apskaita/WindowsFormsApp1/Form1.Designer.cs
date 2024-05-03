namespace WindowsFormsApp1
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.BtnAddTransaction = new System.Windows.Forms.Button();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.BtnEditCategory = new System.Windows.Forms.Button();
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.btnDeleteTrans = new System.Windows.Forms.Button();
            this.btnEditTrans = new System.Windows.Forms.Button();
            this.dgReportGen = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgCateRepGen = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgLast = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCateRepGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLast)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(1016, 232);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(75, 52);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Generuoti Ataskaita";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(786, 264);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dgTransactions
            // 
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Location = new System.Drawing.Point(42, 299);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.Size = new System.Drawing.Size(576, 150);
            this.dgTransactions.TabIndex = 3;
            this.dgTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransactions_CellContentClick);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(39, 28);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 13);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Kategorijos ";
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ataskaita Generatorius pagal data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(786, 235);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 6;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // BtnAddTransaction
            // 
            this.BtnAddTransaction.Location = new System.Drawing.Point(39, 485);
            this.BtnAddTransaction.Name = "BtnAddTransaction";
            this.BtnAddTransaction.Size = new System.Drawing.Size(178, 23);
            this.BtnAddTransaction.TabIndex = 7;
            this.BtnAddTransaction.Text = "Prideti transakcija";
            this.BtnAddTransaction.UseVisualStyleBackColor = true;
            this.BtnAddTransaction.Click += new System.EventHandler(this.BtnAddTransaction_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Location = new System.Drawing.Point(42, 232);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(101, 23);
            this.BtnAddCategory.TabIndex = 8;
            this.BtnAddCategory.Text = "pridet kategorija";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // BtnEditCategory
            // 
            this.BtnEditCategory.Location = new System.Drawing.Point(192, 232);
            this.BtnEditCategory.Name = "BtnEditCategory";
            this.BtnEditCategory.Size = new System.Drawing.Size(101, 23);
            this.BtnEditCategory.TabIndex = 9;
            this.BtnEditCategory.Text = "edit kategorija";
            this.BtnEditCategory.UseVisualStyleBackColor = true;
            this.BtnEditCategory.Click += new System.EventHandler(this.BtnEditCategory_Click);
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.Location = new System.Drawing.Point(350, 232);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(101, 23);
            this.BtnDeleteCategory.TabIndex = 10;
            this.BtnDeleteCategory.Text = "delete kategorija";
            this.BtnDeleteCategory.UseVisualStyleBackColor = true;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // dgCategories
            // 
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Location = new System.Drawing.Point(42, 62);
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.Size = new System.Drawing.Size(409, 150);
            this.dgCategories.TabIndex = 11;
            // 
            // btnDeleteTrans
            // 
            this.btnDeleteTrans.Location = new System.Drawing.Point(440, 485);
            this.btnDeleteTrans.Name = "btnDeleteTrans";
            this.btnDeleteTrans.Size = new System.Drawing.Size(178, 23);
            this.btnDeleteTrans.TabIndex = 12;
            this.btnDeleteTrans.Text = "transakcija delete";
            this.btnDeleteTrans.UseVisualStyleBackColor = true;
            this.btnDeleteTrans.Click += new System.EventHandler(this.btnDeleteTrans_Click);
            // 
            // btnEditTrans
            // 
            this.btnEditTrans.Location = new System.Drawing.Point(246, 485);
            this.btnEditTrans.Name = "btnEditTrans";
            this.btnEditTrans.Size = new System.Drawing.Size(164, 23);
            this.btnEditTrans.TabIndex = 13;
            this.btnEditTrans.Text = "transakcija edit";
            this.btnEditTrans.UseVisualStyleBackColor = true;
            this.btnEditTrans.Click += new System.EventHandler(this.btnEditTrans_Click);
            // 
            // dgReportGen
            // 
            this.dgReportGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportGen.Location = new System.Drawing.Point(549, 62);
            this.dgReportGen.Name = "dgReportGen";
            this.dgReportGen.Size = new System.Drawing.Size(542, 150);
            this.dgReportGen.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pradzios DATA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pabaigos DATA";
            // 
            // dgCateRepGen
            // 
            this.dgCateRepGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCateRepGen.Location = new System.Drawing.Point(662, 299);
            this.dgCateRepGen.Name = "dgCateRepGen";
            this.dgCateRepGen.Size = new System.Drawing.Size(429, 150);
            this.dgCateRepGen.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generuoti kategorine sumine ataskaita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Finansinės transakcijos";
            // 
            // dgLast
            // 
            this.dgLast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLast.Location = new System.Drawing.Point(662, 549);
            this.dgLast.Name = "dgLast";
            this.dgLast.Size = new System.Drawing.Size(429, 150);
            this.dgLast.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 715);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(429, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sugeneruoti Finansinę Sumos Ataskaitą";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Paaiskinimas:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "1. Prideti Kategorija(irasyti arba \"Pajamos\" arba \"Islaidos\")";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "2. Prideti Finasine Transakcija, viska surasyti klavetura (nurodyti kategorijos i" +
    "d ir t.t.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 656);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "3. Generuokite visas tris ataskaitas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 790);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgLast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgCateRepGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReportGen);
            this.Controls.Add(this.btnEditTrans);
            this.Controls.Add(this.btnDeleteTrans);
            this.Controls.Add(this.dgCategories);
            this.Controls.Add(this.BtnDeleteCategory);
            this.Controls.Add(this.BtnEditCategory);
            this.Controls.Add(this.BtnAddCategory);
            this.Controls.Add(this.BtnAddTransaction);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dgTransactions);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCateRepGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button BtnAddTransaction;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Button BtnEditCategory;
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.DataGridView dgCategories;
        private System.Windows.Forms.Button btnDeleteTrans;
        private System.Windows.Forms.Button btnEditTrans;
        private System.Windows.Forms.DataGridView dgReportGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgCateRepGen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgLast;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

