namespace SisRename
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelecionarSaida = new System.Windows.Forms.Button();
            this.txtSelecionarSaida = new System.Windows.Forms.TextBox();
            this.lblInstacia = new System.Windows.Forms.Label();
            this.txtInstacia = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.cmbTabela = new System.Windows.Forms.ComboBox();
            this.lblCol1 = new System.Windows.Forms.Label();
            this.cmbCol1 = new System.Windows.Forms.ComboBox();
            this.lblCol2 = new System.Windows.Forms.Label();
            this.cmbCol2 = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSelecionarEntrada = new System.Windows.Forms.TextBox();
            this.btnselecionarEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCol3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lblpct = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblversion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelecionarSaida
            // 
            this.btnSelecionarSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarSaida.Location = new System.Drawing.Point(650, 195);
            this.btnSelecionarSaida.Name = "btnSelecionarSaida";
            this.btnSelecionarSaida.Size = new System.Drawing.Size(127, 29);
            this.btnSelecionarSaida.TabIndex = 11;
            this.btnSelecionarSaida.Text = "Saida...";
            this.btnSelecionarSaida.UseVisualStyleBackColor = true;
            this.btnSelecionarSaida.Click += new System.EventHandler(this.btnSelecionar_Click_1);
            // 
            // txtSelecionarSaida
            // 
            this.txtSelecionarSaida.Enabled = false;
            this.txtSelecionarSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarSaida.Location = new System.Drawing.Point(783, 197);
            this.txtSelecionarSaida.Name = "txtSelecionarSaida";
            this.txtSelecionarSaida.Size = new System.Drawing.Size(382, 26);
            this.txtSelecionarSaida.TabIndex = 1;
            this.txtSelecionarSaida.TabStop = false;
            this.txtSelecionarSaida.Text = "Diretorio de saida de dados";
            // 
            // lblInstacia
            // 
            this.lblInstacia.AutoSize = true;
            this.lblInstacia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstacia.Location = new System.Drawing.Point(15, 16);
            this.lblInstacia.Name = "lblInstacia";
            this.lblInstacia.Size = new System.Drawing.Size(73, 18);
            this.lblInstacia.TabIndex = 2;
            this.lblInstacia.Text = "Instância:";
            // 
            // txtInstacia
            // 
            this.txtInstacia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstacia.Location = new System.Drawing.Point(195, 13);
            this.txtInstacia.Name = "txtInstacia";
            this.txtInstacia.Size = new System.Drawing.Size(358, 26);
            this.txtInstacia.TabIndex = 1;
            this.txtInstacia.Text = "10.101.0.41\\SQLEXPRESS";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(15, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 18);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuario:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(195, 56);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(358, 26);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "sde";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(15, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Senha:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPassword.Location = new System.Drawing.Point(195, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'l';
            this.txtPassword.Size = new System.Drawing.Size(358, 25);
            this.txtPassword.TabIndex = 3;
            // 
            // cmbBanco
            // 
            this.cmbBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.ItemHeight = 18;
            this.cmbBanco.Location = new System.Drawing.Point(220, 267);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(358, 26);
            this.cmbBanco.TabIndex = 4;
            this.cmbBanco.DropDown += new System.EventHandler(this.cmbBanco_DropDown);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(40, 267);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(130, 18);
            this.lblBanco.TabIndex = 9;
            this.lblBanco.Text = "Banco de Dados:";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(40, 312);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(58, 18);
            this.lblTabela.TabIndex = 11;
            this.lblTabela.Text = "Tabela:";
            // 
            // cmbTabela
            // 
            this.cmbTabela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabela.FormattingEnabled = true;
            this.cmbTabela.ItemHeight = 18;
            this.cmbTabela.Location = new System.Drawing.Point(220, 309);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(358, 26);
            this.cmbTabela.TabIndex = 5;
            this.cmbTabela.DropDown += new System.EventHandler(this.cmbTabela_DropDown);
            // 
            // lblCol1
            // 
            this.lblCol1.AutoSize = true;
            this.lblCol1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol1.Location = new System.Drawing.Point(40, 351);
            this.lblCol1.Name = "lblCol1";
            this.lblCol1.Size = new System.Drawing.Size(126, 18);
            this.lblCol1.TabIndex = 13;
            this.lblCol1.Text = "Coluna de poste:";
            // 
            // cmbCol1
            // 
            this.cmbCol1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCol1.FormattingEnabled = true;
            this.cmbCol1.Location = new System.Drawing.Point(220, 348);
            this.cmbCol1.Name = "cmbCol1";
            this.cmbCol1.Size = new System.Drawing.Size(358, 26);
            this.cmbCol1.TabIndex = 6;
            this.cmbCol1.DropDown += new System.EventHandler(this.cmbCol1_DropDown);
            // 
            // lblCol2
            // 
            this.lblCol2.AutoSize = true;
            this.lblCol2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol2.Location = new System.Drawing.Point(40, 391);
            this.lblCol2.Name = "lblCol2";
            this.lblCol2.Size = new System.Drawing.Size(157, 18);
            this.lblCol2.TabIndex = 15;
            this.lblCol2.Text = "Coluna de foto inicial:";
            // 
            // cmbCol2
            // 
            this.cmbCol2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCol2.FormattingEnabled = true;
            this.cmbCol2.Location = new System.Drawing.Point(220, 388);
            this.cmbCol2.Name = "cmbCol2";
            this.cmbCol2.Size = new System.Drawing.Size(358, 26);
            this.cmbCol2.TabIndex = 7;
            this.cmbCol2.DropDown += new System.EventHandler(this.cmbCol2_DropDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(43, 566);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 34);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(1079, 260);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(86, 33);
            this.btnConfirma.TabIndex = 12;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisRename.Properties.Resources.logo_arya;
            this.pictureBox1.Location = new System.Drawing.Point(511, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 68);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Enabled = false;
            this.rtxtLog.Location = new System.Drawing.Point(650, 309);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(515, 190);
            this.rtxtLog.TabIndex = 19;
            this.rtxtLog.TabStop = false;
            this.rtxtLog.Text = resources.GetString("rtxtLog.Text");
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(647, 288);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(39, 18);
            this.lblLog.TabIndex = 20;
            this.lblLog.Text = "Log:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1081, 566);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSelecionarEntrada
            // 
            this.txtSelecionarEntrada.Enabled = false;
            this.txtSelecionarEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarEntrada.Location = new System.Drawing.Point(783, 137);
            this.txtSelecionarEntrada.Name = "txtSelecionarEntrada";
            this.txtSelecionarEntrada.Size = new System.Drawing.Size(382, 26);
            this.txtSelecionarEntrada.TabIndex = 21;
            this.txtSelecionarEntrada.TabStop = false;
            this.txtSelecionarEntrada.Text = "Diretorio de entrada de dados";
            // 
            // btnselecionarEntrada
            // 
            this.btnselecionarEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselecionarEntrada.Location = new System.Drawing.Point(650, 135);
            this.btnselecionarEntrada.Name = "btnselecionarEntrada";
            this.btnselecionarEntrada.Size = new System.Drawing.Size(127, 29);
            this.btnselecionarEntrada.TabIndex = 10;
            this.btnselecionarEntrada.Text = "Entrada...";
            this.btnselecionarEntrada.UseVisualStyleBackColor = true;
            this.btnselecionarEntrada.Click += new System.EventHandler(this.btnselecionarEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Coluna de foto final:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCol3
            // 
            this.cmbCol3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCol3.FormattingEnabled = true;
            this.cmbCol3.Location = new System.Drawing.Point(220, 429);
            this.cmbCol3.Name = "cmbCol3";
            this.cmbCol3.Size = new System.Drawing.Size(358, 26);
            this.cmbCol3.TabIndex = 8;
            this.cmbCol3.DropDown += new System.EventHandler(this.cmbCol3_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Caracter de separação:";
            // 
            // txtCaracter
            // 
            this.txtCaracter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaracter.Location = new System.Drawing.Point(220, 473);
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(358, 26);
            this.txtCaracter.TabIndex = 9;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWork_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWork_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWork_RunWorkerCompleted);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(43, 528);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(1122, 23);
            this.pbar.TabIndex = 27;
            // 
            // lblpct
            // 
            this.lblpct.AutoSize = true;
            this.lblpct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpct.Location = new System.Drawing.Point(40, 507);
            this.lblpct.Name = "lblpct";
            this.lblpct.Size = new System.Drawing.Size(31, 18);
            this.lblpct.TabIndex = 28;
            this.lblpct.Text = "0%";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPrincipal.Controls.Add(this.lblversion);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.pictureBox1);
            this.pnlPrincipal.Controls.Add(this.lblpct);
            this.pnlPrincipal.Controls.Add(this.pbar);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.btnSelecionarSaida);
            this.pnlPrincipal.Controls.Add(this.txtCaracter);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.cmbCol3);
            this.pnlPrincipal.Controls.Add(this.txtSelecionarSaida);
            this.pnlPrincipal.Controls.Add(this.txtSelecionarEntrada);
            this.pnlPrincipal.Controls.Add(this.btnselecionarEntrada);
            this.pnlPrincipal.Controls.Add(this.btnCancelar);
            this.pnlPrincipal.Controls.Add(this.cmbBanco);
            this.pnlPrincipal.Controls.Add(this.lblLog);
            this.pnlPrincipal.Controls.Add(this.lblBanco);
            this.pnlPrincipal.Controls.Add(this.rtxtLog);
            this.pnlPrincipal.Controls.Add(this.cmbTabela);
            this.pnlPrincipal.Controls.Add(this.lblTabela);
            this.pnlPrincipal.Controls.Add(this.btnConfirma);
            this.pnlPrincipal.Controls.Add(this.cmbCol1);
            this.pnlPrincipal.Controls.Add(this.btnFechar);
            this.pnlPrincipal.Controls.Add(this.lblCol1);
            this.pnlPrincipal.Controls.Add(this.lblCol2);
            this.pnlPrincipal.Controls.Add(this.cmbCol2);
            this.pnlPrincipal.Location = new System.Drawing.Point(31, 29);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1201, 616);
            this.pnlPrincipal.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.txtInstacia);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.lblInstacia);
            this.panel1.Location = new System.Drawing.Point(30, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 140);
            this.panel1.TabIndex = 29;
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.BackColor = System.Drawing.SystemColors.Control;
            this.lblversion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblversion.Location = new System.Drawing.Point(562, 84);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(88, 18);
            this.lblversion.TabIndex = 30;
            this.lblversion.Text = "Versão: 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 657);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SisRename";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarSaida;
        private System.Windows.Forms.TextBox txtSelecionarSaida;
        private System.Windows.Forms.Label lblInstacia;
        private System.Windows.Forms.TextBox txtInstacia;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.ComboBox cmbTabela;
        private System.Windows.Forms.Label lblCol1;
        private System.Windows.Forms.ComboBox cmbCol1;
        private System.Windows.Forms.Label lblCol2;
        private System.Windows.Forms.ComboBox cmbCol2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSelecionarEntrada;
        private System.Windows.Forms.Button btnselecionarEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCol3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Label lblpct;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblversion;
    }
}

