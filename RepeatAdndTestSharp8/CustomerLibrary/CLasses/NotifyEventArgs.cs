using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.CLasses
{
	public class NotifyEventArgs: EventArgs
	{
		public NotifyEventArgs(string customName) {
			CustomName = customName;
		}

		public string CustomName { get; set; }		

	}
}
