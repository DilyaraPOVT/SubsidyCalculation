using LoggerBarsGroup;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SubsidyCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Log logger = new Log();
            logger.Fatal("Критичнаяая ошибка!");
            logger.Error(new IndexOutOfRangeException());
            logger.ErrorUnique("До этого такой ошибки не было.", new IndexOutOfRangeException());
            Dictionary<object, object> dict = new Dictionary<object, object>();
            dict.Add(1, "BarsGroup");
            dict.Add(2, "Программирование");
            logger.SystemInfo("SystemInfo", dict);
            logger.Warning("Предупреждение");
            logger.WarningUnique("Новое предупреждение!");
            Console.ReadLine();
        }
    }
}
