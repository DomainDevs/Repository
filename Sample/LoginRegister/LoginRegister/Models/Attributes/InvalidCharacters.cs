using System;
using System.Text.RegularExpressions;

namespace LoginRegister.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class InvalidCharacters : RegexAttribute
    {
        public InvalidCharacters() : base(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", RegexOptions.IgnoreCase)
        {
            ErrorMessage = "Caracteres invalidos.";
        }
    }
}
