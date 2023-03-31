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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Узел6");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Узел7");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Узел8");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Судьи", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Узел9");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Узел10");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Узел11");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Узел12");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Узел13");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Узел14");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Жертвы", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Узел15");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Узел16");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Узел17");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Узел18");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Узел19");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Узел20");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Подозреваемые", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitterL = new System.Windows.Forms.Splitter();
            this.TabControlMenu = new System.Windows.Forms.TabControl();
            this.LoadInfo = new System.Windows.Forms.TabPage();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Process345json = new System.Windows.Forms.RadioButton();
            this.Process1234json = new System.Windows.Forms.RadioButton();
            this.Process123xml = new System.Windows.Forms.RadioButton();
            this.Process228xml = new System.Windows.Forms.RadioButton();
            this.Process18223json = new System.Windows.Forms.RadioButton();
            this.Process322xml = new System.Windows.Forms.RadioButton();
            this.ShowInfo = new System.Windows.Forms.TabPage();
            this.MainList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseApp = new System.Windows.Forms.TabPage();
            this.splitterR = new System.Windows.Forms.Splitter();
            this.closeButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabControlMenu.SuspendLayout();
            this.LoadInfo.SuspendLayout();
            this.ShowInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainList)).BeginInit();
            this.CloseApp.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.splitterL);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControlMenu);
            this.splitContainer1.Panel2.Controls.Add(this.splitterR);
            this.splitContainer1.Panel2MinSize = 610;
            this.splitContainer1.Size = new System.Drawing.Size(809, 441);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitterL
            // 
            this.splitterL.BackColor = System.Drawing.Color.Lime;
            this.splitterL.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterL.Enabled = false;
            this.splitterL.Location = new System.Drawing.Point(191, 0);
            this.splitterL.Name = "splitterL";
            this.splitterL.Size = new System.Drawing.Size(4, 441);
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
            this.TabControlMenu.Multiline = true;
            this.TabControlMenu.Name = "TabControlMenu";
            this.TabControlMenu.SelectedIndex = 0;
            this.TabControlMenu.Size = new System.Drawing.Size(597, 435);
            this.TabControlMenu.TabIndex = 1;
            // 
            // LoadInfo
            // 
            this.LoadInfo.BackColor = System.Drawing.SystemColors.Window;
            this.LoadInfo.Controls.Add(this.ConfirmButton);
            this.LoadInfo.Controls.Add(this.Process345json);
            this.LoadInfo.Controls.Add(this.Process1234json);
            this.LoadInfo.Controls.Add(this.Process123xml);
            this.LoadInfo.Controls.Add(this.Process228xml);
            this.LoadInfo.Controls.Add(this.Process18223json);
            this.LoadInfo.Controls.Add(this.Process322xml);
            this.LoadInfo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadInfo.Location = new System.Drawing.Point(4, 34);
            this.LoadInfo.Name = "LoadInfo";
            this.LoadInfo.Padding = new System.Windows.Forms.Padding(3);
            this.LoadInfo.Size = new System.Drawing.Size(589, 397);
            this.LoadInfo.TabIndex = 0;
            this.LoadInfo.Text = "Загрузить материалы";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(494, 361);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(89, 30);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Загрузить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Process345json
            // 
            this.Process345json.AutoSize = true;
            this.Process345json.Location = new System.Drawing.Point(22, 174);
            this.Process345json.Name = "Process345json";
            this.Process345json.Size = new System.Drawing.Size(298, 22);
            this.Process345json.TabIndex = 5;
            this.Process345json.TabStop = true;
            this.Process345json.Text = "Дело № 345 (загрузка с JSON-файла)";
            this.Process345json.UseVisualStyleBackColor = true;
            this.Process345json.CheckedChanged += new System.EventHandler(this.Process345json_CheckedChanged);
            // 
            // Process1234json
            // 
            this.Process1234json.AutoSize = true;
            this.Process1234json.Location = new System.Drawing.Point(22, 146);
            this.Process1234json.Name = "Process1234json";
            this.Process1234json.Size = new System.Drawing.Size(306, 22);
            this.Process1234json.TabIndex = 4;
            this.Process1234json.TabStop = true;
            this.Process1234json.Text = "Дело № 1234 (загрузка с JSON-файла)";
            this.Process1234json.UseVisualStyleBackColor = true;
            this.Process1234json.CheckedChanged += new System.EventHandler(this.Process1234json_CheckedChanged);
            // 
            // Process123xml
            // 
            this.Process123xml.AutoSize = true;
            this.Process123xml.Location = new System.Drawing.Point(22, 90);
            this.Process123xml.Name = "Process123xml";
            this.Process123xml.Size = new System.Drawing.Size(290, 22);
            this.Process123xml.TabIndex = 3;
            this.Process123xml.TabStop = true;
            this.Process123xml.Text = "Дело № 123 (загрузка с XML-файла)";
            this.Process123xml.UseVisualStyleBackColor = true;
            this.Process123xml.CheckedChanged += new System.EventHandler(this.Process123xml_CheckedChanged);
            // 
            // Process228xml
            // 
            this.Process228xml.AutoSize = true;
            this.Process228xml.Location = new System.Drawing.Point(22, 62);
            this.Process228xml.Name = "Process228xml";
            this.Process228xml.Size = new System.Drawing.Size(290, 22);
            this.Process228xml.TabIndex = 2;
            this.Process228xml.TabStop = true;
            this.Process228xml.Text = "Дело № 228 (загрузка с XML-файла)";
            this.Process228xml.UseVisualStyleBackColor = true;
            this.Process228xml.CheckedChanged += new System.EventHandler(this.Process228xml_CheckedChanged);
            // 
            // Process18223json
            // 
            this.Process18223json.AutoSize = true;
            this.Process18223json.Location = new System.Drawing.Point(22, 118);
            this.Process18223json.Name = "Process18223json";
            this.Process18223json.Size = new System.Drawing.Size(314, 22);
            this.Process18223json.TabIndex = 1;
            this.Process18223json.TabStop = true;
            this.Process18223json.Text = "Дело № 18223 (загрузка с JSON-файла)";
            this.Process18223json.UseVisualStyleBackColor = true;
            this.Process18223json.CheckedChanged += new System.EventHandler(this.Process18223json_CheckedChanged);
            // 
            // Process322xml
            // 
            this.Process322xml.AutoSize = true;
            this.Process322xml.Location = new System.Drawing.Point(22, 34);
            this.Process322xml.Name = "Process322xml";
            this.Process322xml.Size = new System.Drawing.Size(290, 22);
            this.Process322xml.TabIndex = 0;
            this.Process322xml.TabStop = true;
            this.Process322xml.Text = "Дело № 322 (загрузка с XML-файла)";
            this.Process322xml.UseVisualStyleBackColor = true;
            this.Process322xml.CheckedChanged += new System.EventHandler(this.Process322xml_CheckedChanged);
            // 
            // ShowInfo
            // 
            this.ShowInfo.BackColor = System.Drawing.SystemColors.Window;
            this.ShowInfo.Controls.Add(this.MainList);
            this.ShowInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfo.Location = new System.Drawing.Point(4, 34);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInfo.Size = new System.Drawing.Size(589, 397);
            this.ShowInfo.TabIndex = 1;
            this.ShowInfo.Text = "Показать материалы";
            // 
            // MainList
            // 
            this.MainList.AllowUserToAddRows = false;
            this.MainList.AllowUserToDeleteRows = false;
            this.MainList.AllowUserToResizeColumns = false;
            this.MainList.AllowUserToResizeRows = false;
            this.MainList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MainList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.Status,
            this.Process});
            this.MainList.Location = new System.Drawing.Point(0, 0);
            this.MainList.MultiSelect = false;
            this.MainList.Name = "MainList";
            this.MainList.RowHeadersVisible = false;
            this.MainList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainList.Size = new System.Drawing.Size(588, 410);
            this.MainList.TabIndex = 0;
            this.MainList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainList_CellContentDoubleClick);
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 200;
            // 
            // age
            // 
            this.age.HeaderText = "Возраст";
            this.age.Name = "age";
            this.age.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.age.Width = 65;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 250;
            // 
            // Process
            // 
            this.Process.HeaderText = "Дело №";
            this.Process.Name = "Process";
            this.Process.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Process.Width = 70;
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.SystemColors.Window;
            this.CloseApp.Controls.Add(this.closeButton);
            this.CloseApp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseApp.Location = new System.Drawing.Point(4, 34);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(626, 397);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.Text = "Закрыть";
            // 
            // splitterR
            // 
            this.splitterR.BackColor = System.Drawing.Color.MediumOrchid;
            this.splitterR.Enabled = false;
            this.splitterR.Location = new System.Drawing.Point(0, 0);
            this.splitterR.Name = "splitterR";
            this.splitterR.Size = new System.Drawing.Size(4, 441);
            this.splitterR.TabIndex = 0;
            this.splitterR.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(213, 165);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(200, 42);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Закрыть программу";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(3, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Узел3";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "Узел4";
            treeNode3.Name = "Узел5";
            treeNode3.Text = "Узел5";
            treeNode4.Name = "Узел6";
            treeNode4.Text = "Узел6";
            treeNode5.Name = "Узел7";
            treeNode5.Text = "Узел7";
            treeNode6.Name = "Узел8";
            treeNode6.Text = "Узел8";
            treeNode7.Name = "judges";
            treeNode7.Text = "Судьи";
            treeNode8.Name = "Узел9";
            treeNode8.Text = "Узел9";
            treeNode9.Name = "Узел10";
            treeNode9.Text = "Узел10";
            treeNode10.Name = "Узел11";
            treeNode10.Text = "Узел11";
            treeNode11.Name = "Узел12";
            treeNode11.Text = "Узел12";
            treeNode12.Name = "Узел13";
            treeNode12.Text = "Узел13";
            treeNode13.Name = "Узел14";
            treeNode13.Text = "Узел14";
            treeNode14.Name = "victims";
            treeNode14.Text = "Жертвы";
            treeNode15.Name = "Узел15";
            treeNode15.Text = "Узел15";
            treeNode16.Name = "Узел16";
            treeNode16.Text = "Узел16";
            treeNode17.Name = "Узел17";
            treeNode17.Text = "Узел17";
            treeNode18.Name = "Узел18";
            treeNode18.Text = "Узел18";
            treeNode19.Name = "Узел19";
            treeNode19.Text = "Узел19";
            treeNode20.Name = "Узел20";
            treeNode20.Text = "Узел20";
            treeNode21.Name = "defendants";
            treeNode21.Text = "Подозреваемые";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode14,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(182, 421);
            this.treeView1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(809, 441);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(825, 480);
            this.MinimumSize = new System.Drawing.Size(825, 480);
            this.Name = "MainForm";
            this.Text = "Судебное разбирательства";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabControlMenu.ResumeLayout(false);
            this.LoadInfo.ResumeLayout(false);
            this.LoadInfo.PerformLayout();
            this.ShowInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainList)).EndInit();
            this.CloseApp.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton Process18223json;
        private System.Windows.Forms.RadioButton Process322xml;
        private System.Windows.Forms.RadioButton Process228xml;
        private System.Windows.Forms.RadioButton Process345json;
        private System.Windows.Forms.RadioButton Process1234json;
        private System.Windows.Forms.RadioButton Process123xml;
        private System.Windows.Forms.DataGridView MainList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TreeView treeView1;
    }
}

