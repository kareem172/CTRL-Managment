
namespace CTRL_Managment
{
    partial class Applicants
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
            this.label2 = new System.Windows.Forms.Label();
            this.f_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.email_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.degree_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dob_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reject_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.accept_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.applicantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managmentDataSet1 = new CTRL_Managment.managmentDataSet1();
            this.applicantsTableAdapter = new CTRL_Managment.managmentDataSet1TableAdapters.ApplicantsTableAdapter();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Full Name";
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(6, 63);
            this.f_name.Margin = new System.Windows.Forms.Padding(6);
            this.f_name.Name = "f_name";
            this.f_name.ReadOnly = true;
            this.f_name.Size = new System.Drawing.Size(293, 37);
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
            this.f_name.TabIndex = 9;
            this.f_name.Tag = "";
            this.f_name.Text = "Full Name";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(6, 126);
            this.email_txt.Margin = new System.Windows.Forms.Padding(6);
            this.email_txt.Name = "email_txt";
            this.email_txt.ReadOnly = true;
            this.email_txt.Size = new System.Drawing.Size(293, 37);
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
            this.email_txt.TabIndex = 9;
            this.email_txt.Tag = "";
            this.email_txt.Text = "E-mail@example.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "E-mail";
            // 
            // degree_txt
            // 
            this.degree_txt.Location = new System.Drawing.Point(6, 189);
            this.degree_txt.Margin = new System.Windows.Forms.Padding(6);
            this.degree_txt.Name = "degree_txt";
            this.degree_txt.ReadOnly = true;
            this.degree_txt.Size = new System.Drawing.Size(293, 37);
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
            this.degree_txt.TabIndex = 9;
            this.degree_txt.Tag = "";
            this.degree_txt.Text = "Degree";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Degree";
            // 
            // dob_txt
            // 
            this.dob_txt.Location = new System.Drawing.Point(6, 252);
            this.dob_txt.Margin = new System.Windows.Forms.Padding(6);
            this.dob_txt.Name = "dob_txt";
            this.dob_txt.ReadOnly = true;
            this.dob_txt.Size = new System.Drawing.Size(293, 37);
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
            this.dob_txt.TabIndex = 9;
            this.dob_txt.Tag = "";
            this.dob_txt.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date of birth";
            // 
            // salary_txt
            // 
            this.salary_txt.Location = new System.Drawing.Point(6, 378);
            this.salary_txt.Margin = new System.Windows.Forms.Padding(6);
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(293, 37);
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
            this.salary_txt.TabIndex = 9;
            this.salary_txt.Tag = "";
            this.salary_txt.Text = "EGP";
            this.salary_txt.Enter += new System.EventHandler(this.kryptonTextBox5_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary";
            // 
            // gender_txt
            // 
            this.gender_txt.Location = new System.Drawing.Point(6, 315);
            this.gender_txt.Margin = new System.Windows.Forms.Padding(6);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.ReadOnly = true;
            this.gender_txt.Size = new System.Drawing.Size(293, 37);
            this.gender_txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gender_txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.gender_txt.StateActive.Border.Rounding = 20;
            this.gender_txt.StateActive.Border.Width = 1;
            this.gender_txt.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.gender_txt.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_txt.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gender_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.gender_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gender_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.gender_txt.StateCommon.Border.Rounding = 20;
            this.gender_txt.StateCommon.Border.Width = 2;
            this.gender_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.gender_txt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gender_txt.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.gender_txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gender_txt.StateDisabled.Border.Rounding = 20;
            this.gender_txt.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.gender_txt.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.gender_txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gender_txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gender_txt.StateNormal.Border.Rounding = 20;
            this.gender_txt.StateNormal.Border.Width = 1;
            this.gender_txt.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.gender_txt.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_txt.TabIndex = 9;
            this.gender_txt.Tag = "";
            this.gender_txt.Text = "gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // reject_btn
            // 
            this.reject_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reject_btn.Location = new System.Drawing.Point(331, 410);
            this.reject_btn.Name = "reject_btn";
            this.reject_btn.Size = new System.Drawing.Size(171, 39);
            this.reject_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.reject_btn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.reject_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.reject_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.reject_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.reject_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.reject_btn.StateCommon.Border.Rounding = 20;
            this.reject_btn.StateCommon.Border.Width = 1;
            this.reject_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject_btn.TabIndex = 11;
            this.reject_btn.Values.Text = "Reject";
            this.reject_btn.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // accept_btn
            // 
            this.accept_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept_btn.Location = new System.Drawing.Point(588, 410);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(171, 39);
            this.accept_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.accept_btn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.accept_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.accept_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.accept_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.accept_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.accept_btn.StateCommon.Border.Rounding = 20;
            this.accept_btn.StateCommon.Border.Width = 1;
            this.accept_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_btn.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.accept_btn.StateDisabled.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.accept_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.accept_btn.StateNormal.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.accept_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.accept_btn.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.accept_btn.TabIndex = 11;
            this.accept_btn.Values.Text = "Accept";
            this.accept_btn.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.doBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonDataGridView1.DataSource = this.applicantsBindingSource1;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(331, 40);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(428, 349);
            this.kryptonDataGridView1.TabIndex = 23;
            this.kryptonDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellContentClick_1);
            // 
            // applicantsBindingSource
            // 
            this.applicantsBindingSource.DataMember = "Applicants";
            this.applicantsBindingSource.DataSource = this.managmentDataSet1;
            // 
            // managmentDataSet1
            // 
            this.managmentDataSet1.DataSetName = "managmentDataSet1";
            this.managmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantsTableAdapter
            // 
            this.applicantsTableAdapter.ClearBeforeFill = true;
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
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicantsBindingSource1
            // 
            this.applicantsBindingSource1.DataMember = "Applicants";
            this.applicantsBindingSource1.DataSource = this.managmentDataSet1;
            // 
            // Applicants
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.reject_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gender_txt);
            this.Controls.Add(this.salary_txt);
            this.Controls.Add(this.dob_txt);
            this.Controls.Add(this.degree_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.f_name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Applicants";
            this.Size = new System.Drawing.Size(762, 474);
            this.Load += new System.EventHandler(this.Applicants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox f_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_txt;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox degree_txt;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox dob_txt;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox salary_txt;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox gender_txt;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton reject_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton accept_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.BindingSource applicantsBindingSource;
        private managmentDataSet1 managmentDataSet1;
        private managmentDataSet1TableAdapters.ApplicantsTableAdapter applicantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource applicantsBindingSource1;
    }
}
