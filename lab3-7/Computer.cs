using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_7
{
	internal class Computer
	{
		private String manufacturer;
		private String model;
		private String os;
		private Hdd hardDisk;
		private RAM ram;
		private Processor processor;
		private VideoCard videoCard;

		public Computer(String manufacturer, String model, String os) 
		{
			this.manufacturer = manufacturer;
			this.model = model;
			this.os = os;
		}

		public void TurnOn()
		{
            Console.WriteLine("Добро пожаловать");
        }

		public void TurnOff() 
		{
			Console.WriteLine("До свидания");
		}

		public void ScanVirus()
		{
			if (this.os == "MacOS")
			{
                Console.WriteLine("В системе нет никакой опасности.");
            } 
			else
			{
                Console.WriteLine("Существует опасность заражения вирусами!");
            }
		}

		public String Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		public String Model
		{
			get { return model; }
			set { model = value; }	
		}

		public String OS
		{
			get { return os; }
			set { os = value; }
		}

		public Hdd HardDisk
		{
			get { return hardDisk; }
			set { hardDisk = value; }
		}

		public RAM Ram
		{
			get { return ram; }
			set { ram = value; }
		}

		public Processor Processor
		{ 
			get { return processor; } 
			set { processor = value; }
		}

		public VideoCard VideoCard 
		{ 
			get { return videoCard; } 
			set {  videoCard = value; } 
		}
	}
}
