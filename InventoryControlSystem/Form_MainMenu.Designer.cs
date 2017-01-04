namespace InventoryControlSystem
{
    partial class Form_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.b_itemRequest = new System.Windows.Forms.Button();
            this.b_purchaseOrder = new System.Windows.Forms.Button();
            this.b_GRN = new System.Windows.Forms.Button();
            this.b_storesIssue = new System.Windows.Forms.Button();
            this.b_items = new System.Windows.Forms.Button();
            this.b_outlets = new System.Windows.Forms.Button();
            this.b_employee = new System.Windows.Forms.Button();
            this.b_supplier = new System.Windows.Forms.Button();
            this.b_inventoryRpt = new System.Windows.Forms.Button();
            this.b_purchaseOdrRpt = new System.Windows.Forms.Button();
            this.b_GRNRpt = new System.Windows.Forms.Button();
            this.b_storeIssue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(203, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY CONTROL SYSTEM";
            // 
            // b_itemRequest
            // 
            this.b_itemRequest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_itemRequest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_itemRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_itemRequest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_itemRequest.Location = new System.Drawing.Point(20, 24);
            this.b_itemRequest.Name = "b_itemRequest";
            this.b_itemRequest.Size = new System.Drawing.Size(140, 43);
            this.b_itemRequest.TabIndex = 2;
            this.b_itemRequest.Text = "ITEM REQUEST";
            this.b_itemRequest.UseVisualStyleBackColor = false;
            this.b_itemRequest.Click += new System.EventHandler(this.b_itemRequest_Click);
            // 
            // b_purchaseOrder
            // 
            this.b_purchaseOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_purchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_purchaseOrder.ForeColor = System.Drawing.Color.Black;
            this.b_purchaseOrder.Location = new System.Drawing.Point(20, 93);
            this.b_purchaseOrder.Name = "b_purchaseOrder";
            this.b_purchaseOrder.Size = new System.Drawing.Size(140, 43);
            this.b_purchaseOrder.TabIndex = 3;
            this.b_purchaseOrder.Text = "PURCHASE ORDER";
            this.b_purchaseOrder.UseVisualStyleBackColor = false;
            this.b_purchaseOrder.Click += new System.EventHandler(this.b_purchaseOrder_Click);
            // 
            // b_GRN
            // 
            this.b_GRN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_GRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_GRN.ForeColor = System.Drawing.Color.Black;
            this.b_GRN.Location = new System.Drawing.Point(20, 162);
            this.b_GRN.Name = "b_GRN";
            this.b_GRN.Size = new System.Drawing.Size(140, 43);
            this.b_GRN.TabIndex = 4;
            this.b_GRN.Text = "GRN";
            this.b_GRN.UseVisualStyleBackColor = false;
            this.b_GRN.Click += new System.EventHandler(this.b_GRN_Click);
            // 
            // b_storesIssue
            // 
            this.b_storesIssue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_storesIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_storesIssue.ForeColor = System.Drawing.Color.Black;
            this.b_storesIssue.Location = new System.Drawing.Point(20, 231);
            this.b_storesIssue.Name = "b_storesIssue";
            this.b_storesIssue.Size = new System.Drawing.Size(140, 43);
            this.b_storesIssue.TabIndex = 5;
            this.b_storesIssue.Text = "STORES ISSUING";
            this.b_storesIssue.UseVisualStyleBackColor = false;
            this.b_storesIssue.Click += new System.EventHandler(this.b_storesIssue_Click);
            // 
            // b_items
            // 
            this.b_items.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_items.ForeColor = System.Drawing.Color.Black;
            this.b_items.Location = new System.Drawing.Point(20, 24);
            this.b_items.Name = "b_items";
            this.b_items.Size = new System.Drawing.Size(140, 43);
            this.b_items.TabIndex = 6;
            this.b_items.Text = "ITEMS";
            this.b_items.UseVisualStyleBackColor = false;
            // 
            // b_outlets
            // 
            this.b_outlets.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_outlets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_outlets.ForeColor = System.Drawing.Color.Black;
            this.b_outlets.Location = new System.Drawing.Point(20, 93);
            this.b_outlets.Name = "b_outlets";
            this.b_outlets.Size = new System.Drawing.Size(140, 43);
            this.b_outlets.TabIndex = 7;
            this.b_outlets.Text = "OUTLETS";
            this.b_outlets.UseVisualStyleBackColor = false;
            // 
            // b_employee
            // 
            this.b_employee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_employee.ForeColor = System.Drawing.Color.Black;
            this.b_employee.Location = new System.Drawing.Point(20, 162);
            this.b_employee.Name = "b_employee";
            this.b_employee.Size = new System.Drawing.Size(140, 43);
            this.b_employee.TabIndex = 8;
            this.b_employee.Text = "EMPLOYEE";
            this.b_employee.UseVisualStyleBackColor = false;
            // 
            // b_supplier
            // 
            this.b_supplier.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_supplier.ForeColor = System.Drawing.Color.Black;
            this.b_supplier.Location = new System.Drawing.Point(20, 231);
            this.b_supplier.Name = "b_supplier";
            this.b_supplier.Size = new System.Drawing.Size(140, 43);
            this.b_supplier.TabIndex = 9;
            this.b_supplier.Text = "SUPPLIERS";
            this.b_supplier.UseVisualStyleBackColor = false;
            // 
            // b_inventoryRpt
            // 
            this.b_inventoryRpt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_inventoryRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_inventoryRpt.ForeColor = System.Drawing.Color.Black;
            this.b_inventoryRpt.Location = new System.Drawing.Point(20, 24);
            this.b_inventoryRpt.Name = "b_inventoryRpt";
            this.b_inventoryRpt.Size = new System.Drawing.Size(140, 43);
            this.b_inventoryRpt.TabIndex = 10;
            this.b_inventoryRpt.Text = "INVENTORY";
            this.b_inventoryRpt.UseVisualStyleBackColor = false;
            // 
            // b_purchaseOdrRpt
            // 
            this.b_purchaseOdrRpt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_purchaseOdrRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_purchaseOdrRpt.ForeColor = System.Drawing.Color.Black;
            this.b_purchaseOdrRpt.Location = new System.Drawing.Point(20, 93);
            this.b_purchaseOdrRpt.Name = "b_purchaseOdrRpt";
            this.b_purchaseOdrRpt.Size = new System.Drawing.Size(140, 43);
            this.b_purchaseOdrRpt.TabIndex = 11;
            this.b_purchaseOdrRpt.Text = "PURCHASE ORDER";
            this.b_purchaseOdrRpt.UseVisualStyleBackColor = false;
            // 
            // b_GRNRpt
            // 
            this.b_GRNRpt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_GRNRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_GRNRpt.ForeColor = System.Drawing.Color.Black;
            this.b_GRNRpt.Location = new System.Drawing.Point(20, 162);
            this.b_GRNRpt.Name = "b_GRNRpt";
            this.b_GRNRpt.Size = new System.Drawing.Size(140, 43);
            this.b_GRNRpt.TabIndex = 12;
            this.b_GRNRpt.Text = "GRN";
            this.b_GRNRpt.UseVisualStyleBackColor = false;
            // 
            // b_storeIssue
            // 
            this.b_storeIssue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_storeIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_storeIssue.ForeColor = System.Drawing.Color.Black;
            this.b_storeIssue.Location = new System.Drawing.Point(20, 231);
            this.b_storeIssue.Name = "b_storeIssue";
            this.b_storeIssue.Size = new System.Drawing.Size(140, 43);
            this.b_storeIssue.TabIndex = 13;
            this.b_storeIssue.Text = "STORES ISSUING";
            this.b_storeIssue.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.b_itemRequest);
            this.panel1.Controls.Add(this.b_purchaseOrder);
            this.panel1.Controls.Add(this.b_GRN);
            this.panel1.Controls.Add(this.b_storesIssue);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(32, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 309);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.b_items);
            this.panel2.Controls.Add(this.b_outlets);
            this.panel2.Controls.Add(this.b_employee);
            this.panel2.Controls.Add(this.b_supplier);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(254, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 309);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.b_inventoryRpt);
            this.panel3.Controls.Add(this.b_purchaseOdrRpt);
            this.panel3.Controls.Add(this.b_GRNRpt);
            this.panel3.Controls.Add(this.b_storeIssue);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(476, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 309);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "DATA ENTRY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "MASTER DATA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "REPORTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryControlSystem.Properties.Resources._5G;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(299, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "MAIN MENU";
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MainMenu";
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_itemRequest;
        private System.Windows.Forms.Button b_purchaseOrder;
        private System.Windows.Forms.Button b_GRN;
        private System.Windows.Forms.Button b_storesIssue;
        private System.Windows.Forms.Button b_items;
        private System.Windows.Forms.Button b_outlets;
        private System.Windows.Forms.Button b_employee;
        private System.Windows.Forms.Button b_supplier;
        private System.Windows.Forms.Button b_inventoryRpt;
        private System.Windows.Forms.Button b_purchaseOdrRpt;
        private System.Windows.Forms.Button b_GRNRpt;
        private System.Windows.Forms.Button b_storeIssue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}