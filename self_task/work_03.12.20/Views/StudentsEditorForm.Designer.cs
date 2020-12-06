namespace WindowsFormsApp6.Views
{
    partial class StudentsEditorForm
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
            this.fioLabelStudentsEditorForm = new System.Windows.Forms.Label();
            this.genderLabelStudentsEditorForm = new System.Windows.Forms.Label();
            this.phoneLabelStudentsEditorForm = new System.Windows.Forms.Label();
            this.groupLabelStudentsEditorForm = new System.Windows.Forms.Label();
            this.fioTextBoxStudentsEditorForm = new System.Windows.Forms.TextBox();
            this.groupComboBoxStudentsEditorForm = new System.Windows.Forms.ComboBox();
            this.phoneTextBoxStudentsEditorForm = new System.Windows.Forms.MaskedTextBox();
            this.submitButtonStudentsEditorForm = new System.Windows.Forms.Button();
            this.exitButtonStudentsEditorForm = new System.Windows.Forms.Button();
            this.genderComboBoxStudentsEditorForm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fioLabelStudentsEditorForm
            // 
            this.fioLabelStudentsEditorForm.AutoSize = true;
            this.fioLabelStudentsEditorForm.Location = new System.Drawing.Point(12, 22);
            this.fioLabelStudentsEditorForm.Name = "fioLabelStudentsEditorForm";
            this.fioLabelStudentsEditorForm.Size = new System.Drawing.Size(37, 13);
            this.fioLabelStudentsEditorForm.TabIndex = 0;
            this.fioLabelStudentsEditorForm.Text = "ФИО:";
            // 
            // genderLabelStudentsEditorForm
            // 
            this.genderLabelStudentsEditorForm.AutoSize = true;
            this.genderLabelStudentsEditorForm.Location = new System.Drawing.Point(12, 70);
            this.genderLabelStudentsEditorForm.Name = "genderLabelStudentsEditorForm";
            this.genderLabelStudentsEditorForm.Size = new System.Drawing.Size(30, 13);
            this.genderLabelStudentsEditorForm.TabIndex = 1;
            this.genderLabelStudentsEditorForm.Text = "Пол:";
            // 
            // phoneLabelStudentsEditorForm
            // 
            this.phoneLabelStudentsEditorForm.AutoSize = true;
            this.phoneLabelStudentsEditorForm.Location = new System.Drawing.Point(12, 118);
            this.phoneLabelStudentsEditorForm.Name = "phoneLabelStudentsEditorForm";
            this.phoneLabelStudentsEditorForm.Size = new System.Drawing.Size(55, 13);
            this.phoneLabelStudentsEditorForm.TabIndex = 2;
            this.phoneLabelStudentsEditorForm.Text = "Телефон:";
            // 
            // groupLabelStudentsEditorForm
            // 
            this.groupLabelStudentsEditorForm.AutoSize = true;
            this.groupLabelStudentsEditorForm.Location = new System.Drawing.Point(14, 166);
            this.groupLabelStudentsEditorForm.Name = "groupLabelStudentsEditorForm";
            this.groupLabelStudentsEditorForm.Size = new System.Drawing.Size(45, 13);
            this.groupLabelStudentsEditorForm.TabIndex = 3;
            this.groupLabelStudentsEditorForm.Text = "Группа:";
            // 
            // fioTextBoxStudentsEditorForm
            // 
            this.fioTextBoxStudentsEditorForm.Location = new System.Drawing.Point(12, 38);
            this.fioTextBoxStudentsEditorForm.Name = "fioTextBoxStudentsEditorForm";
            this.fioTextBoxStudentsEditorForm.Size = new System.Drawing.Size(220, 20);
            this.fioTextBoxStudentsEditorForm.TabIndex = 4;
            // 
            // groupComboBoxStudentsEditorForm
            // 
            this.groupComboBoxStudentsEditorForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBoxStudentsEditorForm.FormattingEnabled = true;
            this.groupComboBoxStudentsEditorForm.Location = new System.Drawing.Point(12, 182);
            this.groupComboBoxStudentsEditorForm.Name = "groupComboBoxStudentsEditorForm";
            this.groupComboBoxStudentsEditorForm.Size = new System.Drawing.Size(220, 21);
            this.groupComboBoxStudentsEditorForm.TabIndex = 6;
            // 
            // phoneTextBoxStudentsEditorForm
            // 
            this.phoneTextBoxStudentsEditorForm.Location = new System.Drawing.Point(12, 134);
            this.phoneTextBoxStudentsEditorForm.Mask = "(999) 000-0000";
            this.phoneTextBoxStudentsEditorForm.Name = "phoneTextBoxStudentsEditorForm";
            this.phoneTextBoxStudentsEditorForm.Size = new System.Drawing.Size(220, 20);
            this.phoneTextBoxStudentsEditorForm.TabIndex = 7;
            // 
            // submitButtonStudentsEditorForm
            // 
            this.submitButtonStudentsEditorForm.Location = new System.Drawing.Point(12, 224);
            this.submitButtonStudentsEditorForm.Name = "submitButtonStudentsEditorForm";
            this.submitButtonStudentsEditorForm.Size = new System.Drawing.Size(110, 23);
            this.submitButtonStudentsEditorForm.TabIndex = 8;
            this.submitButtonStudentsEditorForm.Text = "Принять";
            this.submitButtonStudentsEditorForm.UseVisualStyleBackColor = true;
            // 
            // exitButtonStudentsEditorForm
            // 
            this.exitButtonStudentsEditorForm.Location = new System.Drawing.Point(128, 224);
            this.exitButtonStudentsEditorForm.Name = "exitButtonStudentsEditorForm";
            this.exitButtonStudentsEditorForm.Size = new System.Drawing.Size(104, 23);
            this.exitButtonStudentsEditorForm.TabIndex = 9;
            this.exitButtonStudentsEditorForm.Text = "Закрыть";
            this.exitButtonStudentsEditorForm.UseVisualStyleBackColor = true;
            // 
            // genderComboBoxStudentsEditorForm
            // 
            this.genderComboBoxStudentsEditorForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBoxStudentsEditorForm.FormattingEnabled = true;
            this.genderComboBoxStudentsEditorForm.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBoxStudentsEditorForm.Location = new System.Drawing.Point(12, 86);
            this.genderComboBoxStudentsEditorForm.Name = "genderComboBoxStudentsEditorForm";
            this.genderComboBoxStudentsEditorForm.Size = new System.Drawing.Size(220, 21);
            this.genderComboBoxStudentsEditorForm.TabIndex = 10;
            // 
            // StudentsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 259);
            this.Controls.Add(this.genderComboBoxStudentsEditorForm);
            this.Controls.Add(this.exitButtonStudentsEditorForm);
            this.Controls.Add(this.submitButtonStudentsEditorForm);
            this.Controls.Add(this.phoneTextBoxStudentsEditorForm);
            this.Controls.Add(this.groupComboBoxStudentsEditorForm);
            this.Controls.Add(this.fioTextBoxStudentsEditorForm);
            this.Controls.Add(this.groupLabelStudentsEditorForm);
            this.Controls.Add(this.phoneLabelStudentsEditorForm);
            this.Controls.Add(this.genderLabelStudentsEditorForm);
            this.Controls.Add(this.fioLabelStudentsEditorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentsEditorForm";
            this.Text = "StudentsEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fioLabelStudentsEditorForm;
        private System.Windows.Forms.Label genderLabelStudentsEditorForm;
        private System.Windows.Forms.Label phoneLabelStudentsEditorForm;
        private System.Windows.Forms.Label groupLabelStudentsEditorForm;
        private System.Windows.Forms.TextBox fioTextBoxStudentsEditorForm;
        private System.Windows.Forms.ComboBox groupComboBoxStudentsEditorForm;
        private System.Windows.Forms.MaskedTextBox phoneTextBoxStudentsEditorForm;
        private System.Windows.Forms.Button submitButtonStudentsEditorForm;
        private System.Windows.Forms.Button exitButtonStudentsEditorForm;
        private System.Windows.Forms.ComboBox genderComboBoxStudentsEditorForm;
    }
}