using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Utilites
{
    //Класс для удобной конвертации
    public static class Converter
    {
        public static int ToInt(this object obj) => Convert.ToInt32(obj);
        public static long ToLong(this object obj) => Convert.ToInt64(obj);
        public static decimal ToDecimal(this object obj) => Convert.ToDecimal(obj);
        public static double ToDouble(this object obj) => Convert.ToDouble(obj);
    }
}
