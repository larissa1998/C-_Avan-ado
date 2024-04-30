using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Atributo
{
    public class MyValidacao : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(((string)value).Length == 10){
                return true;
            } else
            {
                return false;
            }
        }
    }
}
