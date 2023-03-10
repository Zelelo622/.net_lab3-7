using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_7
{
	internal class VideoCard
	{
		private String manufacturer;
		private String memory;
		private String frequencyVideoChip;

		public VideoCard(String manufacturer, String memory) 
		{
			this.manufacturer = manufacturer;
			this.memory = memory;
		}

		public String Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		public String Memory
		{
			get { return memory; }
			set { memory = value; }
		}

		public String FrequencyVideoChip
		{
			get { return frequencyVideoChip; }
			set { frequencyVideoChip = value; }
		}
	}
}
