namespace NOD6
{
    partial class FormAddEmployee
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
            label_FormAE_LastName = new Label();
            label_FormAE_FirsName = new Label();
            label_FormAE_Patronymic = new Label();
            textBox_FormAE_LastName = new TextBox();
            textBox_FormAE_FirsName = new TextBox();
            textBox_FormAE_Patronymic = new TextBox();
            button_FormAE = new Button();
            SuspendLayout();
            // 
            // label_FormAE_LastName
            // 
            label_FormAE_LastName.AutoSize = true;
            label_FormAE_LastName.Location = new Point(50, 70);
            label_FormAE_LastName.Name = "label_FormAE_LastName";
            label_FormAE_LastName.Size = new Size(58, 15);
            label_FormAE_LastName.TabIndex = 1;
            label_FormAE_LastName.Text = "Фамилия";
            // 
            // label_FormAE_FirsName
            // 
            label_FormAE_FirsName.AutoSize = true;
            label_FormAE_FirsName.Location = new Point(50, 157);
            label_FormAE_FirsName.Name = "label_FormAE_FirsName";
            label_FormAE_FirsName.Size = new Size(31, 15);
            label_FormAE_FirsName.TabIndex = 2;
            label_FormAE_FirsName.Text = "Имя";
            // 
            // label_FormAE_Patronymic
            // 
            label_FormAE_Patronymic.AutoSize = true;
            label_FormAE_Patronymic.Location = new Point(50, 244);
            label_FormAE_Patronymic.Name = "label_FormAE_Patronymic";
            label_FormAE_Patronymic.Size = new Size(58, 15);
            label_FormAE_Patronymic.TabIndex = 3;
            label_FormAE_Patronymic.Text = "Отчество";
            // 
            // textBox_FormAE_LastName
            // 
            textBox_FormAE_LastName.Location = new Point(214, 67);
            textBox_FormAE_LastName.Name = "textBox_FormAE_LastName";
            textBox_FormAE_LastName.Size = new Size(199, 23);
            textBox_FormAE_LastName.TabIndex = 4;
            // 
            // textBox_FormAE_FirsName
            // 
            textBox_FormAE_FirsName.Location = new Point(214, 154);
            textBox_FormAE_FirsName.Name = "textBox_FormAE_FirsName";
            textBox_FormAE_FirsName.Size = new Size(199, 23);
            textBox_FormAE_FirsName.TabIndex = 5;
            // 
            // textBox_FormAE_Patronymic
            // 
            textBox_FormAE_Patronymic.Location = new Point(214, 241);
            textBox_FormAE_Patronymic.Name = "textBox_FormAE_Patronymic";
            textBox_FormAE_Patronymic.Size = new Size(202, 23);
            textBox_FormAE_Patronymic.TabIndex = 6;
            // 
            // button_FormAE
            // 
            button_FormAE.Location = new Point(184, 335);
            button_FormAE.Name = "button_FormAE";
            button_FormAE.Size = new Size(110, 34);
            button_FormAE.TabIndex = 7;
            button_FormAE.Text = "Сохранить";
            button_FormAE.UseVisualStyleBackColor = true;
            button_FormAE.Click += button_FormAE_Click;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 450);
            Controls.Add(textBox_FormAE_LastName);
            Controls.Add(textBox_FormAE_FirsName);
            Controls.Add(label_FormAE_LastName);
            Controls.Add(button_FormAE);
            Controls.Add(textBox_FormAE_Patronymic);
            Controls.Add(label_FormAE_Patronymic);
            Controls.Add(label_FormAE_FirsName);
            Name = "FormAddEmployee";
            Text = "Добавить работника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label label1;
        private Label label_FormAE_FirsName;
        private Label label_FormAE_Patronymic;
        private Label label_FormAE_LastName;
        private TextBox textBox_FormAE_Patronymic;
        private TextBox textBox_FormAE_FirsName;
        private TextBox textBox_FormAE_LastName;
        private Button button_FormAE;
    }
}