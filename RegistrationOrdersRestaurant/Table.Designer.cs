namespace RegistrationOrdersRestaurant
{
    partial class Table
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
            this.PriceGrid = new System.Windows.Forms.DataGridView();
            this.CloseBox = new System.Windows.Forms.Button();
            this.SaveBox = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SaveBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PriceGrid
            // 
            this.PriceGrid.AllowUserToAddRows = false;
            this.PriceGrid.AllowUserToDeleteRows = false;
            this.PriceGrid.AllowUserToResizeRows = false;
            this.PriceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PriceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceGrid.Location = new System.Drawing.Point(0, 0);
            this.PriceGrid.Name = "PriceGrid";
            this.PriceGrid.Size = new System.Drawing.Size(431, 237);
            this.PriceGrid.TabIndex = 5;
            // 
            // CloseBox
            // 
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseBox.Location = new System.Drawing.Point(3, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(209, 33);
            this.CloseBox.TabIndex = 0;
            this.CloseBox.Text = "Отмена";
            this.CloseBox.UseVisualStyleBackColor = true;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // SaveBox
            // 
            this.SaveBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBox.Location = new System.Drawing.Point(218, 3);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(210, 33);
            this.SaveBox.TabIndex = 1;
            this.SaveBox.Text = "Сохранить";
            this.SaveBox.UseVisualStyleBackColor = true;
            this.SaveBox.Click += new System.EventHandler(this.SaveBox_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 276);
            this.Controls.Add(this.PriceGrid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Table";
            this.Text = "Table";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView PriceGrid;
        private System.Windows.Forms.Button SaveBox;
        private System.Windows.Forms.Button CloseBox;
    }
}