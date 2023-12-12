namespace WarehouseApp.View
{
    partial class FormHandlerProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextProductID = new System.Windows.Forms.TextBox();
            this.TextProductName = new System.Windows.Forms.TextBox();
            this.TextProductStock = new System.Windows.Forms.TextBox();
            this.TextProductPrice = new System.Windows.Forms.TextBox();
            this.ButtonHandler = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // TextProductID
            // 
            this.TextProductID.BackColor = System.Drawing.SystemColors.Window;
            this.TextProductID.Location = new System.Drawing.Point(93, 12);
            this.TextProductID.Name = "TextProductID";
            this.TextProductID.Size = new System.Drawing.Size(133, 20);
            this.TextProductID.TabIndex = 5;
            // 
            // TextProductName
            // 
            this.TextProductName.Location = new System.Drawing.Point(93, 38);
            this.TextProductName.Name = "TextProductName";
            this.TextProductName.Size = new System.Drawing.Size(220, 20);
            this.TextProductName.TabIndex = 6;
            // 
            // TextProductStock
            // 
            this.TextProductStock.Location = new System.Drawing.Point(93, 64);
            this.TextProductStock.Name = "TextProductStock";
            this.TextProductStock.Size = new System.Drawing.Size(100, 20);
            this.TextProductStock.TabIndex = 7;
            // 
            // TextProductPrice
            // 
            this.TextProductPrice.Location = new System.Drawing.Point(93, 90);
            this.TextProductPrice.Name = "TextProductPrice";
            this.TextProductPrice.Size = new System.Drawing.Size(100, 20);
            this.TextProductPrice.TabIndex = 8;
            // 
            // ButtonHandler
            // 
            this.ButtonHandler.Location = new System.Drawing.Point(93, 116);
            this.ButtonHandler.Name = "ButtonHandler";
            this.ButtonHandler.Size = new System.Drawing.Size(106, 29);
            this.ButtonHandler.TabIndex = 9;
            this.ButtonHandler.Text = "Add/Update";
            this.ButtonHandler.UseVisualStyleBackColor = true;
            this.ButtonHandler.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(207, 116);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(106, 29);
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FormHandlerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 162);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonHandler);
            this.Controls.Add(this.TextProductPrice);
            this.Controls.Add(this.TextProductStock);
            this.Controls.Add(this.TextProductName);
            this.Controls.Add(this.TextProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHandlerProduct";
            this.Text = "Form Handler Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextProductID;
        private System.Windows.Forms.TextBox TextProductName;
        private System.Windows.Forms.TextBox TextProductStock;
        private System.Windows.Forms.TextBox TextProductPrice;
        private System.Windows.Forms.Button ButtonHandler;
        private System.Windows.Forms.Button ButtonClose;
    }
}