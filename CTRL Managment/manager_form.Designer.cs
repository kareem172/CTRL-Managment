
namespace CTRL_Managment
{
    partial class manager_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_form));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.profile_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.seller_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selection_panel = new System.Windows.Forms.Panel();
            this.applicant_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.task_list = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managmentDataSet1 = new CTRL_Managment.managmentDataSet1();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tasl_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.task_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.customerTableAdapter = new CTRL_Managment.managmentDataSet1TableAdapters.customerTableAdapter();
            this.sellers1 = new CTRL_Managment.Sellers();
            this.applicants1 = new CTRL_Managment.Applicants();
            this.profile1 = new CTRL_Managment.Profile();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Exit_btn);
            this.panel3.Controls.Add(this.back_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(138, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 46);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Home";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Image = global::CTRL_Managment.Properties.Resources.delete_icon;
            this.Exit_btn.Location = new System.Drawing.Point(727, 6);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(29, 30);
            this.Exit_btn.TabIndex = 5;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Image = global::CTRL_Managment.Properties.Resources.Praveen_Minimal_Outline_Back_2;
            this.back_btn.Location = new System.Drawing.Point(676, 6);
            this.back_btn.Margin = new System.Windows.Forms.Padding(6);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(39, 30);
            this.back_btn.TabIndex = 6;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 107);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home_btn
            // 
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_btn.Location = new System.Drawing.Point(0, 107);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(138, 75);
            this.home_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.home_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.home_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.home_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.home_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.home_btn.StateCommon.Border.Rounding = 1;
            this.home_btn.StateCommon.Border.Width = 1;
            this.home_btn.TabIndex = 1;
            this.home_btn.Values.Text = "Home";
            this.home_btn.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_btn.Location = new System.Drawing.Point(0, 182);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(138, 75);
            this.profile_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.profile_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.profile_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.profile_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.profile_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profile_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.profile_btn.StateCommon.Border.Rounding = 1;
            this.profile_btn.TabIndex = 2;
            this.profile_btn.Values.Text = "Profile";
            this.profile_btn.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // seller_btn
            // 
            this.seller_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.seller_btn.Location = new System.Drawing.Point(0, 257);
            this.seller_btn.Name = "seller_btn";
            this.seller_btn.Size = new System.Drawing.Size(138, 75);
            this.seller_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.seller_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.seller_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.seller_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.seller_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.seller_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.seller_btn.StateCommon.Border.Rounding = 1;
            this.seller_btn.TabIndex = 3;
            this.seller_btn.Values.Text = "Sellers";
            this.seller_btn.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selection_panel);
            this.panel1.Controls.Add(this.applicant_btn);
            this.panel1.Controls.Add(this.seller_btn);
            this.panel1.Controls.Add(this.profile_btn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 520);
            this.panel1.TabIndex = 7;
            // 
            // selection_panel
            // 
            this.selection_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(234)))));
            this.selection_panel.Location = new System.Drawing.Point(128, 107);
            this.selection_panel.Name = "selection_panel";
            this.selection_panel.Size = new System.Drawing.Size(10, 75);
            this.selection_panel.TabIndex = 16;
            // 
            // applicant_btn
            // 
            this.applicant_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.applicant_btn.Location = new System.Drawing.Point(0, 332);
            this.applicant_btn.Name = "applicant_btn";
            this.applicant_btn.Size = new System.Drawing.Size(138, 75);
            this.applicant_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.applicant_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.applicant_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.applicant_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.applicant_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.applicant_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.applicant_btn.StateCommon.Border.Rounding = 1;
            this.applicant_btn.TabIndex = 5;
            this.applicant_btn.Values.Text = "Applicants";
            this.applicant_btn.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // task_list
            // 
            this.task_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.task_list.CheckOnClick = true;
            this.task_list.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_list.FormattingEnabled = true;
            this.task_list.Items.AddRange(new object[] {
            "Check Sellers Salary",
            "Check the Sales of the Company",
            "Attend the Board meeting",
            "Sign with new Sellers"});
            this.task_list.Location = new System.Drawing.Point(16, 43);
            this.task_list.Name = "task_list";
            this.task_list.Size = new System.Drawing.Size(365, 166);
            this.task_list.TabIndex = 15;
            this.task_list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kryptonDataGridView1);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.tasl_txt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.task_btn);
            this.panel4.Controls.Add(this.task_list);
            this.panel4.Controls.Add(this.sellers1);
            this.panel4.Controls.Add(this.applicants1);
            this.panel4.Controls.Add(this.profile1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(138, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 474);
            this.panel4.TabIndex = 9;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.packageNumDataGridViewTextBoxColumn,
            this.packagePriceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonDataGridView1.DataSource = this.customerBindingSource;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(16, 215);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(731, 247);
            this.kryptonDataGridView1.TabIndex = 27;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "sale_ID";
            this.saleIDDataGridViewTextBoxColumn.FillWeight = 362.5668F;
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "sale_ID";
            this.saleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            this.saleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.FillWeight = 47.48663F;
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.FillWeight = 47.48663F;
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // packageNumDataGridViewTextBoxColumn
            // 
            this.packageNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packageNumDataGridViewTextBoxColumn.DataPropertyName = "PackageNum";
            this.packageNumDataGridViewTextBoxColumn.FillWeight = 47.48663F;
            this.packageNumDataGridViewTextBoxColumn.HeaderText = "PackageNum";
            this.packageNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageNumDataGridViewTextBoxColumn.Name = "packageNumDataGridViewTextBoxColumn";
            // 
            // packagePriceDataGridViewTextBoxColumn
            // 
            this.packagePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packagePriceDataGridViewTextBoxColumn.DataPropertyName = "PackagePrice";
            this.packagePriceDataGridViewTextBoxColumn.FillWeight = 47.48663F;
            this.packagePriceDataGridViewTextBoxColumn.HeaderText = "PackagePrice";
            this.packagePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packagePriceDataGridViewTextBoxColumn.Name = "packagePriceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 47.48663F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.managmentDataSet1;
            // 
            // managmentDataSet1
            // 
            this.managmentDataSet1.DataSetName = "managmentDataSet1";
            this.managmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.progressBar1.Location = new System.Drawing.Point(390, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(357, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 26;
            // 
            // tasl_txt
            // 
            this.tasl_txt.Location = new System.Drawing.Point(390, 102);
            this.tasl_txt.Margin = new System.Windows.Forms.Padding(6);
            this.tasl_txt.Name = "tasl_txt";
            this.tasl_txt.Size = new System.Drawing.Size(357, 37);
            this.tasl_txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tasl_txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tasl_txt.StateActive.Border.Rounding = 20;
            this.tasl_txt.StateActive.Border.Width = 1;
            this.tasl_txt.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.tasl_txt.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasl_txt.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tasl_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tasl_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tasl_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tasl_txt.StateCommon.Border.Rounding = 20;
            this.tasl_txt.StateCommon.Border.Width = 2;
            this.tasl_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tasl_txt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasl_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tasl_txt.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.tasl_txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tasl_txt.StateDisabled.Border.Rounding = 20;
            this.tasl_txt.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.tasl_txt.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasl_txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.tasl_txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasl_txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tasl_txt.StateNormal.Border.Rounding = 20;
            this.tasl_txt.StateNormal.Border.Width = 1;
            this.tasl_txt.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.tasl_txt.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasl_txt.TabIndex = 25;
            this.tasl_txt.Tag = "";
            this.tasl_txt.Text = "Tasks";
            this.tasl_txt.Enter += new System.EventHandler(this.kryptonTextBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "TO DO List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "ADD Task";
            // 
            // task_btn
            // 
            this.task_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.task_btn.Location = new System.Drawing.Point(529, 156);
            this.task_btn.Name = "task_btn";
            this.task_btn.Size = new System.Drawing.Size(221, 39);
            this.task_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.task_btn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.task_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.task_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.task_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.task_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.task_btn.StateCommon.Border.Rounding = 20;
            this.task_btn.StateCommon.Border.Width = 1;
            this.task_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_btn.TabIndex = 24;
            this.task_btn.Values.Text = "ADD to TODO List";
            this.task_btn.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(422, 43);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.ReadOnly = true;
            this.kryptonTextBox1.Size = new System.Drawing.Size(293, 37);
            this.kryptonTextBox1.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateActive.Border.Rounding = 20;
            this.kryptonTextBox1.StateActive.Border.Width = 1;
            this.kryptonTextBox1.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox1.StateCommon.Border.Width = 2;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateDisabled.Border.Rounding = 20;
            this.kryptonTextBox1.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.kryptonTextBox1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateNormal.Border.Rounding = 20;
            this.kryptonTextBox1.StateNormal.Border.Width = 1;
            this.kryptonTextBox1.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 16;
            this.kryptonTextBox1.Tag = "";
            this.kryptonTextBox1.Text = "Full Name";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // sellers1
            // 
            this.sellers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sellers1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellers1.Location = new System.Drawing.Point(-106, 438);
            this.sellers1.Name = "sellers1";
            this.sellers1.Size = new System.Drawing.Size(762, 474);
            this.sellers1.TabIndex = 14;
            this.sellers1.Visible = false;
            // 
            // applicants1
            // 
            this.applicants1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.applicants1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applicants1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicants1.Location = new System.Drawing.Point(208, 438);
            this.applicants1.Name = "applicants1";
            this.applicants1.Size = new System.Drawing.Size(762, 474);
            this.applicants1.TabIndex = 13;
            this.applicants1.Visible = false;
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.profile1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile1.Location = new System.Drawing.Point(-351, 403);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(762, 474);
            this.profile1.TabIndex = 12;
            this.profile1.Visible = false;
            // 
            // manager_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "manager_form";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateActive.Border.Rounding = 15;
            this.StateActive.Border.Width = 1;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 2;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateInactive.Border.Rounding = 15;
            this.StateInactive.Border.Width = 1;
            this.Text = "manager_form";
            this.Load += new System.EventHandler(this.manager_form_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton home_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton profile_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton seller_btn;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton applicant_btn;
        private Profile profile1;
        private Applicants applicants1;
        private Sellers sellers1;
        private System.Windows.Forms.CheckedListBox task_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton task_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tasl_txt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Panel selection_panel;
        private managmentDataSet1 managmentDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private managmentDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}