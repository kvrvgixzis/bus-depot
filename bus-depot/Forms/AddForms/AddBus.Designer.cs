namespace bus_depot
{
    partial class AddBus
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
            this.typeInput = new System.Windows.Forms.ComboBox();
            this.capacityInput = new System.Windows.Forms.MaskedTextBox();
            this.isWorkingInput = new System.Windows.Forms.ComboBox();
            this.addBusBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(126, 12);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(197, 20);
            this.numberInput.TabIndex = 0;
            // 
            // typeInput
            // 
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Items.AddRange(new object[] {
            "Автолайн",
            "Автобус",
            "Гармошка",
            "Большой автобус"});
            this.typeInput.Location = new System.Drawing.Point(126, 39);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(197, 21);
            this.typeInput.TabIndex = 1;
            // 
            // capacityInput
            // 
            this.capacityInput.Location = new System.Drawing.Point(126, 66);
            this.capacityInput.Name = "capacityInput";
            this.capacityInput.Size = new System.Drawing.Size(197, 20);
            this.capacityInput.TabIndex = 2;
            // 
            // isWorkingInput
            // 
            this.isWorkingInput.FormattingEnabled = true;
            this.isWorkingInput.Items.AddRange(new object[] {
            "Работает",
            "Не работает"});
            this.isWorkingInput.Location = new System.Drawing.Point(126, 92);
            this.isWorkingInput.Name = "isWorkingInput";
            this.isWorkingInput.Size = new System.Drawing.Size(197, 21);
            this.isWorkingInput.TabIndex = 3;
            // 
            // addBusBtn
            // 
            this.addBusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBusBtn.Location = new System.Drawing.Point(12, 120);
            this.addBusBtn.Name = "addBusBtn";
            this.addBusBtn.Size = new System.Drawing.Size(311, 23);
            this.addBusBtn.TabIndex = 4;
            this.addBusBtn.Text = "Добавить";
            this.addBusBtn.UseVisualStyleBackColor = true;
            this.addBusBtn.Click += new System.EventHandler(this.addBusBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(12, 149);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(311, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Отмена";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер автобуса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип автобуса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вместительность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Состояние:";
            // 
            // AddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addBusBtn);
            this.Controls.Add(this.isWorkingInput);
            this.Controls.Add(this.capacityInput);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.numberInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 220);
            this.Name = "AddBus";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить автобус";
            this.Load += new System.EventHandler(this.AddBus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox numberInput;
        private System.Windows.Forms.ComboBox typeInput;
        private System.Windows.Forms.MaskedTextBox capacityInput;
        private System.Windows.Forms.ComboBox isWorkingInput;
        private System.Windows.Forms.Button addBusBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}