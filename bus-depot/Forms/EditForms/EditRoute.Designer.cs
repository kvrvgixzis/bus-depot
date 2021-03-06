﻿namespace bus_depot.EditForms
{
    partial class EditRoute
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveRouteBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalInput = new System.Windows.Forms.MaskedTextBox();
            this.endTimeInput = new System.Windows.Forms.MaskedTextBox();
            this.stTimeInpuut = new System.Windows.Forms.MaskedTextBox();
            this.endPointInput = new System.Windows.Forms.MaskedTextBox();
            this.stPointInput = new System.Windows.Forms.MaskedTextBox();
            this.numberInput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(15, 203);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(307, 23);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.Text = "Отмена";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveRouteBtn
            // 
            this.saveRouteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRouteBtn.Location = new System.Drawing.Point(15, 174);
            this.saveRouteBtn.Name = "saveRouteBtn";
            this.saveRouteBtn.Size = new System.Drawing.Size(307, 23);
            this.saveRouteBtn.TabIndex = 26;
            this.saveRouteBtn.Text = "Сохранить";
            this.saveRouteBtn.UseVisualStyleBackColor = true;
            this.saveRouteBtn.Click += new System.EventHandler(this.saveRouteBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Интервал (мин):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Конец движения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Начало движения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Конечный пункт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Начальный пункт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Номер машрута:";
            // 
            // intervalInput
            // 
            this.intervalInput.Location = new System.Drawing.Point(138, 146);
            this.intervalInput.Mask = "00";
            this.intervalInput.Name = "intervalInput";
            this.intervalInput.Size = new System.Drawing.Size(184, 20);
            this.intervalInput.TabIndex = 19;
            this.intervalInput.ValidatingType = typeof(int);
            // 
            // endTimeInput
            // 
            this.endTimeInput.Location = new System.Drawing.Point(138, 118);
            this.endTimeInput.Mask = "00:00";
            this.endTimeInput.Name = "endTimeInput";
            this.endTimeInput.Size = new System.Drawing.Size(184, 20);
            this.endTimeInput.TabIndex = 18;
            this.endTimeInput.ValidatingType = typeof(System.DateTime);
            // 
            // stTimeInpuut
            // 
            this.stTimeInpuut.Location = new System.Drawing.Point(138, 90);
            this.stTimeInpuut.Mask = "00:00";
            this.stTimeInpuut.Name = "stTimeInpuut";
            this.stTimeInpuut.Size = new System.Drawing.Size(184, 20);
            this.stTimeInpuut.TabIndex = 17;
            this.stTimeInpuut.ValidatingType = typeof(System.DateTime);
            // 
            // endPointInput
            // 
            this.endPointInput.Location = new System.Drawing.Point(138, 62);
            this.endPointInput.Name = "endPointInput";
            this.endPointInput.Size = new System.Drawing.Size(184, 20);
            this.endPointInput.TabIndex = 16;
            // 
            // stPointInput
            // 
            this.stPointInput.Location = new System.Drawing.Point(138, 34);
            this.stPointInput.Name = "stPointInput";
            this.stPointInput.Size = new System.Drawing.Size(184, 20);
            this.stPointInput.TabIndex = 15;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(138, 6);
            this.numberInput.Mask = "000";
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(184, 20);
            this.numberInput.TabIndex = 14;
            // 
            // EditRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 236);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveRouteBtn);
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
            this.Name = "EditRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRoute";
            this.Load += new System.EventHandler(this.EditRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveRouteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox intervalInput;
        private System.Windows.Forms.MaskedTextBox endTimeInput;
        private System.Windows.Forms.MaskedTextBox stTimeInpuut;
        private System.Windows.Forms.MaskedTextBox endPointInput;
        private System.Windows.Forms.MaskedTextBox stPointInput;
        private System.Windows.Forms.MaskedTextBox numberInput;
    }
}