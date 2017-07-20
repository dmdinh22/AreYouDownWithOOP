using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        // extension method for inserting spaces
        // use 'this' before param to turn into extension method
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            // If source is not null
            if (!String.IsNullOrWhiteSpace(source))
            {
                // spin through each letter
                foreach ( char letter in source)
                {
                    // if there is an uppercase letter, add a space before
                    if (char.IsUpper(letter))
                    {
                        //trim any spaces that already exist
                        result = result.Trim();
                        result += " ";
                    }
                    // ad each letter to the result var
                    result += letter;
                }
                result = result.Trim();
            }
            //return the result
            return result;
        }
    }
}
