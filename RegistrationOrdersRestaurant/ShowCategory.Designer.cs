namespace RegistrationOrdersRestaurant
{
    partial class ShowCategory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddBox = new System.Windows.Forms.Button();
            this.CloseBox = new System.Windows.Forms.Button();
            this.CategoryGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 239);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddBox
            // 
            this.AddBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBox.Location = new System.Drawing.Point(189, 3);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(180, 37);
            this.AddBox.TabIndex = 1;
            this.AddBox.Text = "Добавить";
            this.AddBox.UseVisualStyleBackColor = true;
            this.AddBox.Click += new System.EventHandler(this.AddBox_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseBox.Location = new System.Drawing.Point(3, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(180, 37);
            this.CloseBox.TabIndex = 0;
            this.CloseBox.Text = "Отмена";
            this.CloseBox.UseVisualStyleBackColor = true;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // CategoryGrid
            // 
            this.CategoryGrid.AllowUserToAddRows = false;
            this.CategoryGrid.AllowUserToDeleteRows = false;
            this.CategoryGrid.AllowUserToResizeRows = false;
            this.CategoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.CategoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CategoryGrid.Location = new System.Drawing.Point(0, 0);
            this.CategoryGrid.Name = "CategoryGrid";
            this.CategoryGrid.ReadOnly = true;
            this.CategoryGrid.Size = new System.Drawing.Size(372, 239);
            this.CategoryGrid.TabIndex = 4;
            this.CategoryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGrid_CellClick);
            this.CategoryGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGrid_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ShowCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 282);
            this.Controls.Add(this.CategoryGrid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowCategory";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddBox;
        private System.Windows.Forms.Button CloseBox;
        private System.Windows.Forms.DataGridView CategoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}