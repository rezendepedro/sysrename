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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtSelecionar = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(35, 468);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(127, 29);
            this.btnSelecionar.TabIndex = 7;
            this.btnSelecionar.Text = "Selecione...";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // txtSelecionar
            // 
            this.txtSelecionar.Enabled = false;
            this.txtSelecionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionar.Location = new System.Drawing.Point(168, 470);
            this.txtSelecionar.Name = "txtSelecionar";
            this.txtSelecionar.Size = new System.Drawing.Size(292, 26);
            this.txtSelecionar.TabIndex = 1;
            this.txtSelecionar.TabStop = false;
            this.txtSelecionar.Text = "C:\\Users\\pedro.rezende\\Documents\\File\\IMG";
            // 
            // lblInstacia
            // 
            this.lblInstacia.AutoSize = true;
            this.lblInstacia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstacia.Location = new System.Drawing.Point(32, 104);
            this.lblInstacia.Name = "lblInstacia";
            this.lblInstacia.Size = new System.Drawing.Size(73, 18);
            this.lblInstacia.TabIndex = 2;
            this.lblInstacia.Text = "Instância:";
            // 
            // txtInstacia
            // 
            this.txtInstacia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstacia.Location = new System.Drawing.Point(180, 101);
            this.txtInstacia.Name = "txtInstacia";
            this.txtInstacia.Size = new System.Drawing.Size(280, 26);
            this.txtInstacia.TabIndex = 0;
            this.txtInstacia.Text = "10.101.0.41\\SQLEXPRESS";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(177, 168);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 18);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuario:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(249, 168);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(211, 26);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "sde";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(177, 213);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Senha:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPassword.Location = new System.Drawing.Point(249, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'l';
            this.txtPassword.Size = new System.Drawing.Size(211, 25);
            this.txtPassword.TabIndex = 2;
            // 
            // cmbBanco
            // 
            this.cmbBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.ItemHeight = 18;
            this.cmbBanco.Location = new System.Drawing.Point(168, 296);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(292, 26);
            this.cmbBanco.TabIndex = 3;
            this.cmbBanco.DropDown += new System.EventHandler(this.cmbBanco_DropDown);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(32, 299);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(130, 18);
            this.lblBanco.TabIndex = 9;
            this.lblBanco.Text = "Banco de Dados:";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(165, 347);
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
            this.cmbTabela.Location = new System.Drawing.Point(237, 344);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(223, 26);
            this.cmbTabela.TabIndex = 4;
            this.cmbTabela.DropDown += new System.EventHandler(this.cmbTabela_DropDown);
            // 
            // lblCol1
            // 
            this.lblCol1.AutoSize = true;
            this.lblCol1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol1.Location = new System.Drawing.Point(234, 386);
            this.lblCol1.Name = "lblCol1";
            this.lblCol1.Size = new System.Drawing.Size(70, 18);
            this.lblCol1.TabIndex = 13;
            this.lblCol1.Text = "Coluna1:";
            // 
            // cmbCol1
            // 
            this.cmbCol1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCol1.FormattingEnabled = true;
            this.cmbCol1.Location = new System.Drawing.Point(313, 383);
            this.cmbCol1.Name = "cmbCol1";
            this.cmbCol1.Size = new System.Drawing.Size(147, 26);
            this.cmbCol1.TabIndex = 5;
            this.cmbCol1.DropDown += new System.EventHandler(this.cmbCol1_DropDown);
            // 
            // lblCol2
            // 
            this.lblCol2.AutoSize = true;
            this.lblCol2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol2.Location = new System.Drawing.Point(234, 428);
            this.lblCol2.Name = "lblCol2";
            this.lblCol2.Size = new System.Drawing.Size(70, 18);
            this.lblCol2.TabIndex = 15;
            this.lblCol2.Text = "Coluna2:";
            // 
            // cmbCol2
            // 
            this.cmbCol2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCol2.FormattingEnabled = true;
            this.cmbCol2.Location = new System.Drawing.Point(313, 425);
            this.cmbCol2.Name = "cmbCol2";
            this.cmbCol2.Size = new System.Drawing.Size(147, 26);
            this.cmbCol2.TabIndex = 6;
            this.cmbCol2.DropDown += new System.EventHandler(this.cmbCol2_DropDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(30, 694);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 34);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(374, 523);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(86, 33);
            this.btnConfirma.TabIndex = 8;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisRename.Properties.Resources.logo_arya;
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 68);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Enabled = false;
            this.rtxtLog.Location = new System.Drawing.Point(35, 592);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(425, 96);
            this.rtxtLog.TabIndex = 19;
            this.rtxtLog.TabStop = false;
            this.rtxtLog.Text = "";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(32, 571);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(39, 18);
            this.lblLog.TabIndex = 20;
            this.lblLog.Text = "Log:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(376, 695);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 740);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblCol2);
            this.Controls.Add(this.cmbCol2);
            this.Controls.Add(this.lblCol1);
            this.Controls.Add(this.cmbCol1);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.cmbTabela);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSelecionar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblInstacia);
            this.Controls.Add(this.txtInstacia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtSelecionar;
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
    }
}

