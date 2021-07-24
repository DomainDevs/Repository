using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace LoginRegister.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ControlCharacters : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string inlineString = string.Empty;
            if (value == null)
            {
                return true;
            }
            else
            {
                string pattern = @"[!@'<>#]";
                Match mt = Regex.Match(value.ToString(), pattern);
                Console.WriteLine("Resultados" + mt.Length);
                if (mt.Length > 0)
                {
                    ErrorMessage = "Password Invalido!";
                    while (mt.Success)
                    {
                        ErrorMessage = ErrorMessage + string.Format("'{0}' encontrado en la posición {1} \n", mt.Value, mt.Index);
                        mt = mt.NextMatch();
                    }
                    return false;
                }
            }
            return true;
        }
    }
}
