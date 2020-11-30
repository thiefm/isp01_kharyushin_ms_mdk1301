namespace WindowsFormsApp5
{
    partial class Form1
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
            this.showSpecialtyButton = new System.Windows.Forms.Button();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.showGroupsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showSpecialtyButton
            // 
            this.showSpecialtyButton.Location = new System.Drawing.Point(12, 47);
            this.showSpecialtyButton.Name = "showSpecialtyButton";
            this.showSpecialtyButton.Size = new System.Drawing.Size(127, 35);
            this.showSpecialtyButton.TabIndex = 0;
            this.showSpecialtyButton.Text = "Специальности";
            this.showSpecialtyButton.UseVisualStyleBackColor = true;
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.Location = new System.Drawing.Point(163, 47);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(127, 35);
            this.showStudentsButton.TabIndex = 1;
            this.showStudentsButton.Text = "Студенты";
            this.showStudentsButton.UseVisualStyleBackColor = true;
            // 
            // showGroupsButton
            // 
            this.showGroupsButton.Location = new System.Drawing.Point(314, 47);
            this.showGroupsButton.Name = "showGroupsButton";
            this.showGroupsButton.Size = new System.Drawing.Size(127, 35);
            this.showGroupsButton.TabIndex = 2;
            this.showGroupsButton.Text = "Группы";
            this.showGroupsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 130);
            this.Controls.Add(this.showGroupsButton);
            this.Controls.Add(this.showStudentsButton);
            this.Controls.Add(this.showSpecialtyButton);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showSpecialtyButton;
        private System.Windows.Forms.Button showStudentsButton;
        private System.Windows.Forms.Button showGroupsButton;
    }
}

