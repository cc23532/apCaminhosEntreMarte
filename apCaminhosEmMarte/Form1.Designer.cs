namespace apCaminhosEmMarte
{
  partial class FrmCaminhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaminhos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCidades = new System.Windows.Forms.TabPage();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.lsbCidades = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.udY = new System.Windows.Forms.NumericUpDown();
            this.udX = new System.Windows.Forms.NumericUpDown();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.rbHashDuplo = new System.Windows.Forms.RadioButton();
            this.rbHashQuadratico = new System.Windows.Forms.RadioButton();
            this.rbHashLinear = new System.Windows.Forms.RadioButton();
            this.rbBucketHash = new System.Windows.Forms.RadioButton();
            this.tpCaminhos = new System.Windows.Forms.TabPage();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpCidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCidades);
            this.tabControl1.Controls.Add(this.tpCaminhos);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCidades
            // 
            this.tpCidades.Controls.Add(this.pbMapa);
            this.tpCidades.Controls.Add(this.lsbCidades);
            this.tpCidades.Controls.Add(this.btnListar);
            this.tpCidades.Controls.Add(this.btnBuscar);
            this.tpCidades.Controls.Add(this.btnRemover);
            this.tpCidades.Controls.Add(this.btnInserir);
            this.tpCidades.Controls.Add(this.udY);
            this.tpCidades.Controls.Add(this.udX);
            this.tpCidades.Controls.Add(this.txtCidade);
            this.tpCidades.Controls.Add(this.label3);
            this.tpCidades.Controls.Add(this.label2);
            this.tpCidades.Controls.Add(this.label1);
            this.tpCidades.Controls.Add(this.groupBox1);
            this.tpCidades.Location = new System.Drawing.Point(4, 25);
            this.tpCidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCidades.Name = "tpCidades";
            this.tpCidades.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCidades.Size = new System.Drawing.Size(900, 415);
            this.tpCidades.TabIndex = 0;
            this.tpCidades.Text = "Cidades";
            this.tpCidades.UseVisualStyleBackColor = true;
            // 
            // pbMapa
            // 
            this.pbMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMapa.Image = ((System.Drawing.Image)(resources.GetObject("pbMapa.Image")));
            this.pbMapa.Location = new System.Drawing.Point(367, 74);
            this.pbMapa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(527, 324);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 12;
            this.pbMapa.TabStop = false;
            // 
            // lsbCidades
            // 
            this.lsbCidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsbCidades.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCidades.FormattingEnabled = true;
            this.lsbCidades.ItemHeight = 16;
            this.lsbCidades.Location = new System.Drawing.Point(13, 238);
            this.lsbCidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbCidades.Name = "lsbCidades";
            this.lsbCidades.ScrollAlwaysVisible = true;
            this.lsbCidades.Size = new System.Drawing.Size(344, 148);
            this.lsbCidades.Sorted = true;
            this.lsbCidades.TabIndex = 11;
            // 
            // btnListar
            // 
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.Location = new System.Drawing.Point(197, 192);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(53, 37);
            this.btnListar.TabIndex = 10;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(136, 192);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 37);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(75, 192);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(53, 37);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(13, 192);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(53, 37);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "+";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // udY
            // 
            this.udY.DecimalPlaces = 5;
            this.udY.Location = new System.Drawing.Point(75, 155);
            this.udY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.udY.Name = "udY";
            this.udY.Size = new System.Drawing.Size(100, 22);
            this.udY.TabIndex = 6;
            // 
            // udX
            // 
            this.udX.DecimalPlaces = 5;
            this.udX.Location = new System.Drawing.Point(75, 123);
            this.udX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.udX.Name = "udX";
            this.udX.Size = new System.Drawing.Size(100, 22);
            this.udX.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(75, 87);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.MaxLength = 15;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(132, 22);
            this.txtCidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cidade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnLerArquivo);
            this.groupBox1.Controls.Add(this.rbHashDuplo);
            this.groupBox1.Controls.Add(this.rbHashQuadratico);
            this.groupBox1.Controls.Add(this.rbHashLinear);
            this.groupBox1.Controls.Add(this.rbBucketHash);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(889, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Técnica de Hash desejada ";
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLerArquivo.Location = new System.Drawing.Point(787, 20);
            this.btnLerArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(95, 28);
            this.btnLerArquivo.TabIndex = 4;
            this.btnLerArquivo.Text = "Ler Arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // rbHashDuplo
            // 
            this.rbHashDuplo.AutoSize = true;
            this.rbHashDuplo.Location = new System.Drawing.Point(499, 23);
            this.rbHashDuplo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHashDuplo.Name = "rbHashDuplo";
            this.rbHashDuplo.Size = new System.Drawing.Size(99, 20);
            this.rbHashDuplo.TabIndex = 3;
            this.rbHashDuplo.Text = "Hash Duplo";
            this.rbHashDuplo.UseVisualStyleBackColor = true;
            // 
            // rbHashQuadratico
            // 
            this.rbHashQuadratico.AutoSize = true;
            this.rbHashQuadratico.Location = new System.Drawing.Point(300, 23);
            this.rbHashQuadratico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHashQuadratico.Name = "rbHashQuadratico";
            this.rbHashQuadratico.Size = new System.Drawing.Size(164, 20);
            this.rbHashQuadratico.TabIndex = 2;
            this.rbHashQuadratico.Text = "Sondagem Quadrática";
            this.rbHashQuadratico.UseVisualStyleBackColor = true;
            // 
            // rbHashLinear
            // 
            this.rbHashLinear.AutoSize = true;
            this.rbHashLinear.Location = new System.Drawing.Point(148, 23);
            this.rbHashLinear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHashLinear.Name = "rbHashLinear";
            this.rbHashLinear.Size = new System.Drawing.Size(135, 20);
            this.rbHashLinear.TabIndex = 1;
            this.rbHashLinear.Text = "Sondagem Linear";
            this.rbHashLinear.UseVisualStyleBackColor = true;
            // 
            // rbBucketHash
            // 
            this.rbBucketHash.AutoSize = true;
            this.rbBucketHash.Checked = true;
            this.rbBucketHash.Location = new System.Drawing.Point(21, 23);
            this.rbBucketHash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBucketHash.Name = "rbBucketHash";
            this.rbBucketHash.Size = new System.Drawing.Size(104, 20);
            this.rbBucketHash.TabIndex = 0;
            this.rbBucketHash.TabStop = true;
            this.rbBucketHash.Text = "Bucket Hash";
            this.rbBucketHash.UseVisualStyleBackColor = true;
            // 
            // tpCaminhos
            // 
            this.tpCaminhos.Location = new System.Drawing.Point(4, 25);
            this.tpCaminhos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCaminhos.Name = "tpCaminhos";
            this.tpCaminhos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCaminhos.Size = new System.Drawing.Size(900, 415);
            this.tpCaminhos.TabIndex = 1;
            this.tpCaminhos.Text = "Caminhos";
            this.tpCaminhos.UseVisualStyleBackColor = true;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.txt";
            this.dlgAbrir.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FrmCaminhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 447);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCaminhos";
            this.Text = "Caminhos em Marte - Ra1 - Ra2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCaminhos_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tpCidades.ResumeLayout(false);
            this.tpCidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpCidades;
    private System.Windows.Forms.TabPage tpCaminhos;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbHashDuplo;
    private System.Windows.Forms.RadioButton rbHashQuadratico;
    private System.Windows.Forms.RadioButton rbHashLinear;
    private System.Windows.Forms.RadioButton rbBucketHash;
    private System.Windows.Forms.Button btnLerArquivo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown udX;
    private System.Windows.Forms.TextBox txtCidade;
    private System.Windows.Forms.NumericUpDown udY;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Button btnRemover;
    private System.Windows.Forms.Button btnInserir;
    private System.Windows.Forms.Button btnListar;
    private System.Windows.Forms.ListBox lsbCidades;
    private System.Windows.Forms.PictureBox pbMapa;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
  }
}

