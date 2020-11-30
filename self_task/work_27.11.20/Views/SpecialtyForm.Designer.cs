namespace WindowsFormsApp5.Views
{
    partial class SpecialtyForm
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
            this.updateButtonSpecialtyForm = new System.Windows.Forms.Button();
            this.specialtyGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButtonSpecialtyForm
            // 
            this.updateButtonSpecialtyForm.Location = new System.Drawing.Point(229, 239);
            this.updateButtonSpecialtyForm.Name = "updateButtonSpecialtyForm";
            this.updateButtonSpecialtyForm.Size = new System.Drawing.Size(75, 23);
            this.updateButtonSpecialtyForm.TabIndex = 2;
            this.updateButtonSpecialtyForm.Text = "Обновить";
            this.updateButtonSpecialtyForm.UseVisualStyleBackColor = true;
            // 
            // specialtyGridView
            // 
            this.specialtyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialtyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.codeColumn,
            this.nameColumn});
            this.specialtyGridView.Location = new System.Drawing.Point(12, 12);
            this.specialtyGridView.Name = "specialtyGridView";
            this.specialtyGridView.Size = new System.Drawing.Size(525, 221);
            this.specialtyGridView.TabIndex = 3;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // codeColumn
            // 
            this.codeColumn.DataPropertyName = "Code";
            this.codeColumn.HeaderText = "Шифр";
            this.codeColumn.Name = "codeColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            // 
            // SpecialtyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 274);
            this.Controls.Add(this.specialtyGridView);
            this.Controls.Add(this.updateButtonSpecialtyForm);
            this.Name = "SpecialtyForm";
            this.Text = "SpecialtyForm";
            ((System.ComponentModel.ISupportInitialize)(this.specialtyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButtonSpecialtyForm;
        private System.Windows.Forms.DataGridView specialtyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
    }
}