namespace QLTK_NRO
{
    partial class MainForm
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
            dataGridView = new DataGridView();
            tick = new DataGridViewCheckBoxColumn();
            acc = new DataGridViewTextBoxColumn();
            pwd = new DataGridViewTextBoxColumn();
            server = new DataGridViewTextBoxColumn();
            map = new DataGridViewTextBoxColumn();
            proxy = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            sortTabBtn = new Button();
            offBtn = new Button();
            onBtn = new Button();
            uncheckBtn = new Button();
            checkBtn = new Button();
            groupBox1 = new GroupBox();
            EditBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            httpProxy_rdb = new RadioButton();
            sockProxy_rdb = new RadioButton();
            noProxy_rdb = new RadioButton();
            strProxy = new TextBox();
            indexServer = new ComboBox();
            password = new TextBox();
            username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            panel3 = new Panel();
            trainAll = new RadioButton();
            trainSuper = new RadioButton();
            trainNormal = new RadioButton();
            panel2 = new Panel();
            trainType3 = new RadioButton();
            trainType2 = new RadioButton();
            trainType1 = new RadioButton();
            panel1 = new Panel();
            pickType3 = new RadioButton();
            pickType2 = new RadioButton();
            pickType1 = new RadioButton();
            label6 = new Label();
            dame = new NumericUpDown();
            ki = new NumericUpDown();
            hp = new NumericUpDown();
            label5 = new Label();
            goBackOutKi = new CheckBox();
            checkBox2 = new CheckBox();
            goBack = new CheckBox();
            useItem = new CheckBox();
            strUseItem = new TextBox();
            flag = new CheckBox();
            pickItem = new CheckBox();
            useSkills = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            strSkills = new TextBox();
            strPick = new TextBox();
            applyBtn = new Button();
            zoneID = new NumericUpDown();
            mapID = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zoneID).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AccessibleRole = AccessibleRole.None;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { tick, acc, pwd, server, map, proxy, status });
            dataGridView.Location = new Point(10, 9);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(510, 366);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.MouseDown += dataGridView_MouseDown;
            dataGridView.MouseMove += dataGridView_MouseMove;
            dataGridView.MouseUp += dataGridView_MouseUp;
            // 
            // tick
            // 
            tick.FalseValue = "F";
            tick.FillWeight = 25F;
            tick.HeaderText = "#";
            tick.MinimumWidth = 6;
            tick.Name = "tick";
            tick.ReadOnly = true;
            tick.TrueValue = "T";
            // 
            // acc
            // 
            acc.HeaderText = "Tài khoản";
            acc.MinimumWidth = 6;
            acc.Name = "acc";
            acc.ReadOnly = true;
            acc.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pwd
            // 
            pwd.HeaderText = "Mật khẩu";
            pwd.MinimumWidth = 6;
            pwd.Name = "pwd";
            pwd.ReadOnly = true;
            pwd.SortMode = DataGridViewColumnSortMode.NotSortable;
            pwd.Visible = false;
            // 
            // server
            // 
            server.HeaderText = "Máy chủ";
            server.MinimumWidth = 6;
            server.Name = "server";
            server.ReadOnly = true;
            server.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // map
            // 
            map.HeaderText = "Map";
            map.MinimumWidth = 6;
            map.Name = "map";
            map.ReadOnly = true;
            map.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // proxy
            // 
            proxy.HeaderText = "Proxy";
            proxy.MinimumWidth = 6;
            proxy.Name = "proxy";
            proxy.ReadOnly = true;
            proxy.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // status
            // 
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(534, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(380, 368);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(372, 340);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(sortTabBtn);
            groupBox2.Controls.Add(offBtn);
            groupBox2.Controls.Add(onBtn);
            groupBox2.Controls.Add(uncheckBtn);
            groupBox2.Controls.Add(checkBtn);
            groupBox2.Location = new Point(15, 202);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(343, 134);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // sortTabBtn
            // 
            sortTabBtn.BackColor = Color.LightGray;
            sortTabBtn.Location = new Point(12, 97);
            sortTabBtn.Name = "sortTabBtn";
            sortTabBtn.Size = new Size(116, 22);
            sortTabBtn.TabIndex = 18;
            sortTabBtn.Text = "Sắp xếp tab";
            sortTabBtn.UseVisualStyleBackColor = false;
            sortTabBtn.Click += SortTabBtn_Click;
            // 
            // offBtn
            // 
            offBtn.BackColor = Color.LightGray;
            offBtn.ForeColor = SystemColors.ControlText;
            offBtn.Location = new Point(195, 75);
            offBtn.Margin = new Padding(3, 2, 3, 2);
            offBtn.Name = "offBtn";
            offBtn.Size = new Size(131, 45);
            offBtn.TabIndex = 17;
            offBtn.Text = "Tắt";
            offBtn.UseVisualStyleBackColor = false;
            offBtn.Click += offBtn_Click;
            // 
            // onBtn
            // 
            onBtn.BackColor = Color.LightGray;
            onBtn.Location = new Point(195, 26);
            onBtn.Margin = new Padding(3, 2, 3, 2);
            onBtn.Name = "onBtn";
            onBtn.Size = new Size(131, 44);
            onBtn.TabIndex = 16;
            onBtn.Text = "Bật";
            onBtn.UseVisualStyleBackColor = false;
            onBtn.Click += onBtn_Click;
            // 
            // uncheckBtn
            // 
            uncheckBtn.BackColor = Color.LightGray;
            uncheckBtn.Location = new Point(12, 62);
            uncheckBtn.Margin = new Padding(3, 2, 3, 2);
            uncheckBtn.Name = "uncheckBtn";
            uncheckBtn.Size = new Size(116, 22);
            uncheckBtn.TabIndex = 14;
            uncheckBtn.Text = "Bỏ chọn nhanh";
            uncheckBtn.UseVisualStyleBackColor = false;
            uncheckBtn.Click += unSelectBtn_Click;
            // 
            // checkBtn
            // 
            checkBtn.BackColor = Color.LightGray;
            checkBtn.Location = new Point(12, 26);
            checkBtn.Margin = new Padding(3, 2, 3, 2);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(116, 22);
            checkBtn.TabIndex = 13;
            checkBtn.Text = "Chọn nhanh";
            checkBtn.UseVisualStyleBackColor = false;
            checkBtn.Click += selectBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EditBtn);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(httpProxy_rdb);
            groupBox1.Controls.Add(sockProxy_rdb);
            groupBox1.Controls.Add(noProxy_rdb);
            groupBox1.Controls.Add(strProxy);
            groupBox1.Controls.Add(indexServer);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 4);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(341, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.LightGray;
            EditBtn.Location = new Point(130, 158);
            EditBtn.Margin = new Padding(3, 2, 3, 2);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(82, 22);
            EditBtn.TabIndex = 12;
            EditBtn.Text = "Sửa";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.LightGray;
            deleteBtn.Location = new Point(243, 158);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(82, 22);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LightGray;
            addBtn.Location = new Point(12, 158);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(82, 22);
            addBtn.TabIndex = 10;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // httpProxy_rdb
            // 
            httpProxy_rdb.AutoSize = true;
            httpProxy_rdb.Location = new Point(238, 104);
            httpProxy_rdb.Margin = new Padding(3, 2, 3, 2);
            httpProxy_rdb.Name = "httpProxy_rdb";
            httpProxy_rdb.Size = new Size(82, 19);
            httpProxy_rdb.TabIndex = 9;
            httpProxy_rdb.TabStop = true;
            httpProxy_rdb.Text = "Http proxy";
            httpProxy_rdb.UseVisualStyleBackColor = true;
            httpProxy_rdb.CheckedChanged += httpProxy_RadioBtn;
            // 
            // sockProxy_rdb
            // 
            sockProxy_rdb.AutoSize = true;
            sockProxy_rdb.Location = new Point(130, 104);
            sockProxy_rdb.Margin = new Padding(3, 2, 3, 2);
            sockProxy_rdb.Name = "sockProxy_rdb";
            sockProxy_rdb.Size = new Size(83, 19);
            sockProxy_rdb.TabIndex = 8;
            sockProxy_rdb.TabStop = true;
            sockProxy_rdb.Text = "Sock proxy";
            sockProxy_rdb.UseVisualStyleBackColor = true;
            sockProxy_rdb.CheckedChanged += sockProxy_RadioBtn;
            // 
            // noProxy_rdb
            // 
            noProxy_rdb.AutoSize = true;
            noProxy_rdb.Location = new Point(12, 104);
            noProxy_rdb.Margin = new Padding(3, 2, 3, 2);
            noProxy_rdb.Name = "noProxy_rdb";
            noProxy_rdb.Size = new Size(93, 19);
            noProxy_rdb.TabIndex = 7;
            noProxy_rdb.TabStop = true;
            noProxy_rdb.Text = "Không proxy";
            noProxy_rdb.UseVisualStyleBackColor = true;
            noProxy_rdb.CheckedChanged += noProxy_RadioBtn;
            // 
            // strProxy
            // 
            strProxy.Location = new Point(12, 127);
            strProxy.Margin = new Padding(3, 2, 3, 2);
            strProxy.Name = "strProxy";
            strProxy.Size = new Size(314, 23);
            strProxy.TabIndex = 6;
            // 
            // indexServer
            // 
            indexServer.AccessibleName = "";
            indexServer.DropDownStyle = ComboBoxStyle.DropDownList;
            indexServer.FormattingEnabled = true;
            indexServer.Items.AddRange(new object[] { "Vũ trụ 1", "Vũ trụ 2", "Vũ trụ 3", "Vũ trụ 4", "Vũ trụ 5", "Vũ trụ 6", "Vũ trụ 7", "Vũ trụ 8", "Vũ trụ 9", "Vũ trụ 10", "Vũ trụ 11", "Vũ trụ 12", "Vũ trụ 13" });
            indexServer.Location = new Point(88, 77);
            indexServer.Margin = new Padding(3, 2, 3, 2);
            indexServer.Name = "indexServer";
            indexServer.Size = new Size(106, 23);
            indexServer.TabIndex = 5;
            // 
            // password
            // 
            password.Location = new Point(88, 50);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(238, 23);
            password.TabIndex = 4;
            // 
            // username
            // 
            username.Location = new Point(88, 24);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.Size = new Size(238, 23);
            username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Máy chủ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(372, 340);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cài đặt";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(panel1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dame);
            groupBox3.Controls.Add(ki);
            groupBox3.Controls.Add(hp);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(goBackOutKi);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(goBack);
            groupBox3.Controls.Add(useItem);
            groupBox3.Controls.Add(strUseItem);
            groupBox3.Controls.Add(flag);
            groupBox3.Controls.Add(pickItem);
            groupBox3.Controls.Add(useSkills);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(strSkills);
            groupBox3.Controls.Add(strPick);
            groupBox3.Controls.Add(applyBtn);
            groupBox3.Controls.Add(zoneID);
            groupBox3.Controls.Add(mapID);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(5, 4);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(362, 330);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thiết lập";
            // 
            // panel3
            // 
            panel3.Controls.Add(trainAll);
            panel3.Controls.Add(trainSuper);
            panel3.Controls.Add(trainNormal);
            panel3.Location = new Point(7, 236);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 20);
            panel3.TabIndex = 46;
            // 
            // trainAll
            // 
            trainAll.AutoSize = true;
            trainAll.Location = new Point(12, 0);
            trainAll.Margin = new Padding(3, 2, 3, 2);
            trainAll.Name = "trainAll";
            trainAll.Size = new Size(56, 19);
            trainAll.TabIndex = 36;
            trainAll.TabStop = true;
            trainAll.Text = "Tất cả";
            trainAll.UseVisualStyleBackColor = true;
            // 
            // trainSuper
            // 
            trainSuper.AutoSize = true;
            trainSuper.Location = new Point(270, 0);
            trainSuper.Margin = new Padding(3, 2, 3, 2);
            trainSuper.Name = "trainSuper";
            trainSuper.Size = new Size(73, 19);
            trainSuper.TabIndex = 35;
            trainSuper.TabStop = true;
            trainSuper.Text = "Siêu quái";
            trainSuper.UseVisualStyleBackColor = true;
            // 
            // trainNormal
            // 
            trainNormal.AutoSize = true;
            trainNormal.Location = new Point(138, 0);
            trainNormal.Margin = new Padding(3, 2, 3, 2);
            trainNormal.Name = "trainNormal";
            trainNormal.Size = new Size(92, 19);
            trainNormal.TabIndex = 34;
            trainNormal.TabStop = true;
            trainNormal.Text = "Quái thường";
            trainNormal.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(trainType3);
            panel2.Controls.Add(trainType2);
            panel2.Controls.Add(trainType1);
            panel2.Location = new Point(7, 48);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 20);
            panel2.TabIndex = 45;
            // 
            // trainType3
            // 
            trainType3.AutoSize = true;
            trainType3.Location = new Point(270, 0);
            trainType3.Margin = new Padding(3, 2, 3, 2);
            trainType3.Name = "trainType3";
            trainType3.Size = new Size(62, 19);
            trainType3.TabIndex = 12;
            trainType3.TabStop = true;
            trainType3.Text = "Up GLT";
            trainType3.UseVisualStyleBackColor = true;
            // 
            // trainType2
            // 
            trainType2.AutoSize = true;
            trainType2.Location = new Point(138, 0);
            trainType2.Margin = new Padding(3, 2, 3, 2);
            trainType2.Name = "trainType2";
            trainType2.Size = new Size(68, 19);
            trainType2.TabIndex = 11;
            trainType2.TabStop = true;
            trainType2.Text = "Up TDLT";
            trainType2.UseVisualStyleBackColor = true;
            // 
            // trainType1
            // 
            trainType1.AutoSize = true;
            trainType1.Location = new Point(12, 0);
            trainType1.Margin = new Padding(3, 2, 3, 2);
            trainType1.Name = "trainType1";
            trainType1.Size = new Size(68, 19);
            trainType1.TabIndex = 10;
            trainType1.TabStop = true;
            trainType1.Text = "Up chay";
            trainType1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(pickType3);
            panel1.Controls.Add(pickType2);
            panel1.Controls.Add(pickType1);
            panel1.Location = new Point(7, 132);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 20);
            panel1.TabIndex = 44;
            // 
            // pickType3
            // 
            pickType3.AutoSize = true;
            pickType3.Location = new Point(270, 0);
            pickType3.Margin = new Padding(3, 2, 3, 2);
            pickType3.Name = "pickType3";
            pickType3.Size = new Size(70, 19);
            pickType3.TabIndex = 29;
            pickType3.TabStop = true;
            pickType3.Text = "Chỉ nhặt";
            pickType3.UseVisualStyleBackColor = true;
            // 
            // pickType2
            // 
            pickType2.AutoSize = true;
            pickType2.Location = new Point(138, 0);
            pickType2.Margin = new Padding(3, 2, 3, 2);
            pickType2.Name = "pickType2";
            pickType2.Size = new Size(75, 19);
            pickType2.TabIndex = 28;
            pickType2.TabStop = true;
            pickType2.Text = "Ngoại trừ";
            pickType2.UseVisualStyleBackColor = true;
            // 
            // pickType1
            // 
            pickType1.AutoSize = true;
            pickType1.Location = new Point(12, 0);
            pickType1.Margin = new Padding(3, 2, 3, 2);
            pickType1.Name = "pickType1";
            pickType1.Size = new Size(56, 19);
            pickType1.TabIndex = 27;
            pickType1.TabStop = true;
            pickType1.Text = "Tất cả";
            pickType1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 76);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 43;
            label6.Text = "Hp/Ki/Sd";
            // 
            // dame
            // 
            dame.Location = new Point(265, 73);
            dame.Margin = new Padding(3, 2, 3, 2);
            dame.Name = "dame";
            dame.Size = new Size(60, 23);
            dame.TabIndex = 42;
            // 
            // ki
            // 
            ki.Location = new Point(186, 73);
            ki.Margin = new Padding(3, 2, 3, 2);
            ki.Name = "ki";
            ki.Size = new Size(60, 23);
            ki.TabIndex = 41;
            // 
            // hp
            // 
            hp.Location = new Point(108, 73);
            hp.Margin = new Padding(3, 2, 3, 2);
            hp.Name = "hp";
            hp.Size = new Size(60, 23);
            hp.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 70);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 39;
            // 
            // goBackOutKi
            // 
            goBackOutKi.AutoSize = true;
            goBackOutKi.Location = new Point(18, 290);
            goBackOutKi.Margin = new Padding(3, 2, 3, 2);
            goBackOutKi.Name = "goBackOutKi";
            goBackOutKi.Size = new Size(117, 19);
            goBackOutKi.TabIndex = 38;
            goBackOutKi.Text = "Goback khi hết ki";
            goBackOutKi.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(145, 263);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 19);
            checkBox2.TabIndex = 37;
            checkBox2.Text = "Mua TDLT";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // goBack
            // 
            goBack.AutoSize = true;
            goBack.Location = new Point(18, 263);
            goBack.Margin = new Padding(3, 2, 3, 2);
            goBack.Name = "goBack";
            goBack.Size = new Size(66, 19);
            goBack.TabIndex = 33;
            goBack.Text = "Goback";
            goBack.UseVisualStyleBackColor = true;
            // 
            // useItem
            // 
            useItem.AutoSize = true;
            useItem.Location = new Point(18, 158);
            useItem.Margin = new Padding(3, 2, 3, 2);
            useItem.Name = "useItem";
            useItem.Size = new Size(82, 19);
            useItem.TabIndex = 32;
            useItem.Text = "Dùng item";
            useItem.UseVisualStyleBackColor = true;
            // 
            // strUseItem
            // 
            strUseItem.Location = new Point(108, 158);
            strUseItem.Margin = new Padding(3, 2, 3, 2);
            strUseItem.Name = "strUseItem";
            strUseItem.Size = new Size(169, 23);
            strUseItem.TabIndex = 31;
            // 
            // flag
            // 
            flag.AutoSize = true;
            flag.Location = new Point(283, 263);
            flag.Margin = new Padding(3, 2, 3, 2);
            flag.Name = "flag";
            flag.Size = new Size(59, 19);
            flag.TabIndex = 30;
            flag.Text = "Bật cờ";
            flag.UseVisualStyleBackColor = true;
            // 
            // pickItem
            // 
            pickItem.AutoSize = true;
            pickItem.Location = new Point(18, 106);
            pickItem.Margin = new Padding(3, 2, 3, 2);
            pickItem.Name = "pickItem";
            pickItem.Size = new Size(79, 19);
            pickItem.TabIndex = 26;
            pickItem.Text = "Nhặt item";
            pickItem.UseVisualStyleBackColor = true;
            // 
            // useSkills
            // 
            useSkills.AutoSize = true;
            useSkills.Location = new Point(18, 184);
            useSkills.Margin = new Padding(3, 2, 3, 2);
            useSkills.Name = "useSkills";
            useSkills.Size = new Size(111, 19);
            useSkills.TabIndex = 25;
            useSkills.Text = "Dùng nhiều skill";
            useSkills.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 211);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 21;
            label8.Text = "D.sách skill";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 181);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 19;
            // 
            // strSkills
            // 
            strSkills.Location = new Point(108, 211);
            strSkills.Margin = new Padding(3, 2, 3, 2);
            strSkills.Name = "strSkills";
            strSkills.Size = new Size(169, 23);
            strSkills.TabIndex = 18;
            // 
            // strPick
            // 
            strPick.Location = new Point(108, 106);
            strPick.Margin = new Padding(3, 2, 3, 2);
            strPick.Name = "strPick";
            strPick.Size = new Size(169, 23);
            strPick.TabIndex = 14;
            // 
            // applyBtn
            // 
            applyBtn.BackColor = Color.LightGray;
            applyBtn.Location = new Point(262, 296);
            applyBtn.Margin = new Padding(3, 2, 3, 2);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(82, 25);
            applyBtn.TabIndex = 13;
            applyBtn.Text = "Áp dụng";
            applyBtn.UseVisualStyleBackColor = false;
            applyBtn.Click += ConfigAuto_Click;
            // 
            // zoneID
            // 
            zoneID.Location = new Point(286, 22);
            zoneID.Margin = new Padding(3, 2, 3, 2);
            zoneID.Name = "zoneID";
            zoneID.Size = new Size(58, 23);
            zoneID.TabIndex = 2;
            // 
            // mapID
            // 
            mapID.DropDownStyle = ComboBoxStyle.DropDownList;
            mapID.FormattingEnabled = true;
            mapID.Location = new Point(108, 22);
            mapID.Margin = new Padding(3, 2, 3, 2);
            mapID.Name = "mapID";
            mapID.Size = new Size(169, 23);
            mapID.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 24);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "Map/khu";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(925, 386);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "QLTK";
            FormClosed += MainForm_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dame).EndInit();
            ((System.ComponentModel.ISupportInitialize)ki).EndInit();
            ((System.ComponentModel.ISupportInitialize)hp).EndInit();
            ((System.ComponentModel.ISupportInitialize)zoneID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox indexServer;
        private TextBox password;
        private TextBox username;
        private Label label3;
        private Label label2;
        private RadioButton httpProxy_rdb;
        private RadioButton sockProxy_rdb;
        private RadioButton noProxy_rdb;
        private TextBox strProxy;
        private Button EditBtn;
        private Button deleteBtn;
        private Button addBtn;
        private GroupBox groupBox2;
        private Button uncheckBtn;
        private Button checkBtn;
        private Button offBtn;
        private Button onBtn;
        private GroupBox groupBox3;
        private Label label4;
        private NumericUpDown zoneID;
        private ComboBox mapID;
        private RadioButton trainType3;
        private RadioButton trainType2;
        private RadioButton trainType1;
        private Button applyBtn;
        private Label label7;
        private TextBox strSkills;
        private TextBox strPick;
        private Label label8;
        private CheckBox flag;
        private CheckBox pickItem;
        private CheckBox useSkills;
        private RadioButton trainAll;
        private RadioButton trainSuper;
        private RadioButton trainNormal;
        private CheckBox goBack;
        private CheckBox useItem;
        private TextBox strUseItem;
        private CheckBox goBackOutKi;
        private CheckBox checkBox2;
        private NumericUpDown dame;
        private NumericUpDown ki;
        private NumericUpDown hp;
        private Label label5;
        private Label label6;
        private RadioButton pickType3;
        private RadioButton pickType2;
        private RadioButton pickType1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridViewCheckBoxColumn tick;
        private DataGridViewTextBoxColumn acc;
        private DataGridViewTextBoxColumn pwd;
        private DataGridViewTextBoxColumn server;
        private DataGridViewTextBoxColumn map;
        private DataGridViewTextBoxColumn proxy;
        private DataGridViewTextBoxColumn status;
        private Button sortTabBtn;
    }
}
