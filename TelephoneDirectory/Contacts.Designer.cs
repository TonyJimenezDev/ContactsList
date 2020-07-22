namespace TelephoneDirectory
{
    partial class Contacts
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
            this.New_Btn = new System.Windows.Forms.Button();
            this.Insert_Btn = new System.Windows.Forms.Button();
            this.firstName_TB = new System.Windows.Forms.TextBox();
            this.lastName_TB = new System.Windows.Forms.TextBox();
            this.mobile_TB = new System.Windows.Forms.TextBox();
            this.email_TB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstName_Label = new System.Windows.Forms.Label();
            this.lastName_Label = new System.Windows.Forms.Label();
            this.mobile_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.catagory_Label = new System.Windows.Forms.Label();
            this.catagory_CB = new System.Windows.Forms.ComboBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.ID_Label = new System.Windows.Forms.Label();
            this.ID_ValueLabel = new System.Windows.Forms.Label();
            this.SearchBox_TB = new System.Windows.Forms.TextBox();
            this.Search_Label = new System.Windows.Forms.Label();
            this.IDSearch_TB = new System.Windows.Forms.TextBox();
            this.IDNotFound_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.madeBy_Label = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // New_Btn
            // 
            this.New_Btn.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.New_Btn.Location = new System.Drawing.Point(715, 44);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(187, 46);
            this.New_Btn.TabIndex = 5;
            this.New_Btn.Text = "NEW";
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_Btn_Click);
            // 
            // Insert_Btn
            // 
            this.Insert_Btn.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.Insert_Btn.Location = new System.Drawing.Point(715, 98);
            this.Insert_Btn.Name = "Insert_Btn";
            this.Insert_Btn.Size = new System.Drawing.Size(187, 46);
            this.Insert_Btn.TabIndex = 6;
            this.Insert_Btn.Text = "SAVE";
            this.Insert_Btn.UseVisualStyleBackColor = true;
            this.Insert_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // firstName_TB
            // 
            this.firstName_TB.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_TB.Location = new System.Drawing.Point(206, 50);
            this.firstName_TB.Name = "firstName_TB";
            this.firstName_TB.Size = new System.Drawing.Size(391, 31);
            this.firstName_TB.TabIndex = 0;
            // 
            // lastName_TB
            // 
            this.lastName_TB.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_TB.Location = new System.Drawing.Point(206, 88);
            this.lastName_TB.Name = "lastName_TB";
            this.lastName_TB.Size = new System.Drawing.Size(391, 31);
            this.lastName_TB.TabIndex = 1;
            // 
            // mobile_TB
            // 
            this.mobile_TB.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_TB.Location = new System.Drawing.Point(206, 126);
            this.mobile_TB.Name = "mobile_TB";
            this.mobile_TB.Size = new System.Drawing.Size(391, 31);
            this.mobile_TB.TabIndex = 2;
            // 
            // email_TB
            // 
            this.email_TB.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_TB.Location = new System.Drawing.Point(206, 164);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(391, 31);
            this.email_TB.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.mobile,
            this.email,
            this.catagory});
            this.dataGridView1.Location = new System.Drawing.Point(12, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1384, 455);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // firstName_Label
            // 
            this.firstName_Label.AutoSize = true;
            this.firstName_Label.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_Label.Location = new System.Drawing.Point(41, 50);
            this.firstName_Label.Name = "firstName_Label";
            this.firstName_Label.Size = new System.Drawing.Size(142, 24);
            this.firstName_Label.TabIndex = 7;
            this.firstName_Label.Text = "First Name:";
            // 
            // lastName_Label
            // 
            this.lastName_Label.AutoSize = true;
            this.lastName_Label.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_Label.Location = new System.Drawing.Point(53, 88);
            this.lastName_Label.Name = "lastName_Label";
            this.lastName_Label.Size = new System.Drawing.Size(130, 24);
            this.lastName_Label.TabIndex = 8;
            this.lastName_Label.Text = "Last Name:";
            // 
            // mobile_Label
            // 
            this.mobile_Label.AutoSize = true;
            this.mobile_Label.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_Label.Location = new System.Drawing.Point(89, 126);
            this.mobile_Label.Name = "mobile_Label";
            this.mobile_Label.Size = new System.Drawing.Size(94, 24);
            this.mobile_Label.TabIndex = 9;
            this.mobile_Label.Text = "Mobile:";
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_Label.Location = new System.Drawing.Point(101, 164);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(82, 24);
            this.email_Label.TabIndex = 10;
            this.email_Label.Text = "Email:";
            // 
            // catagory_Label
            // 
            this.catagory_Label.AutoSize = true;
            this.catagory_Label.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagory_Label.Location = new System.Drawing.Point(65, 205);
            this.catagory_Label.Name = "catagory_Label";
            this.catagory_Label.Size = new System.Drawing.Size(118, 24);
            this.catagory_Label.TabIndex = 11;
            this.catagory_Label.Text = "Catagory:";
            // 
            // catagory_CB
            // 
            this.catagory_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagory_CB.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.catagory_CB.FormattingEnabled = true;
            this.catagory_CB.Items.AddRange(new object[] {
            "HOME",
            "OFFICE",
            "BUSINESS",
            "FRIENDS",
            "FAMILY"});
            this.catagory_CB.Location = new System.Drawing.Point(206, 208);
            this.catagory_CB.Name = "catagory_CB";
            this.catagory_CB.Size = new System.Drawing.Size(391, 32);
            this.catagory_CB.TabIndex = 4;
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.Delete_Btn.Location = new System.Drawing.Point(715, 152);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(187, 46);
            this.Delete_Btn.TabIndex = 7;
            this.Delete_Btn.Text = "DELETE";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.Update_Btn.Location = new System.Drawing.Point(715, 206);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(187, 46);
            this.Update_Btn.TabIndex = 8;
            this.Update_Btn.Text = "UPDATE";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(137, 254);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(46, 24);
            this.ID_Label.TabIndex = 15;
            this.ID_Label.Text = "ID:";
            // 
            // ID_ValueLabel
            // 
            this.ID_ValueLabel.AutoSize = true;
            this.ID_ValueLabel.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_ValueLabel.Location = new System.Drawing.Point(202, 254);
            this.ID_ValueLabel.Name = "ID_ValueLabel";
            this.ID_ValueLabel.Size = new System.Drawing.Size(0, 24);
            this.ID_ValueLabel.TabIndex = 16;
            // 
            // SearchBox_TB
            // 
            this.SearchBox_TB.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_TB.Location = new System.Drawing.Point(715, 258);
            this.SearchBox_TB.Name = "SearchBox_TB";
            this.SearchBox_TB.Size = new System.Drawing.Size(302, 31);
            this.SearchBox_TB.TabIndex = 9;
            this.SearchBox_TB.TextChanged += new System.EventHandler(this.SearchBox_TB_TextChanged);
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Label.Location = new System.Drawing.Point(721, 291);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(115, 13);
            this.Search_Label.TabIndex = 18;
            this.Search_Label.Text = "Search by all except ID";
            // 
            // IDSearch_TB
            // 
            this.IDSearch_TB.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.IDSearch_TB.Location = new System.Drawing.Point(1057, 258);
            this.IDSearch_TB.Name = "IDSearch_TB";
            this.IDSearch_TB.Size = new System.Drawing.Size(100, 31);
            this.IDSearch_TB.TabIndex = 10;
            this.IDSearch_TB.TextChanged += new System.EventHandler(this.IDSearch_TB_TextChanged);
            // 
            // IDNotFound_Label
            // 
            this.IDNotFound_Label.AutoSize = true;
            this.IDNotFound_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.IDNotFound_Label.Location = new System.Drawing.Point(1067, 291);
            this.IDNotFound_Label.Name = "IDNotFound_Label";
            this.IDNotFound_Label.Size = new System.Drawing.Size(65, 13);
            this.IDNotFound_Label.TabIndex = 20;
            this.IDNotFound_Label.Text = "Search by id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif Cond", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONTACT LIST";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Noto Mono", 6F);
            this.linkLabel1.Location = new System.Drawing.Point(1310, 765);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 11);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My Porfolio";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PortfolioLink_LinkClicked);
            // 
            // madeBy_Label
            // 
            this.madeBy_Label.AutoSize = true;
            this.madeBy_Label.Font = new System.Drawing.Font("Noto Mono", 6.5F);
            this.madeBy_Label.Location = new System.Drawing.Point(1141, 765);
            this.madeBy_Label.Name = "madeBy_Label";
            this.madeBy_Label.Size = new System.Drawing.Size(154, 13);
            this.madeBy_Label.TabIndex = 23;
            this.madeBy_Label.Text = "Made by: Tony Jimenez";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 30;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Mobile";
            this.mobile.Name = "mobile";
            this.mobile.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // catagory
            // 
            this.catagory.HeaderText = "Catagory";
            this.catagory.Name = "catagory";
            this.catagory.Width = 150;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1408, 783);
            this.Controls.Add(this.madeBy_Label);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDNotFound_Label);
            this.Controls.Add(this.IDSearch_TB);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.SearchBox_TB);
            this.Controls.Add(this.ID_ValueLabel);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.catagory_CB);
            this.Controls.Add(this.catagory_Label);
            this.Controls.Add(this.email_Label);
            this.Controls.Add(this.mobile_Label);
            this.Controls.Add(this.lastName_Label);
            this.Controls.Add(this.firstName_Label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.email_TB);
            this.Controls.Add(this.mobile_TB);
            this.Controls.Add(this.lastName_TB);
            this.Controls.Add(this.firstName_TB);
            this.Controls.Add(this.Insert_Btn);
            this.Controls.Add(this.New_Btn);
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Insert_Btn;
        private System.Windows.Forms.TextBox firstName_TB;
        private System.Windows.Forms.TextBox lastName_TB;
        private System.Windows.Forms.TextBox mobile_TB;
        private System.Windows.Forms.TextBox email_TB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label firstName_Label;
        private System.Windows.Forms.Label lastName_Label;
        private System.Windows.Forms.Label mobile_Label;
        private System.Windows.Forms.Label email_Label;
        private System.Windows.Forms.Label catagory_Label;
        private System.Windows.Forms.ComboBox catagory_CB;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label ID_ValueLabel;
        private System.Windows.Forms.TextBox SearchBox_TB;
        private System.Windows.Forms.Label Search_Label;
        private System.Windows.Forms.TextBox IDSearch_TB;
        private System.Windows.Forms.Label IDNotFound_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label madeBy_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory;
    }
}