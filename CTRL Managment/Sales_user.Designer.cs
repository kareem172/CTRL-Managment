
namespace CTRL_Managment
{
    partial class Sales_user
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
            this.sell_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.edit_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pack_price = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pack_num = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cus_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managmentDataSet1 = new CTRL_Managment.managmentDataSet1();
            this.sale_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new CTRL_Managment.managmentDataSet1TableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sell_btn
            // 
            this.sell_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sell_btn.Location = new System.Drawing.Point(587, 403);
            this.sell_btn.Name = "sell_btn";
            this.sell_btn.Size = new System.Drawing.Size(171, 39);
            this.sell_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.sell_btn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.sell_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sell_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sell_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sell_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sell_btn.StateCommon.Border.Rounding = 20;
            this.sell_btn.StateCommon.Border.Width = 1;
            this.sell_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_btn.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.sell_btn.StateDisabled.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.sell_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.sell_btn.StateNormal.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.sell_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.sell_btn.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.sell_btn.TabIndex = 25;
            this.sell_btn.Values.Text = "Sell";
            this.sell_btn.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.Location = new System.Drawing.Point(330, 403);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(171, 39);
            this.edit_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.edit_btn.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.edit_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.edit_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.edit_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.edit_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.edit_btn.StateCommon.Border.Rounding = 20;
            this.edit_btn.StateCommon.Border.Width = 1;
            this.edit_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.TabIndex = 26;
            this.edit_btn.Values.Text = "Edit";
            this.edit_btn.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "price of the package";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Number of packages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customer Name";
            // 
            // pack_price
            // 
            this.pack_price.Location = new System.Drawing.Point(6, 336);
            this.pack_price.Margin = new System.Windows.Forms.Padding(6);
            this.pack_price.Name = "pack_price";
            this.pack_price.Size = new System.Drawing.Size(293, 37);
            this.pack_price.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_price.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pack_price.StateActive.Border.Rounding = 20;
            this.pack_price.StateActive.Border.Width = 1;
            this.pack_price.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_price.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_price.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pack_price.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.pack_price.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_price.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pack_price.StateCommon.Border.Rounding = 20;
            this.pack_price.StateCommon.Border.Width = 2;
            this.pack_price.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_price.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_price.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pack_price.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.pack_price.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_price.StateDisabled.Border.Rounding = 20;
            this.pack_price.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_price.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_price.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.pack_price.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_price.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_price.StateNormal.Border.Rounding = 20;
            this.pack_price.StateNormal.Border.Width = 1;
            this.pack_price.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_price.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_price.TabIndex = 16;
            this.pack_price.Tag = "";
            this.pack_price.Text = "EGP";
            this.pack_price.Enter += new System.EventHandler(this.kryptonTextBox3_Enter);
            // 
            // pack_num
            // 
            this.pack_num.Location = new System.Drawing.Point(6, 273);
            this.pack_num.Margin = new System.Windows.Forms.Padding(6);
            this.pack_num.Name = "pack_num";
            this.pack_num.Size = new System.Drawing.Size(293, 37);
            this.pack_num.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_num.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pack_num.StateActive.Border.Rounding = 20;
            this.pack_num.StateActive.Border.Width = 1;
            this.pack_num.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_num.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_num.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pack_num.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.pack_num.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_num.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pack_num.StateCommon.Border.Rounding = 20;
            this.pack_num.StateCommon.Border.Width = 2;
            this.pack_num.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_num.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_num.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pack_num.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.pack_num.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_num.StateDisabled.Border.Rounding = 20;
            this.pack_num.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_num.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_num.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.pack_num.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pack_num.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pack_num.StateNormal.Border.Rounding = 20;
            this.pack_num.StateNormal.Border.Width = 1;
            this.pack_num.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.pack_num.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_num.TabIndex = 17;
            this.pack_num.Tag = "";
            this.pack_num.Text = "0";
            this.pack_num.Enter += new System.EventHandler(this.kryptonTextBox2_Enter);
            // 
            // cus_name
            // 
            this.cus_name.Location = new System.Drawing.Point(6, 210);
            this.cus_name.Margin = new System.Windows.Forms.Padding(6);
            this.cus_name.Name = "cus_name";
            this.cus_name.Size = new System.Drawing.Size(293, 37);
            this.cus_name.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cus_name.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cus_name.StateActive.Border.Rounding = 20;
            this.cus_name.StateActive.Border.Width = 1;
            this.cus_name.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.cus_name.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_name.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cus_name.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cus_name.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cus_name.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cus_name.StateCommon.Border.Rounding = 20;
            this.cus_name.StateCommon.Border.Width = 2;
            this.cus_name.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.cus_name.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cus_name.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.cus_name.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cus_name.StateDisabled.Border.Rounding = 20;
            this.cus_name.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.cus_name.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_name.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.cus_name.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cus_name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cus_name.StateNormal.Border.Rounding = 20;
            this.cus_name.StateNormal.Border.Width = 1;
            this.cus_name.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.cus_name.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_name.TabIndex = 18;
            this.cus_name.Tag = "";
            this.cus_name.Text = "Full Name";
            this.cus_name.Enter += new System.EventHandler(this.kryptonTextBox1_Enter);
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
            this.kryptonDataGridView1.Location = new System.Drawing.Point(330, 33);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(428, 349);
            this.kryptonDataGridView1.TabIndex = 12;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "sale_ID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "sale_ID";
            this.saleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            this.saleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageNumDataGridViewTextBoxColumn
            // 
            this.packageNumDataGridViewTextBoxColumn.DataPropertyName = "PackageNum";
            this.packageNumDataGridViewTextBoxColumn.HeaderText = "PackageNum";
            this.packageNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageNumDataGridViewTextBoxColumn.Name = "packageNumDataGridViewTextBoxColumn";
            this.packageNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // packagePriceDataGridViewTextBoxColumn
            // 
            this.packagePriceDataGridViewTextBoxColumn.DataPropertyName = "PackagePrice";
            this.packagePriceDataGridViewTextBoxColumn.HeaderText = "PackagePrice";
            this.packagePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packagePriceDataGridViewTextBoxColumn.Name = "packagePriceDataGridViewTextBoxColumn";
            this.packagePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
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
            // sale_ID
            // 
            this.sale_ID.Location = new System.Drawing.Point(6, 53);
            this.sale_ID.Margin = new System.Windows.Forms.Padding(6);
            this.sale_ID.Name = "sale_ID";
            this.sale_ID.Size = new System.Drawing.Size(293, 37);
            this.sale_ID.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sale_ID.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sale_ID.StateActive.Border.Rounding = 20;
            this.sale_ID.StateActive.Border.Width = 1;
            this.sale_ID.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.sale_ID.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_ID.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sale_ID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.sale_ID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sale_ID.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sale_ID.StateCommon.Border.Rounding = 20;
            this.sale_ID.StateCommon.Border.Width = 2;
            this.sale_ID.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.sale_ID.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_ID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sale_ID.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.sale_ID.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sale_ID.StateDisabled.Border.Rounding = 20;
            this.sale_ID.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.sale_ID.StateDisabled.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_ID.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.sale_ID.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sale_ID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sale_ID.StateNormal.Border.Rounding = 20;
            this.sale_ID.StateNormal.Border.Width = 1;
            this.sale_ID.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.sale_ID.StateNormal.Content.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_ID.TabIndex = 18;
            this.sale_ID.Tag = "";
            this.sale_ID.Text = "ID";
            this.sale_ID.Enter += new System.EventHandler(this.kryptonTextBox4_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sale ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(21, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "*ID is used for edit only*";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Sales_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sell_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pack_price);
            this.Controls.Add(this.sale_ID);
            this.Controls.Add(this.pack_num);
            this.Controls.Add(this.cus_name);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Sales_user";
            this.Size = new System.Drawing.Size(762, 474);
            this.Load += new System.EventHandler(this.Sales_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton sell_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton edit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pack_price;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pack_num;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cus_name;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox sale_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private managmentDataSet1 managmentDataSet1;
        private managmentDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
    }
}
