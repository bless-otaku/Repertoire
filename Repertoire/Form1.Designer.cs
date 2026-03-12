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
            listViewContacts = new ListView();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(66, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Nom";
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 31);
            txtName.TabIndex = 1;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(67, 184);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(92, 25);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Telephone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(67, 248);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(251, 31);
            txtPhone.TabIndex = 3;
            // 
            // btnContact
            // 
            btnContact.BackColor = SystemColors.HotTrack;
            btnContact.ForeColor = SystemColors.ButtonFace;
            btnContact.Location = new Point(206, 561);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(112, 55);
            btnContact.TabIndex = 4;
            btnContact.Text = "Ajouter";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
            // 
            // labelMsg
            // 
            labelMsg.AutoSize = true;
            labelMsg.Location = new Point(66, 322);
            labelMsg.Name = "labelMsg";
            labelMsg.Size = new Size(0, 25);
            labelMsg.TabIndex = 5;
           
            // 
            // listViewContacts
            // 
            listViewContacts.BackColor = SystemColors.ScrollBar;
            listViewContacts.Location = new Point(378, 38);
            listViewContacts.Name = "listViewContacts";
            listViewContacts.Size = new Size(447, 578);
            listViewContacts.TabIndex = 6;
            listViewContacts.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 655);
            Controls.Add(listViewContacts);
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
        private ListView listViewContacts;
    }
}
