﻿using System;
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
       public int renomeiaArquivos(string caminhoentrada,string caminhosaida,DataTable dt,string coluna1,string coluna2,string coluna3,string caracterespecial)
       {
           try {
                    // Caminho literal da pasta informada 
                    DirectoryInfo dirInfo = new DirectoryInfo(@caminhoentrada);
                    //FileSystemInfo[] files = dirInfo.GetFileSystemInfos();                    
                    // Pega todas as informações dos arquivos dentro do diretório informado 
                    FileInfo[] arquivos =  dirInfo.GetFiles().OrderBy(p => p.Name).ToArray();
                      
                       string antigoNome;
                       string novoNome;
                       string nomebdinicio = "";
                       string nomebdfinal = "";                       
                       int arqAfet = 0;                      
                       string nomecompincio="";
                       string nomecompfinal = "";
                       int cont=0;

                       if (dt.Rows.Count > 0)
                       {
                           for(int i=0;i<dt.Rows.Count;i++)
                           {
                               if ((i + 1) > dt.Rows.Count)
                               {
                                   break;
                               }
                               else
                               {
                                   nomebdinicio=dt.Rows[i][coluna2].ToString();
                                   nomebdfinal = dt.Rows[i][coluna3].ToString();
                                   nomecompincio = "IMG_" + nomebdinicio+".JPG";
                                   nomecompfinal = "IMG_" + nomebdfinal + ".JPG";

                                   for (int j = 0; j < arquivos.Length;j++ )
                                   {
                                       if(arquivos[j].ToString()==nomecompincio)
                                       {
                                           cont = 0;                                           
                                           
                                               for (int x = j; x < arquivos.Length; x++)
                                               {
                                                   cont++;
                                                   antigoNome = @caminhoentrada + "\\" + arquivos[x].ToString();
                                                   novoNome = @caminhosaida + "\\" + dt.Rows[i][coluna1].ToString() + caracterespecial + cont+".JPG";
                                                   File.Copy(antigoNome, novoNome); // Move o arquivo para a mesma pasta com os carateres substituídos
                                                   arqAfet++;
                                                   if (arquivos[x].ToString() == nomecompfinal)
                                                   {
                                                       cont = -1;
                                                       break;
                                                   }
                                                       

                                               }

                                            if(cont==-1)
                                            {
                                                break;
                                            }                                       
                                           

                                           
                                       }
                                   }


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
        public string removeCaracter(char caracter,string value)
       {
           string[] part = value.Split(caracter);
            value="";
            for(int i=0;i<part.Length;i++)
            {
                value += part[i];

            }

           return value;
       }
        public string[] ordenar(string[] lista)
        {


            return lista;

        }



    }
}
