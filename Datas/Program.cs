using System;
using System.Globalization;

namespace Datas{
    class Program{

        static void Main(string[] args){

            Console.Clear();

            // var data = new DateTime();
            // var dataAgora = DateTime.Now;
            // var data = new DateTime(2023, 10, 12, 8, 23, 14);
            // var mes = data.Month;
            // var diaDaSemana = data.DayOfWeek;

            // var dataAgora = DateTime.Now;
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss f z}", dataAgora);
            // Console.WriteLine(formatada);

            // var dataAgora = DateTime.Now;
            // Console.WriteLine(dataAgora.AddDays(13));
            // Console.WriteLine(dataAgora.AddMonths(3));

            // var pt = new CultureInfo("pt-BR");
            // var autal = CultureInfo.CurrentCulture;
            // Console.WriteLine(DateTime.Now.ToString("D", pt));

            // var utcDate = DateTime.UtcNow;
            // Console.WriteLine(utcDate.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            
            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            // Console.WriteLine(horaAustralia);


            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0))); //add 12 hours

        }

    }
}