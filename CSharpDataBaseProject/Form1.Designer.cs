namespace CSharpDataBaseProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrders = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbBookid = new System.Windows.Forms.TextBox();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbCustid = new System.Windows.Forms.TextBox();
            this.tbCustname = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.tbSaleprice = new System.Windows.Forms.TextBox();
            this.mtbOrderdate = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.tbOCustid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbOBookid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTextboxClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gbBook.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(454, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "테이블 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrders);
            this.groupBox1.Controls.Add(this.rbCustomer);
            this.groupBox1.Controls.Add(this.rbBook);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans CJK KR Medium", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(458, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table";
            // 
            // rbOrders
            // 
            this.rbOrders.AutoSize = true;
            this.rbOrders.Font = new System.Drawing.Font("Noto Sans CJK KR Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbOrders.Location = new System.Drawing.Point(16, 81);
            this.rbOrders.Name = "rbOrders";
            this.rbOrders.Size = new System.Drawing.Size(93, 32);
            this.rbOrders.TabIndex = 2;
            this.rbOrders.TabStop = true;
            this.rbOrders.Text = "Orders";
            this.rbOrders.UseVisualStyleBackColor = true;
            this.rbOrders.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Font = new System.Drawing.Font("Noto Sans CJK KR Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbCustomer.Location = new System.Drawing.Point(16, 51);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(120, 32);
            this.rbCustomer.TabIndex = 1;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Font = new System.Drawing.Font("Noto Sans CJK KR Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbBook.Location = new System.Drawing.Point(16, 20);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(78, 32);
            this.rbBook.TabIndex = 0;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F);
            this.tbPrice.Location = new System.Drawing.Point(114, 134);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(312, 31);
            this.tbPrice.TabIndex = 15;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBookName
            // 
            this.tbBookName.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F);
            this.tbBookName.Location = new System.Drawing.Point(114, 62);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(312, 31);
            this.tbBookName.TabIndex = 13;
            this.tbBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBookid
            // 
            this.tbBookid.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F);
            this.tbBookid.Location = new System.Drawing.Point(114, 25);
            this.tbBookid.Name = "tbBookid";
            this.tbBookid.Size = new System.Drawing.Size(312, 31);
            this.tbBookid.TabIndex = 10;
            this.tbBookid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.label2);
            this.gbBook.Controls.Add(this.label3);
            this.gbBook.Controls.Add(this.label4);
            this.gbBook.Controls.Add(this.label5);
            this.gbBook.Controls.Add(this.tbBookid);
            this.gbBook.Controls.Add(this.tbBookName);
            this.gbBook.Controls.Add(this.cbPublisher);
            this.gbBook.Controls.Add(this.tbPrice);
            this.gbBook.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBook.Location = new System.Drawing.Point(12, 12);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(432, 179);
            this.gbBook.TabIndex = 17;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Book";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "BookID :  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(2, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Publisher :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(2, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(2, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.mtbPhone);
            this.gbCustomer.Controls.Add(this.tbCustid);
            this.gbCustomer.Controls.Add(this.tbCustname);
            this.gbCustomer.Controls.Add(this.tbAddress);
            this.gbCustomer.Controls.Add(this.label7);
            this.gbCustomer.Controls.Add(this.label8);
            this.gbCustomer.Controls.Add(this.label9);
            this.gbCustomer.Controls.Add(this.label6);
            this.gbCustomer.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(432, 179);
            this.gbCustomer.TabIndex = 18;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            this.gbCustomer.Visible = false;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(105, 138);
            this.mtbPhone.Mask = "000-9000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(321, 31);
            this.mtbPhone.TabIndex = 16;
            // 
            // tbCustid
            // 
            this.tbCustid.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F);
            this.tbCustid.Location = new System.Drawing.Point(105, 30);
            this.tbCustid.Name = "tbCustid";
            this.tbCustid.Size = new System.Drawing.Size(321, 31);
            this.tbCustid.TabIndex = 10;
            this.tbCustid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCustname
            // 
            this.tbCustname.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F);
            this.tbCustname.Location = new System.Drawing.Point(105, 67);
            this.tbCustname.Name = "tbCustname";
            this.tbCustname.Size = new System.Drawing.Size(321, 31);
            this.tbCustname.TabIndex = 13;
            this.tbCustname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F);
            this.tbAddress.Location = new System.Drawing.Point(105, 103);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(321, 31);
            this.tbAddress.TabIndex = 15;
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(6, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 37);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phone :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 37);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "CustID :  ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.tbSaleprice);
            this.gbOrders.Controls.Add(this.mtbOrderdate);
            this.gbOrders.Controls.Add(this.label14);
            this.gbOrders.Controls.Add(this.tbOrderId);
            this.gbOrders.Controls.Add(this.tbOCustid);
            this.gbOrders.Controls.Add(this.label10);
            this.gbOrders.Controls.Add(this.tbOBookid);
            this.gbOrders.Controls.Add(this.label11);
            this.gbOrders.Controls.Add(this.label12);
            this.gbOrders.Controls.Add(this.label13);
            this.gbOrders.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbOrders.Location = new System.Drawing.Point(12, 12);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(432, 179);
            this.gbOrders.TabIndex = 19;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Orders";
            this.gbOrders.Visible = false;
            // 
            // tbSaleprice
            // 
            this.tbSaleprice.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSaleprice.Location = new System.Drawing.Point(106, 113);
            this.tbSaleprice.Name = "tbSaleprice";
            this.tbSaleprice.Size = new System.Drawing.Size(321, 27);
            this.tbSaleprice.TabIndex = 19;
            this.tbSaleprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbOrderdate
            // 
            this.mtbOrderdate.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mtbOrderdate.Location = new System.Drawing.Point(106, 142);
            this.mtbOrderdate.Mask = "0000-00-00";
            this.mtbOrderdate.Name = "mtbOrderdate";
            this.mtbOrderdate.Size = new System.Drawing.Size(321, 27);
            this.mtbOrderdate.TabIndex = 18;
            this.mtbOrderdate.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(8, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "Orderdate :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOrderId
            // 
            this.tbOrderId.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOrderId.Location = new System.Drawing.Point(106, 24);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(321, 27);
            this.tbOrderId.TabIndex = 10;
            this.tbOrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOCustid
            // 
            this.tbOCustid.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOCustid.Location = new System.Drawing.Point(106, 54);
            this.tbOCustid.Name = "tbOCustid";
            this.tbOCustid.Size = new System.Drawing.Size(321, 27);
            this.tbOCustid.TabIndex = 13;
            this.tbOCustid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(7, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "OrderID : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOBookid
            // 
            this.tbOBookid.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOBookid.Location = new System.Drawing.Point(106, 84);
            this.tbOBookid.Name = "tbOBookid";
            this.tbOBookid.Size = new System.Drawing.Size(321, 27);
            this.tbOBookid.TabIndex = 15;
            this.tbOBookid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(8, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "BookID :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(8, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Saleprice :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(7, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "CustID :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(432, 378);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Noto Sans CJK KR Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(458, 273);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(166, 70);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Noto Sans CJK KR Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(458, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 70);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Noto Sans CJK KR Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(458, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 70);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTextboxClear
            // 
            this.btnTextboxClear.Font = new System.Drawing.Font("Noto Sans CJK KR Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTextboxClear.Location = new System.Drawing.Point(458, 505);
            this.btnTextboxClear.Name = "btnTextboxClear";
            this.btnTextboxClear.Size = new System.Drawing.Size(166, 70);
            this.btnTextboxClear.TabIndex = 25;
            this.btnTextboxClear.Text = "Textbox Clear";
            this.btnTextboxClear.UseVisualStyleBackColor = true;
            this.btnTextboxClear.Click += new System.EventHandler(this.btnTextboxClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Noto Sans CJK KR Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(458, 197);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(166, 70);
            this.btnSelect.TabIndex = 26;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbPublisher
            // 
            this.cbPublisher.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F);
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(114, 98);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(312, 32);
            this.cbPublisher.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 587);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnTextboxClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbOrders.ResumeLayout(false);
            this.gbOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOrders;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.TextBox tbBookid;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.TextBox tbCustid;
        private System.Windows.Forms.TextBox tbCustname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.TextBox tbSaleprice;
        private System.Windows.Forms.MaskedTextBox mtbOrderdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.TextBox tbOCustid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbOBookid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTextboxClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbPublisher;
    }
}

