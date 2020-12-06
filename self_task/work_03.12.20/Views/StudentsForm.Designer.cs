namespace WindowsFormsApp6.Views
{
    partial class StudentsForm
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
            this.editButtonStudentsForm = new System.Windows.Forms.Button();
            this.addButtonStudentsForm = new System.Windows.Forms.Button();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButtonStudentsForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editButtonStudentsForm
            // 
            this.editButtonStudentsForm.Location = new System.Drawing.Point(465, 333);
            this.editButtonStudentsForm.Name = "editButtonStudentsForm";
            this.editButtonStudentsForm.Size = new System.Drawing.Size(75, 23);
            this.editButtonStudentsForm.TabIndex = 9;
            this.editButtonStudentsForm.Text = "Изменить";
            this.editButtonStudentsForm.UseVisualStyleBackColor = true;
            // 
            // addButtonStudentsForm
            // 
            this.addButtonStudentsForm.Location = new System.Drawing.Point(12, 333);
            this.addButtonStudentsForm.Name = "addButtonStudentsForm";
            this.addButtonStudentsForm.Size = new System.Drawing.Size(75, 23);
            this.addButtonStudentsForm.TabIndex = 6;
            this.addButtonStudentsForm.Text = "Добавить";
            this.addButtonStudentsForm.UseVisualStyleBackColor = true;
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.FullNameColumn,
            this.GenderColumn,
            this.PhoneColumn,
            this.GroupColumn});
            this.studentsGridView.Location = new System.Drawing.Point(12, 12);
            this.studentsGridView.MultiSelect = false;
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.ReadOnly = true;
            this.studentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsGridView.Size = new System.Drawing.Size(528, 300);
            this.studentsGridView.TabIndex = 5;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Ид";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            this.FullNameColumn.HeaderText = "ФИО";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            // 
            // GenderColumn
            // 
            this.GenderColumn.DataPropertyName = "Gender";
            this.GenderColumn.HeaderText = "Пол";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.DataPropertyName = "Phone";
            this.PhoneColumn.HeaderText = "Телефон";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // GroupColumn
            // 
            this.GroupColumn.DataPropertyName = "Group";
            this.GroupColumn.HeaderText = "Группа";
            this.GroupColumn.Name = "GroupColumn";
            this.GroupColumn.ReadOnly = true;
            // 
            // updateButtonStudentsForm
            // 
            this.updateButtonStudentsForm.Location = new System.Drawing.Point(233, 333);
            this.updateButtonStudentsForm.Name = "updateButtonStudentsForm";
            this.updateButtonStudentsForm.Size = new System.Drawing.Size(75, 23);
            this.updateButtonStudentsForm.TabIndex = 10;
            this.updateButtonStudentsForm.Text = "Обновить";
            this.updateButtonStudentsForm.UseVisualStyleBackColor = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.updateButtonStudentsForm);
            this.Controls.Add(this.editButtonStudentsForm);
            this.Controls.Add(this.addButtonStudentsForm);
            this.Controls.Add(this.studentsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editButtonStudentsForm;
        private System.Windows.Forms.Button addButtonStudentsForm;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupColumn;
        private System.Windows.Forms.Button updateButtonStudentsForm;
    }
}