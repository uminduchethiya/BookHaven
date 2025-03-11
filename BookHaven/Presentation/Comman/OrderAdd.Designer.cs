namespace BookHaven.Presentation.Comman
{
    partial class OrderAdd
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
            panel1 = new Panel();
            lblname = new Label();
            label1 = new Label();
            cmbsearchphone = new ComboBox();
            cmbsearchbook = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            dtgcustomerdeatils = new DataGridView();
            dtgsearchbook = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtbookqunity = new TextBox();
            txtbookprice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblsubtotal = new Label();
            chkdiliverydetails = new CheckedListBox();
            txtaddress = new TextBox();
            label7 = new Label();
            btnorder = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcustomerdeatils).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgsearchbook).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblname);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 78);
            panel1.TabIndex = 0;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(426, 38);
            lblname.Name = "lblname";
            lblname.Size = new Size(62, 15);
            lblname.TabIndex = 0;
            lblname.Text = "Add Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Customer Phone";
            // 
            // cmbsearchphone
            // 
            cmbsearchphone.FormattingEnabled = true;
            cmbsearchphone.Location = new Point(168, 97);
            cmbsearchphone.Name = "cmbsearchphone";
            cmbsearchphone.Size = new Size(184, 23);
            cmbsearchphone.TabIndex = 2;
            cmbsearchphone.SelectedIndexChanged += cmbsearchphone_SelectedIndexChanged;
            // 
            // cmbsearchbook
            // 
            cmbsearchbook.FormattingEnabled = true;
            cmbsearchbook.Location = new Point(611, 100);
            cmbsearchbook.Name = "cmbsearchbook";
            cmbsearchbook.Size = new Size(192, 23);
            cmbsearchbook.TabIndex = 3;
            cmbsearchbook.SelectedIndexChanged += cmbsearchbook_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 103);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Search Book";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(834, 96);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 5;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtgcustomerdeatils
            // 
            dtgcustomerdeatils.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcustomerdeatils.Location = new Point(12, 141);
            dtgcustomerdeatils.Name = "dtgcustomerdeatils";
            dtgcustomerdeatils.Size = new Size(476, 102);
            dtgcustomerdeatils.TabIndex = 6;
            dtgcustomerdeatils.CellContentClick += dtgcustomerdeatils_CellContentClick;
            // 
            // dtgsearchbook
            // 
            dtgsearchbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsearchbook.Location = new Point(514, 138);
            dtgsearchbook.Name = "dtgsearchbook";
            dtgsearchbook.Size = new Size(484, 105);
            dtgsearchbook.TabIndex = 7;
            dtgsearchbook.CellContentClick += dtgsearchbook_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(455, 274);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Order Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 382);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 9;
            label4.Text = "Book Quntity";
            // 
            // txtbookqunity
            // 
            txtbookqunity.Location = new Point(110, 381);
            txtbookqunity.Name = "txtbookqunity";
            txtbookqunity.Size = new Size(242, 23);
            txtbookqunity.TabIndex = 10;
            txtbookqunity.TextChanged += txtbookqunity_TextChanged;
            // 
            // txtbookprice
            // 
            txtbookprice.Location = new Point(468, 382);
            txtbookprice.Name = "txtbookprice";
            txtbookprice.Size = new Size(242, 23);
            txtbookprice.TabIndex = 12;
            txtbookprice.TextChanged += txtbookprice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 383);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 11;
            label5.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(752, 385);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Sub Total";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(851, 385);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(25, 15);
            lblsubtotal.TabIndex = 14;
            lblsubtotal.Text = "123";
            // 
            // chkdiliverydetails
            // 
            chkdiliverydetails.FormattingEnabled = true;
            chkdiliverydetails.Items.AddRange(new object[] { "PickUp", "Dilivery" });
            chkdiliverydetails.Location = new Point(55, 497);
            chkdiliverydetails.Name = "chkdiliverydetails";
            chkdiliverydetails.Size = new Size(120, 40);
            chkdiliverydetails.TabIndex = 15;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(703, 514);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(242, 23);
            txtaddress.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(616, 515);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 16;
            label7.Text = "Address";
            // 
            // btnorder
            // 
            btnorder.Location = new Point(456, 628);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(75, 23);
            btnorder.TabIndex = 18;
            btnorder.Text = "Order";
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnorder_Click;
            // 
            // OrderAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnorder);
            Controls.Add(txtaddress);
            Controls.Add(label7);
            Controls.Add(chkdiliverydetails);
            Controls.Add(lblsubtotal);
            Controls.Add(label6);
            Controls.Add(txtbookprice);
            Controls.Add(label5);
            Controls.Add(txtbookqunity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtgsearchbook);
            Controls.Add(dtgcustomerdeatils);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cmbsearchbook);
            Controls.Add(cmbsearchphone);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "OrderAdd";
            Text = "OrderAdd";
            Load += OrderAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcustomerdeatils).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgsearchbook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblname;
        private Label label1;
        private ComboBox cmbsearchphone;
        private ComboBox cmbsearchbook;
        private Label label2;
        private Button button1;
        private DataGridView dtgcustomerdeatils;
        private DataGridView dtgsearchbook;
        private Label label3;
        private Label label4;
        private TextBox txtbookqunity;
        private TextBox txtbookprice;
        private Label label5;
        private Label label6;
        private Label lblsubtotal;
        private CheckedListBox chkdiliverydetails;
        private TextBox txtaddress;
        private Label label7;
        private Button btnorder;
    }
}