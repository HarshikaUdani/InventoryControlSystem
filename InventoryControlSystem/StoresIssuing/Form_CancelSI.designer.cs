namespace InventoryControlSystem
{
    partial class Form_CancelSI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CancelSI));
            this.lb_userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.itemRequest = new System.Windows.Forms.ComboBox();
            this.b_view = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.Location = new System.Drawing.Point(12, 129);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(273, 17);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "ADVICE OF DISPATCHED FORM NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(148, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "INVENTORY CONTROL SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryControlSystem.Properties.Resources._5G;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 75);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_exit.Location = new System.Drawing.Point(465, 222);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(68, 39);
            this.b_exit.TabIndex = 5;
            this.b_exit.Text = "EXIT";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancel.Location = new System.Drawing.Point(381, 222);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(68, 39);
            this.b_cancel.TabIndex = 8;
            this.b_cancel.Text = "CANCEL";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // itemRequest
            // 
            this.itemRequest.FormattingEnabled = true;
            this.itemRequest.Location = new System.Drawing.Point(291, 128);
            this.itemRequest.Name = "itemRequest";
            this.itemRequest.Size = new System.Drawing.Size(158, 21);
            this.itemRequest.TabIndex = 10;
            // 
            // b_view
            // 
            this.b_view.BackColor = System.Drawing.SystemColors.ControlDark;
            this.b_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_view.Location = new System.Drawing.Point(291, 222);
            this.b_view.Name = "b_view";
            this.b_view.Size = new System.Drawing.Size(68, 39);
            this.b_view.TabIndex = 11;
            this.b_view.Text = "VIEW";
            this.b_view.UseVisualStyleBackColor = false;
            this.b_view.Click += new System.EventHandler(this.b_view_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(213, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "ADVICE OF DISPATCHED";
            // 
            // Form_CancelSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_view);
            this.Controls.Add(this.itemRequest);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.b_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CancelSI";
            this.Text = "Cancel Stores Issuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.ComboBox itemRequest;
        private System.Windows.Forms.Button b_view;
        private System.Windows.Forms.Label label2;
    }
}

