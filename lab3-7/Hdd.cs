using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_7
{
	internal class Hdd
	{
		private String type;
		private String manufacturer;
		private String capacity;
		private int maxOperatingTemperature;

		public Hdd(String type, String manufacturer, String capacity) 
		{
			this.type = type;
			this.manufacturer = manufacturer;
			this.capacity = capacity;
		}

		public String Type
		{
			get { return type; }
			set { type = value; }
		}

		public String Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		public String Capacity
		{ 
			get { return capacity; } 
			set { capacity = value; }
		}

		public int MaxOperatingTemperature
		{ 
			get { return maxOperatingTemperature; } 
			set { maxOperatingTemperature = value; } 
		}
	}
}
