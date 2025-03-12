namespace BookHaven.Presentation.Admin
{
    partial class AddSupplier
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
            label1 = new Label();
            dtgsupplier = new DataGridView();
            label2 = new Label();
            txtsuppliername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtsupplierphonenumber = new TextBox();
            label5 = new Label();
            txtsupplieremail = new TextBox();
            label6 = new Label();
            txtsupplieraddress = new TextBox();
            btnaddsupplier = new Button();
            btnupdatesupplier = new Button();
            btndelete = new Button();
            btnclear = new Button();
            cmbsupplier = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Manage Supplier";
            // 
            // dtgsupplier
            // 
            dtgsupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsupplier.Location = new Point(29, 156);
            dtgsupplier.Name = "dtgsupplier";
            dtgsupplier.Size = new Size(963, 227);
            dtgsupplier.TabIndex = 1;
            dtgsupplier.CellContentClick += dtgsupplier_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 402);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Add Supplier";
            // 
            // txtsuppliername
            // 
            txtsuppliername.Location = new Point(132, 480);
            txtsuppliername.Name = "txtsuppliername";
            txtsuppliername.Size = new Size(219, 23);
            txtsuppliername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 483);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Supplier Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(611, 486);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 6;
            label4.Text = "Supplier PhoneNumber";
            // 
            // txtsupplierphonenumber
            // 
            txtsupplierphonenumber.Location = new Point(773, 483);
            txtsupplierphonenumber.Name = "txtsupplierphonenumber";
            txtsupplierphonenumber.Size = new Size(219, 23);
            txtsupplierphonenumber.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 542);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 8;
            label5.Text = "Supplier Email";
            // 
            // txtsupplieremail
            // 
            txtsupplieremail.Location = new Point(132, 539);
            txtsupplieremail.Name = "txtsupplieremail";
            txtsupplieremail.Size = new Size(219, 23);
            txtsupplieremail.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 542);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 10;
            label6.Text = "Supplier Address";
            // 
            // txtsupplieraddress
            // 
            txtsupplieraddress.Location = new Point(773, 539);
            txtsupplieraddress.Name = "txtsupplieraddress";
            txtsupplieraddress.Size = new Size(219, 23);
            txtsupplieraddress.TabIndex = 9;
            // 
            // btnaddsupplier
            // 
            btnaddsupplier.Location = new Point(80, 654);
            btnaddsupplier.Name = "btnaddsupplier";
            btnaddsupplier.Size = new Size(128, 53);
            btnaddsupplier.TabIndex = 11;
            btnaddsupplier.Text = "Add Supplier";
            btnaddsupplier.UseVisualStyleBackColor = true;
            btnaddsupplier.Click += btnaddsupplier_Click;
            // 
            // btnupdatesupplier
            // 
            btnupdatesupplier.Location = new Point(355, 654);
            btnupdatesupplier.Name = "btnupdatesupplier";
            btnupdatesupplier.Size = new Size(116, 53);
            btnupdatesupplier.TabIndex = 12;
            btnupdatesupplier.Text = "Update Supplier";
            btnupdatesupplier.UseVisualStyleBackColor = true;
            btnupdatesupplier.Click += btnupdatesupplier_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(611, 654);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(113, 53);
            btndelete.TabIndex = 13;
            btndelete.Text = "Delete Supplier";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(880, 654);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(112, 53);
            btnclear.TabIndex = 14;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // cmbsupplier
            // 
            cmbsupplier.FormattingEnabled = true;
            cmbsupplier.Location = new Point(731, 106);
            cmbsupplier.Name = "cmbsupplier";
            cmbsupplier.Size = new Size(261, 23);
            cmbsupplier.TabIndex = 15;
            cmbsupplier.SelectedIndexChanged += cmbsupplier_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 109);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 16;
            label7.Text = "Search Supplier ";
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label7);
            Controls.Add(cmbsupplier);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdatesupplier);
            Controls.Add(btnaddsupplier);
            Controls.Add(label6);
            Controls.Add(txtsupplieraddress);
            Controls.Add(label5);
            Controls.Add(txtsupplieremail);
            Controls.Add(label4);
            Controls.Add(txtsupplierphonenumber);
            Controls.Add(label3);
            Controls.Add(txtsuppliername);
            Controls.Add(label2);
            Controls.Add(dtgsupplier);
            Controls.Add(panel1);
            Name = "AddSupplier";
            Text = "AddSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dtgsupplier;
        private Label label2;
        private TextBox txtsuppliername;
        private Label label3;
        private Label label4;
        private TextBox txtsupplierphonenumber;
        private Label label5;
        private TextBox txtsupplieremail;
        private Label label6;
        private TextBox txtsupplieraddress;
        private Button btnaddsupplier;
        private Button btnupdatesupplier;
        private Button btndelete;
        private Button btnclear;
        private ComboBox cmbsupplier;
        private Label label7;
    }
}