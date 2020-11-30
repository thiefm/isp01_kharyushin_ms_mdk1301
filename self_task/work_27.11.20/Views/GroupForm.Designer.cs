namespace WindowsFormsApp5.Views
{
    partial class GroupForm
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
            this.updateButtonGroupForm = new System.Windows.Forms.Button();
            this.groupGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButtonGroupForm
            // 
            this.updateButtonGroupForm.Location = new System.Drawing.Point(201, 221);
            this.updateButtonGroupForm.Name = "updateButtonGroupForm";
            this.updateButtonGroupForm.Size = new System.Drawing.Size(75, 23);
            this.updateButtonGroupForm.TabIndex = 1;
            this.updateButtonGroupForm.Text = "Обновить";
            this.updateButtonGroupForm.UseVisualStyleBackColor = true;
            // 
            // groupGridView
            // 
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.yearColumn});
            this.groupGridView.Location = new System.Drawing.Point(12, 12);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.Size = new System.Drawing.Size(478, 203);
            this.groupGridView.TabIndex = 2;
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
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            // 
            // yearColumn
            // 
            this.yearColumn.DataPropertyName = "Year";
            this.yearColumn.HeaderText = "Год создания";
            this.yearColumn.Name = "yearColumn";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 256);
            this.Controls.Add(this.groupGridView);
            this.Controls.Add(this.updateButtonGroupForm);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button updateButtonGroupForm;
        private System.Windows.Forms.DataGridView groupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearColumn;
    }
}