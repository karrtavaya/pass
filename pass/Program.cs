using System.ComponentModel.DataAnnotations;
using pass.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать!");
        ApplicationContext ef = new ApplicationContext();
        Ticket tick = new Ticket()
        {
            Passanger = ef.Passangers.FirstOrDefault(x => x.IdPassanger == 2),
            PointArrival = ef.Points.FirstOrDefault(x => x.IdPoint == 3),
            PointDeparture = ef.Points.FirstOrDefault(x => x.IdPoint == 2),
            DataArriva = new DateTime(2023, 02, 07, 11, 31, 10)
        };
        ef.Add(tick);
        ef.SaveChanges();

        Console.WriteLine("Введите ФИО и номер телефона пассажира");
        Passanger p = new Passanger()
        {
            Name = Console.ReadLine(),
            Phone = Console.ReadLine()
        };
        Passanger p2 = new Passanger()
        {
            Name = Console.ReadLine(),
            Phone = Console.ReadLine()
        };
        Passanger p3 = new Passanger()
        {
            Name = Console.ReadLine(),
            Phone = Console.ReadLine()
        };
        if (!ef.Passangers.Any(x => x.Name == p.Name))
        {
            ef.Add(p);
        }
        ef.Add(p);
        ef.Add(p2);
        ef.Add(p3);

        Point point = new Point() { Value = Console.ReadLine() };
        Point point2 = new Point() { Value = Console.ReadLine() };
        Point point3 = new Point() { Value = Console.ReadLine() };
        Point point4 = new Point() { Value = Console.ReadLine() };
        Point point5 = new Point() { Value = Console.ReadLine() };
        ef.Add(point);
        ef.Add(point2);
        ef.Add(point3);
        ef.Add(point4);
        ef.Add(point5);
        ef.SaveChanges();


    }



}