namespace WindowsFormsApp6
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsButtonMainForm = new System.Windows.Forms.Button();
            this.groupsButtonMainForm = new System.Windows.Forms.Button();
            this.specialtiesButtonMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsButtonMainForm
            // 
            this.studentsButtonMainForm.Location = new System.Drawing.Point(12, 34);
            this.studentsButtonMainForm.Name = "studentsButtonMainForm";
            this.studentsButtonMainForm.Size = new System.Drawing.Size(108, 23);
            this.studentsButtonMainForm.TabIndex = 0;
            this.studentsButtonMainForm.Text = "Студенты";
            this.studentsButtonMainForm.UseVisualStyleBackColor = true;
            // 
            // groupsButtonMainForm
            // 
            this.groupsButtonMainForm.Location = new System.Drawing.Point(126, 34);
            this.groupsButtonMainForm.Name = "groupsButtonMainForm";
            this.groupsButtonMainForm.Size = new System.Drawing.Size(111, 23);
            this.groupsButtonMainForm.TabIndex = 1;
            this.groupsButtonMainForm.Text = "Группы";
            this.groupsButtonMainForm.UseVisualStyleBackColor = true;
            // 
            // specialtiesButtonMainForm
            // 
            this.specialtiesButtonMainForm.Location = new System.Drawing.Point(243, 34);
            this.specialtiesButtonMainForm.Name = "specialtiesButtonMainForm";
            this.specialtiesButtonMainForm.Size = new System.Drawing.Size(99, 23);
            this.specialtiesButtonMainForm.TabIndex = 2;
            this.specialtiesButtonMainForm.Text = "Специальности";
            this.specialtiesButtonMainForm.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 90);
            this.Controls.Add(this.specialtiesButtonMainForm);
            this.Controls.Add(this.groupsButtonMainForm);
            this.Controls.Add(this.studentsButtonMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentsButtonMainForm;
        private System.Windows.Forms.Button groupsButtonMainForm;
        private System.Windows.Forms.Button specialtiesButtonMainForm;
    }
}

