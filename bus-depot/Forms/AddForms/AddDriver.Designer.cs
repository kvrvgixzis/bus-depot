namespace bus_depot
{
    partial class AddDriver
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
            this.GradeInput = new System.Windows.Forms.ComboBox();
            this.LastNameInput = new System.Windows.Forms.MaskedTextBox();
            this.NameInput = new System.Windows.Forms.MaskedTextBox();
            this.PatronymicInput = new System.Windows.Forms.MaskedTextBox();
            this.ExpInput = new System.Windows.Forms.MaskedTextBox();
            this.BusInput = new System.Windows.Forms.ComboBox();
            this.RouteInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MonCheck = new System.Windows.Forms.CheckBox();
            this.TuesCheck = new System.Windows.Forms.CheckBox();
            this.WedCheck = new System.Windows.Forms.CheckBox();
            this.ThursCheck = new System.Windows.Forms.CheckBox();
            this.FriCheck = new System.Windows.Forms.CheckBox();
            this.SatCheck = new System.Windows.Forms.CheckBox();
            this.SunCheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addDriverBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GradeInput
            // 
            this.GradeInput.FormattingEnabled = true;
            this.GradeInput.Items.AddRange(new object[] {
            "1 класс",
            "2 класс",
            "3 класс"});
            this.GradeInput.Location = new System.Drawing.Point(114, 96);
            this.GradeInput.Name = "GradeInput";
            this.GradeInput.Size = new System.Drawing.Size(305, 21);
            this.GradeInput.Sorted = true;
            this.GradeInput.TabIndex = 0;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(114, 12);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(305, 22);
            this.LastNameInput.TabIndex = 1;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(114, 40);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(305, 22);
            this.NameInput.TabIndex = 2;
            // 
            // PatronymicInput
            // 
            this.PatronymicInput.Location = new System.Drawing.Point(114, 68);
            this.PatronymicInput.Name = "PatronymicInput";
            this.PatronymicInput.Size = new System.Drawing.Size(305, 22);
            this.PatronymicInput.TabIndex = 3;
            // 
            // ExpInput
            // 
            this.ExpInput.Location = new System.Drawing.Point(114, 123);
            this.ExpInput.Mask = "00";
            this.ExpInput.Name = "ExpInput";
            this.ExpInput.Size = new System.Drawing.Size(305, 22);
            this.ExpInput.TabIndex = 4;
            // 
            // BusInput
            // 
            this.BusInput.FormattingEnabled = true;
            this.BusInput.Location = new System.Drawing.Point(114, 151);
            this.BusInput.Name = "BusInput";
            this.BusInput.Size = new System.Drawing.Size(305, 21);
            this.BusInput.TabIndex = 6;
            // 
            // RouteInput
            // 
            this.RouteInput.FormattingEnabled = true;
            this.RouteInput.Location = new System.Drawing.Point(114, 178);
            this.RouteInput.Name = "RouteInput";
            this.RouteInput.Size = new System.Drawing.Size(305, 21);
            this.RouteInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Класс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Стаж: [лет]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Автобус:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Маршрут:";
            // 
            // MonCheck
            // 
            this.MonCheck.AutoSize = true;
            this.MonCheck.Location = new System.Drawing.Point(114, 206);
            this.MonCheck.Name = "MonCheck";
            this.MonCheck.Size = new System.Drawing.Size(41, 17);
            this.MonCheck.TabIndex = 16;
            this.MonCheck.Text = "Пн";
            this.MonCheck.UseVisualStyleBackColor = true;
            // 
            // TuesCheck
            // 
            this.TuesCheck.AutoSize = true;
            this.TuesCheck.Location = new System.Drawing.Point(160, 206);
            this.TuesCheck.Name = "TuesCheck";
            this.TuesCheck.Size = new System.Drawing.Size(38, 17);
            this.TuesCheck.TabIndex = 17;
            this.TuesCheck.Text = "Вт";
            this.TuesCheck.UseVisualStyleBackColor = true;
            // 
            // WedCheck
            // 
            this.WedCheck.AutoSize = true;
            this.WedCheck.Location = new System.Drawing.Point(203, 206);
            this.WedCheck.Name = "WedCheck";
            this.WedCheck.Size = new System.Drawing.Size(40, 17);
            this.WedCheck.TabIndex = 18;
            this.WedCheck.Text = "Ср";
            this.WedCheck.UseVisualStyleBackColor = true;
            // 
            // ThursCheck
            // 
            this.ThursCheck.AutoSize = true;
            this.ThursCheck.Location = new System.Drawing.Point(248, 206);
            this.ThursCheck.Name = "ThursCheck";
            this.ThursCheck.Size = new System.Drawing.Size(39, 17);
            this.ThursCheck.TabIndex = 19;
            this.ThursCheck.Text = "Чт";
            this.ThursCheck.UseVisualStyleBackColor = true;
            // 
            // FriCheck
            // 
            this.FriCheck.AutoSize = true;
            this.FriCheck.Location = new System.Drawing.Point(292, 206);
            this.FriCheck.Name = "FriCheck";
            this.FriCheck.Size = new System.Drawing.Size(39, 17);
            this.FriCheck.TabIndex = 20;
            this.FriCheck.Text = "Пт";
            this.FriCheck.UseVisualStyleBackColor = true;
            // 
            // SatCheck
            // 
            this.SatCheck.AutoSize = true;
            this.SatCheck.Location = new System.Drawing.Point(336, 206);
            this.SatCheck.Name = "SatCheck";
            this.SatCheck.Size = new System.Drawing.Size(40, 17);
            this.SatCheck.TabIndex = 21;
            this.SatCheck.Text = "Сб";
            this.SatCheck.UseVisualStyleBackColor = true;
            // 
            // SunCheck
            // 
            this.SunCheck.AutoSize = true;
            this.SunCheck.Location = new System.Drawing.Point(381, 206);
            this.SunCheck.Name = "SunCheck";
            this.SunCheck.Size = new System.Drawing.Size(38, 17);
            this.SunCheck.TabIndex = 22;
            this.SunCheck.Text = "Вс";
            this.SunCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Рабочий график:";
            // 
            // addDriverBtn
            // 
            this.addDriverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDriverBtn.Location = new System.Drawing.Point(15, 257);
            this.addDriverBtn.Name = "addDriverBtn";
            this.addDriverBtn.Size = new System.Drawing.Size(404, 23);
            this.addDriverBtn.TabIndex = 24;
            this.addDriverBtn.Text = "Добавить";
            this.addDriverBtn.UseVisualStyleBackColor = true;
            this.addDriverBtn.Click += new System.EventHandler(this.addDriverBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(15, 286);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(404, 23);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "Отмена";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 318);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addDriverBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SunCheck);
            this.Controls.Add(this.SatCheck);
            this.Controls.Add(this.FriCheck);
            this.Controls.Add(this.ThursCheck);
            this.Controls.Add(this.WedCheck);
            this.Controls.Add(this.TuesCheck);
            this.Controls.Add(this.MonCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteInput);
            this.Controls.Add(this.BusInput);
            this.Controls.Add(this.ExpInput);
            this.Controls.Add(this.PatronymicInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.GradeInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 353);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 353);
            this.Name = "AddDriver";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить водителя";
            this.Load += new System.EventHandler(this.AddDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GradeInput;
        private System.Windows.Forms.MaskedTextBox LastNameInput;
        private System.Windows.Forms.MaskedTextBox NameInput;
        private System.Windows.Forms.MaskedTextBox PatronymicInput;
        private System.Windows.Forms.MaskedTextBox ExpInput;
        private System.Windows.Forms.ComboBox BusInput;
        private System.Windows.Forms.ComboBox RouteInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox MonCheck;
        private System.Windows.Forms.CheckBox TuesCheck;
        private System.Windows.Forms.CheckBox WedCheck;
        private System.Windows.Forms.CheckBox ThursCheck;
        private System.Windows.Forms.CheckBox FriCheck;
        private System.Windows.Forms.CheckBox SatCheck;
        private System.Windows.Forms.CheckBox SunCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addDriverBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}