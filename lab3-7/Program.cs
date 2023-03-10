namespace lab3_7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			VideoCard card = new VideoCard("Nvidia", "16 gb");
			Processor processor = new Processor("Intel", 4);
			RAM ram = new RAM();
			Hdd hdd = new Hdd("SSD", "Samsung", "256 gb");
			Computer computer = new Computer("DEXP", "Atlas H377", "Linux");

			computer.VideoCard = card;
			computer.Processor = processor;
			computer.Ram = ram;
			computer.HardDisk = hdd;

			computer.TurnOn();
			computer.ScanVirus();
            computer.TurnOff();
		}
	}
}