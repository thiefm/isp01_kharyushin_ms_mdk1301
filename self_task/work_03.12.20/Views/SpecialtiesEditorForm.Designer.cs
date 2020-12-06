namespace WindowsFormsApp6.Views
{
    partial class SpecialtiesEditorForm
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
            this.exitButtonSpecialtiesEditorForm = new System.Windows.Forms.Button();
            this.submitButtonSpecialtiesEditorForm = new System.Windows.Forms.Button();
            this.nameLabelSpecialtiesEditorForm = new System.Windows.Forms.Label();
            this.codeTextBoxSpecialtiesEditorForm = new System.Windows.Forms.TextBox();
            this.codeLabelSpecialtiesEditorForm = new System.Windows.Forms.Label();
            this.nameTextBoxSpecialtiesEditorForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButtonSpecialtiesEditorForm
            // 
            this.exitButtonSpecialtiesEditorForm.Location = new System.Drawing.Point(125, 134);
            this.exitButtonSpecialtiesEditorForm.Name = "exitButtonSpecialtiesEditorForm";
            this.exitButtonSpecialtiesEditorForm.Size = new System.Drawing.Size(107, 23);
            this.exitButtonSpecialtiesEditorForm.TabIndex = 13;
            this.exitButtonSpecialtiesEditorForm.Text = "Закрыть";
            this.exitButtonSpecialtiesEditorForm.UseVisualStyleBackColor = true;
            // 
            // submitButtonSpecialtiesEditorForm
            // 
            this.submitButtonSpecialtiesEditorForm.Location = new System.Drawing.Point(12, 134);
            this.submitButtonSpecialtiesEditorForm.Name = "submitButtonSpecialtiesEditorForm";
            this.submitButtonSpecialtiesEditorForm.Size = new System.Drawing.Size(107, 23);
            this.submitButtonSpecialtiesEditorForm.TabIndex = 12;
            this.submitButtonSpecialtiesEditorForm.Text = "Принять";
            this.submitButtonSpecialtiesEditorForm.UseVisualStyleBackColor = true;
            // 
            // nameLabelSpecialtiesEditorForm
            // 
            this.nameLabelSpecialtiesEditorForm.AutoSize = true;
            this.nameLabelSpecialtiesEditorForm.Location = new System.Drawing.Point(12, 67);
            this.nameLabelSpecialtiesEditorForm.Name = "nameLabelSpecialtiesEditorForm";
            this.nameLabelSpecialtiesEditorForm.Size = new System.Drawing.Size(83, 13);
            this.nameLabelSpecialtiesEditorForm.TabIndex = 11;
            this.nameLabelSpecialtiesEditorForm.Text = "Наименование";
            // 
            // codeTextBoxSpecialtiesEditorForm
            // 
            this.codeTextBoxSpecialtiesEditorForm.Location = new System.Drawing.Point(12, 35);
            this.codeTextBoxSpecialtiesEditorForm.Name = "codeTextBoxSpecialtiesEditorForm";
            this.codeTextBoxSpecialtiesEditorForm.Size = new System.Drawing.Size(220, 20);
            this.codeTextBoxSpecialtiesEditorForm.TabIndex = 9;
            // 
            // codeLabelSpecialtiesEditorForm
            // 
            this.codeLabelSpecialtiesEditorForm.AutoSize = true;
            this.codeLabelSpecialtiesEditorForm.Location = new System.Drawing.Point(12, 19);
            this.codeLabelSpecialtiesEditorForm.Name = "codeLabelSpecialtiesEditorForm";
            this.codeLabelSpecialtiesEditorForm.Size = new System.Drawing.Size(39, 13);
            this.codeLabelSpecialtiesEditorForm.TabIndex = 8;
            this.codeLabelSpecialtiesEditorForm.Text = "Шифр:";
            // 
            // nameTextBoxSpecialtiesEditorForm
            // 
            this.nameTextBoxSpecialtiesEditorForm.Location = new System.Drawing.Point(12, 83);
            this.nameTextBoxSpecialtiesEditorForm.Name = "nameTextBoxSpecialtiesEditorForm";
            this.nameTextBoxSpecialtiesEditorForm.Size = new System.Drawing.Size(220, 20);
            this.nameTextBoxSpecialtiesEditorForm.TabIndex = 14;
            // 
            // SpecialtiesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 175);
            this.Controls.Add(this.nameTextBoxSpecialtiesEditorForm);
            this.Controls.Add(this.exitButtonSpecialtiesEditorForm);
            this.Controls.Add(this.submitButtonSpecialtiesEditorForm);
            this.Controls.Add(this.nameLabelSpecialtiesEditorForm);
            this.Controls.Add(this.codeTextBoxSpecialtiesEditorForm);
            this.Controls.Add(this.codeLabelSpecialtiesEditorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SpecialtiesEditorForm";
            this.Text = "SpecialtiesEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButtonSpecialtiesEditorForm;
        private System.Windows.Forms.Button submitButtonSpecialtiesEditorForm;
        private System.Windows.Forms.Label nameLabelSpecialtiesEditorForm;
        private System.Windows.Forms.TextBox codeTextBoxSpecialtiesEditorForm;
        private System.Windows.Forms.Label codeLabelSpecialtiesEditorForm;
        private System.Windows.Forms.TextBox nameTextBoxSpecialtiesEditorForm;
    }
}