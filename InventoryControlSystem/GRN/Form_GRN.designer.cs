namespace InventoryControlSystem
{
    partial class Form_GRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GRN));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_mainMenu = new System.Windows.Forms.Button();
            this.b_cancelGRN = new System.Windows.Forms.Button();
            this.b_editGRN = new System.Windows.Forms.Button();
            this.b_addGRN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryControlSystem.Properties.Resources._5G;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // b_mainMenu
            // 
            this.b_mainMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_mainMenu.ForeColor = System.Drawing.Color.Black;
            this.b_mainMenu.Location = new System.Drawing.Point(20, 231);
            this.b_mainMenu.Name = "b_mainMenu";
            this.b_mainMenu.Size = new System.Drawing.Size(213, 43);
            this.b_mainMenu.TabIndex = 5;
            this.b_mainMenu.Text = "MAIN MENU";
            this.b_mainMenu.UseVisualStyleBackColor = false;
            this.b_mainMenu.Click += new System.EventHandler(this.b_mainMenu_Click);
            // 
            // b_cancelGRN
            // 
            this.b_cancelGRN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_cancelGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancelGRN.ForeColor = System.Drawing.Color.Black;
            this.b_cancelGRN.Location = new System.Drawing.Point(20, 162);
            this.b_cancelGRN.Name = "b_cancelGRN";
            this.b_cancelGRN.Size = new System.Drawing.Size(213, 43);
            this.b_cancelGRN.TabIndex = 4;
            this.b_cancelGRN.Text = "CANCEL GOOD RECEIVED NOTE";
            this.b_cancelGRN.UseVisualStyleBackColor = false;
            this.b_cancelGRN.Click += new System.EventHandler(this.b_cancelGRN_Click);
            // 
            // b_editGRN
            // 
            this.b_editGRN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_editGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_editGRN.ForeColor = System.Drawing.Color.Black;
            this.b_editGRN.Location = new System.Drawing.Point(20, 93);
            this.b_editGRN.Name = "b_editGRN";
            this.b_editGRN.Size = new System.Drawing.Size(213, 43);
            this.b_editGRN.TabIndex = 3;
            this.b_editGRN.Text = "EDIT GOOD RECEIVED NOTE";
            this.b_editGRN.UseVisualStyleBackColor = false;
            this.b_editGRN.Click += new System.EventHandler(this.b_editGRN_Click);
            // 
            // b_addGRN
            // 
            this.b_addGRN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_addGRN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_addGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addGRN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addGRN.Location = new System.Drawing.Point(20, 24);
            this.b_addGRN.Name = "b_addGRN";
            this.b_addGRN.Size = new System.Drawing.Size(213, 43);
            this.b_addGRN.TabIndex = 2;
            this.b_addGRN.Text = "ADD GOOD RECEIVED NOTE";
            this.b_addGRN.UseVisualStyleBackColor = false;
            this.b_addGRN.Click += new System.EventHandler(this.b_addGRN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.b_addGRN);
            this.panel1.Controls.Add(this.b_editGRN);
            this.panel1.Controls.Add(this.b_cancelGRN);
            this.panel1.Controls.Add(this.b_mainMenu);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(222, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 309);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(294, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "GOOD RECEIVED NOTE";
            // 
            // Form_GRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GRN";
            this.Text = "Good Received Note";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_mainMenu;
        private System.Windows.Forms.Button b_cancelGRN;
        private System.Windows.Forms.Button b_editGRN;
        private System.Windows.Forms.Button b_addGRN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}