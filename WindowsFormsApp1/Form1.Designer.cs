namespace WindowsFormsApp1
{
    partial class Frm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCEstd = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbPag = new System.Windows.Forms.ComboBox();
            this.lblPag = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpCompra = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.cmbQnt = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtLiv = new System.Windows.Forms.TextBox();
            this.lblLiv = new System.Windows.Forms.Label();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpLvr4 = new System.Windows.Forms.GroupBox();
            this.BoxLvr4 = new System.Windows.Forms.CheckBox();
            this.picQuatro = new System.Windows.Forms.PictureBox();
            this.grpLvr5 = new System.Windows.Forms.GroupBox();
            this.BoxLvr5 = new System.Windows.Forms.CheckBox();
            this.picCinco = new System.Windows.Forms.PictureBox();
            this.grpLvr6 = new System.Windows.Forms.GroupBox();
            this.BoxLvr6 = new System.Windows.Forms.CheckBox();
            this.picSeis = new System.Windows.Forms.PictureBox();
            this.grpLvr3 = new System.Windows.Forms.GroupBox();
            this.BoxLvr3 = new System.Windows.Forms.CheckBox();
            this.picTres = new System.Windows.Forms.PictureBox();
            this.grpLvr2 = new System.Windows.Forms.GroupBox();
            this.BoxLvr2 = new System.Windows.Forms.CheckBox();
            this.picDois = new System.Windows.Forms.PictureBox();
            this.grpLvr1 = new System.Windows.Forms.GroupBox();
            this.BoxLvr1 = new System.Windows.Forms.CheckBox();
            this.picUm = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.grpDados.SuspendLayout();
            this.grpCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpLvr4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuatro)).BeginInit();
            this.grpLvr5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCinco)).BeginInit();
            this.grpLvr6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeis)).BeginInit();
            this.grpLvr3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTres)).BeginInit();
            this.grpLvr2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDois)).BeginInit();
            this.grpLvr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 100;
            this.lblName.Text = "Nome:";
            // 
            // lblCEstd
            // 
            this.lblCEstd.AutoSize = true;
            this.lblCEstd.Location = new System.Drawing.Point(6, 95);
            this.lblCEstd.Name = "lblCEstd";
            this.lblCEstd.Size = new System.Drawing.Size(43, 13);
            this.lblCEstd.TabIndex = 4444;
            this.lblCEstd.Text = "Estado:";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.btnLimp);
            this.grpDados.Controls.Add(this.btnConfirm);
            this.grpDados.Controls.Add(this.cmbPag);
            this.grpDados.Controls.Add(this.lblPag);
            this.grpDados.Controls.Add(this.groupBox2);
            this.grpDados.Controls.Add(this.lblName);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(245, 137);
            this.grpDados.TabIndex = 222;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados de Usuário";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(30, 108);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbPag
            // 
            this.cmbPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPag.FormattingEnabled = true;
            this.cmbPag.Location = new System.Drawing.Point(76, 68);
            this.cmbPag.Name = "cmbPag";
            this.cmbPag.Size = new System.Drawing.Size(154, 21);
            this.cmbPag.TabIndex = 1;
            this.cmbPag.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPag
            // 
            this.lblPag.AutoSize = true;
            this.lblPag.Location = new System.Drawing.Point(6, 71);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(64, 13);
            this.lblPag.TabIndex = 101;
            this.lblPag.Text = "Pagamento:";
            this.lblPag.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(319, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 217);
            this.groupBox2.TabIndex = 866;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Detalhes:";
            // 
            // grpCompra
            // 
            this.grpCompra.Controls.Add(this.btnClear);
            this.grpCompra.Controls.Add(this.btnCalc);
            this.grpCompra.Controls.Add(this.cmbEst);
            this.grpCompra.Controls.Add(this.cmbQnt);
            this.grpCompra.Controls.Add(this.btnBuy);
            this.grpCompra.Controls.Add(this.lblCEstd);
            this.grpCompra.Controls.Add(this.txtLiv);
            this.grpCompra.Controls.Add(this.lblLiv);
            this.grpCompra.Controls.Add(this.lblQnt);
            this.grpCompra.Controls.Add(this.lblPreco);
            this.grpCompra.Controls.Add(this.txtPreco);
            this.grpCompra.Location = new System.Drawing.Point(12, 155);
            this.grpCompra.Name = "grpCompra";
            this.grpCompra.Size = new System.Drawing.Size(245, 402);
            this.grpCompra.TabIndex = 111;
            this.grpCompra.TabStop = false;
            this.grpCompra.Text = "Compra";
            this.grpCompra.Visible = false;
            this.grpCompra.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(76, 246);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cmbEst
            // 
            this.cmbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Location = new System.Drawing.Point(50, 92);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(180, 21);
            this.cmbEst.TabIndex = 5;
            // 
            // cmbQnt
            // 
            this.cmbQnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQnt.FormattingEnabled = true;
            this.cmbQnt.Location = new System.Drawing.Point(50, 139);
            this.cmbQnt.Name = "cmbQnt";
            this.cmbQnt.Size = new System.Drawing.Size(180, 21);
            this.cmbQnt.TabIndex = 6;
            this.cmbQnt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(135, 322);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtLiv
            // 
            this.txtLiv.Location = new System.Drawing.Point(50, 188);
            this.txtLiv.Name = "txtLiv";
            this.txtLiv.ReadOnly = true;
            this.txtLiv.Size = new System.Drawing.Size(180, 20);
            this.txtLiv.TabIndex = 7;
            this.txtLiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLiv.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblLiv
            // 
            this.lblLiv.AutoSize = true;
            this.lblLiv.Location = new System.Drawing.Point(11, 191);
            this.lblLiv.Name = "lblLiv";
            this.lblLiv.Size = new System.Drawing.Size(33, 13);
            this.lblLiv.TabIndex = 666;
            this.lblLiv.Text = "Livro:";
            this.lblLiv.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(10, 142);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(42, 13);
            this.lblQnt.TabIndex = 555;
            this.lblQnt.Text = "Quant.:";
            this.lblQnt.Click += new System.EventHandler(this.lblFrete_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(10, 48);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 333;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(50, 45);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(180, 20);
            this.txtPreco.TabIndex = 4;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpLvr4);
            this.groupBox1.Controls.Add(this.grpLvr5);
            this.groupBox1.Controls.Add(this.grpLvr6);
            this.groupBox1.Controls.Add(this.grpLvr3);
            this.groupBox1.Controls.Add(this.grpLvr2);
            this.groupBox1.Controls.Add(this.grpLvr1);
            this.groupBox1.Location = new System.Drawing.Point(300, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 574);
            this.groupBox1.TabIndex = 888;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpLvr4
            // 
            this.grpLvr4.Controls.Add(this.BoxLvr4);
            this.grpLvr4.Controls.Add(this.picQuatro);
            this.grpLvr4.Location = new System.Drawing.Point(31, 306);
            this.grpLvr4.Name = "grpLvr4";
            this.grpLvr4.Size = new System.Drawing.Size(166, 249);
            this.grpLvr4.TabIndex = 9;
            this.grpLvr4.TabStop = false;
            this.grpLvr4.Text = "Astrofísica Para Apressados";
            // 
            // BoxLvr4
            // 
            this.BoxLvr4.AutoSize = true;
            this.BoxLvr4.Location = new System.Drawing.Point(41, 222);
            this.BoxLvr4.Name = "BoxLvr4";
            this.BoxLvr4.Size = new System.Drawing.Size(85, 17);
            this.BoxLvr4.TabIndex = 488;
            this.BoxLvr4.Text = "Ver detalhes";
            this.BoxLvr4.UseVisualStyleBackColor = true;
            this.BoxLvr4.CheckedChanged += new System.EventHandler(this.BoxLvr4_CheckedChanged);
            // 
            // picQuatro
            // 
            this.picQuatro.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picQuatro.ErrorImage")));
            this.picQuatro.Image = ((System.Drawing.Image)(resources.GetObject("picQuatro.Image")));
            this.picQuatro.Location = new System.Drawing.Point(21, 37);
            this.picQuatro.Name = "picQuatro";
            this.picQuatro.Size = new System.Drawing.Size(129, 171);
            this.picQuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuatro.TabIndex = 0;
            this.picQuatro.TabStop = false;
            // 
            // grpLvr5
            // 
            this.grpLvr5.Controls.Add(this.BoxLvr5);
            this.grpLvr5.Controls.Add(this.picCinco);
            this.grpLvr5.Location = new System.Drawing.Point(339, 306);
            this.grpLvr5.Name = "grpLvr5";
            this.grpLvr5.Size = new System.Drawing.Size(166, 249);
            this.grpLvr5.TabIndex = 9;
            this.grpLvr5.TabStop = false;
            this.grpLvr5.Text = "O Ladrão de Raios";
            // 
            // BoxLvr5
            // 
            this.BoxLvr5.AutoSize = true;
            this.BoxLvr5.Location = new System.Drawing.Point(43, 222);
            this.BoxLvr5.Name = "BoxLvr5";
            this.BoxLvr5.Size = new System.Drawing.Size(85, 17);
            this.BoxLvr5.TabIndex = 599;
            this.BoxLvr5.Text = "Ver detalhes";
            this.BoxLvr5.UseVisualStyleBackColor = true;
            this.BoxLvr5.CheckedChanged += new System.EventHandler(this.BoxLvr5_CheckedChanged);
            // 
            // picCinco
            // 
            this.picCinco.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picCinco.ErrorImage")));
            this.picCinco.Image = ((System.Drawing.Image)(resources.GetObject("picCinco.Image")));
            this.picCinco.Location = new System.Drawing.Point(21, 37);
            this.picCinco.Name = "picCinco";
            this.picCinco.Size = new System.Drawing.Size(129, 171);
            this.picCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCinco.TabIndex = 0;
            this.picCinco.TabStop = false;
            this.picCinco.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // grpLvr6
            // 
            this.grpLvr6.Controls.Add(this.BoxLvr6);
            this.grpLvr6.Controls.Add(this.picSeis);
            this.grpLvr6.Location = new System.Drawing.Point(634, 306);
            this.grpLvr6.Name = "grpLvr6";
            this.grpLvr6.Size = new System.Drawing.Size(166, 249);
            this.grpLvr6.TabIndex = 9;
            this.grpLvr6.TabStop = false;
            this.grpLvr6.Text = "As Cronicas de Gelo e Fogo Vol.3";
            // 
            // BoxLvr6
            // 
            this.BoxLvr6.AutoSize = true;
            this.BoxLvr6.Location = new System.Drawing.Point(44, 222);
            this.BoxLvr6.Name = "BoxLvr6";
            this.BoxLvr6.Size = new System.Drawing.Size(85, 17);
            this.BoxLvr6.TabIndex = 677;
            this.BoxLvr6.Text = "Ver detalhes";
            this.BoxLvr6.UseVisualStyleBackColor = true;
            this.BoxLvr6.CheckedChanged += new System.EventHandler(this.BoxLvr6_CheckedChanged);
            // 
            // picSeis
            // 
            this.picSeis.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picSeis.ErrorImage")));
            this.picSeis.Image = ((System.Drawing.Image)(resources.GetObject("picSeis.Image")));
            this.picSeis.Location = new System.Drawing.Point(21, 37);
            this.picSeis.Name = "picSeis";
            this.picSeis.Size = new System.Drawing.Size(129, 171);
            this.picSeis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeis.TabIndex = 0;
            this.picSeis.TabStop = false;
            // 
            // grpLvr3
            // 
            this.grpLvr3.Controls.Add(this.BoxLvr3);
            this.grpLvr3.Controls.Add(this.picTres);
            this.grpLvr3.Location = new System.Drawing.Point(634, 44);
            this.grpLvr3.Name = "grpLvr3";
            this.grpLvr3.Size = new System.Drawing.Size(166, 229);
            this.grpLvr3.TabIndex = 9;
            this.grpLvr3.TabStop = false;
            this.grpLvr3.Text = "A Sútil Arte de Ligar o F*da-se";
            this.grpLvr3.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // BoxLvr3
            // 
            this.BoxLvr3.AutoSize = true;
            this.BoxLvr3.Location = new System.Drawing.Point(44, 201);
            this.BoxLvr3.Name = "BoxLvr3";
            this.BoxLvr3.Size = new System.Drawing.Size(85, 17);
            this.BoxLvr3.TabIndex = 55;
            this.BoxLvr3.Text = "Ver detalhes";
            this.BoxLvr3.UseVisualStyleBackColor = true;
            this.BoxLvr3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // picTres
            // 
            this.picTres.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picTres.ErrorImage")));
            this.picTres.Image = ((System.Drawing.Image)(resources.GetObject("picTres.Image")));
            this.picTres.Location = new System.Drawing.Point(21, 18);
            this.picTres.Name = "picTres";
            this.picTres.Size = new System.Drawing.Size(129, 171);
            this.picTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTres.TabIndex = 0;
            this.picTres.TabStop = false;
            // 
            // grpLvr2
            // 
            this.grpLvr2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpLvr2.Controls.Add(this.BoxLvr2);
            this.grpLvr2.Controls.Add(this.picDois);
            this.grpLvr2.Location = new System.Drawing.Point(339, 37);
            this.grpLvr2.Name = "grpLvr2";
            this.grpLvr2.Size = new System.Drawing.Size(166, 229);
            this.grpLvr2.TabIndex = 9;
            this.grpLvr2.TabStop = false;
            this.grpLvr2.Text = "A República";
            // 
            // BoxLvr2
            // 
            this.BoxLvr2.AutoSize = true;
            this.BoxLvr2.Location = new System.Drawing.Point(43, 205);
            this.BoxLvr2.Name = "BoxLvr2";
            this.BoxLvr2.Size = new System.Drawing.Size(85, 17);
            this.BoxLvr2.TabIndex = 244;
            this.BoxLvr2.Text = "Ver detalhes";
            this.BoxLvr2.UseVisualStyleBackColor = true;
            this.BoxLvr2.CheckedChanged += new System.EventHandler(this.BoxLvr2_CheckedChanged);
            // 
            // picDois
            // 
            this.picDois.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picDois.ErrorImage")));
            this.picDois.Image = ((System.Drawing.Image)(resources.GetObject("picDois.Image")));
            this.picDois.Location = new System.Drawing.Point(21, 18);
            this.picDois.Name = "picDois";
            this.picDois.Size = new System.Drawing.Size(129, 171);
            this.picDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDois.TabIndex = 0;
            this.picDois.TabStop = false;
            // 
            // grpLvr1
            // 
            this.grpLvr1.Controls.Add(this.BoxLvr1);
            this.grpLvr1.Controls.Add(this.picUm);
            this.grpLvr1.Location = new System.Drawing.Point(31, 31);
            this.grpLvr1.Name = "grpLvr1";
            this.grpLvr1.Size = new System.Drawing.Size(166, 229);
            this.grpLvr1.TabIndex = 8;
            this.grpLvr1.TabStop = false;
            this.grpLvr1.Text = "A Menina que Roubava Livros";
            this.grpLvr1.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // BoxLvr1
            // 
            this.BoxLvr1.AutoSize = true;
            this.BoxLvr1.Location = new System.Drawing.Point(41, 200);
            this.BoxLvr1.Name = "BoxLvr1";
            this.BoxLvr1.Size = new System.Drawing.Size(85, 17);
            this.BoxLvr1.TabIndex = 1;
            this.BoxLvr1.Text = "Ver detalhes";
            this.BoxLvr1.UseVisualStyleBackColor = true;
            this.BoxLvr1.CheckedChanged += new System.EventHandler(this.BoxLvr1_CheckedChanged);
            // 
            // picUm
            // 
            this.picUm.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picUm.ErrorImage")));
            this.picUm.Image = ((System.Drawing.Image)(resources.GetObject("picUm.Image")));
            this.picUm.Location = new System.Drawing.Point(21, 18);
            this.picUm.Name = "picUm";
            this.picUm.Size = new System.Drawing.Size(129, 171);
            this.picUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUm.TabIndex = 0;
            this.picUm.TabStop = false;
            this.picUm.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(155, 108);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 3;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCompra);
            this.Controls.Add(this.grpDados);
            this.Name = "Frm";
            this.Text = "Compra de Livros";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpCompra.ResumeLayout(false);
            this.grpCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpLvr4.ResumeLayout(false);
            this.grpLvr4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuatro)).EndInit();
            this.grpLvr5.ResumeLayout(false);
            this.grpLvr5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCinco)).EndInit();
            this.grpLvr6.ResumeLayout(false);
            this.grpLvr6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeis)).EndInit();
            this.grpLvr3.ResumeLayout(false);
            this.grpLvr3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTres)).EndInit();
            this.grpLvr2.ResumeLayout(false);
            this.grpLvr2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDois)).EndInit();
            this.grpLvr1.ResumeLayout(false);
            this.grpLvr1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCEstd;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtLiv;
        private System.Windows.Forms.Label lblLiv;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picUm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpLvr1;
        private System.Windows.Forms.GroupBox grpLvr4;
        private System.Windows.Forms.PictureBox picQuatro;
        private System.Windows.Forms.GroupBox grpLvr5;
        private System.Windows.Forms.PictureBox picCinco;
        private System.Windows.Forms.GroupBox grpLvr6;
        private System.Windows.Forms.PictureBox picSeis;
        private System.Windows.Forms.GroupBox grpLvr3;
        private System.Windows.Forms.PictureBox picTres;
        private System.Windows.Forms.GroupBox grpLvr2;
        private System.Windows.Forms.PictureBox picDois;
        private System.Windows.Forms.CheckBox BoxLvr4;
        private System.Windows.Forms.CheckBox BoxLvr5;
        private System.Windows.Forms.CheckBox BoxLvr6;
        private System.Windows.Forms.CheckBox BoxLvr3;
        private System.Windows.Forms.CheckBox BoxLvr2;
        private System.Windows.Forms.CheckBox BoxLvr1;
        private System.Windows.Forms.GroupBox grpCompra;
        private System.Windows.Forms.ComboBox cmbPag;
        private System.Windows.Forms.Label lblPag;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbQnt;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLimp;
    }
}

