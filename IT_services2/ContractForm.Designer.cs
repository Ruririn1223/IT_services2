namespace IT_services2
{
    partial class ContractForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelFlags = new System.Windows.Forms.Label();
            this.labelSystems = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOrganization = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.checkBoxNDA = new System.Windows.Forms.CheckBox();
            this.checkBoxUrgent = new System.Windows.Forms.CheckBox();
            this.checkBoxPrepayment = new System.Windows.Forms.CheckBox();
            this.checkBoxLongTerm = new System.Windows.Forms.CheckBox();
            this.checkedListBoxSystems = new System.Windows.Forms.CheckedListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(16, 18);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(53, 16);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(16, 55);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Дата:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(16, 92);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(42, 16);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "Срок:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(16, 129);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(53, 16);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Сумма:";
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Location = new System.Drawing.Point(16, 166);
            this.labelOrganization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(97, 16);
            this.labelOrganization.TabIndex = 4;
            this.labelOrganization.Text = "Организация:";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(16, 203);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(81, 16);
            this.labelEmployee.TabIndex = 5;
            this.labelEmployee.Text = "Сотрудник:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(16, 240);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 16);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Статус:";
            // 
            // labelFlags
            // 
            this.labelFlags.AutoSize = true;
            this.labelFlags.Location = new System.Drawing.Point(16, 277);
            this.labelFlags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFlags.Name = "labelFlags";
            this.labelFlags.Size = new System.Drawing.Size(51, 16);
            this.labelFlags.TabIndex = 7;
            this.labelFlags.Text = "Флаги:";
            // 
            // labelSystems
            // 
            this.labelSystems.AutoSize = true;
            this.labelSystems.Location = new System.Drawing.Point(16, 363);
            this.labelSystems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSystems.Name = "labelSystems";
            this.labelSystems.Size = new System.Drawing.Size(67, 16);
            this.labelSystems.TabIndex = 8;
            this.labelSystems.Text = "Системы:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(160, 15);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(265, 22);
            this.textBoxNumber.TabIndex = 9;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(160, 52);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDate.TabIndex = 10;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(160, 89);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerEndDate.TabIndex = 11;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(160, 126);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(267, 22);
            this.numericUpDownAmount.TabIndex = 12;
            // 
            // comboBoxOrganization
            // 
            this.comboBoxOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrganization.FormattingEnabled = true;
            this.comboBoxOrganization.Location = new System.Drawing.Point(160, 162);
            this.comboBoxOrganization.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOrganization.Name = "comboBoxOrganization";
            this.comboBoxOrganization.Size = new System.Drawing.Size(265, 24);
            this.comboBoxOrganization.TabIndex = 13;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(160, 199);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(265, 24);
            this.comboBoxEmployee.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(160, 236);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(265, 24);
            this.comboBoxStatus.TabIndex = 15;
            // 
            // checkBoxNDA
            // 
            this.checkBoxNDA.AutoSize = true;
            this.checkBoxNDA.Location = new System.Drawing.Point(160, 277);
            this.checkBoxNDA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNDA.Name = "checkBoxNDA";
            this.checkBoxNDA.Size = new System.Drawing.Size(58, 20);
            this.checkBoxNDA.TabIndex = 16;
            this.checkBoxNDA.Text = "NDA";
            this.checkBoxNDA.UseVisualStyleBackColor = true;
            // 
            // checkBoxUrgent
            // 
            this.checkBoxUrgent.AutoSize = true;
            this.checkBoxUrgent.Location = new System.Drawing.Point(240, 277);
            this.checkBoxUrgent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxUrgent.Name = "checkBoxUrgent";
            this.checkBoxUrgent.Size = new System.Drawing.Size(87, 20);
            this.checkBoxUrgent.TabIndex = 17;
            this.checkBoxUrgent.Text = "Срочный";
            this.checkBoxUrgent.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrepayment
            // 
            this.checkBoxPrepayment.AutoSize = true;
            this.checkBoxPrepayment.Location = new System.Drawing.Point(333, 277);
            this.checkBoxPrepayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPrepayment.Name = "checkBoxPrepayment";
            this.checkBoxPrepayment.Size = new System.Drawing.Size(128, 20);
            this.checkBoxPrepayment.TabIndex = 18;
            this.checkBoxPrepayment.Text = "С предоплатой";
            this.checkBoxPrepayment.UseVisualStyleBackColor = true;
            // 
            // checkBoxLongTerm
            // 
            this.checkBoxLongTerm.AutoSize = true;
            this.checkBoxLongTerm.Location = new System.Drawing.Point(160, 308);
            this.checkBoxLongTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxLongTerm.Name = "checkBoxLongTerm";
            this.checkBoxLongTerm.Size = new System.Drawing.Size(124, 20);
            this.checkBoxLongTerm.TabIndex = 19;
            this.checkBoxLongTerm.Text = "Долгосрочный";
            this.checkBoxLongTerm.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxSystems
            // 
            this.checkedListBoxSystems.FormattingEnabled = true;
            this.checkedListBoxSystems.Location = new System.Drawing.Point(160, 363);
            this.checkedListBoxSystems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBoxSystems.Name = "checkedListBoxSystems";
            this.checkedListBoxSystems.Size = new System.Drawing.Size(265, 106);
            this.checkedListBoxSystems.TabIndex = 20;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(160, 492);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(133, 37);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(307, 492);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 37);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 554);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkedListBoxSystems);
            this.Controls.Add(this.checkBoxLongTerm);
            this.Controls.Add(this.checkBoxPrepayment);
            this.Controls.Add(this.checkBoxUrgent);
            this.Controls.Add(this.checkBoxNDA);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxOrganization);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelSystems);
            this.Controls.Add(this.labelFlags);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelOrganization);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление договора";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelFlags;
        private System.Windows.Forms.Label labelSystems;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.ComboBox comboBoxOrganization;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxNDA;
        private System.Windows.Forms.CheckBox checkBoxUrgent;
        private System.Windows.Forms.CheckBox checkBoxPrepayment;
        private System.Windows.Forms.CheckBox checkBoxLongTerm;
        private System.Windows.Forms.CheckedListBox checkedListBoxSystems;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}