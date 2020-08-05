using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
 
                string[] Weekends = new string[2];
                WorkDayCalculator calculator = new WorkDayCalculator();

                Console.Write("Start date:");
                DateTime Date = Convert.ToDateTime(DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));

                Console.Write("Duration, day(s):");
                uint Duration = UInt32.Parse(Console.ReadLine());

                Console.Write("Weekends 1:");
                string weekends = Console.ReadLine();
                if (weekends != "0")
                {
                    Weekends = weekends.Split('-');
                }
                DateTime startWeek = Convert.ToDateTime(DateTime.ParseExact(Weekends[0], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                DateTime endtWeek = Convert.ToDateTime(DateTime.ParseExact(Weekends[1], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                WeekEnd[] weekEnd = new WeekEnd[]
                {
                    new WeekEnd(startWeek, endtWeek)
                };

                Console.Write("Weekends 2:");
                weekends = Console.ReadLine();
                if (weekends != "0")
                {
                    Weekends = weekends.Split('-');
                    startWeek = Convert.ToDateTime(DateTime.ParseExact(Weekends[0], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                    endtWeek = Convert.ToDateTime(DateTime.ParseExact(Weekends[1], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                    Array.Resize(ref weekEnd, 2);
                    weekEnd[1] = new WeekEnd(startWeek, endtWeek);
                }
                int Duration2 = Convert.ToInt32(Duration);
                Console.WriteLine($"At the exit there should be: {calculator.Calculate(Date, Duration2, weekEnd).ToShortDateString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
