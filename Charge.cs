using System;

namespace SubsidyCalculation
{
    /// <summary>
    /// Начисление
    /// </summary>
    public static class Charge
    {
        public static int serviceId;

        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public static int ServiceId
        {
            get
            {
                return serviceId;
            }

            set
            {
                serviceId = value;
            }
        }

        /// <summary>
        /// Идентификатор дома
        /// </summary>
        public static int HouseId { get; set; }
        
        /// <summary>
        /// Месяц начисления
        /// </summary>
        public static DateTime Month { get; set; }
        
        /// <summary>
        /// Значение начисления
        /// </summary>
        public static decimal Value { get; set; }



        public Charge CalculateSubsidy(Volume volumes, Tariff tariff)
        {  
         
        }
    }
}