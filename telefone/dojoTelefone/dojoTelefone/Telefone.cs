using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dojoTelefone
{
    public class Telefone
    {
        public static string GetNumber(string number)
        {
            string retorno = "";
            char[] array = number.ToCharArray();
           

            foreach(var item in array)
            {
                retorno+=Get(item);
            }           

            return retorno;
        }

        private static char Get(char number)
        {
            if (number.Equals('A') || number.Equals('B') || number.Equals('C'))
                return '2';
            if (number.Equals('D') || number.Equals('E') || number.Equals('F'))
                return '3';
            else
                return number;
        }
    }
}
