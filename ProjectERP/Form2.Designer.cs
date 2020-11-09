using System.Drawing;

namespace ProjectERP
{
    partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.employeeTab = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.employeeInsertTab = new System.Windows.Forms.TabPage();
			this.buttonAdrSearch = new System.Windows.Forms.Button();
			this.buttonEmpEnroll = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxEmpClass = new System.Windows.Forms.ComboBox();
			this.comboBoxEmpDivision = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxEmpAge = new System.Windows.Forms.TextBox();
			this.textBoxEmpAddress = new System.Windows.Forms.TextBox();
			this.textBoxEmpName = new System.Windows.Forms.TextBox();
			this.textBoxEmpNum = new System.Windows.Forms.TextBox();
			this.employeeUpdateTab = new System.Windows.Forms.TabPage();
			this.label13 = new System.Windows.Forms.Label();
			this.buttonEmpSearch = new System.Windows.Forms.Button();
			this.textBoxSearchEmp = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.employeeDeleteTab = new System.Windows.Forms.TabPage();
			this.buttonEmpDelete = new System.Windows.Forms.Button();
			this.dataGridViewEmpList = new System.Windows.Forms.DataGridView();
			this.employeeSearchTab = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.workTab = new System.Windows.Forms.TabPage();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage_master = new System.Windows.Forms.TabPage();
			this.button_Refresh = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button_revise = new System.Windows.Forms.Button();
			this.button_plus = new System.Windows.Forms.Button();
			this.button_del = new System.Windows.Forms.Button();
			this.dataGridView_master = new System.Windows.Forms.DataGridView();
			this.divsionTab = new System.Windows.Forms.TabPage();
			this.tabControl4 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.dataGridView6 = new System.Windows.Forms.DataGridView();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button8 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.dataGridView7 = new System.Windows.Forms.DataGridView();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.dataGridView8 = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.employeeTab.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.employeeInsertTab.SuspendLayout();
			this.employeeUpdateTab.SuspendLayout();
			this.employeeDeleteTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpList)).BeginInit();
			this.employeeSearchTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.workTab.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.tabPage_master.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_master)).BeginInit();
			this.divsionTab.SuspendLayout();
			this.tabControl4.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.employeeTab);
			this.tabControl1.Controls.Add(this.workTab);
			this.tabControl1.Controls.Add(this.divsionTab);
			this.tabControl1.Location = new System.Drawing.Point(4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(795, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// employeeTab
			// 
			this.employeeTab.Controls.Add(this.tabControl2);
			this.employeeTab.Location = new System.Drawing.Point(4, 22);
			this.employeeTab.Name = "employeeTab";
			this.employeeTab.Padding = new System.Windows.Forms.Padding(3);
			this.employeeTab.Size = new System.Drawing.Size(787, 424);
			this.employeeTab.TabIndex = 0;
			this.employeeTab.Text = "사원";
			this.employeeTab.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.employeeInsertTab);
			this.tabControl2.Controls.Add(this.employeeUpdateTab);
			this.tabControl2.Controls.Add(this.employeeDeleteTab);
			this.tabControl2.Controls.Add(this.employeeSearchTab);
			this.tabControl2.Location = new System.Drawing.Point(-4, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(795, 428);
			this.tabControl2.TabIndex = 0;
			// 
			// employeeInsertTab
			// 
			this.employeeInsertTab.Controls.Add(this.buttonAdrSearch);
			this.employeeInsertTab.Controls.Add(this.buttonEmpEnroll);
			this.employeeInsertTab.Controls.Add(this.label6);
			this.employeeInsertTab.Controls.Add(this.label5);
			this.employeeInsertTab.Controls.Add(this.comboBoxEmpClass);
			this.employeeInsertTab.Controls.Add(this.comboBoxEmpDivision);
			this.employeeInsertTab.Controls.Add(this.label4);
			this.employeeInsertTab.Controls.Add(this.label3);
			this.employeeInsertTab.Controls.Add(this.label2);
			this.employeeInsertTab.Controls.Add(this.label1);
			this.employeeInsertTab.Controls.Add(this.textBoxEmpAge);
			this.employeeInsertTab.Controls.Add(this.textBoxEmpAddress);
			this.employeeInsertTab.Controls.Add(this.textBoxEmpName);
			this.employeeInsertTab.Controls.Add(this.textBoxEmpNum);
			this.employeeInsertTab.Location = new System.Drawing.Point(4, 22);
			this.employeeInsertTab.Name = "employeeInsertTab";
			this.employeeInsertTab.Padding = new System.Windows.Forms.Padding(3);
			this.employeeInsertTab.Size = new System.Drawing.Size(787, 402);
			this.employeeInsertTab.TabIndex = 0;
			this.employeeInsertTab.Text = "등록";
			this.employeeInsertTab.UseVisualStyleBackColor = true;
			// 
			// buttonAdrSearch
			// 
			this.buttonAdrSearch.Location = new System.Drawing.Point(295, 225);
			this.buttonAdrSearch.Name = "buttonAdrSearch";
			this.buttonAdrSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonAdrSearch.TabIndex = 13;
			this.buttonAdrSearch.Text = "주소찾기";
			this.buttonAdrSearch.UseVisualStyleBackColor = true;
			// 
			// buttonEmpEnroll
			// 
			this.buttonEmpEnroll.Location = new System.Drawing.Point(342, 301);
			this.buttonEmpEnroll.Name = "buttonEmpEnroll";
			this.buttonEmpEnroll.Size = new System.Drawing.Size(75, 23);
			this.buttonEmpEnroll.TabIndex = 12;
			this.buttonEmpEnroll.Text = "등록";
			this.buttonEmpEnroll.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(420, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 11;
			this.label6.Text = "직급";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(420, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 10;
			this.label5.Text = "부서";
			// 
			// comboBoxEmpClass
			// 
			this.comboBoxEmpClass.FormattingEnabled = true;
			this.comboBoxEmpClass.Location = new System.Drawing.Point(478, 133);
			this.comboBoxEmpClass.Name = "comboBoxEmpClass";
			this.comboBoxEmpClass.Size = new System.Drawing.Size(121, 20);
			this.comboBoxEmpClass.TabIndex = 9;
			// 
			// comboBoxEmpDivision
			// 
			this.comboBoxEmpDivision.FormattingEnabled = true;
			this.comboBoxEmpDivision.Location = new System.Drawing.Point(478, 86);
			this.comboBoxEmpDivision.Name = "comboBoxEmpDivision";
			this.comboBoxEmpDivision.Size = new System.Drawing.Size(121, 20);
			this.comboBoxEmpDivision.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(123, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "이름";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(123, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "나이";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(123, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "주소";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(123, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "사원번호";
			// 
			// textBoxEmpAge
			// 
			this.textBoxEmpAge.Location = new System.Drawing.Point(189, 179);
			this.textBoxEmpAge.Name = "textBoxEmpAge";
			this.textBoxEmpAge.Size = new System.Drawing.Size(100, 21);
			this.textBoxEmpAge.TabIndex = 3;
			// 
			// textBoxEmpAddress
			// 
			this.textBoxEmpAddress.Location = new System.Drawing.Point(189, 225);
			this.textBoxEmpAddress.Name = "textBoxEmpAddress";
			this.textBoxEmpAddress.Size = new System.Drawing.Size(100, 21);
			this.textBoxEmpAddress.TabIndex = 2;
			// 
			// textBoxEmpName
			// 
			this.textBoxEmpName.Location = new System.Drawing.Point(189, 132);
			this.textBoxEmpName.Name = "textBoxEmpName";
			this.textBoxEmpName.Size = new System.Drawing.Size(100, 21);
			this.textBoxEmpName.TabIndex = 1;
			// 
			// textBoxEmpNum
			// 
			this.textBoxEmpNum.Location = new System.Drawing.Point(189, 85);
			this.textBoxEmpNum.Name = "textBoxEmpNum";
			this.textBoxEmpNum.Size = new System.Drawing.Size(100, 21);
			this.textBoxEmpNum.TabIndex = 0;
			// 
			// employeeUpdateTab
			// 
			this.employeeUpdateTab.Controls.Add(this.label13);
			this.employeeUpdateTab.Controls.Add(this.buttonEmpSearch);
			this.employeeUpdateTab.Controls.Add(this.textBoxSearchEmp);
			this.employeeUpdateTab.Controls.Add(this.button1);
			this.employeeUpdateTab.Controls.Add(this.button2);
			this.employeeUpdateTab.Controls.Add(this.label7);
			this.employeeUpdateTab.Controls.Add(this.label8);
			this.employeeUpdateTab.Controls.Add(this.comboBox1);
			this.employeeUpdateTab.Controls.Add(this.comboBox2);
			this.employeeUpdateTab.Controls.Add(this.label9);
			this.employeeUpdateTab.Controls.Add(this.label10);
			this.employeeUpdateTab.Controls.Add(this.label11);
			this.employeeUpdateTab.Controls.Add(this.label12);
			this.employeeUpdateTab.Controls.Add(this.textBox1);
			this.employeeUpdateTab.Controls.Add(this.textBox2);
			this.employeeUpdateTab.Controls.Add(this.textBox3);
			this.employeeUpdateTab.Controls.Add(this.textBox4);
			this.employeeUpdateTab.Location = new System.Drawing.Point(4, 22);
			this.employeeUpdateTab.Name = "employeeUpdateTab";
			this.employeeUpdateTab.Padding = new System.Windows.Forms.Padding(3);
			this.employeeUpdateTab.Size = new System.Drawing.Size(787, 402);
			this.employeeUpdateTab.TabIndex = 1;
			this.employeeUpdateTab.Text = "수정";
			this.employeeUpdateTab.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(87, 40);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 12);
			this.label13.TabIndex = 30;
			this.label13.Text = "사원검색";
			// 
			// buttonEmpSearch
			// 
			this.buttonEmpSearch.Location = new System.Drawing.Point(263, 35);
			this.buttonEmpSearch.Name = "buttonEmpSearch";
			this.buttonEmpSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonEmpSearch.TabIndex = 29;
			this.buttonEmpSearch.Text = "사원검색";
			this.buttonEmpSearch.UseVisualStyleBackColor = true;
			// 
			// textBoxSearchEmp
			// 
			this.textBoxSearchEmp.Location = new System.Drawing.Point(157, 35);
			this.textBoxSearchEmp.Name = "textBoxSearchEmp";
			this.textBoxSearchEmp.Size = new System.Drawing.Size(100, 21);
			this.textBoxSearchEmp.TabIndex = 28;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(327, 222);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 27;
			this.button1.Text = "주소찾기";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(374, 298);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 26;
			this.button2.Text = "수정";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(452, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 25;
			this.label7.Text = "직급";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(452, 86);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 24;
			this.label8.Text = "부서";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(510, 130);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 23;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(510, 83);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(155, 132);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 12);
			this.label9.TabIndex = 21;
			this.label9.Text = "이름";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(155, 179);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 12);
			this.label10.TabIndex = 20;
			this.label10.Text = "나이";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(155, 225);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 19;
			this.label11.Text = "주소";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(155, 85);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 12);
			this.label12.TabIndex = 18;
			this.label12.Text = "사원번호";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(221, 176);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 17;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(221, 222);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 21);
			this.textBox2.TabIndex = 16;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(221, 129);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 21);
			this.textBox3.TabIndex = 15;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(221, 82);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 21);
			this.textBox4.TabIndex = 14;
			// 
			// employeeDeleteTab
			// 
			this.employeeDeleteTab.Controls.Add(this.buttonEmpDelete);
			this.employeeDeleteTab.Controls.Add(this.dataGridViewEmpList);
			this.employeeDeleteTab.Location = new System.Drawing.Point(4, 22);
			this.employeeDeleteTab.Name = "employeeDeleteTab";
			this.employeeDeleteTab.Size = new System.Drawing.Size(787, 402);
			this.employeeDeleteTab.TabIndex = 2;
			this.employeeDeleteTab.Text = "삭제";
			this.employeeDeleteTab.UseVisualStyleBackColor = true;
			// 
			// buttonEmpDelete
			// 
			this.buttonEmpDelete.Location = new System.Drawing.Point(356, 315);
			this.buttonEmpDelete.Name = "buttonEmpDelete";
			this.buttonEmpDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonEmpDelete.TabIndex = 1;
			this.buttonEmpDelete.Text = "삭제";
			this.buttonEmpDelete.UseVisualStyleBackColor = true;
			// 
			// dataGridViewEmpList
			// 
			this.dataGridViewEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmpList.Location = new System.Drawing.Point(39, 20);
			this.dataGridViewEmpList.Name = "dataGridViewEmpList";
			this.dataGridViewEmpList.RowTemplate.Height = 23;
			this.dataGridViewEmpList.Size = new System.Drawing.Size(700, 267);
			this.dataGridViewEmpList.TabIndex = 0;
			// 
			// employeeSearchTab
			// 
			this.employeeSearchTab.Controls.Add(this.button3);
			this.employeeSearchTab.Controls.Add(this.textBox5);
			this.employeeSearchTab.Controls.Add(this.comboBox3);
			this.employeeSearchTab.Controls.Add(this.dataGridView1);
			this.employeeSearchTab.Location = new System.Drawing.Point(4, 22);
			this.employeeSearchTab.Name = "employeeSearchTab";
			this.employeeSearchTab.Size = new System.Drawing.Size(787, 402);
			this.employeeSearchTab.TabIndex = 3;
			this.employeeSearchTab.Text = "검색";
			this.employeeSearchTab.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(642, 71);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(66, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "검색";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(525, 70);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 21);
			this.textBox5.TabIndex = 2;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(429, 71);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(90, 20);
			this.comboBox3.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(55, 108);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(653, 238);
			this.dataGridView1.TabIndex = 0;
			// 
			// workTab
			// 
			this.workTab.Controls.Add(this.tabControl3);
			this.workTab.Location = new System.Drawing.Point(4, 22);
			this.workTab.Name = "workTab";
			this.workTab.Padding = new System.Windows.Forms.Padding(3);
			this.workTab.Size = new System.Drawing.Size(787, 424);
			this.workTab.TabIndex = 1;
			this.workTab.Text = "업무";
			this.workTab.UseVisualStyleBackColor = true;
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.Add(this.tabPage_master);
			this.tabControl3.Location = new System.Drawing.Point(-4, 0);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(795, 428);
			this.tabControl3.TabIndex = 0;
			// 
			// tabPage_master
			// 
			this.tabPage_master.Controls.Add(this.button_Refresh);
			this.tabPage_master.Controls.Add(this.groupBox4);
			this.tabPage_master.Controls.Add(this.button_del);
			this.tabPage_master.Location = new System.Drawing.Point(4, 22);
			this.tabPage_master.Name = "tabPage_master";
			this.tabPage_master.Size = new System.Drawing.Size(787, 402);
			this.tabPage_master.TabIndex = 2;
			this.tabPage_master.Text = "수정";
			this.tabPage_master.UseVisualStyleBackColor = true;
			// 
			// button_Refresh
			// 
			this.button_Refresh.Location = new System.Drawing.Point(705, 3);
			this.button_Refresh.Name = "button_Refresh";
			this.button_Refresh.Size = new System.Drawing.Size(75, 23);
			this.button_Refresh.TabIndex = 7;
			this.button_Refresh.Text = "새로고침";
			this.button_Refresh.UseVisualStyleBackColor = true;
			this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button_revise);
			this.groupBox4.Controls.Add(this.button_plus);
			this.groupBox4.Controls.Add(this.dataGridView_master);
			this.groupBox4.Location = new System.Drawing.Point(40, 30);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(670, 338);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "업무 마스터";
			// 
			// button_revise
			// 
			this.button_revise.BackColor = System.Drawing.Color.White;
			this.button_revise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_revise.Image = ((System.Drawing.Image)(resources.GetObject("button_revise.Image")));
			this.button_revise.Location = new System.Drawing.Point(582, 20);
			this.button_revise.Name = "button_revise";
			this.button_revise.Size = new System.Drawing.Size(38, 26);
			this.button_revise.TabIndex = 4;
			this.button_revise.UseVisualStyleBackColor = false;
			this.button_revise.Click += new System.EventHandler(this.button_revise_Click);
			// 
			// button_plus
			// 
			this.button_plus.BackColor = System.Drawing.Color.White;
			this.button_plus.Image = ((System.Drawing.Image)(resources.GetObject("button_plus.Image")));
			this.button_plus.Location = new System.Drawing.Point(626, 20);
			this.button_plus.Name = "button_plus";
			this.button_plus.Size = new System.Drawing.Size(38, 26);
			this.button_plus.TabIndex = 3;
			this.button_plus.UseVisualStyleBackColor = false;
			this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
			// 
			// button_del
			// 
			this.button_del.BackColor = System.Drawing.Color.White;
			this.button_del.Image = ((System.Drawing.Image)(resources.GetObject("button_del.Image")));
			this.button_del.Location = new System.Drawing.Point(731, 82);
			this.button_del.Name = "button_del";
			this.button_del.Size = new System.Drawing.Size(38, 26);
			this.button_del.TabIndex = 2;
			this.button_del.UseVisualStyleBackColor = false;
			this.button_del.Visible = false;
			this.button_del.Click += new System.EventHandler(this.button_del_Click);
			// 
			// dataGridView_master
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.dataGridView_master.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_master.Location = new System.Drawing.Point(6, 52);
			this.dataGridView_master.MultiSelect = false;
			this.dataGridView_master.Name = "dataGridView_master";
			this.dataGridView_master.RowTemplate.Height = 23;
			this.dataGridView_master.Size = new System.Drawing.Size(658, 284);
			this.dataGridView_master.TabIndex = 0;
			this.dataGridView_master.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_master_UserDeletedRow);
			this.dataGridView_master.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView_master_UserDeletingRow);
			// 
			// divsionTab
			// 
			this.divsionTab.Controls.Add(this.tabControl4);
			this.divsionTab.Location = new System.Drawing.Point(4, 22);
			this.divsionTab.Name = "divsionTab";
			this.divsionTab.Size = new System.Drawing.Size(787, 424);
			this.divsionTab.TabIndex = 2;
			this.divsionTab.Text = "부서";
			this.divsionTab.UseVisualStyleBackColor = true;
			// 
			// tabControl4
			// 
			this.tabControl4.Controls.Add(this.tabPage4);
			this.tabControl4.Controls.Add(this.tabPage5);
			this.tabControl4.Controls.Add(this.tabPage6);
			this.tabControl4.Location = new System.Drawing.Point(-4, 0);
			this.tabControl4.Name = "tabControl4";
			this.tabControl4.SelectedIndex = 0;
			this.tabControl4.Size = new System.Drawing.Size(795, 428);
			this.tabControl4.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button7);
			this.tabPage4.Controls.Add(this.textBox9);
			this.tabPage4.Controls.Add(this.dataGridView6);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(787, 402);
			this.tabPage4.TabIndex = 0;
			this.tabPage4.Text = "등록";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(425, 299);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 2;
			this.button7.Text = "등록";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(257, 299);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(123, 21);
			this.textBox9.TabIndex = 1;
			// 
			// dataGridView6
			// 
			this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView6.Location = new System.Drawing.Point(149, 69);
			this.dataGridView6.Name = "dataGridView6";
			this.dataGridView6.RowTemplate.Height = 23;
			this.dataGridView6.Size = new System.Drawing.Size(455, 190);
			this.dataGridView6.TabIndex = 0;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.button8);
			this.tabPage5.Controls.Add(this.textBox10);
			this.tabPage5.Controls.Add(this.dataGridView7);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(787, 402);
			this.tabPage5.TabIndex = 1;
			this.tabPage5.Text = "수정";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(442, 305);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 5;
			this.button8.Text = "수정";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(274, 305);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(123, 21);
			this.textBox10.TabIndex = 4;
			// 
			// dataGridView7
			// 
			this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView7.Location = new System.Drawing.Point(166, 75);
			this.dataGridView7.Name = "dataGridView7";
			this.dataGridView7.RowTemplate.Height = 23;
			this.dataGridView7.Size = new System.Drawing.Size(455, 190);
			this.dataGridView7.TabIndex = 3;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.button9);
			this.tabPage6.Controls.Add(this.textBox11);
			this.tabPage6.Controls.Add(this.dataGridView8);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(787, 402);
			this.tabPage6.TabIndex = 2;
			this.tabPage6.Text = "삭제";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(442, 305);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 5;
			this.button9.Text = "삭제";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(274, 305);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(123, 21);
			this.textBox11.TabIndex = 4;
			// 
			// dataGridView8
			// 
			this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView8.Location = new System.Drawing.Point(166, 75);
			this.dataGridView8.Name = "dataGridView8";
			this.dataGridView8.RowTemplate.Height = 23;
			this.dataGridView8.Size = new System.Drawing.Size(455, 190);
			this.dataGridView8.TabIndex = 3;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form2";
			this.Text = "ERP";
			this.tabControl1.ResumeLayout(false);
			this.employeeTab.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.employeeInsertTab.ResumeLayout(false);
			this.employeeInsertTab.PerformLayout();
			this.employeeUpdateTab.ResumeLayout(false);
			this.employeeUpdateTab.PerformLayout();
			this.employeeDeleteTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpList)).EndInit();
			this.employeeSearchTab.ResumeLayout(false);
			this.employeeSearchTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.workTab.ResumeLayout(false);
			this.tabControl3.ResumeLayout(false);
			this.tabPage_master.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_master)).EndInit();
			this.divsionTab.ResumeLayout(false);
			this.tabControl4.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage employeeInsertTab;
        private System.Windows.Forms.Button buttonAdrSearch;
        private System.Windows.Forms.Button buttonEmpEnroll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEmpClass;
        private System.Windows.Forms.ComboBox comboBoxEmpDivision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmpAge;
        private System.Windows.Forms.TextBox textBoxEmpAddress;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.TextBox textBoxEmpNum;
        private System.Windows.Forms.TabPage employeeUpdateTab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonEmpSearch;
        private System.Windows.Forms.TextBox textBoxSearchEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage employeeDeleteTab;
        private System.Windows.Forms.TabPage employeeSearchTab;
        private System.Windows.Forms.TabPage workTab;
        private System.Windows.Forms.TabPage divsionTab;
        private System.Windows.Forms.Button buttonEmpDelete;
        private System.Windows.Forms.DataGridView dataGridViewEmpList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.DataGridView dataGridView8;
		private System.Windows.Forms.TabControl tabControl3;
		private System.Windows.Forms.TabPage tabPage_master;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button_revise;
		private System.Windows.Forms.Button button_plus;
		private System.Windows.Forms.Button button_del;
		private System.Windows.Forms.DataGridView dataGridView_master;
		private System.Windows.Forms.Button button_Refresh;
	}
}