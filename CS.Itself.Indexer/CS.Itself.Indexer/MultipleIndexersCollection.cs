using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CS.Itself.Indexer
{

    public class MultipleIndexersCollection
    {
        private string[] englishMonths = new[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
            "November", "December"
        };

        private string[] russianMonths = new[]
        {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь",
            "Ноябрь", "Декабрь"
        };

        /// <summary>
        /// Gets the number of month by name
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public int this[string month]
        {
            get => Array.IndexOf(englishMonths,month) + 1;
        }

        /// <summary>
        /// Gets the month name by number
        /// </summary>
        /// <param name="monthNumber"></param>
        /// <returns></returns>
        public string this[int monthNumber]
        {
            get => englishMonths[monthNumber - 1];
        }


        public string this [LanguageStructure structure]
        {
            get
            {
                if (structure.Language == "Russian")
                {
                    return russianMonths[structure.MonthNumber - 1];
                }
                else 
                {
                    return englishMonths[structure.MonthNumber - 1];
                }
            }
        }
    }
}
