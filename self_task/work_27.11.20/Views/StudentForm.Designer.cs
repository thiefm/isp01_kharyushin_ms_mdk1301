namespace WindowsFormsApp5.Views
{
    partial class StudentForm
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
            this.updateButtonStudentForm = new System.Windows.Forms.Button();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButtonStudentForm
            // 
            this.updateButtonStudentForm.Location = new System.Drawing.Point(239, 271);
            this.updateButtonStudentForm.Name = "updateButtonStudentForm";
            this.updateButtonStudentForm.Size = new System.Drawing.Size(75, 23);
            this.updateButtonStudentForm.TabIndex = 3;
            this.updateButtonStudentForm.Text = "Обновить";
            this.updateButtonStudentForm.UseVisualStyleBackColor = true;
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.surnameColumn,
            this.groupColumn});
            this.studentGridView.Location = new System.Drawing.Point(12, 12);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(555, 253);
            this.studentGridView.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.Name = "nameColumn";
            // 
            // surnameColumn
            // 
            this.surnameColumn.DataPropertyName = "Surname";
            this.surnameColumn.HeaderText = "Фамилия";
            this.surnameColumn.Name = "surnameColumn";
            // 
            // groupColumn
            // 
            this.groupColumn.DataPropertyName = "Group";
            this.groupColumn.HeaderText = "Группа";
            this.groupColumn.Name = "groupColumn";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 306);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.updateButtonStudentForm);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButtonStudentForm;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupColumn;
    }
}