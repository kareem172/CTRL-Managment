
namespace CTRL_Managment
{
    partial class Sellers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salary_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dob_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.degree_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.f_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.email_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.update_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.letGo_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managmentDataSet2 = new CTRL_Managment.managmentDataSet2();
            this.sellersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter1 = new CTRL_Managment.managmentDataSet2TableAdapters.SellersTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Degree";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Full Name";
            // 
            // salary_txt
            // 
            this.salary_txt.Location = new System.Drawing.Point(6, 420);
            this.salary_txt.Margin = new System.Windows.Forms.Padding(6);
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(284, 37);
            this.salary_txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.salary_txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.salary_txt.StateActive.Border.Rounding = 20;
            this.salary_txt.StateActive.Border.Width = 1;
            this.salary_txt.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.salary_txt.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_txt.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.salary_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.salary_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.salary_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.salary_txt.StateCommon.Border.Rounding = 20;
            this.salary_txt.StateCommon.Border.Width = 2;
            this.salary_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.salary_txt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.salary_txt.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.salary_txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.salary_txt.StateDisabled.Border.Rounding = 20;
            this.salary_txt.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.salary_txt.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.salary_txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salary_txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.salary_txt.StateNormal.Border.Rounding = 20;
            this.salary_txt.StateNormal.Border.Width = 1;
            this.salary_txt.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.salary_txt.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_txt.TabIndex = 15;
            this.salary_txt.Tag = "";
            this.salary_txt.Text = "EGP";
            this.salary_txt.Enter += new System.EventHandler(this.kryptonTextBox6_Enter);
            // 
            // dob_txt
            // 
            this.dob_txt.Location = new System.Drawing.Point(6, 347);
            this.dob_txt.Margin = new System.Windows.Forms.Padding(6);
            this.dob_txt.Name = "dob_txt";
            this.dob_txt.Size = new System.Drawing.Size(284, 37);
            this.dob_txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dob_txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dob_txt.StateActive.Border.Rounding = 20;
            this.dob_txt.StateActive.Border.Width = 1;
            this.dob_txt.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.dob_txt.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_txt.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dob_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dob_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dob_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dob_txt.StateCommon.Border.Rounding = 20;
            this.dob_txt.StateCommon.Border.Width = 2;
            this.dob_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.dob_txt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dob_txt.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.dob_txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dob_txt.StateDisabled.Border.Rounding = 20;
            this.dob_txt.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.dob_txt.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.dob_txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dob_txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dob_txt.StateNormal.Border.Rounding = 20;
            this.dob_txt.StateNormal.Border.Width = 1;
            this.dob_txt.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.dob_txt.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_txt.TabIndex = 16;
            this.dob_txt.Tag = "";
            this.dob_txt.Text = "DOB";
            this.dob_txt.Enter += new System.EventHandler(this.kryptonTextBox4_Enter);
            // 
            // degree_txt
            // 
            this.degree_txt.Location = new System.Drawing.Point(6, 274);
            this.degree_txt.Margin = new System.Windows.Forms.Padding(6);
            this.degree_txt.Name = "degree_txt";
            this.degree_txt.Size = new System.Drawing.Size(284, 37);
            this.degree_txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.degree_txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.degree_txt.StateActive.Border.Rounding = 20;
            this.degree_txt.StateActive.Border.Width = 1;
            this.degree_txt.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.degree_txt.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_txt.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.degree_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.degree_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.degree_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.degree_txt.StateCommon.Border.Rounding = 20;
            this.degree_txt.StateCommon.Border.Width = 2;
            this.degree_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.degree_txt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.degree_txt.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.degree_txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.degree_txt.StateDisabled.Border.Rounding = 20;
            this.degree_txt.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.degree_txt.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.degree_txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.degree_txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.degree_txt.StateNormal.Border.Rounding = 20;
            this.degree_txt.StateNormal.Border.Width = 1;
            this.degree_txt.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.degree_txt.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_txt.TabIndex = 14;
            this.degree_txt.Tag = "";
            this.degree_txt.Text = "Degree";
            this.degree_txt.Enter += new System.EventHandler(this.kryptonTextBox3_Enter);
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(6, 128);
            this.f_name.Margin = new System.Windows.Forms.Padding(6);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(284, 37);
            this.f_name.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.f_name.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.f_name.StateActive.Border.Rounding = 20;
            this.f_name.StateActive.Border.Width = 1;
            this.f_name.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.f_name.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_name.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.f_name.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.f_name.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.f_name.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.f_name.StateCommon.Border.Rounding = 20;
            this.f_name.StateCommon.Border.Width = 2;
            this.f_name.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.f_name.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.f_name.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.f_name.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.f_name.StateDisabled.Border.Rounding = 20;
            this.f_name.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.f_name.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_name.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.f_name.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.f_name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.f_name.StateNormal.Border.Rounding = 20;
            this.f_name.StateNormal.Border.Width = 1;
            this.f_name.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.f_name.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_name.TabIndex = 12;
            this.f_name.Tag = "";
            this.f_name.Text = "First&Last Name";
            this.f_name.Enter += new System.EventHandler(this.kryptonTextBox1_Enter);
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(6, 201);
            this.email_txt.Margin = new System.Windows.Forms.Padding(6);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(284, 37);
            this.email_txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email_txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.email_txt.StateActive.Border.Rounding = 20;
            this.email_txt.StateActive.Border.Width = 1;
            this.email_txt.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.email_txt.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.email_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.email_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.email_txt.StateCommon.Border.Rounding = 20;
            this.email_txt.StateCommon.Border.Width = 2;
            this.email_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.email_txt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.email_txt.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.email_txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email_txt.StateDisabled.Border.Rounding = 20;
            this.email_txt.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.email_txt.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.email_txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.email_txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email_txt.StateNormal.Border.Rounding = 20;
            this.email_txt.StateNormal.Border.Width = 1;
            this.email_txt.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.email_txt.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.TabIndex = 13;
            this.email_txt.Tag = "";
            this.email_txt.Text = "E-mail@example.com";
            this.email_txt.Enter += new System.EventHandler(this.kryptonTextBox2_Enter);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.UserName,
            this.emailDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.doBDataGridViewTextBoxColumn,
            this.salary});
            this.kryptonDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonDataGridView1.DataSource = this.sellersBindingSource1;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(322, 55);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(428, 349);
            this.kryptonDataGridView1.TabIndex = 22;
            this.kryptonDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellContentClick);
            this.kryptonDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellContentClick);
            // 
            // update_btn
            // 
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.Location = new System.Drawing.Point(579, 420);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(171, 39);
            this.update_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.update_btn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.update_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.update_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.update_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.update_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.update_btn.StateCommon.Border.Rounding = 20;
            this.update_btn.StateCommon.Border.Width = 1;
            this.update_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.TabIndex = 23;
            this.update_btn.Values.Text = "Update Info";
            this.update_btn.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // letGo_btn
            // 
            this.letGo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letGo_btn.Location = new System.Drawing.Point(322, 420);
            this.letGo_btn.Name = "letGo_btn";
            this.letGo_btn.Size = new System.Drawing.Size(171, 39);
            this.letGo_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.letGo_btn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.letGo_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.letGo_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.letGo_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.letGo_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.letGo_btn.StateCommon.Border.Rounding = 20;
            this.letGo_btn.StateCommon.Border.Width = 1;
            this.letGo_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letGo_btn.TabIndex = 24;
            this.letGo_btn.Values.Text = "Let Go";
            this.letGo_btn.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(6, 55);
            this.ID_txt.Margin = new System.Windows.Forms.Padding(6);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(284, 37);
            this.ID_txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID_txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ID_txt.StateActive.Border.Rounding = 20;
            this.ID_txt.StateActive.Border.Width = 1;
            this.ID_txt.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.ID_txt.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ID_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ID_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ID_txt.StateCommon.Border.Rounding = 20;
            this.ID_txt.StateCommon.Border.Width = 2;
            this.ID_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ID_txt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ID_txt.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.ID_txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID_txt.StateDisabled.Border.Rounding = 20;
            this.ID_txt.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.ID_txt.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.ID_txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ID_txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID_txt.StateNormal.Border.Rounding = 20;
            this.ID_txt.StateNormal.Border.Width = 1;
            this.ID_txt.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.ID_txt.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.TabIndex = 25;
            this.ID_txt.Tag = "";
            this.ID_txt.Text = "id";
            this.ID_txt.Enter += new System.EventHandler(this.kryptonTextBox5_Enter);
            // 
            // managmentDataSet2
            // 
            this.managmentDataSet2.DataSetName = "managmentDataSet2";
            this.managmentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellersBindingSource1
            // 
            this.sellersBindingSource1.DataMember = "Sellers";
            this.sellersBindingSource1.DataSource = this.managmentDataSet2;
            // 
            // sellersTableAdapter1
            // 
            this.sellersTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeDataGridViewTextBoxColumn.Width = 125;
            // 
            // doBDataGridViewTextBoxColumn
            // 
            this.doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            this.doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            this.doBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            this.doBDataGridViewTextBoxColumn.ReadOnly = true;
            this.doBDataGridViewTextBoxColumn.Width = 125;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 125;
            // 
            // Sellers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.letGo_btn);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salary_txt);
            this.Controls.Add(this.dob_txt);
            this.Controls.Add(this.degree_txt);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.email_txt);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Sellers";
            this.Size = new System.Drawing.Size(762, 474);
            this.Load += new System.EventHandler(this.Sellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox salary_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox dob_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox degree_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox f_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton update_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton letGo_btn;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ID_txt;
        internal System.Windows.Forms.BindingSource sellersBindingSource;
        internal System.Windows.Forms.BindingSource sellersBindingSource1;
        internal managmentDataSet2 managmentDataSet2;
        internal managmentDataSet2TableAdapters.SellersTableAdapter sellersTableAdapter1;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}
