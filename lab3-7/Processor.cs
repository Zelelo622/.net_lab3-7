using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_7
{
	internal class Processor
	{
		private String manufacturer;
		private int cores;
		private int threads;
		private int frequency;

		public Processor(String manufacturer, int cores) 
		{
			this.manufacturer = manufacturer;
			this.cores = cores;
		}

		public String Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		public int Cores
		{
			get { return cores; }
			set { cores = value; }
		}

		public int Threads
		{
			get { return threads; }
			set { threads = value; }
		}

		public int Frequency
		{
			get { return frequency; }
			set { frequency = value; }
		}
	}
}
