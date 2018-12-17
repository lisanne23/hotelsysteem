namespace WindowsFormsApp_HotelSysteem
{
    partial class Form_Reservations
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
            this.lb_Guests = new System.Windows.Forms.ListBox();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Guests
            // 
            this.lb_Guests.FormattingEnabled = true;
            this.lb_Guests.Location = new System.Drawing.Point(12, 12);
            this.lb_Guests.Name = "lb_Guests";
            this.lb_Guests.Size = new System.Drawing.Size(234, 303);
            this.lb_Guests.TabIndex = 0;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(380, 129);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(75, 23);
            this.btn_AddUser.TabIndex = 1;
            this.btn_AddUser.Text = "button1";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(367, 65);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // Form_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.lb_Guests);
            this.Name = "Form_Reservations";
            this.Text = "Reserveringen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Guests;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.TextBox tb_Name;
    }
}

