using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using SQLAssist.Classes;

namespace SQLAssist.VerticalViewer
{
	class VerticalViewer : ListBox
	{
		public List<SQLDataCell> DataCells
		{ get; set; }
	}
}
