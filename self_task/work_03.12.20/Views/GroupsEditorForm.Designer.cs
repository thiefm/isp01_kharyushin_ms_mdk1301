namespace WindowsFormsApp6.Views
{
    partial class GroupsEditorForm
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
            this.nameLabelGroupsEditorForm = new System.Windows.Forms.Label();
            this.nameTextBoxGroupsEditorForm = new System.Windows.Forms.TextBox();
            this.yearCreationTextBoxGroupsEditorForm = new System.Windows.Forms.MaskedTextBox();
            this.yearCreationLabelGroupsEditorForm = new System.Windows.Forms.Label();
            this.specialtyLabelGroupsEditorForm = new System.Windows.Forms.Label();
            this.specialtyComboBoxGroupsEditorForm = new System.Windows.Forms.ComboBox();
            this.submitButtonGroupsEditorForm = new System.Windows.Forms.Button();
            this.exitButtonGroupsEditorForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabelGroupsEditorForm
            // 
            this.nameLabelGroupsEditorForm.AutoSize = true;
            this.nameLabelGroupsEditorForm.Location = new System.Drawing.Point(12, 26);
            this.nameLabelGroupsEditorForm.Name = "nameLabelGroupsEditorForm";
            this.nameLabelGroupsEditorForm.Size = new System.Drawing.Size(60, 13);
            this.nameLabelGroupsEditorForm.TabIndex = 0;
            this.nameLabelGroupsEditorForm.Text = "Название:";
            // 
            // nameTextBoxGroupsEditorForm
            // 
            this.nameTextBoxGroupsEditorForm.Location = new System.Drawing.Point(12, 42);
            this.nameTextBoxGroupsEditorForm.Name = "nameTextBoxGroupsEditorForm";
            this.nameTextBoxGroupsEditorForm.Size = new System.Drawing.Size(220, 20);
            this.nameTextBoxGroupsEditorForm.TabIndex = 1;
            // 
            // yearCreationTextBoxGroupsEditorForm
            // 
            this.yearCreationTextBoxGroupsEditorForm.Location = new System.Drawing.Point(12, 90);
            this.yearCreationTextBoxGroupsEditorForm.Mask = "0000";
            this.yearCreationTextBoxGroupsEditorForm.Name = "yearCreationTextBoxGroupsEditorForm";
            this.yearCreationTextBoxGroupsEditorForm.Size = new System.Drawing.Size(220, 20);
            this.yearCreationTextBoxGroupsEditorForm.TabIndex = 2;
            this.yearCreationTextBoxGroupsEditorForm.ValidatingType = typeof(int);
            // 
            // yearCreationLabelGroupsEditorForm
            // 
            this.yearCreationLabelGroupsEditorForm.AutoSize = true;
            this.yearCreationLabelGroupsEditorForm.Location = new System.Drawing.Point(12, 74);
            this.yearCreationLabelGroupsEditorForm.Name = "yearCreationLabelGroupsEditorForm";
            this.yearCreationLabelGroupsEditorForm.Size = new System.Drawing.Size(107, 13);
            this.yearCreationLabelGroupsEditorForm.TabIndex = 3;
            this.yearCreationLabelGroupsEditorForm.Text = "Год формирования:";
            // 
            // specialtyLabelGroupsEditorForm
            // 
            this.specialtyLabelGroupsEditorForm.AutoSize = true;
            this.specialtyLabelGroupsEditorForm.Location = new System.Drawing.Point(12, 122);
            this.specialtyLabelGroupsEditorForm.Name = "specialtyLabelGroupsEditorForm";
            this.specialtyLabelGroupsEditorForm.Size = new System.Drawing.Size(88, 13);
            this.specialtyLabelGroupsEditorForm.TabIndex = 4;
            this.specialtyLabelGroupsEditorForm.Text = "Специальность:";
            // 
            // specialtyComboBoxGroupsEditorForm
            // 
            this.specialtyComboBoxGroupsEditorForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialtyComboBoxGroupsEditorForm.FormattingEnabled = true;
            this.specialtyComboBoxGroupsEditorForm.Location = new System.Drawing.Point(12, 138);
            this.specialtyComboBoxGroupsEditorForm.Name = "specialtyComboBoxGroupsEditorForm";
            this.specialtyComboBoxGroupsEditorForm.Size = new System.Drawing.Size(220, 21);
            this.specialtyComboBoxGroupsEditorForm.TabIndex = 5;
            // 
            // submitButtonGroupsEditorForm
            // 
            this.submitButtonGroupsEditorForm.Location = new System.Drawing.Point(12, 184);
            this.submitButtonGroupsEditorForm.Name = "submitButtonGroupsEditorForm";
            this.submitButtonGroupsEditorForm.Size = new System.Drawing.Size(107, 23);
            this.submitButtonGroupsEditorForm.TabIndex = 6;
            this.submitButtonGroupsEditorForm.Text = "Принять";
            this.submitButtonGroupsEditorForm.UseVisualStyleBackColor = true;
            // 
            // exitButtonGroupsEditorForm
            // 
            this.exitButtonGroupsEditorForm.Location = new System.Drawing.Point(125, 184);
            this.exitButtonGroupsEditorForm.Name = "exitButtonGroupsEditorForm";
            this.exitButtonGroupsEditorForm.Size = new System.Drawing.Size(107, 23);
            this.exitButtonGroupsEditorForm.TabIndex = 7;
            this.exitButtonGroupsEditorForm.Text = "Закрыть";
            this.exitButtonGroupsEditorForm.UseVisualStyleBackColor = true;
            // 
            // GroupsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 219);
            this.Controls.Add(this.exitButtonGroupsEditorForm);
            this.Controls.Add(this.submitButtonGroupsEditorForm);
            this.Controls.Add(this.specialtyComboBoxGroupsEditorForm);
            this.Controls.Add(this.specialtyLabelGroupsEditorForm);
            this.Controls.Add(this.yearCreationLabelGroupsEditorForm);
            this.Controls.Add(this.yearCreationTextBoxGroupsEditorForm);
            this.Controls.Add(this.nameTextBoxGroupsEditorForm);
            this.Controls.Add(this.nameLabelGroupsEditorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GroupsEditorForm";
            this.Text = "GroupsEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabelGroupsEditorForm;
        private System.Windows.Forms.TextBox nameTextBoxGroupsEditorForm;
        private System.Windows.Forms.MaskedTextBox yearCreationTextBoxGroupsEditorForm;
        private System.Windows.Forms.Label yearCreationLabelGroupsEditorForm;
        private System.Windows.Forms.Label specialtyLabelGroupsEditorForm;
        private System.Windows.Forms.ComboBox specialtyComboBoxGroupsEditorForm;
        private System.Windows.Forms.Button submitButtonGroupsEditorForm;
        private System.Windows.Forms.Button exitButtonGroupsEditorForm;
    }
}