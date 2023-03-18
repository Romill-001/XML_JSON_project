namespace XML_JSON_project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitterL = new System.Windows.Forms.Splitter();
            this.TabControlMenu = new System.Windows.Forms.TabControl();
            this.LoadInfo = new System.Windows.Forms.TabPage();
            this.JSONfile = new System.Windows.Forms.RadioButton();
            this.XMLfile = new System.Windows.Forms.RadioButton();
            this.ShowInfo = new System.Windows.Forms.TabPage();
            this.MainList = new System.Windows.Forms.ListView();
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseApp = new System.Windows.Forms.TabPage();
            this.splitterR = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabControlMenu.SuspendLayout();
            this.LoadInfo.SuspendLayout();
            this.ShowInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.splitterL);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControlMenu);
            this.splitContainer1.Panel2.Controls.Add(this.splitterR);
            this.splitContainer1.Panel2MinSize = 600;
            this.splitContainer1.Size = new System.Drawing.Size(801, 450);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitterL
            // 
            this.splitterL.BackColor = System.Drawing.Color.Lime;
            this.splitterL.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterL.Enabled = false;
            this.splitterL.Location = new System.Drawing.Point(146, 0);
            this.splitterL.Name = "splitterL";
            this.splitterL.Size = new System.Drawing.Size(4, 450);
            this.splitterL.TabIndex = 0;
            this.splitterL.TabStop = false;
            // 
            // TabControlMenu
            // 
            this.TabControlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlMenu.Controls.Add(this.LoadInfo);
            this.TabControlMenu.Controls.Add(this.ShowInfo);
            this.TabControlMenu.Controls.Add(this.CloseApp);
            this.TabControlMenu.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControlMenu.ItemSize = new System.Drawing.Size(200, 30);
            this.TabControlMenu.Location = new System.Drawing.Point(10, 3);
            this.TabControlMenu.Name = "TabControlMenu";
            this.TabControlMenu.SelectedIndex = 0;
            this.TabControlMenu.Size = new System.Drawing.Size(634, 444);
            this.TabControlMenu.TabIndex = 1;
            // 
            // LoadInfo
            // 
            this.LoadInfo.BackColor = System.Drawing.SystemColors.Window;
            this.LoadInfo.Controls.Add(this.JSONfile);
            this.LoadInfo.Controls.Add(this.XMLfile);
            this.LoadInfo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadInfo.Location = new System.Drawing.Point(4, 34);
            this.LoadInfo.Name = "LoadInfo";
            this.LoadInfo.Padding = new System.Windows.Forms.Padding(3);
            this.LoadInfo.Size = new System.Drawing.Size(626, 406);
            this.LoadInfo.TabIndex = 0;
            this.LoadInfo.Text = "Загрузить материалы";
            // 
            // JSONfile
            // 
            this.JSONfile.AutoSize = true;
            this.JSONfile.Location = new System.Drawing.Point(22, 63);
            this.JSONfile.Name = "JSONfile";
            this.JSONfile.Size = new System.Drawing.Size(314, 22);
            this.JSONfile.TabIndex = 1;
            this.JSONfile.TabStop = true;
            this.JSONfile.Text = "Дело № 18223 (загрузка с JSON-файла)";
            this.JSONfile.UseVisualStyleBackColor = true;
            // 
            // XMLfile
            // 
            this.XMLfile.AutoSize = true;
            this.XMLfile.Location = new System.Drawing.Point(22, 34);
            this.XMLfile.Name = "XMLfile";
            this.XMLfile.Size = new System.Drawing.Size(290, 22);
            this.XMLfile.TabIndex = 0;
            this.XMLfile.TabStop = true;
            this.XMLfile.Text = "Дело № 322 (загрузка с XML-файла)";
            this.XMLfile.UseVisualStyleBackColor = true;
            this.XMLfile.CheckedChanged += new System.EventHandler(this.XMLfile_CheckedChanged);
            // 
            // ShowInfo
            // 
            this.ShowInfo.BackColor = System.Drawing.SystemColors.Window;
            this.ShowInfo.Controls.Add(this.MainList);
            this.ShowInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfo.Location = new System.Drawing.Point(4, 34);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInfo.Size = new System.Drawing.Size(626, 406);
            this.ShowInfo.TabIndex = 1;
            this.ShowInfo.Text = "Показать материалы";
            // 
            // MainList
            // 
            this.MainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullName,
            this.Status,
            this.Process,
            this.Age});
            this.MainList.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MainList.HideSelection = false;
            this.MainList.Location = new System.Drawing.Point(-4, 0);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(264, 406);
            this.MainList.TabIndex = 0;
            this.MainList.UseCompatibleStateImageBehavior = false;
            this.MainList.View = System.Windows.Forms.View.Details;
            // 
            // fullName
            // 
            this.fullName.Text = "Имя";
            // 
            // Status
            // 
            this.Status.Text = "Статус";
            this.Status.Width = 72;
            // 
            // Process
            // 
            this.Process.Text = "Дело №";
            // 
            // Age
            // 
            this.Age.Text = "Возраст";
            this.Age.Width = 68;
            // 
            // CloseApp
            // 
            this.CloseApp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseApp.Location = new System.Drawing.Point(4, 34);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(626, 406);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.Text = "Закрыть";
            this.CloseApp.UseVisualStyleBackColor = true;
            // 
            // splitterR
            // 
            this.splitterR.BackColor = System.Drawing.Color.MediumOrchid;
            this.splitterR.Enabled = false;
            this.splitterR.Location = new System.Drawing.Point(0, 0);
            this.splitterR.Name = "splitterR";
            this.splitterR.Size = new System.Drawing.Size(4, 450);
            this.splitterR.TabIndex = 0;
            this.splitterR.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(817, 480);
            this.Name = "MainForm";
            this.Text = "Судебное бюро";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabControlMenu.ResumeLayout(false);
            this.LoadInfo.ResumeLayout(false);
            this.LoadInfo.PerformLayout();
            this.ShowInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitterL;
        private System.Windows.Forms.Splitter splitterR;
        private System.Windows.Forms.TabControl TabControlMenu;
        private System.Windows.Forms.TabPage LoadInfo;
        private System.Windows.Forms.TabPage ShowInfo;
        private System.Windows.Forms.TabPage CloseApp;
        private System.Windows.Forms.RadioButton JSONfile;
        private System.Windows.Forms.RadioButton XMLfile;
        private System.Windows.Forms.ListView MainList;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Process;
        private System.Windows.Forms.ColumnHeader Age;
    }
}

