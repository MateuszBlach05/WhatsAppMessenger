namespace WhatsAppMessenger
{
    partial class frmRegister
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.grbRequestCode = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbConfirmCode = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSmsCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbRequestCode.SuspendLayout();
            this.grbConfirmCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(265, 103);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(94, 29);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // grbRequestCode
            // 
            this.grbRequestCode.Controls.Add(this.txtFullName);
            this.grbRequestCode.Controls.Add(this.btnRequest);
            this.grbRequestCode.Controls.Add(this.label2);
            this.grbRequestCode.Controls.Add(this.txtPhoneNumber);
            this.grbRequestCode.Controls.Add(this.label1);
            this.grbRequestCode.Location = new System.Drawing.Point(12, 23);
            this.grbRequestCode.Name = "grbRequestCode";
            this.grbRequestCode.Size = new System.Drawing.Size(381, 143);
            this.grbRequestCode.TabIndex = 1;
            this.grbRequestCode.TabStop = false;
            this.grbRequestCode.Text = "Step 1: Request code";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(135, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(224, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full name:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(135, 26);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(224, 27);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbConfirmCode
            // 
            this.grbConfirmCode.Controls.Add(this.btnConfirm);
            this.grbConfirmCode.Controls.Add(this.txtSmsCode);
            this.grbConfirmCode.Controls.Add(this.label4);
            this.grbConfirmCode.Enabled = false;
            this.grbConfirmCode.Location = new System.Drawing.Point(12, 200);
            this.grbConfirmCode.Name = "grbConfirmCode";
            this.grbConfirmCode.Size = new System.Drawing.Size(381, 99);
            this.grbConfirmCode.TabIndex = 1;
            this.grbConfirmCode.TabStop = false;
            this.grbConfirmCode.Text = "Step 2: Confirm code";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(265, 59);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtSmsCode
            // 
            this.txtSmsCode.Location = new System.Drawing.Point(135, 26);
            this.txtSmsCode.MaxLength = 6;
            this.txtSmsCode.Name = "txtSmsCode";
            this.txtSmsCode.Size = new System.Drawing.Size(224, 27);
            this.txtSmsCode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "SMS code:";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 308);
            this.Controls.Add(this.grbConfirmCode);
            this.Controls.Add(this.grbRequestCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.grbRequestCode.ResumeLayout(false);
            this.grbRequestCode.PerformLayout();
            this.grbConfirmCode.ResumeLayout(false);
            this.grbConfirmCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRequest;
        private GroupBox grbRequestCode;
        private TextBox txtPhoneNumber;
        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private GroupBox grbConfirmCode;
        private Button btnConfirm;
        private TextBox txtSmsCode;
        private Label label4;
    }
}