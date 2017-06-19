namespace RegistrationOrdersRestaurant
{
    partial class PriceListForm
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
            this.PriceBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableDescription = new System.Windows.Forms.Label();
            this.TableBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CloseBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriceBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClientBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CloseBox
            // 
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBox.Location = new System.Drawing.Point(10, 231);
            this.CloseBox.Margin = new System.Windows.Forms.Padding(10);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(242, 37);
            this.CloseBox.TabIndex = 10;
            this.CloseBox.Text = "Отмена";
            this.CloseBox.UseVisualStyleBackColor = true;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // AddBox
            // 
            this.AddBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBox.Location = new System.Drawing.Point(272, 231);
            this.AddBox.Margin = new System.Windows.Forms.Padding(10);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(242, 37);
            this.AddBox.TabIndex = 9;
            this.AddBox.Text = "Купить";
            this.AddBox.UseVisualStyleBackColor = true;
            this.AddBox.Click += new System.EventHandler(this.AddBox_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.AutoSize = true;
            this.PriceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceBox.Location = new System.Drawing.Point(272, 176);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(10);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(242, 35);
            this.PriceBox.TabIndex = 5;
            this.PriceBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя покупателя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientBox
            // 
            this.ClientBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientBox.Location = new System.Drawing.Point(272, 10);
            this.ClientBox.Margin = new System.Windows.Forms.Padding(10);
            this.ClientBox.Multiline = true;
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(242, 35);
            this.ClientBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = "Столик";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TableDescription);
            this.panel1.Controls.Add(this.TableBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(265, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 105);
            this.panel1.TabIndex = 11;
            // 
            // TableDescription
            // 
            this.TableDescription.AutoSize = true;
            this.TableDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableDescription.Location = new System.Drawing.Point(0, 21);
            this.TableDescription.Margin = new System.Windows.Forms.Padding(10);
            this.TableDescription.Name = "TableDescription";
            this.TableDescription.Size = new System.Drawing.Size(0, 19);
            this.TableDescription.TabIndex = 13;
            this.TableDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableBox
            // 
            this.TableBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Location = new System.Drawing.Point(0, 0);
            this.TableBox.Margin = new System.Windows.Forms.Padding(10);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(256, 21);
            this.TableBox.TabIndex = 12;
            this.TableBox.SelectedIndexChanged += new System.EventHandler(this.TableBox_SelectedIndexChanged);
            // 
            // PriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 278);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PriceListForm";
            this.Text = "Форма покупки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ClientBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddBox;
        private System.Windows.Forms.Button CloseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TableDescription;
        private System.Windows.Forms.ComboBox TableBox;
    }
}