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
            this.leftControlPanel = new System.Windows.Forms.Panel();
            this.Table = new System.Windows.Forms.DataGridView();
            this.ShowBusesBtn = new System.Windows.Forms.Button();
            this.ShowDriversBtn = new System.Windows.Forms.Button();
            this.ShowRoutesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddNewElementBtn = new System.Windows.Forms.Button();
            this.deleteSelectedBtn = new System.Windows.Forms.Button();
            this.leftControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // leftControlPanel
            // 
            this.leftControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftControlPanel.Controls.Add(this.deleteSelectedBtn);
            this.leftControlPanel.Controls.Add(this.ShowRoutesBtn);
            this.leftControlPanel.Controls.Add(this.AddNewElementBtn);
            this.leftControlPanel.Controls.Add(this.ShowDriversBtn);
            this.leftControlPanel.Controls.Add(this.ExitBtn);
            this.leftControlPanel.Controls.Add(this.ShowBusesBtn);
            this.leftControlPanel.Location = new System.Drawing.Point(2, 2);
            this.leftControlPanel.Name = "leftControlPanel";
            this.leftControlPanel.Size = new System.Drawing.Size(209, 447);
            this.leftControlPanel.TabIndex = 0;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(217, 127);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.RowTemplate.Height = 24;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.ShowEditingIcon = false;
            this.Table.Size = new System.Drawing.Size(571, 311);
            this.Table.TabIndex = 1;
            // 
            // ShowBusesBtn
            // 
            this.ShowBusesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowBusesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBusesBtn.Location = new System.Drawing.Point(3, 125);
            this.ShowBusesBtn.Name = "ShowBusesBtn";
            this.ShowBusesBtn.Size = new System.Drawing.Size(203, 32);
            this.ShowBusesBtn.TabIndex = 0;
            this.ShowBusesBtn.Text = "Buses";
            this.ShowBusesBtn.UseVisualStyleBackColor = true;
            this.ShowBusesBtn.Click += new System.EventHandler(this.ShowBusesBtn_Click);
            // 
            // ShowDriversBtn
            // 
            this.ShowDriversBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowDriversBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDriversBtn.Location = new System.Drawing.Point(3, 163);
            this.ShowDriversBtn.Name = "ShowDriversBtn";
            this.ShowDriversBtn.Size = new System.Drawing.Size(203, 32);
            this.ShowDriversBtn.TabIndex = 1;
            this.ShowDriversBtn.Text = "Drivers";
            this.ShowDriversBtn.UseVisualStyleBackColor = true;
            this.ShowDriversBtn.Click += new System.EventHandler(this.ShowDriversBtn_Click);
            // 
            // ShowRoutesBtn
            // 
            this.ShowRoutesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowRoutesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRoutesBtn.Location = new System.Drawing.Point(3, 201);
            this.ShowRoutesBtn.Name = "ShowRoutesBtn";
            this.ShowRoutesBtn.Size = new System.Drawing.Size(203, 32);
            this.ShowRoutesBtn.TabIndex = 2;
            this.ShowRoutesBtn.Text = "Routes";
            this.ShowRoutesBtn.UseVisualStyleBackColor = true;
            this.ShowRoutesBtn.Click += new System.EventHandler(this.ShowRoutesBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(3, 404);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(203, 32);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddNewElementBtn
            // 
            this.AddNewElementBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewElementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewElementBtn.Location = new System.Drawing.Point(3, 255);
            this.AddNewElementBtn.Name = "AddNewElementBtn";
            this.AddNewElementBtn.Size = new System.Drawing.Size(203, 32);
            this.AddNewElementBtn.TabIndex = 4;
            this.AddNewElementBtn.Text = "Add new bus";
            this.AddNewElementBtn.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedBtn.Location = new System.Drawing.Point(3, 293);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(203, 32);
            this.deleteSelectedBtn.TabIndex = 5;
            this.deleteSelectedBtn.Text = "Delete selected bus";
            this.deleteSelectedBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.leftControlPanel);
            this.MinimumSize = new System.Drawing.Size(816, 485);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "BUS DEPOT TERMIANL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftControlPanel;
        private System.Windows.Forms.Button AddNewElementBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ShowRoutesBtn;
        private System.Windows.Forms.Button ShowDriversBtn;
        private System.Windows.Forms.Button ShowBusesBtn;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button deleteSelectedBtn;
    }
}