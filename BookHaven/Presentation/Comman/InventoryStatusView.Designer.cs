namespace BookHaven.Presentation.Comman
{
    partial class InventoryStatusView
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
            label1 = new Label();
            btnGenarate = new Button();
            dataGridView1 = new DataGridView();
            btnexport = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 40);
            label1.TabIndex = 0;
            label1.Text = "Inventory Status";
            // 
            // btnGenarate
            // 
            btnGenarate.Location = new Point(805, 70);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(75, 23);
            btnGenarate.TabIndex = 1;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = true;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(822, 471);
            dataGridView1.TabIndex = 2;
            // 
            // btnexport
            // 
            btnexport.Location = new Point(769, 621);
            btnexport.Name = "btnexport";
            btnexport.Size = new Size(111, 37);
            btnexport.TabIndex = 3;
            btnexport.Text = "Export To Excel";
            btnexport.UseVisualStyleBackColor = true;
            btnexport.Click += btnexport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(296, 598);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // InventoryStatusView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnBack);
            Controls.Add(btnexport);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenarate);
            Controls.Add(label1);
            Name = "InventoryStatusView";
            Text = "InventoryStatusView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenarate;
        private DataGridView dataGridView1;
        private Button btnexport;
        private Button btnBack;
    }
}