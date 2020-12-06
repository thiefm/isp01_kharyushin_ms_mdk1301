namespace WindowsFormsApp6.Views
{
    partial class GroupsForm
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
            this.editButtonGroupsForm = new System.Windows.Forms.Button();
            this.addButtonGroupsForm = new System.Windows.Forms.Button();
            this.groupsGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCreationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButtonGroupsForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editButtonGroupsForm
            // 
            this.editButtonGroupsForm.Location = new System.Drawing.Point(465, 333);
            this.editButtonGroupsForm.Name = "editButtonGroupsForm";
            this.editButtonGroupsForm.Size = new System.Drawing.Size(75, 23);
            this.editButtonGroupsForm.TabIndex = 12;
            this.editButtonGroupsForm.Text = "Изменить";
            this.editButtonGroupsForm.UseVisualStyleBackColor = true;
            // 
            // addButtonGroupsForm
            // 
            this.addButtonGroupsForm.Location = new System.Drawing.Point(12, 333);
            this.addButtonGroupsForm.Name = "addButtonGroupsForm";
            this.addButtonGroupsForm.Size = new System.Drawing.Size(75, 23);
            this.addButtonGroupsForm.TabIndex = 11;
            this.addButtonGroupsForm.Text = "Добавить";
            this.addButtonGroupsForm.UseVisualStyleBackColor = true;
            // 
            // groupsGridView
            // 
            this.groupsGridView.AllowUserToAddRows = false;
            this.groupsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.YearCreationColumn,
            this.SpecialtyColumn});
            this.groupsGridView.Location = new System.Drawing.Point(12, 12);
            this.groupsGridView.MultiSelect = false;
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.ReadOnly = true;
            this.groupsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsGridView.Size = new System.Drawing.Size(528, 300);
            this.groupsGridView.TabIndex = 10;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Ид";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // YearCreationColumn
            // 
            this.YearCreationColumn.DataPropertyName = "YearCreation";
            this.YearCreationColumn.HeaderText = "Дата создания";
            this.YearCreationColumn.Name = "YearCreationColumn";
            this.YearCreationColumn.ReadOnly = true;
            // 
            // SpecialtyColumn
            // 
            this.SpecialtyColumn.DataPropertyName = "Specialty";
            this.SpecialtyColumn.HeaderText = "Специальность";
            this.SpecialtyColumn.Name = "SpecialtyColumn";
            this.SpecialtyColumn.ReadOnly = true;
            // 
            // updateButtonGroupsForm
            // 
            this.updateButtonGroupsForm.Location = new System.Drawing.Point(234, 333);
            this.updateButtonGroupsForm.Name = "updateButtonGroupsForm";
            this.updateButtonGroupsForm.Size = new System.Drawing.Size(75, 23);
            this.updateButtonGroupsForm.TabIndex = 13;
            this.updateButtonGroupsForm.Text = "Обновить";
            this.updateButtonGroupsForm.UseVisualStyleBackColor = true;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.updateButtonGroupsForm);
            this.Controls.Add(this.editButtonGroupsForm);
            this.Controls.Add(this.addButtonGroupsForm);
            this.Controls.Add(this.groupsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editButtonGroupsForm;
        private System.Windows.Forms.Button addButtonGroupsForm;
        private System.Windows.Forms.DataGridView groupsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCreationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyColumn;
        private System.Windows.Forms.Button updateButtonGroupsForm;
    }
}