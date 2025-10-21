namespace NOD6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            ШЧ = new TabPage();
            Программы = new TabPage();
            НОД = new TabPage();
            Прочие = new TabPage();
            Станции = new TabPage();
            Расписание = new TabPage();
            ЦУП = new TabPage();
            ТЧ = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ШЧ);
            tabControl1.Controls.Add(Программы);
            tabControl1.Controls.Add(НОД);
            tabControl1.Controls.Add(Прочие);
            tabControl1.Controls.Add(Станции);
            tabControl1.Controls.Add(Расписание);
            tabControl1.Controls.Add(ЦУП);
            tabControl1.Controls.Add(ТЧ);
            tabControl1.Location = new Point(4, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 150);
            tabControl1.TabIndex = 0;
            // 
            // ШЧ
            // 
            ШЧ.Location = new Point(4, 24);
            ШЧ.Name = "ШЧ";
            ШЧ.Padding = new Padding(3);
            ШЧ.Size = new Size(786, 122);
            ШЧ.TabIndex = 0;
            ШЧ.Text = "ШЧ";
            ШЧ.UseVisualStyleBackColor = true;
            // 
            // Программы
            // 
            Программы.Location = new Point(4, 24);
            Программы.Name = "Программы";
            Программы.Padding = new Padding(3);
            Программы.Size = new Size(786, 122);
            Программы.TabIndex = 1;
            Программы.Text = "Программы";
            Программы.UseVisualStyleBackColor = true;
            // 
            // НОД
            // 
            НОД.Location = new Point(4, 24);
            НОД.Name = "НОД";
            НОД.Size = new Size(786, 122);
            НОД.TabIndex = 2;
            НОД.Text = "НОД";
            НОД.UseVisualStyleBackColor = true;
            // 
            // Прочие
            // 
            Прочие.Location = new Point(4, 24);
            Прочие.Name = "Прочие";
            Прочие.Size = new Size(786, 122);
            Прочие.TabIndex = 3;
            Прочие.Text = "Прочие";
            Прочие.UseVisualStyleBackColor = true;
            // 
            // Станции
            // 
            Станции.Location = new Point(4, 24);
            Станции.Name = "Станции";
            Станции.Size = new Size(786, 122);
            Станции.TabIndex = 4;
            Станции.Text = "Станции";
            Станции.UseVisualStyleBackColor = true;
            // 
            // Расписание
            // 
            Расписание.Location = new Point(4, 24);
            Расписание.Name = "Расписание";
            Расписание.Size = new Size(786, 122);
            Расписание.TabIndex = 5;
            Расписание.Text = "Расписание";
            Расписание.UseVisualStyleBackColor = true;
            // 
            // ЦУП
            // 
            ЦУП.Location = new Point(4, 24);
            ЦУП.Name = "ЦУП";
            ЦУП.Size = new Size(786, 122);
            ЦУП.TabIndex = 6;
            ЦУП.Text = "ЦУП";
            ЦУП.UseVisualStyleBackColor = true;
            // 
            // ТЧ
            // 
            ТЧ.Location = new Point(4, 24);
            ТЧ.Name = "ТЧ";
            ТЧ.Size = new Size(786, 122);
            ТЧ.TabIndex = 7;
            ТЧ.Text = "ТЧ";
            ТЧ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "ШНД";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ШЧ;
        private TabPage Программы;
        private TabPage НОД;
        private TabPage Прочие;
        private TabPage Станции;
        private TabPage Расписание;
        private TabPage ЦУП;
        private TabPage ТЧ;
    }
}
