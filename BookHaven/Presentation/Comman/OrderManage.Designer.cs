namespace BookHaven.Presentation.Comman
{
    partial class OrderManage
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
            label2 = new Label();
            cmbsearchorder = new ComboBox();
            btnaddneworder = new Button();
            btnaddnewcustomer = new Button();
            dtgorder = new DataGridView();
            btndelete = new Button();
            btnupdate = new Button();
            cmborderstatus = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgorder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 18);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Manage Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Order Id Search";
            // 
            // cmbsearchorder
            // 
            cmbsearchorder.FormattingEnabled = true;
            cmbsearchorder.Location = new Point(116, 97);
            cmbsearchorder.Name = "cmbsearchorder";
            cmbsearchorder.Size = new Size(205, 23);
            cmbsearchorder.TabIndex = 2;
            cmbsearchorder.SelectedIndexChanged += cmbsearchorder_SelectedIndexChanged;
            // 
            // btnaddneworder
            // 
            btnaddneworder.Location = new Point(524, 93);
            btnaddneworder.Name = "btnaddneworder";
            btnaddneworder.Size = new Size(133, 28);
            btnaddneworder.TabIndex = 3;
            btnaddneworder.Text = "Add New Order";
            btnaddneworder.UseVisualStyleBackColor = true;
            // 
            // btnaddnewcustomer
            // 
            btnaddnewcustomer.Location = new Point(847, 97);
            btnaddnewcustomer.Name = "btnaddnewcustomer";
            btnaddnewcustomer.Size = new Size(126, 28);
            btnaddnewcustomer.TabIndex = 4;
            btnaddnewcustomer.Text = "Add New Customer";
            btnaddnewcustomer.UseVisualStyleBackColor = true;
            // 
            // dtgorder
            // 
            dtgorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgorder.Location = new Point(12, 169);
            dtgorder.Name = "dtgorder";
            dtgorder.Size = new Size(984, 219);
            dtgorder.TabIndex = 5;
            dtgorder.CellContentClick += dtgorder_CellContentClick;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(582, 540);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(339, 540);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 23);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // cmborderstatus
            // 
            cmborderstatus.FormattingEnabled = true;
            cmborderstatus.Items.AddRange(new object[] { "Pending", "Completed", "Canceled" });
            cmborderstatus.Location = new Point(116, 421);
            cmborderstatus.Name = "cmborderstatus";
            cmborderstatus.Size = new Size(205, 23);
            cmborderstatus.TabIndex = 8;
            cmborderstatus.SelectedIndexChanged += cmborderstatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 424);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 9;
            label3.Text = "Order Status";
            // 
            // OrderManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label3);
            Controls.Add(cmborderstatus);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(dtgorder);
            Controls.Add(btnaddnewcustomer);
            Controls.Add(btnaddneworder);
            Controls.Add(cmbsearchorder);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "OrderManage";
            Text = "OrderManage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbsearchorder;
        private Button btnaddneworder;
        private Button btnaddnewcustomer;
        private DataGridView dtgorder;
        private Button btndelete;
        private Button btnupdate;
        private ComboBox cmborderstatus;
        private Label label3;
    }
}