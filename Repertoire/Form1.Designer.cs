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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelName = new Label();
            txtName = new TextBox();
            labelPhone = new Label();
            txtPhone = new TextBox();
            btnContact = new Button();
            labelMsg = new Label();
            listViewContacts = new ListView();
            label1 = new Label();
            btnSupprimer = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = SystemColors.HotTrack;
            labelName.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(66, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(70, 32);
            labelName.TabIndex = 0;
            labelName.Text = "Nom";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ScrollBar;
            txtName.Location = new Point(66, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 31);
            txtName.TabIndex = 1;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = SystemColors.HotTrack;
            labelPhone.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhone.ForeColor = SystemColors.ButtonHighlight;
            labelPhone.Location = new Point(67, 184);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(137, 32);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Telephone";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ScrollBar;
            txtPhone.Location = new Point(67, 248);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(251, 31);
            txtPhone.TabIndex = 3;
            // 
            // btnContact
            // 
            btnContact.BackColor = SystemColors.HotTrack;
            btnContact.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContact.ForeColor = SystemColors.ButtonFace;
            btnContact.Location = new Point(269, 552);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(135, 64);
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
            listViewContacts.Location = new Point(462, 88);
            listViewContacts.Name = "listViewContacts";
            listViewContacts.Size = new Size(447, 528);
            listViewContacts.TabIndex = 6;
            listViewContacts.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(599, 38);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 7;
            label1.Text = "Mes contacts";
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = SystemColors.ButtonFace;
            btnSupprimer.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(66, 559);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(138, 51);
            btnSupprimer.TabIndex = 8;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1042, 655);
            Controls.Add(btnSupprimer);
            Controls.Add(label1);
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
        private Label label1;
        private Button btnSupprimer;
    }
}
