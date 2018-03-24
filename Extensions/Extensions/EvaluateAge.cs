using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public static class EvaluateAge
    {
        public static int CalculateAge(this DateTime dateTime)
        {
            var age = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now < dateTime.AddYears(age))
                age--;
            return age;
        }
    }
}
