using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;

namespace SisRename
{
    public partial class Form1 : Form
    {
        Classes.validacao validar;
        Classes.conexao conexao;
        ServerConnection srvConn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            

          
        
        }      

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

       

        private void cmbBanco_DropDown(object sender, System.EventArgs e)
        {
            validar = new Classes.validacao();//instacia objeto da classe vilidar
            String sqlServerLogin = txtUser.Text; //login usuario
            String password = txtPassword.Text;//senha usuario
            String instanceName = txtInstacia.Text;//instacia sql server
            //String remoteSvrName = "10.101.0.41";
            List<string> lista;

            try
            {
                if (validar.validaCampo(sqlServerLogin) || validar.validaCampo(password) || validar.validaCampo(instanceName))//verifica se os campos estão vazios
                {
                                      
                    srvConn = new ServerConnection();
                    srvConn.ServerInstance = @"" + (instanceName);   // connects to named instance
                    srvConn.LoginSecure = false;   // set to true for Windows Authentication
                    srvConn.Login = sqlServerLogin;
                    srvConn.Password = password;
                    Server srv2 = new Server(srvConn);
                    rtxtLog.Text = srv2.Information.Version.ToString();   // connection is established              





                    conexao = new Classes.conexao(srvConn.ConnectionString);

                    lista = conexao.GetDatabaseList("SELECT * FROM sys.databases");

                    if (lista[0] != "ERRO")
                    {
                        cmbBanco.DataSource = lista;
                    }
                    else
                    {
                        rtxtLog.Text = "\n\n Erro ao selecionar Banco de dados:" + lista[1];
                    }


                    //// For remote connection, remote server name / ServerInstance needs to be specified
                    //ServerConnection srvConn2 = new ServerConnection(remoteSvrName);
                    //srvConn2.LoginSecure = false;
                    //srvConn2.Login = sqlServerLogin;
                    //srvConn2.Password = password;
                    //Server srv3 = new Server(srvConn2);
                    //rtxtLog.Text+="\n"+srv3.Information.Version.ToString();   // connection is established

                }
                else
                {
                    rtxtLog.Text = "";
                    rtxtLog.Text = "\n Preencha todos os dados e tente novamente.";
                    MessageBox.Show("Preencha todos os dados e tente novamente.");
                }


            }
            catch (Exception ex)
            {
                rtxtLog.Text = ex.Message;
            }
            
        }

        private void cmbTabela_DropDown(object sender, System.EventArgs e)
        {
            List<string> lista;
            if(cmbBanco.SelectedIndex!=-1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);  
                lista = conexao.GetDatabaseList("use "+cmbBanco.Text +"; SELECT table_name FROM information_schema.tables ORDER BY table_name");
                if (lista[0] != "ERRO")
                {
                    cmbTabela.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += "\n\n Erro ao selecionar tabela:" + lista[1];
                }

            }
           
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Selecione a pasta para salvar as imagens:";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSelecionar.Text = fbd.SelectedPath;
            }
                
        }
    }
}
