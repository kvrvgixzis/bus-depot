namespace bus_depot
{
    partial class AddRoute
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
            this.numberInput = new System.Windows.Forms.MaskedTextBox();
            this.stPointInput = new System.Windows.Forms.MaskedTextBox();
            this.endPointInput = new System.Windows.Forms.MaskedTextBox();
            this.stTimeInpuut = new System.Windows.Forms.MaskedTextBox();
            this.endTimeInput = new System.Windows.Forms.MaskedTextBox();
            this.intervalInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addRouteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(139, 12);
            this.numberInput.Mask = "000";
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(184, 22);
            this.numberInput.TabIndex = 0;
            // 
            // stPointInput
            // 
            this.stPointInput.Location = new System.Drawing.Point(139, 40);
            this.stPointInput.Name = "stPointInput";
            this.stPointInput.Size = new System.Drawing.Size(184, 22);
            this.stPointInput.TabIndex = 1;
            // 
            // endPointInput
            // 
            this.endPointInput.Location = new System.Drawing.Point(139, 68);
            this.endPointInput.Name = "endPointInput";
            this.endPointInput.Size = new System.Drawing.Size(184, 22);
            this.endPointInput.TabIndex = 2;
            // 
            // stTimeInpuut
            // 
            this.stTimeInpuut.Location = new System.Drawing.Point(139, 96);
            this.stTimeInpuut.Mask = "00:00";
            this.stTimeInpuut.Name = "stTimeInpuut";
            this.stTimeInpuut.Size = new System.Drawing.Size(184, 22);
            this.stTimeInpuut.TabIndex = 3;
            this.stTimeInpuut.ValidatingType = typeof(System.DateTime);
            // 
            // endTimeInput
            // 
            this.endTimeInput.Location = new System.Drawing.Point(139, 124);
            this.endTimeInput.Mask = "00:00";
            this.endTimeInput.Name = "endTimeInput";
            this.endTimeInput.Size = new System.Drawing.Size(184, 22);
            this.endTimeInput.TabIndex = 4;
            this.endTimeInput.ValidatingType = typeof(System.DateTime);
            // 
            // intervalInput
            // 
            this.intervalInput.Location = new System.Drawing.Point(139, 152);
            this.intervalInput.Mask = "00";
            this.intervalInput.Name = "intervalInput";
            this.intervalInput.Size = new System.Drawing.Size(184, 22);
            this.intervalInput.TabIndex = 5;
            this.intervalInput.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер машрута:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Начальный пункт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Конечный пункт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Начало движения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Конец движения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Интервал (мин):";
            // 
            // addRouteBtn
            // 
            this.addRouteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRouteBtn.Location = new System.Drawing.Point(16, 180);
            this.addRouteBtn.Name = "addRouteBtn";
            this.addRouteBtn.Size = new System.Drawing.Size(307, 23);
            this.addRouteBtn.TabIndex = 12;
            this.addRouteBtn.Text = "Добавить";
            this.addRouteBtn.UseVisualStyleBackColor = true;
            this.addRouteBtn.Click += new System.EventHandler(this.addRouteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(16, 209);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(307, 23);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "Отмена";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 240);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addRouteBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalInput);
            this.Controls.Add(this.endTimeInput);
            this.Controls.Add(this.stTimeInpuut);
            this.Controls.Add(this.endPointInput);
            this.Controls.Add(this.stPointInput);
            this.Controls.Add(this.numberInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 275);
            this.Name = "addRoute";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить автобус";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox numberInput;
        private System.Windows.Forms.MaskedTextBox stPointInput;
        private System.Windows.Forms.MaskedTextBox endPointInput;
        private System.Windows.Forms.MaskedTextBox stTimeInpuut;
        private System.Windows.Forms.MaskedTextBox endTimeInput;
        private System.Windows.Forms.MaskedTextBox intervalInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addRouteBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}