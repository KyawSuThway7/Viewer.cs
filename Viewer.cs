 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentforOOP
{
    public  class Viewer:IViewer
    {
        public double minutes { get; set; }
        public void YourReaction()
        {
            Console.WriteLine( "\t For Viewer ");
            Console.WriteLine("Reaction : Like , Love , HaHa, TakeCare,Sad");
            Console.WriteLine("Feedback : Comment");
            Console.WriteLine("Opportunity : Share");
        }
        public double Yourpaymaent(double minutes)
        {
            double result =minutes *5 ;
            return result;
        }
        public void YourpaymentwithMinutes(double minutes, double payment)
        {
            Console.WriteLine($"You pay {payment} kyats in {minutes} minutes");
        }
        public double WatchOscarvideo(double minutes)
        {
            double result = minutes * 10;
            return result;
        }
        public double WatchFunnyvideo(double minutes)
        {
            double result = minutes * 5;
            return result;
        }
        public double WatchPost(double minutes)
        {
            double result = minutes * 2;
            return result;
        }
       
    }
}
