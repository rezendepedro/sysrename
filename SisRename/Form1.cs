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
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;

namespace SisRename
{
    public partial class Form1 : Form
    {
        Classes.validacao validar;
        Classes.conexao conexao;
        ServerConnection srvConn;
        DataTable dt = new DataTable();
        string numVersion = "1.0";
        string erro = "";
        string cmbbanco="";
        string cmbtabela="";
        string cmbcol1="";
        string cmbcol2="";
        string cmbcol3="";
        string cmbcol4 = "";
        string cmbcol5 = "";
        string cmbcol6 = "";
        string cmbcol7 = "";
        string caracter="";
        string sucesso = "";
        string pathentrada = "";
        string pathsaida = "";
        string numarq = "";
        int arqAfet = 0;
        string localidade = "";
        public Form1()
        {
            InitializeComponent();
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            bgWorker.CancelAsync();
            Application.Exit();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (cmbBanco.SelectedIndex != -1 && cmbPoste.SelectedIndex != -1 && cmbInicio.SelectedIndex != -1 && cmbTabela.SelectedIndex != -1)
            {
                cmbbanco = cmbBanco.Text;
                cmbtabela=cmbTabela.Text;
                cmbcol1 = cmbPoste.Text;
                cmbcol2 = cmbInicio.Text;
                cmbcol3 = cmbFim.Text;
                cmbcol4 = cmbSerie.Text; 
                cmbcol5 = cmbLocalidade.Text;
                cmbcol6 = cmbKML.Text;
                cmbcol7 = cmbEquipe.Text;
                caracter = txtCaracter.Text;
                if (txtSelecionarEntrada.Text != "" && txtSelecionarSaida.Text != "")
                {
                    pathentrada = txtSelecionarEntrada.Text;
                    pathsaida = txtSelecionarSaida.Text;
                    rtxtLog.Text ="";
                    bgWorker.RunWorkerAsync();
                }
                else
                {
                    rtxtLog.Text = rtxtLog.Text + System.Environment.NewLine+"Erro: Selecione a entra e saida dos arquivos";
                }
                

            }
           
        
        }      

        private void Form1_Load(object sender, System.EventArgs e)
        {
            pnlPrincipal.Location = new Point(
            this.ClientSize.Width / 2 - pnlPrincipal.Size.Width / 2,
             this.ClientSize.Height / 2 - pnlPrincipal.Size.Height / 2);
            pnlPrincipal.Anchor = AnchorStyles.None;
            lblversion.Text = "Versão: " + numVersion;
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
                    //rtxtLog.Text = srv2.Information.Version.ToString();   // connection is established              

                    string conection = "Data Source=" + instanceName + ";User ID=" + sqlServerLogin + "; Password=" + password + ";MultipleActiveResultSets=False";



                    conexao = new Classes.conexao(conection);

                    lista = conexao.GetDatabaseList("SELECT * FROM sys.databases");

                    if (lista[0] != "ERRO")
                    {
                        cmbBanco.DataSource = lista;
                    }
                    else
                    {
                        rtxtLog.Text = System.Environment.NewLine+"----------Erro ao selecionar Banco de dados:" + lista[1];
                    }                   

                }
                else
                {
                    rtxtLog.Text = "";
                    rtxtLog.Text = System.Environment.NewLine+"----- Preencha todos os dados e tente novamente.";
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
                    rtxtLog.Text += System.Environment.NewLine+" Erro ao selecionar tabela:" + lista[1];
                }

            }
           
        }

        private void cmbCol1_DropDown(object sender, System.EventArgs e)
        {
            List<string> lista;
            if (cmbTabela.SelectedIndex != -1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);
                lista = conexao.GetDatabaseList("use " + cmbBanco.Text + "; SELECT NAME FROM SYSCOLUMNS WHERE ID = OBJECT_ID('"+cmbTabela.Text+"')");
                if (lista[0] != "ERRO")
                {
                    cmbPoste.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += System.Environment.NewLine+" Erro ao selecionar tabela:" + lista[1];
                }

            }

        }

        private void cmbCol2_DropDown(object sender, System.EventArgs e)
        {
            List<string> lista;
            if (cmbTabela.SelectedIndex != -1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);
                lista = conexao.GetDatabaseList("use " + cmbBanco.Text + "; SELECT NAME FROM SYSCOLUMNS WHERE ID = OBJECT_ID('" + cmbTabela.Text + "')");
                if (lista[0] != "ERRO")
                {
                    cmbInicio.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += System.Environment.NewLine+" Erro ao selecionar tabela:" + lista[1];
                }

            }
        }

       

        private void btnSelecionar_Click_1(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Selecione a pasta para salvar as imagens:";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSelecionarSaida.Text = fbd.SelectedPath;
                //Loucura
            }

        }

        private void btnselecionarEntrada_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Selecione a pasta para salvar as imagens:";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSelecionarEntrada.Text = fbd.SelectedPath;
                //Loucura
            }

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void cmbCol3_DropDown(object sender, System.EventArgs e)
        {
            List<string> lista;
            if (cmbTabela.SelectedIndex != -1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);
                lista = conexao.GetDatabaseList("use " + cmbBanco.Text + "; SELECT NAME FROM SYSCOLUMNS WHERE ID = OBJECT_ID('" + cmbTabela.Text + "')");
                if (lista[0] != "ERRO")
                {
                    cmbFim.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += System.Environment.NewLine+" Erro ao selecionar tabela:" + lista[1];
                }

            }
        }
        private void bgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                
                dt.Clear();
                dt=limpaData(dt);
               
                if (cmbbanco != "" && cmbcol1 != "" && cmbcol2 != "" && cmbcol3 != "" && cmbtabela != "")
                {
                    if(caracter=="")
                    {
                        caracter = "_";
                    }
                    dt = conexao.SELECT("use " + cmbbanco + "; SELECT " + cmbcol1 + ", " + cmbcol2 + "," + cmbcol3 + "," + cmbcol4 + ","+cmbcol5 +"," + cmbcol6 + "," + cmbcol7 + " FROM " + cmbtabela + " order by " + cmbcol2);
                   
                    //operação para canlar o loop
                    try
                    {
                        // Caminho literal da pasta informada 
                        DirectoryInfo dirInfo = new DirectoryInfo(@pathentrada);
                        //FileSystemInfo[] files = dirInfo.GetFileSystemInfos();                    
                        // Pega todas as informações dos arquivos dentro do diretório informado 
                        FileInfo[] arquivos = dirInfo.GetFiles().OrderBy(p => p.Name).ToArray();

                        string antigoNome;
                        string novoNome;
                        string nomebdinicio = "";
                        string nomebdfinal = "";
                               
                        string nomecompincio = "";
                        string nomecompfinal = "";
                        int cont = 0;

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (bgWorker.CancellationPending)
                                {
                                    e.Cancel = true;
                                    break;
                                }
                                bgWorker.ReportProgress((100 * (i+1)) / dt.Rows.Count);//acrescenta na barra de progresso
                                
                                 
                                    nomebdinicio = dt.Rows[i][cmbcol2].ToString();
                                    nomebdfinal = dt.Rows[i][cmbcol3].ToString();
                                    nomecompincio = "IMG_" + nomebdinicio + ".JPG";
                                    nomecompfinal = "IMG_" + nomebdfinal + ".JPG";
                                    numarq= arquivos.Length.ToString();
                                   //string [] partdate  = dt.Rows[i][cmbcol5].ToString().Split('/');
                                  // datalevantamento = partdate[2] + partdate[1] + partdate[0];
                                    localidade = dt.Rows[i][cmbcol5].ToString();
                                    
                                    if (!Directory.Exists(@pathsaida + "\\fotos"))
                                    {
                                        Directory.CreateDirectory(@pathsaida + "\\fotos");
                                    }
                                    if (!Directory.Exists(@pathsaida + "\\fotos\\" + dt.Rows[i][cmbcol7].ToString()))
                                    {
                                        Directory.CreateDirectory(@pathsaida + "\\fotos\\" + dt.Rows[i][cmbcol7].ToString());
                                    }
                                    if (!Directory.Exists(@pathsaida + "\\fotos\\" + dt.Rows[i][cmbcol7].ToString() + "\\" + localidade))
                                    {
                                        Directory.CreateDirectory(@pathsaida + "\\fotos\\" + dt.Rows[i][cmbcol7].ToString() + "\\" + localidade);
                                    }

                                    string partpath = pathentrada.Replace("fotos", "?").Split('?')[0];

                                    if (!File.Exists(@partpath + "kml\\" + dt.Rows[i][cmbcol7].ToString() + "\\" + localidade + "\\" + dt.Rows[i][cmbcol6].ToString()))
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Não existe um arquivo kml compativel com a equipe e a data deseja de levantamento continuar?", "Verificação de arquivo", MessageBoxButtons.YesNo);
                                        if(dialogResult == DialogResult.Yes)
                                        {
                                            if (pathentrada.Contains(dt.Rows[i][cmbcol4].ToString()))
                                            {
                                                if (pathentrada.Contains(localidade))
                                                {
                                                    for (int j = 0; j < arquivos.Length; j++)
                                                    {
                                                        if (arquivos[j].ToString() == nomecompincio)
                                                        {
                                                            cont = 0;

                                                            for (int x = j; x < arquivos.Length; x++)
                                                            {
                                                                cont++;
                                                                antigoNome = @pathentrada + "\\" + arquivos[x].ToString();
                                                                novoNome = @pathsaida + "\\fotos\\" + dt.Rows[i][cmbcol7].ToString() + "\\" + dt.Rows[i][cmbcol5].ToString() + "\\" + dt.Rows[i][cmbcol1].ToString() + caracter + cont + ".JPG";
                                                                File.Copy(antigoNome, novoNome); // Move o arquivo para a mesma pasta com os carateres substituídos
                                                                arqAfet++;
                                                                if (arquivos[x].ToString() == nomecompfinal)
                                                                {
                                                                    cont = -1;
                                                                    break;
                                                                }


                                                            }

                                                            if (cont == -1)
                                                            {
                                                                break;
                                                            }



                                                        }
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Diretório de entrada deve esta organizado.Ex: (raiz\\fotos\\equipe\\LOCALIDADE\\serie\\IMG_0001.jpg)");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Diretório de entrada deve esta organizado.Ex: (raiz\\fotos\\equipe\\localidade\\SERIE\\IMG_0001.jpg)");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("O arquivo KML deve estar na raiz do diretorio de entrada, deve esta organizado.Ex: (raiz\\kml\\equipe\\localidade\\arquivo.kml)");
                                        }
                                    }
                                    else
                                    {
                                        if (pathentrada.Contains(dt.Rows[i][cmbcol4].ToString()))
                                        {
                                            if (pathentrada.Contains(localidade))
                                            {
                                                for (int j = 0; j < arquivos.Length; j++)
                                                {
                                                    if (arquivos[j].ToString() == nomecompincio)
                                                    {
                                                        cont = 0;

                                                        for (int x = j; x < arquivos.Length; x++)
                                                        {
                                                            cont++;
                                                            antigoNome = @pathentrada + "\\" + arquivos[x].ToString();
                                                            novoNome = @pathsaida + "\\fotos\\" + dt.Rows[i][cmbcol7].ToString() + "\\" + localidade + "\\" + dt.Rows[i][cmbcol1].ToString() + caracter + cont + ".JPG";
                                                            File.Copy(antigoNome, novoNome); // Move o arquivo para a mesma pasta com os carateres substituídos
                                                            arqAfet++;
                                                            if (arquivos[x].ToString() == nomecompfinal)
                                                            {
                                                                cont = -1;
                                                                break;
                                                            }


                                                        }

                                                        if (cont == -1)
                                                        {
                                                            break;
                                                        }



                                                    }
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Diretório de entrada deve esta organizado.Ex: (raiz\\fotos\\equipe\\LOCALIDADE\\serie\\IMG_0001.jpg)");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Diretório de entrada deve esta organizado.Ex: (raiz\\fotos\\equipe\\localidade\\SERIE\\IMG_0001.jpg)");
                                        }


                                  }                              
                                

                            }

                        }




                       
                    }
                    catch (Exception ex)
                    {
                        erro += System.Environment.NewLine + ex.Message;
                        // Se der erro, exibe o que aconteceu MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (arqAfet > 0)
                    {
                        sucesso = (System.Environment.NewLine + "Concluido!" + System.Environment.NewLine + "Numero de arquivos alterado: " + arqAfet + System.Environment.NewLine+"Numero de arquivos no diretorio de entrada:"+numarq);
                       Process.Start("Explorer", @pathsaida);
                    }

                }      

            }catch(Exception exc)
            {
                erro += System.Environment.NewLine+" -------Erro: " + exc.Message;
            }
        }
        private void bgWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbar.Value = e.ProgressPercentage;
            lblpct.Text = e.ProgressPercentage + "%";
            rtxtLog.Text += erro;
        }
        private void bgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Operação Cancelada!");
                    rtxtLog.Text += System.Environment.NewLine+"Operação Cancelada!";
                }
                else
                {
                    MessageBox.Show("Operação Cancelada! Não existe dados na tabela.");
                    rtxtLog.Text += System.Environment.NewLine+" Operação Cancelada! Não existe dados na tabela.";
                }

            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Operação finalizada com sucesso.");
                    rtxtLog.Text += System.Environment.NewLine + sucesso;
                    
                }
                else
                {
                    MessageBox.Show("Operação finalizada! Não existe dados na tabela.");
                    rtxtLog.Text += System.Environment.NewLine+"Operação finalizada! Não existe dados na tabela.";
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bgWorker.CancelAsync();
        }
        public DataTable limpaData(DataTable table)
        {
            for (int counter = table.Columns.Count - 1; counter >= 0; counter--)
            {
                table.Columns.RemoveAt(counter);
            }
            return table;
        }

        private void cmbCol4_DropDown(object sender, EventArgs e)
        {
            List<string> lista;
            if (cmbTabela.SelectedIndex != -1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);
                lista = conexao.GetDatabaseList("use " + cmbBanco.Text + "; SELECT NAME FROM SYSCOLUMNS WHERE ID = OBJECT_ID('" + cmbTabela.Text + "')");
                if (lista[0] != "ERRO")
                {
                    cmbSerie.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += System.Environment.NewLine + " Erro ao selecionar tabela:" + lista[1];
                }

            }

        }

        private void cmbCol5_DropDown(object sender, EventArgs e)
        {
            List<string> lista;
            if (cmbTabela.SelectedIndex != -1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);
                lista = conexao.GetDatabaseList("use " + cmbBanco.Text + "; SELECT NAME FROM SYSCOLUMNS WHERE ID = OBJECT_ID('" + cmbTabela.Text + "')");
                if (lista[0] != "ERRO")
                {
                    cmbLocalidade.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += System.Environment.NewLine + " Erro ao selecionar tabela:" + lista[1];
                }

            }

        }

        private void cmbCol6_DropDown(object sender, EventArgs e)
        {
            List<string> lista;
            if (cmbTabela.SelectedIndex != -1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);
                lista = conexao.GetDatabaseList("use " + cmbBanco.Text + "; SELECT NAME FROM SYSCOLUMNS WHERE ID = OBJECT_ID('" + cmbTabela.Text + "')");
                if (lista[0] != "ERRO")
                {
                    cmbEquipe.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += System.Environment.NewLine + " Erro ao selecionar tabela:" + lista[1];
                }

            }

        }

        private void cmbCol7_DropDown(object sender, EventArgs e)
        {
            List<string> lista;
            if (cmbTabela.SelectedIndex != -1)
            {
                conexao = new Classes.conexao(srvConn.ConnectionString);
                lista = conexao.GetDatabaseList("use " + cmbBanco.Text + "; SELECT NAME FROM SYSCOLUMNS WHERE ID = OBJECT_ID('" + cmbTabela.Text + "')");
                if (lista[0] != "ERRO")
                {
                    cmbKML.DataSource = lista;
                }
                else
                {
                    rtxtLog.Text += System.Environment.NewLine + " Erro ao selecionar tabela:" + lista[1];
                }

            }
        }

       
        
    }
}
