﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beetle.DTCore.Network
{
	public class ListFolder : MessageBase
	{

	}

	public class ListFolderResponse : MessageBase
	{

		public ListFolderResponse()
		{
			Items = new List<string>();
		}
		public List<string> Items { get; set; }
	}

}
