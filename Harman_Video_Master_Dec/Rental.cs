using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harman_Video_Master_Dec
{
   public  class Rental
    {
        // according to year price is charged to the video
        public int rentalCost(int Price, String issue, String retrn)
        {
            // date function for present date 

            DateTime Current_date = DateTime.Now;

           
            DateTime Old_date = Convert.ToDateTime(issue.ToString());

            // see many days old
           
            String diff = (Current_date - Old_date).TotalDays.ToString();


            // calculate the round off value 
            Double Days = Math.Round(Convert.ToDouble(diff));

        
            return Price * Convert.ToInt32(Days);
        }

    }
}
