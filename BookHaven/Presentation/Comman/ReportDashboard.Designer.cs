namespace BookHaven.Presentation.Comman
{
    partial class ReportDashboard
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
            btnSalesReport = new Button();
            btnBestBooksSelling = new Button();
            btnInventoryStatus = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(460, 40);
            label1.TabIndex = 0;
            label1.Text = "Report Management Dashboard";
            // 
            // btnSalesReport
            // 
            btnSalesReport.Location = new Point(399, 169);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(201, 100);
            btnSalesReport.TabIndex = 1;
            btnSalesReport.Text = "Sales Summery";
            btnSalesReport.UseVisualStyleBackColor = true;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnBestBooksSelling
            // 
            btnBestBooksSelling.Location = new Point(404, 314);
            btnBestBooksSelling.Name = "btnBestBooksSelling";
            btnBestBooksSelling.Size = new Size(201, 100);
            btnBestBooksSelling.TabIndex = 2;
            btnBestBooksSelling.Text = "Best Books Selling";
            btnBestBooksSelling.UseVisualStyleBackColor = true;
            btnBestBooksSelling.Click += btnBestBooksSelling_Click;
            // 
            // btnInventoryStatus
            // 
            btnInventoryStatus.Location = new Point(404, 474);
            btnInventoryStatus.Name = "btnInventoryStatus";
            btnInventoryStatus.Size = new Size(201, 100);
            btnInventoryStatus.TabIndex = 3;
            btnInventoryStatus.Text = "Inventory Status";
            btnInventoryStatus.UseVisualStyleBackColor = true;
            btnInventoryStatus.Click += btnInventoryStatus_Click;
            // 
            // ReportDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnInventoryStatus);
            Controls.Add(btnBestBooksSelling);
            Controls.Add(btnSalesReport);
            Controls.Add(label1);
            Name = "ReportDashboard";
            Text = "ReportDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalesReport;
        private Button btnBestBooksSelling;
        private Button btnInventoryStatus;
    }
}