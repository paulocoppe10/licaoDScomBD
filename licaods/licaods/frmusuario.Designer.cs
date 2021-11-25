namespace licaods
{
    partial class frmusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusuario));
            this.cd_usuarioLabel = new System.Windows.Forms.Label();
            this.nm_usuarioLabel = new System.Windows.Forms.Label();
            this.sg_nivelLabel = new System.Windows.Forms.Label();
            this.nm_loginLabel = new System.Windows.Forms.Label();
            this.cd_senhaLabel = new System.Windows.Forms.Label();
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.tbusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new licaods.cadastroDataSet();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.sg_nivelTextBox = new System.Windows.Forms.TextBox();
            this.nm_loginTextBox = new System.Windows.Forms.TextBox();
            this.cd_senhaTextBox = new System.Windows.Forms.TextBox();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.tbusuarioTableAdapter = new licaods.cadastroDataSetTableAdapters.tbusuarioTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            this.cd_usuarioLabel.AutoSize = true;
            this.cd_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cd_usuarioLabel.Location = new System.Drawing.Point(54, 43);
            this.cd_usuarioLabel.Name = "cd_usuarioLabel";
            this.cd_usuarioLabel.Size = new System.Drawing.Size(60, 20);
            this.cd_usuarioLabel.TabIndex = 1;
            this.cd_usuarioLabel.Text = "codigo:";
            // 
            // nm_usuarioLabel
            // 
            this.nm_usuarioLabel.AutoSize = true;
            this.nm_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nm_usuarioLabel.Location = new System.Drawing.Point(54, 145);
            this.nm_usuarioLabel.Name = "nm_usuarioLabel";
            this.nm_usuarioLabel.Size = new System.Drawing.Size(65, 20);
            this.nm_usuarioLabel.TabIndex = 3;
            this.nm_usuarioLabel.Text = "usuario:";
            // 
            // sg_nivelLabel
            // 
            this.sg_nivelLabel.AutoSize = true;
            this.sg_nivelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sg_nivelLabel.Location = new System.Drawing.Point(54, 94);
            this.sg_nivelLabel.Name = "sg_nivelLabel";
            this.sg_nivelLabel.Size = new System.Drawing.Size(44, 20);
            this.sg_nivelLabel.TabIndex = 5;
            this.sg_nivelLabel.Text = "nivel:";
            // 
            // nm_loginLabel
            // 
            this.nm_loginLabel.AutoSize = true;
            this.nm_loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nm_loginLabel.Location = new System.Drawing.Point(54, 196);
            this.nm_loginLabel.Name = "nm_loginLabel";
            this.nm_loginLabel.Size = new System.Drawing.Size(46, 20);
            this.nm_loginLabel.TabIndex = 7;
            this.nm_loginLabel.Text = "login:";
            this.nm_loginLabel.Click += new System.EventHandler(this.nm_loginLabel_Click);
            // 
            // cd_senhaLabel
            // 
            this.cd_senhaLabel.AutoSize = true;
            this.cd_senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cd_senhaLabel.Location = new System.Drawing.Point(54, 247);
            this.cd_senhaLabel.Name = "cd_senhaLabel";
            this.cd_senhaLabel.Size = new System.Drawing.Size(57, 20);
            this.cd_senhaLabel.TabIndex = 9;
            this.cd_senhaLabel.Text = "senha:";
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(143, 43);
            this.cd_usuarioTextBox.MaxLength = 5;
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(33, 26);
            this.cd_usuarioTextBox.TabIndex = 2;
            this.cd_usuarioTextBox.TextChanged += new System.EventHandler(this.cd_usuarioTextBox_TextChanged);
            // 
            // tbusuarioBindingSource
            // 
            this.tbusuarioBindingSource.DataMember = "tbusuario";
            this.tbusuarioBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(143, 141);
            this.nm_usuarioTextBox.MaxLength = 40;
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(346, 26);
            this.nm_usuarioTextBox.TabIndex = 4;
            // 
            // sg_nivelTextBox
            // 
            this.sg_nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "sg_nivel", true));
            this.sg_nivelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sg_nivelTextBox.Location = new System.Drawing.Point(143, 92);
            this.sg_nivelTextBox.MaxLength = 1;
            this.sg_nivelTextBox.Name = "sg_nivelTextBox";
            this.sg_nivelTextBox.Size = new System.Drawing.Size(33, 26);
            this.sg_nivelTextBox.TabIndex = 6;
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "nm_login", true));
            this.nm_loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nm_loginTextBox.Location = new System.Drawing.Point(143, 190);
            this.nm_loginTextBox.MaxLength = 15;
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(100, 26);
            this.nm_loginTextBox.TabIndex = 8;
            // 
            // cd_senhaTextBox
            // 
            this.cd_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbusuarioBindingSource, "cd_senha", true));
            this.cd_senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cd_senhaTextBox.Location = new System.Drawing.Point(143, 239);
            this.cd_senhaTextBox.MaxLength = 15;
            this.cd_senhaTextBox.Name = "cd_senhaTextBox";
            this.cd_senhaTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_senhaTextBox.TabIndex = 10;
            // 
            // btnanterior
            // 
            this.btnanterior.AutoSize = true;
            this.btnanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanterior.Location = new System.Drawing.Point(30, 384);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(100, 30);
            this.btnanterior.TabIndex = 11;
            this.btnanterior.Text = "anterior";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.AutoSize = true;
            this.btnproximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproximo.Location = new System.Drawing.Point(136, 384);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(100, 30);
            this.btnproximo.TabIndex = 12;
            this.btnproximo.Text = "proximo";
            this.btnproximo.UseVisualStyleBackColor = true;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.AutoSize = true;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(242, 384);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(100, 30);
            this.btnnovo.TabIndex = 13;
            this.btnnovo.Text = "novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.AutoSize = true;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Location = new System.Drawing.Point(348, 384);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(100, 30);
            this.btnalterar.TabIndex = 14;
            this.btnalterar.Text = "alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.AutoSize = true;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(454, 384);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(100, 30);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.AutoSize = true;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(30, 420);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(100, 30);
            this.btnsalvar.TabIndex = 16;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = true;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(136, 420);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 30);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.AutoSize = true;
            this.btnpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(242, 420);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnpesquisar.TabIndex = 18;
            this.btnpesquisar.Text = "pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.AutoSize = true;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(348, 420);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(100, 30);
            this.btnimprimir.TabIndex = 19;
            this.btnimprimir.Text = "imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnsair
            // 
            this.btnsair.AutoSize = true;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(454, 420);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(100, 30);
            this.btnsair.TabIndex = 21;
            this.btnsair.Text = "sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // tbusuarioTableAdapter
            // 
            this.tbusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 651);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(this.nm_usuarioLabel);
            this.Controls.Add(this.nm_usuarioTextBox);
            this.Controls.Add(this.sg_nivelLabel);
            this.Controls.Add(this.sg_nivelTextBox);
            this.Controls.Add(this.nm_loginLabel);
            this.Controls.Add(this.nm_loginTextBox);
            this.Controls.Add(this.cd_senhaLabel);
            this.Controls.Add(this.cd_senhaTextBox);
            this.Name = "frmusuario";
            this.Text = "cadastro usuario";
            this.Load += new System.EventHandler(this.frmusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbusuarioBindingSource;
        private cadastroDataSetTableAdapters.tbusuarioTableAdapter tbusuarioTableAdapter;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox nm_usuarioTextBox;
        private System.Windows.Forms.TextBox sg_nivelTextBox;
        private System.Windows.Forms.TextBox nm_loginTextBox;
        private System.Windows.Forms.TextBox cd_senhaTextBox;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label cd_usuarioLabel;
        private System.Windows.Forms.Label nm_usuarioLabel;
        private System.Windows.Forms.Label sg_nivelLabel;
        private System.Windows.Forms.Label nm_loginLabel;
        private System.Windows.Forms.Label cd_senhaLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}