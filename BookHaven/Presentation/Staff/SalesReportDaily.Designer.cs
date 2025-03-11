namespace BookHaven.Presentation.Staff
{
    partial class SalesReportDaily
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
            dgvDailySales = new DataGridView();
            btnExport = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 20);
            label1.Name = "label1";
            label1.Size = new Size(265, 40);
            label1.TabIndex = 0;
            label1.Text = "Daily Sales Report";
            // 
            // dgvDailySales
            // 
            dgvDailySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDailySales.Location = new Point(91, 77);
            dgvDailySales.Name = "dgvDailySales";
            dgvDailySales.Size = new Size(838, 497);
            dgvDailySales.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(809, 617);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(109, 35);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export To Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(327, 633);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // SalesReportDaily
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(dgvDailySales);
            Controls.Add(label1);
            Name = "SalesReportDaily";
            Text = "SalesReportDaily";
            Load += SalesReportDaily_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDailySales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDailySales;
        private Button btnExport;
        private Button btnBack;
    }
}