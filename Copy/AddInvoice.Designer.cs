namespace Copy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            customerCodeInput = new TextBox();
            customerNameInput = new TextBox();
            lastMonthNumberInput = new TextBox();
            numberOfPeopleInput = new TextBox();
            thisMonthNumberInput = new TextBox();
            customerTypeCombobox = new ComboBox();
            currentMonthCombobox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            calculateButton = new Button();
            saveButton = new Button();
            consumptionLabel = new Label();
            priceLabel = new Label();
            subTotalLabel = new Label();
            envFeeLabel = new Label();
            VATLabel = new Label();
            totalLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 47);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 117);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 188);
            label3.Name = "label3";
            label3.Size = new Size(236, 20);
            label3.TabIndex = 2;
            label3.Text = "Last month's water meter readings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 118);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 3;
            label4.Text = "Number of people";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 47);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 4;
            label5.Text = "Customer Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(571, 188);
            label6.Name = "label6";
            label6.Size = new Size(236, 20);
            label6.TabIndex = 5;
            label6.Text = "This month's water meter readings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(571, 259);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 6;
            label7.Text = "Current Month";
            label7.Click += label7_Click;
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(49, 70);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(294, 27);
            customerCodeInput.TabIndex = 7;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(49, 140);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(294, 27);
            customerNameInput.TabIndex = 8;
            // 
            // lastMonthNumberInput
            // 
            lastMonthNumberInput.Location = new Point(49, 211);
            lastMonthNumberInput.Name = "lastMonthNumberInput";
            lastMonthNumberInput.Size = new Size(294, 27);
            lastMonthNumberInput.TabIndex = 9;
            // 
            // numberOfPeopleInput
            // 
            numberOfPeopleInput.Location = new Point(571, 141);
            numberOfPeopleInput.Name = "numberOfPeopleInput";
            numberOfPeopleInput.Size = new Size(294, 27);
            numberOfPeopleInput.TabIndex = 10;
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(571, 211);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(294, 27);
            thisMonthNumberInput.TabIndex = 11;
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(571, 70);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(294, 28);
            customerTypeCombobox.TabIndex = 12;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(571, 282);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(294, 28);
            currentMonthCombobox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 259);
            label8.Name = "label8";
            label8.Size = new Size(170, 20);
            label8.TabIndex = 14;
            label8.Text = "Amount of consumption";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 306);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 15;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 352);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 16;
            label10.Text = "Subtotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 405);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 17;
            label11.Text = "Enviroment";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(49, 453);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 18;
            label12.Text = "VAT(10%)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.Location = new Point(49, 510);
            label13.Name = "label13";
            label13.Size = new Size(80, 35);
            label13.TabIndex = 19;
            label13.Text = "Total:";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(128, 255, 128);
            calculateButton.Location = new Point(571, 352);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(236, 73);
            calculateButton.TabIndex = 20;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DodgerBlue;
            saveButton.Location = new Point(571, 457);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(236, 73);
            saveButton.TabIndex = 21;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // consumptionLabel
            // 
            consumptionLabel.Location = new Point(251, 259);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(116, 20);
            consumptionLabel.TabIndex = 22;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(251, 306);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(116, 20);
            priceLabel.TabIndex = 23;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subTotalLabel
            // 
            subTotalLabel.Location = new Point(251, 352);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(116, 20);
            subTotalLabel.TabIndex = 24;
            subTotalLabel.Text = "0";
            subTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envFeeLabel
            // 
            envFeeLabel.Location = new Point(251, 405);
            envFeeLabel.Name = "envFeeLabel";
            envFeeLabel.Size = new Size(116, 20);
            envFeeLabel.TabIndex = 25;
            envFeeLabel.Text = "0";
            envFeeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            VATLabel.Location = new Point(251, 457);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(116, 20);
            VATLabel.TabIndex = 26;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalLabel.Location = new Point(144, 510);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(230, 35);
            totalLabel.TabIndex = 27;
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
            Controls.Add(subTotalLabel);
            Controls.Add(priceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(saveButton);
            Controls.Add(calculateButton);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(currentMonthCombobox);
            Controls.Add(customerTypeCombobox);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(numberOfPeopleInput);
            Controls.Add(lastMonthNumberInput);
            Controls.Add(customerNameInput);
            Controls.Add(customerCodeInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoice";
            Size = new Size(924, 599);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox customerCodeInput;
        private TextBox customerNameInput;
        private TextBox lastMonthNumberInput;
        private TextBox numberOfPeopleInput;
        private TextBox thisMonthNumberInput;
        private ComboBox customerTypeCombobox;
        private ComboBox currentMonthCombobox;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button calculateButton;
        private Button saveButton;
        private Label consumptionLabel;
        private Label priceLabel;
        private Label subTotalLabel;
        private Label envFeeLabel;
        private Label VATLabel;
        private Label totalLabel;
    }
}
