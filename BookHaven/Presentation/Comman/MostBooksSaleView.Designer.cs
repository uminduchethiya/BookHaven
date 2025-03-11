namespace BookHaven.Presentation.Comman
{
    partial class MostBooksSaleView
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
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 40);
            label1.TabIndex = 0;
            label1.Text = "Most Sale Books";
            // 
            // btnGenarate
            // 
            btnGenarate.Location = new Point(832, 63);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(100, 47);
            btnGenarate.TabIndex = 1;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = true;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(861, 475);
            dataGridView1.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(818, 632);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(114, 33);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export To Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // MostBooksSaleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnExport);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenarate);
            Controls.Add(label1);
            Name = "MostBooksSaleView";
            Text = "MostBooksSaleView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenarate;
        private DataGridView dataGridView1;
        private Button btnExport;
    }
}