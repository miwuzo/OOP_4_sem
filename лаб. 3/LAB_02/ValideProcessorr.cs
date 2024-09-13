using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace LAB_02
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    class ProcessorrAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string processorr = value.ToString();
                if (Regex.IsMatch(processorr, @"^[a-zA-Zа-яА-ЯёЁ\s-]+$"))
                    return true;
                else
                    ErrorMessage = "ошибка!!!!!!!!!!!";
            }
            return false;
        }
    }
}
