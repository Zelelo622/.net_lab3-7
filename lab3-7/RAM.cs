using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_7
{
	internal class RAM
	{
		private String capacity;
		private int frequency;

		public RAM() { }

		public String Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}

		public int Frequency
		{
			get { return frequency; }
			set { frequency = value; }
		}
	}
}
