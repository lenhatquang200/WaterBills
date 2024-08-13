namespace WinFormsApp3
{
    partial class ManageInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            invoicesDataGridView = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)invoicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // invoicesDataGridView
            // 
            invoicesDataGridView.AllowUserToAddRows = false;
            invoicesDataGridView.ColumnHeadersHeight = 29;
            invoicesDataGridView.Location = new Point(3, 53);
            invoicesDataGridView.Name = "invoicesDataGridView";
            invoicesDataGridView.RowHeadersWidth = 51;
            invoicesDataGridView.Size = new Size(1030, 524);
            invoicesDataGridView.TabIndex = 0;
            invoicesDataGridView.CellClick += CustomersDataGridView_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(867, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(254, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(218, 28);
            comboBox2.TabIndex = 3;
            // 
            // ManageInvoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(invoicesDataGridView);
            Name = "ManageInvoices";
            Size = new Size(1033, 580);
            ((System.ComponentModel.ISupportInitialize)invoicesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView invoicesDataGridView;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
