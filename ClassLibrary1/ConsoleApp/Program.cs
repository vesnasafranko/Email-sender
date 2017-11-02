using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MailClient MailClient= new MailClient();
            MailClient.SendEmail("vesna.safranko@vsmti.hr", "proba", "Booook");
            Console.ReadKey();
        }
    }
}
