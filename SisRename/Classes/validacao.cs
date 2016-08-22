using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace SisRename.Classes
{
    class validacao
    {


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


    }
}
