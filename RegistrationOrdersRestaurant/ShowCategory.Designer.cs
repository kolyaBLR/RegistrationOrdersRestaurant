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
            this.CloseBox = new System.Windows.Forms.Button();
            this.AddBox = new System.Windows.Forms.Button();
            this.CategoryGrid = new System.Windows.Forms.DataGridView();
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
            // CloseBox
            // 
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseBox.Location = new System.Drawing.Point(3, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(180, 37);
            this.CloseBox.TabIndex = 0;
            this.CloseBox.Text = "Отмена";
            this.CloseBox.UseVisualStyleBackColor = true;
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
            // 
            // CategoryGrid
            // 
            this.CategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryGrid.Location = new System.Drawing.Point(0, 0);
            this.CategoryGrid.Name = "CategoryGrid";
            this.CategoryGrid.Size = new System.Drawing.Size(372, 239);
            this.CategoryGrid.TabIndex = 1;
            // 
            // ShowCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 282);
            this.Controls.Add(this.CategoryGrid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowCategory";
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
    }
}