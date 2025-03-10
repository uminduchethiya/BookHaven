namespace BookHaven.Presentation.Admin
{
    partial class UserManagement
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
            datagridviewuser = new DataGridView();
            button1 = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            button4 = new Button();
            label2 = new Label();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            label3 = new Label();
            txtphone = new TextBox();
            label4 = new Label();
            txtidnum = new TextBox();
            label5 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cmbgender = new ComboBox();
            label8 = new Label();
            dobpicker = new DateTimePicker();
            backpic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridviewuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backpic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(backpic);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 87);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 27);
            label1.Name = "label1";
            label1.Size = new Size(219, 29);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // datagridviewuser
            // 
            datagridviewuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewuser.Location = new Point(387, 161);
            datagridviewuser.Name = "datagridviewuser";
            datagridviewuser.Size = new Size(609, 443);
            datagridviewuser.TabIndex = 1;
            datagridviewuser.CellContentClick += datagridviewuser_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(881, 111);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 2;
            button1.Text = "Add New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(881, 645);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(115, 44);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(634, 645);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(115, 44);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // button4
            // 
            button4.Location = new Point(387, 645);
            button4.Name = "button4";
            button4.Size = new Size(115, 44);
            button4.TabIndex = 5;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(12, 147);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(284, 23);
            txtfirstname.TabIndex = 7;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(12, 222);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(284, 23);
            txtlastname.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(78, 16);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(12, 302);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(284, 23);
            txtphone.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 267);
            label4.Name = "label4";
            label4.Size = new Size(106, 16);
            label4.TabIndex = 10;
            label4.Text = "Phone Number:";
            // 
            // txtidnum
            // 
            txtidnum.Location = new Point(12, 377);
            txtidnum.Name = "txtidnum";
            txtidnum.Size = new Size(284, 23);
            txtidnum.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 342);
            label5.Name = "label5";
            label5.Size = new Size(112, 16);
            label5.TabIndex = 12;
            label5.Text = "Identity Number:";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(12, 454);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(284, 23);
            txtaddress.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 419);
            label6.Name = "label6";
            label6.Size = new Size(61, 16);
            label6.TabIndex = 14;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 493);
            label7.Name = "label7";
            label7.Size = new Size(58, 16);
            label7.TabIndex = 16;
            label7.Text = "Gender:";
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Items.AddRange(new object[] { "Male", "Female" });
            cmbgender.Location = new Point(12, 523);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(284, 23);
            cmbgender.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 568);
            label8.Name = "label8";
            label8.Size = new Size(39, 16);
            label8.TabIndex = 18;
            label8.Text = "DOB:";
            // 
            // dobpicker
            // 
            dobpicker.Location = new Point(12, 596);
            dobpicker.Name = "dobpicker";
            dobpicker.Size = new Size(284, 23);
            dobpicker.TabIndex = 19;
            // 
            // backpic
            // 
            backpic.Image = Properties.Resources.left_arrow_10117838;
            backpic.Location = new Point(11, 23);
            backpic.Name = "backpic";
            backpic.Size = new Size(72, 33);
            backpic.SizeMode = PictureBoxSizeMode.Zoom;
            backpic.TabIndex = 1;
            backpic.TabStop = false;
            backpic.Click += backpic_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(dobpicker);
            Controls.Add(label8);
            Controls.Add(cmbgender);
            Controls.Add(label7);
            Controls.Add(txtaddress);
            Controls.Add(label6);
            Controls.Add(txtidnum);
            Controls.Add(label5);
            Controls.Add(txtphone);
            Controls.Add(label4);
            Controls.Add(txtlastname);
            Controls.Add(label3);
            Controls.Add(txtfirstname);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(button1);
            Controls.Add(datagridviewuser);
            Controls.Add(panel1);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridviewuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)backpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView datagridviewuser;
        private Button button1;
        private Button btndelete;
        private Button btnupdate;
        private Button button4;
        private Label label2;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private Label label3;
        private TextBox txtphone;
        private Label label4;
        private TextBox txtidnum;
        private Label label5;
        private TextBox txtaddress;
        private Label label6;
        private Label label7;
        private ComboBox cmbgender;
        private Label label8;
        private DateTimePicker dobpicker;
        private PictureBox backpic;
    }
}