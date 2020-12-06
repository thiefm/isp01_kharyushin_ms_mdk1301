namespace WindowsFormsApp6.Views
{
    partial class SpecialtiesForm
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
            this.updateButtonSpecialtiesForm = new System.Windows.Forms.Button();
            this.editButtonSpecialtiesForm = new System.Windows.Forms.Button();
            this.addButtonSpecialtiesForm = new System.Windows.Forms.Button();
            this.specialtiesGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButtonSpecialtiesForm
            // 
            this.updateButtonSpecialtiesForm.Location = new System.Drawing.Point(234, 333);
            this.updateButtonSpecialtiesForm.Name = "updateButtonSpecialtiesForm";
            this.updateButtonSpecialtiesForm.Size = new System.Drawing.Size(75, 23);
            this.updateButtonSpecialtiesForm.TabIndex = 17;
            this.updateButtonSpecialtiesForm.Text = "Обновить";
            this.updateButtonSpecialtiesForm.UseVisualStyleBackColor = true;
            // 
            // editButtonSpecialtiesForm
            // 
            this.editButtonSpecialtiesForm.Location = new System.Drawing.Point(465, 333);
            this.editButtonSpecialtiesForm.Name = "editButtonSpecialtiesForm";
            this.editButtonSpecialtiesForm.Size = new System.Drawing.Size(75, 23);
            this.editButtonSpecialtiesForm.TabIndex = 16;
            this.editButtonSpecialtiesForm.Text = "Изменить";
            this.editButtonSpecialtiesForm.UseVisualStyleBackColor = true;
            // 
            // addButtonSpecialtiesForm
            // 
            this.addButtonSpecialtiesForm.Location = new System.Drawing.Point(12, 333);
            this.addButtonSpecialtiesForm.Name = "addButtonSpecialtiesForm";
            this.addButtonSpecialtiesForm.Size = new System.Drawing.Size(75, 23);
            this.addButtonSpecialtiesForm.TabIndex = 15;
            this.addButtonSpecialtiesForm.Text = "Добавить";
            this.addButtonSpecialtiesForm.UseVisualStyleBackColor = true;
            // 
            // specialtiesGridView
            // 
            this.specialtiesGridView.AllowUserToAddRows = false;
            this.specialtiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialtiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.CodeColumn,
            this.NameColumn});
            this.specialtiesGridView.Location = new System.Drawing.Point(12, 12);
            this.specialtiesGridView.MultiSelect = false;
            this.specialtiesGridView.Name = "specialtiesGridView";
            this.specialtiesGridView.ReadOnly = true;
            this.specialtiesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.specialtiesGridView.Size = new System.Drawing.Size(528, 300);
            this.specialtiesGridView.TabIndex = 14;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Ид";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // CodeColumn
            // 
            this.CodeColumn.DataPropertyName = "Code";
            this.CodeColumn.HeaderText = "Шифр";
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // SpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.updateButtonSpecialtiesForm);
            this.Controls.Add(this.editButtonSpecialtiesForm);
            this.Controls.Add(this.addButtonSpecialtiesForm);
            this.Controls.Add(this.specialtiesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SpecialtiesForm";
            this.Text = "SpecialtiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButtonSpecialtiesForm;
        private System.Windows.Forms.Button editButtonSpecialtiesForm;
        private System.Windows.Forms.Button addButtonSpecialtiesForm;
        private System.Windows.Forms.DataGridView specialtiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    }
}