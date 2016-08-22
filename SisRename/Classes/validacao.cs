using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
namespace SisRename.Classes
{
    class validacao
    {

        Classes.conexao conexao;
        public bool validaCampo(string val)
        {
            if(val=="")
            {
                return false;
            }
           if(val==null)
            {
                return false;
            }

           return true;

        }
        public string caracterEsp(string input)
        {
            
            string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            return result;
        }
       public int renomeiaArquivos(string caminho,DataTable dt,string coluna1,string coluna2)
       {
           try {
                    // Caminho literal da pasta informada 
                    DirectoryInfo dirInfo = new DirectoryInfo(@caminho);

                    // Pega todas as informações dos arquivos dentro do diretório informado 
                     FileInfo[] arquivos = dirInfo.GetFiles();
                      
                       string antigoNome;
                       string novoNome;
                       int arqAfet = 0;
                       string codigoposte="";
                       int result = -1;
                        string nomeabrev="";

                       for (int i = 0; i < arquivos.Length; i++)
                       {
                           
                           if(dt.Rows.Count>0)
                           { 
                               // caminho\nome do arquivo 
                               antigoNome = @caminho + "\\" + arquivos[i].Name;

                               nomeabrev = arquivos[i].ToString().Split('.')[0];//remove extesão do arquivo
                               if (IsNumeric(nomeabrev))//verifica se é numero
                               {
                                   result = BuscaBinaria(dt, Convert.ToInt32(nomeabrev), coluna2);//consulta datatable se possui o arquivo registrado

                                   if (result != -1)
                                   {
                                       codigoposte = dt.Rows[result][coluna1].ToString();
                                       arqAfet++;//incrementa para cada arquivo afetado
                                       novoNome = @caminho + "\\" + codigoposte + "_" + arquivos[i].Name;
                                       File.Move(antigoNome, novoNome); // Move o arquivo para a mesma pasta com os carateres substituídos
                                   }
                               }
                               else
                               {

                               }

                           }
                              
                              
                           
                       }                    
                      
                       
               return arqAfet;
           }
           catch(Exception ex)
           {
               return -1;
               // Se der erro, exibe o que aconteceu MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
       public int BuscaBinaria(DataTable array, int valor, string coluna)
       {
           int min = 0;
           int max = array.Rows.Count - 1;
           while (max >= min)
           {
               /* Calcula o ponto médio (aproximado dependendo se a quantidade de posições é par ou impar*/
               int mid = (min + max) / 2;

               // Determina qual das metades será usada para continuar a busca  
               if (Convert.ToInt32(array.Rows[mid][coluna]) < valor) min = mid + 1; // troca a primeira posição do array para a posição do meio  

               else if (Convert.ToInt32(array.Rows[mid][coluna]) > valor) max = mid - 1;// troca a última posição do array para a posição do meio  

               else return mid; // Valor encontrado na posição central, para o algoritmo e retorna a posição  
           }
           // Não encontrou o valor desejado no array, retorna -1  
           return -1;
       }
       public bool IsNumeric(string prstValor)
       {
           char[] AIM_stDatachars = prstValor.ToCharArray();

           foreach (var AIM_stDatachar in AIM_stDatachars)
           {
               if (!char.IsDigit(AIM_stDatachar))
                   return false;
           }

           return true;
       }



    }
}
