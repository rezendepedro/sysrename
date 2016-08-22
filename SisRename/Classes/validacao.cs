using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
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
       public int renomeiaArquivos(string caminho, bool renomeiaPastas)
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

                       for (int i = 0; i < arquivos.Length; i++)
                       {
                           if(arquivos[i].Name.Contains(" ")){

                               // caminho\nome do arquivo 
                               antigoNome = @caminho+"\\"+arquivos[i].Name;

                               // caminho\nome_do_arquivo
                               novoNome = @caminho + "\\" +codigoposte+"_"+ arquivos[i].Name;

                               // Move o arquivo para a mesma pasta com os carateres substituídos 
                               File.Move(antigoNome, novoNome);

                               // Contagem dos arquivos renomeados 
                               arqAfet++;
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



    }
}
