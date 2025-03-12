namespace BookHaven.Presentation.Admin
{
    partial class SupplierOrderForm
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
            cmbsupplier = new ComboBox();
            dtgsupplierorder = new DataGridView();
            btnplaceorder = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtnewstock = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplierorder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 34);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Supplier Order Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Search Supplier";
            // 
            // cmbsupplier
            // 
            cmbsupplier.FormattingEnabled = true;
            cmbsupplier.Location = new Point(394, 106);
            cmbsupplier.Name = "cmbsupplier";
            cmbsupplier.Size = new Size(348, 23);
            cmbsupplier.TabIndex = 2;
            cmbsupplier.SelectedIndexChanged += cmbsupplier_SelectedIndexChanged;
            // 
            // dtgsupplierorder
            // 
            dtgsupplierorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsupplierorder.Location = new Point(278, 167);
            dtgsupplierorder.Name = "dtgsupplierorder";
            dtgsupplierorder.Size = new Size(526, 210);
            dtgsupplierorder.TabIndex = 3;
            dtgsupplierorder.CellContentClick += dtgsupplierorder_CellContentClick;
            // 
            // btnplaceorder
            // 
            btnplaceorder.Location = new Point(468, 532);
            btnplaceorder.Name = "btnplaceorder";
            btnplaceorder.Size = new Size(113, 45);
            btnplaceorder.TabIndex = 4;
            btnplaceorder.Text = "Place Order";
            btnplaceorder.UseVisualStyleBackColor = true;
            btnplaceorder.Click += btnplaceorder_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "Approved", "Delivered", "Cancelled" });
            comboBox1.Location = new Point(162, 439);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 441);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Order Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(637, 449);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "New Stock";
            // 
            // txtnewstock
            // 
            txtnewstock.Location = new Point(749, 445);
            txtnewstock.Name = "txtnewstock";
            txtnewstock.Size = new Size(197, 23);
            txtnewstock.TabIndex = 8;
            // 
            // SupplierOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 689);
            Controls.Add(txtnewstock);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(btnplaceorder);
            Controls.Add(dtgsupplierorder);
            Controls.Add(cmbsupplier);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "SupplierOrderForm";
            Text = "SupplierOrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsupplierorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbsupplier;
        private DataGridView dtgsupplierorder;
        private Button btnplaceorder;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox txtnewstock;
    }
}