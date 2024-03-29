namespace Test1.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string Motherboard { get; set; } = "";
        public int? CPUCores { get; set; } = 0;
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = "";

        public void PrintDetails()
        {
            Console.WriteLine(
                    "ComputerId: " + this.ComputerId + ", " +
                    "Motherboard: " + this.Motherboard + ", " +
                    "CPUCores: " + this.CPUCores + ", " +
                    "HasWifi: " + this.HasWifi + ", " +
                    "HasLTE: " + this.HasLTE + ", " +
                    "ReleaseDate: " + this.ReleaseDate + ", " +
                    "Price: " + this.Price + ", " +
                    "VideoCard: " + this.VideoCard
                );
        }
    }
}