namespace Search_Algorithm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            dgvResults = new DataGridView();
            productName = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            productCode = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(42, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(498, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += btnSearch_Click;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToResizeColumns = false;
            dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { productName, productPrice, productCode });
            dgvResults.Location = new Point(24, 77);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.RowTemplate.Height = 29;
            dgvResults.Size = new Size(575, 330);
            dgvResults.TabIndex = 2;
            // 
            // productName
            // 
            productName.HeaderText = "name";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.Width = 300;
            // 
            // productPrice
            // 
            productPrice.HeaderText = "price";
            productPrice.MinimumWidth = 6;
            productPrice.Name = "productPrice";
            productPrice.Width = 125;
            // 
            // productCode
            // 
            productCode.HeaderText = "code";
            productCode.MinimumWidth = 6;
            productCode.Name = "productCode";
            productCode.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResults);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Search Optimized";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn productCode;
    }
}