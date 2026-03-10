namespace Repertoire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            txtName = new TextBox();
            labelPhone = new Label();
            txtPhone = new TextBox();
            btnContact = new Button();
            labelMsg = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(55, 36);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 1;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(67, 184);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(59, 25);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "label2";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(67, 248);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 3;
            // 
            // btnContact
            // 
            btnContact.Location = new Point(86, 374);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(112, 34);
            btnContact.TabIndex = 4;
            btnContact.Text = "button1";
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnContact_Click;
            // 
            // labelMsg
            // 
            labelMsg.AutoSize = true;
            labelMsg.Location = new Point(66, 322);
            labelMsg.Name = "labelMsg";
            labelMsg.Size = new Size(0, 25);
            labelMsg.TabIndex = 5;
            labelMsg.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 655);
            Controls.Add(labelMsg);
            Controls.Add(btnContact);
            Controls.Add(txtPhone);
            Controls.Add(labelPhone);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox txtName;
        private Label labelPhone;
        private TextBox txtPhone;
        private Button btnContact;
        private Label labelMsg;
    }
}
