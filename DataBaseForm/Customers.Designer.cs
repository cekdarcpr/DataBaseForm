﻿namespace DataBaseForm
{
    partial class Customers
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
            dataCustomer = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataCustomer).BeginInit();
            SuspendLayout();
            // 
            // dataCustomer
            // 
            dataCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCustomer.Location = new Point(12, 60);
            dataCustomer.Name = "dataCustomer";
            dataCustomer.RowTemplate.Height = 25;
            dataCustomer.Size = new Size(776, 336);
            dataCustomer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(199, 34);
            label1.TabIndex = 1;
            label1.Text = "CUSTOMERS";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataCustomer);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)dataCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataCustomer;
        private Label label1;
    }
}