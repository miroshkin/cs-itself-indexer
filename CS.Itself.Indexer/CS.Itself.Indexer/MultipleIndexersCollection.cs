using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CS.Itself.Indexer
{

    public class MultipleIndexersCollection
    {
        private string[] months = new[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
            "November", "December"
        };

        /// <summary>
        /// Gets the number of month by name
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public int this[string month]
        {
            get => Array.IndexOf(months,month) + 1;
        }

        /// <summary>
        /// Gets the month name by number
        /// </summary>
        /// <param name="monthNumber"></param>
        /// <returns></returns>
        public string this[int monthNumber]
        {
            get => months[monthNumber - 1];
        }
    }
}
