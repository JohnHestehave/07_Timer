using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer
{
	class Timer
	{
		public int Seconds = 0;

		public override string ToString()
		{
			TimeSpan t = TimeSpan.FromSeconds(Seconds);
			return string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
		}

		public string Padded(int time)
		{
			TimeSpan t = TimeSpan.FromSeconds(time);
			return string.Format("{0:D2}", t.Seconds);
		}
	}
}
