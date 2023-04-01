namespace XML_JSON_project
{
    partial class AboutPerson
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
            this.usersPicture = new System.Windows.Forms.PictureBox();
            this.fullName = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.YearOfBirth = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.Label();
            this.Lawyer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // usersPicture
            // 
            this.usersPicture.Image = global::XML_JSON_project.Properties.Resources.icons8_user_account_100;
            this.usersPicture.Location = new System.Drawing.Point(44, 56);
            this.usersPicture.Name = "usersPicture";
            this.usersPicture.Size = new System.Drawing.Size(100, 100);
            this.usersPicture.TabIndex = 0;
            this.usersPicture.TabStop = false;
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.BackColor = System.Drawing.SystemColors.Control;
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(200, 56);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(61, 24);
            this.fullName.TabIndex = 1;
            this.fullName.Text = "Name";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.SystemColors.Control;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(201, 115);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(45, 24);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(201, 178);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(60, 24);
            this.Status.TabIndex = 3;
            this.Status.Text = "Status";
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.AutoSize = true;
            this.YearOfBirth.BackColor = System.Drawing.SystemColors.Control;
            this.YearOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearOfBirth.Location = new System.Drawing.Point(325, 115);
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.Size = new System.Drawing.Size(110, 24);
            this.YearOfBirth.TabIndex = 4;
            this.YearOfBirth.Text = "Year of birth";
            // 
            // Process
            // 
            this.Process.AutoSize = true;
            this.Process.BackColor = System.Drawing.SystemColors.Control;
            this.Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Process.Location = new System.Drawing.Point(40, 178);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(78, 24);
            this.Process.TabIndex = 5;
            this.Process.Text = "Process";
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.BackColor = System.Drawing.SystemColors.Control;
            this.Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temp.Location = new System.Drawing.Point(40, 303);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(108, 24);
            this.Temp.TabIndex = 6;
            this.Temp.Text = "Experience";
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.BackColor = System.Drawing.SystemColors.Control;
            this.Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place.Location = new System.Drawing.Point(40, 244);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(57, 24);
            this.Place.TabIndex = 7;
            this.Place.Text = "Place";
            // 
            // Lawyer
            // 
            this.Lawyer.AutoSize = true;
            this.Lawyer.BackColor = System.Drawing.SystemColors.Control;
            this.Lawyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lawyer.Location = new System.Drawing.Point(40, 362);
            this.Lawyer.Name = "Lawyer";
            this.Lawyer.Size = new System.Drawing.Size(16, 24);
            this.Lawyer.TabIndex = 8;
            this.Lawyer.Text = "-";
            this.Lawyer.Visible = false;
            // 
            // AboutPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(726, 421);
            this.Controls.Add(this.Lawyer);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.YearOfBirth);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.usersPicture);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(742, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(742, 460);
            this.Name = "AboutPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль";
            ((System.ComponentModel.ISupportInitialize)(this.usersPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox usersPicture;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label YearOfBirth;
        private System.Windows.Forms.Label Process;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.Label Lawyer;
    }
}