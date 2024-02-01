using System.Globalization;
using Test1.Data;
using Test1.Models;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContextDapper dcDapper = new DataContextDapper();
            DataContextEF dcEF = new DataContextEF();

            Computer myComputer = new Computer()
            {
                Motherboard = "Z691",
                HasWifi = true,
                HasLTE = true,
                ReleaseDate = DateTime.Now,
                Price = 1000.87m,
                VideoCard = "RTX 2000"
            };

            //Work with data using Dapper
            // string sqlInsertRecord = @"INSERT INTO TutorialAppSchema.Computer (
            //     Motherboard,
            //     HasWifi,
            //     HasLTE,
            //     ReleaseDate,
            //     Price,
            //     VideoCard
            // ) VALUES ('" + myComputer.ComputerId
            //     + "','" + myComputer.Motherboard
            //     + "','" + myComputer.HasWifi
            //     + "','" + myComputer.HasLTE
            //     + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd")
            //     + "','" + myComputer.Price.ToString("0.00", CultureInfo.InvariantCulture)
            //     + "','" + myComputer.VideoCard
            // + "')";

            //Console.WriteLine(sqlInsertRecord);
            //int affectedRows = dcDapper.ExecuteSql(sqlInsertRecord);

            //Console.WriteLine("Affected rows: " + affectedRows);

            // string sqlGetRecords = "SELECT * FROM TutorialAppSchema.Computer";
            // var computers = dcDapper.GetRecords<Computer>(sqlGetRecords);

            ///Work with data using EntityFramework
            dcEF.Add(myComputer);
            int affectedRows = dcEF.SaveChanges();
            Console.WriteLine("Affected rows: " + affectedRows);

            var computers = dcEF.Computer?.ToList<Computer>();

            if (computers != null)
            {
                foreach (var computer in computers)
                    computer.PrintDetails();
            }
        }

    }
}