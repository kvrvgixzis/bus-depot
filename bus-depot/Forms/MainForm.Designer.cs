namespace bus_depot
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Table = new System.Windows.Forms.DataGridView();
            this.ShowBusesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ShowDriversBtn = new System.Windows.Forms.Button();
            this.AddNewElementBtn = new System.Windows.Forms.Button();
            this.ShowRoutesBtn = new System.Windows.Forms.Button();
            this.deleteSelectedBtn = new System.Windows.Forms.Button();
            this.ReloginBtn = new System.Windows.Forms.Button();
            this.editSelectBtn = new System.Windows.Forms.Button();
            this.showReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Table.ColumnHeadersHeight = 40;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Table.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle13;
            this.Table.Location = new System.Drawing.Point(12, 51);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.Table.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Table.RowTemplate.Height = 34;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.ShowEditingIcon = false;
            this.Table.Size = new System.Drawing.Size(630, 305);
            this.Table.TabIndex = 1;
            // 
            // ShowBusesBtn
            // 
            this.ShowBusesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBusesBtn.Location = new System.Drawing.Point(12, 13);
            this.ShowBusesBtn.Name = "ShowBusesBtn";
            this.ShowBusesBtn.Size = new System.Drawing.Size(206, 32);
            this.ShowBusesBtn.TabIndex = 0;
            this.ShowBusesBtn.Text = "Автобусы";
            this.ShowBusesBtn.UseVisualStyleBackColor = true;
            this.ShowBusesBtn.Click += new System.EventHandler(this.ShowBusesBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(436, 400);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(206, 32);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ShowDriversBtn
            // 
            this.ShowDriversBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDriversBtn.Location = new System.Drawing.Point(224, 13);
            this.ShowDriversBtn.Name = "ShowDriversBtn";
            this.ShowDriversBtn.Size = new System.Drawing.Size(206, 32);
            this.ShowDriversBtn.TabIndex = 1;
            this.ShowDriversBtn.Text = "Водители";
            this.ShowDriversBtn.UseVisualStyleBackColor = true;
            this.ShowDriversBtn.Click += new System.EventHandler(this.ShowDriversBtn_Click);
            // 
            // AddNewElementBtn
            // 
            this.AddNewElementBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewElementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewElementBtn.Location = new System.Drawing.Point(12, 362);
            this.AddNewElementBtn.Name = "AddNewElementBtn";
            this.AddNewElementBtn.Size = new System.Drawing.Size(321, 32);
            this.AddNewElementBtn.TabIndex = 4;
            this.AddNewElementBtn.Text = "Новый автобус";
            this.AddNewElementBtn.UseVisualStyleBackColor = true;
            this.AddNewElementBtn.Click += new System.EventHandler(this.AddNewElementBtn_Click);
            // 
            // ShowRoutesBtn
            // 
            this.ShowRoutesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRoutesBtn.Location = new System.Drawing.Point(436, 13);
            this.ShowRoutesBtn.Name = "ShowRoutesBtn";
            this.ShowRoutesBtn.Size = new System.Drawing.Size(206, 32);
            this.ShowRoutesBtn.TabIndex = 2;
            this.ShowRoutesBtn.Text = "Маршруты";
            this.ShowRoutesBtn.UseVisualStyleBackColor = true;
            this.ShowRoutesBtn.Click += new System.EventHandler(this.ShowRoutesBtn_Click);
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedBtn.Location = new System.Drawing.Point(12, 400);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(164, 32);
            this.deleteSelectedBtn.TabIndex = 5;
            this.deleteSelectedBtn.Text = "Удалить выделенное";
            this.deleteSelectedBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedBtn.Click += new System.EventHandler(this.deleteSelectedBtn_Click);
            // 
            // ReloginBtn
            // 
            this.ReloginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloginBtn.Location = new System.Drawing.Point(436, 362);
            this.ReloginBtn.Name = "ReloginBtn";
            this.ReloginBtn.Size = new System.Drawing.Size(206, 32);
            this.ReloginBtn.TabIndex = 6;
            this.ReloginBtn.Text = "Сменить пользователя";
            this.ReloginBtn.UseVisualStyleBackColor = true;
            this.ReloginBtn.Click += new System.EventHandler(this.ReloginBtn_Click);
            // 
            // editSelectBtn
            // 
            this.editSelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSelectBtn.Location = new System.Drawing.Point(182, 400);
            this.editSelectBtn.Name = "editSelectBtn";
            this.editSelectBtn.Size = new System.Drawing.Size(151, 32);
            this.editSelectBtn.TabIndex = 7;
            this.editSelectBtn.Text = "Изменить выделенное";
            this.editSelectBtn.UseVisualStyleBackColor = true;
            this.editSelectBtn.Click += new System.EventHandler(this.editSelectBtn_Click);
            // 
            // showReportBtn
            // 
            this.showReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReportBtn.Location = new System.Drawing.Point(339, 362);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(91, 70);
            this.showReportBtn.TabIndex = 8;
            this.showReportBtn.Text = "Отчет";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.showReportBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReloginBtn);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.editSelectBtn);
            this.Controls.Add(this.ShowBusesBtn);
            this.Controls.Add(this.deleteSelectedBtn);
            this.Controls.Add(this.ShowDriversBtn);
            this.Controls.Add(this.AddNewElementBtn);
            this.Controls.Add(this.ShowRoutesBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 486);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUS DEPOT TERMIANL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button ShowBusesBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ShowDriversBtn;
        private System.Windows.Forms.Button AddNewElementBtn;
        private System.Windows.Forms.Button ShowRoutesBtn;
        private System.Windows.Forms.Button deleteSelectedBtn;
        private System.Windows.Forms.Button ReloginBtn;
        private System.Windows.Forms.Button editSelectBtn;
        private System.Windows.Forms.Button showReportBtn;
    }
}