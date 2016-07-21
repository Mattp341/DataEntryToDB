namespace DataEntryToDB
{
    partial class EmployeeLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserNameEMP = new System.Windows.Forms.TextBox();
            this.txt_PassWordEMP = new System.Windows.Forms.TextBox();
            this.btn_LoginEMP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LoginEMP);
            this.groupBox1.Controls.Add(this.txt_PassWordEMP);
            this.groupBox1.Controls.Add(this.txt_UserNameEMP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txt_UserNameEMP
            // 
            this.txt_UserNameEMP.Location = new System.Drawing.Point(112, 44);
            this.txt_UserNameEMP.Name = "txt_UserNameEMP";
            this.txt_UserNameEMP.Size = new System.Drawing.Size(100, 20);
            this.txt_UserNameEMP.TabIndex = 3;
            // 
            // txt_PassWordEMP
            // 
            this.txt_PassWordEMP.Location = new System.Drawing.Point(112, 115);
            this.txt_PassWordEMP.Name = "txt_PassWordEMP";
            this.txt_PassWordEMP.Size = new System.Drawing.Size(100, 20);
            this.txt_PassWordEMP.TabIndex = 4;
            // 
            // btn_LoginEMP
            // 
            this.btn_LoginEMP.Location = new System.Drawing.Point(74, 176);
            this.btn_LoginEMP.Name = "btn_LoginEMP";
            this.btn_LoginEMP.Size = new System.Drawing.Size(75, 23);
            this.btn_LoginEMP.TabIndex = 5;
            this.btn_LoginEMP.Text = "Login";
            this.btn_LoginEMP.UseVisualStyleBackColor = true;
            this.btn_LoginEMP.Click += new System.EventHandler(this.btn_LoginEMP_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(354, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeLogin";
            this.Text = "Employee Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_LoginEMP;
        private System.Windows.Forms.TextBox txt_PassWordEMP;
        private System.Windows.Forms.TextBox txt_UserNameEMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}