namespace WinFormsApp3
{
    partial class AddInvoice
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
            customerTypeCombobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            customerCodeInput = new TextBox();
            label3 = new Label();
            customerNameInput = new TextBox();
            label4 = new Label();
            lastMonthNumberInput = new TextBox();
            label5 = new Label();
            thisMonthNumberInput = new TextBox();
            label6 = new Label();
            numberOfPeopleInput = new TextBox();
            calculateButton = new Button();
            saveButton = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            currentMonthCombobox = new ComboBox();
            consumptionLabel = new Label();
            priceLabel = new Label();
            subtotalLabel = new Label();
            envFeeLabel = new Label();
            VATLabel = new Label();
            totalLabel = new Label();
            SuspendLayout();
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.DropDownWidth = 320;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(316, 60);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(236, 28);
            customerTypeCombobox.TabIndex = 2;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 27);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Type";
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(15, 61);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(237, 27);
            customerCodeInput.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 109);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 0;
            label3.Text = "Customer Name";
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(15, 141);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(237, 27);
            customerNameInput.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 194);
            label4.Name = "label4";
            label4.Size = new Size(236, 20);
            label4.TabIndex = 0;
            label4.Text = "Last month’s water meter readings";
            // 
            // lastMonthNumberInput
            // 
            lastMonthNumberInput.Location = new Point(15, 228);
            lastMonthNumberInput.Name = "lastMonthNumberInput";
            lastMonthNumberInput.Size = new Size(237, 27);
            lastMonthNumberInput.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 194);
            label5.Name = "label5";
            label5.Size = new Size(236, 20);
            label5.TabIndex = 0;
            label5.Text = "This month’s water meter readings";
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(316, 228);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(237, 27);
            thisMonthNumberInput.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 109);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 0;
            label6.Text = "Number of people";
            // 
            // numberOfPeopleInput
            // 
            numberOfPeopleInput.Location = new Point(315, 141);
            numberOfPeopleInput.Name = "numberOfPeopleInput";
            numberOfPeopleInput.Size = new Size(237, 27);
            numberOfPeopleInput.TabIndex = 4;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.NavajoWhite;
            calculateButton.Location = new Point(316, 378);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(237, 61);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            calculateButton.MouseLeave += calculateButton_MouseLeave;
            calculateButton.MouseHover += calculateButton_MouseHover;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.Font = new Font("Segoe UI", 9F);
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(315, 455);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(237, 60);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 398);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 4;
            label7.Text = "VAT(10%):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 365);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 5;
            label8.Text = "Environment Fees:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 276);
            label9.Name = "label9";
            label9.Size = new Size(173, 20);
            label9.TabIndex = 4;
            label9.Text = "Amount of consumption:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 305);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 5;
            label10.Text = "Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 334);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 5;
            label11.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 455);
            label12.Name = "label12";
            label12.Size = new Size(73, 31);
            label12.TabIndex = 5;
            label12.Text = "Total:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(316, 267);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 7;
            label13.Text = "Current Month";
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownHeight = 300;
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.IntegralHeight = false;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(316, 297);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(236, 28);
            currentMonthCombobox.TabIndex = 7;
            // 
            // consumptionLabel
            // 
            consumptionLabel.Location = new Point(193, 276);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(58, 20);
            consumptionLabel.TabIndex = 8;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(94, 305);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(157, 20);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Location = new Point(96, 334);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(155, 20);
            subtotalLabel.TabIndex = 8;
            subtotalLabel.Text = "0";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envFeeLabel
            // 
            envFeeLabel.Location = new Point(139, 365);
            envFeeLabel.Name = "envFeeLabel";
            envFeeLabel.Size = new Size(112, 20);
            envFeeLabel.TabIndex = 8;
            envFeeLabel.Text = "0";
            envFeeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            VATLabel.Location = new Point(103, 398);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(148, 20);
            VATLabel.TabIndex = 8;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(87, 455);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(169, 31);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AddInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalLabel);
            Controls.Add(VATLabel);
            Controls.Add(envFeeLabel);
            Controls.Add(subtotalLabel);
            Controls.Add(priceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(label13);
            Controls.Add(currentMonthCombobox);
            Controls.Add(customerTypeCombobox);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(saveButton);
            Controls.Add(calculateButton);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(lastMonthNumberInput);
            Controls.Add(label5);
            Controls.Add(numberOfPeopleInput);
            Controls.Add(customerNameInput);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(customerCodeInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoice";
            Size = new Size(624, 518);
            Load += AddInvoice_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox customerCodeInput;
        private Label label3;
        private TextBox customerNameInput;
        private Label label4;
        private TextBox lastMonthNumberInput;
        private Label label5;
        private TextBox thisMonthNumberInput;
        private Label label6;
        private TextBox numberOfPeopleInput;
        private Button calculateButton;
        private Button saveButton;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox customerTypeCombobox;
        private Label label13;
        private ComboBox currentMonthCombobox;
        private Label consumptionLabel;
        private Label priceLabel;
        private Label subtotalLabel;
        private Label envFeeLabel;
        private Label VATLabel;
        private Label totalLabel;
    }
}
