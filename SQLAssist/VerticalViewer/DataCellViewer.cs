using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using SQLAssist.Classes;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows;

namespace SQLAssist.VerticalViewer
{
	class DataCellViewer : Grid
	{
		private SQLDataCell _data;

		public DataCellViewer(SQLDataCell input)
		{
			DataContext = this;

			_data = input;

			ColumnDefinitions.Add(new ColumnDefinition());
			ColumnDefinitions.Add(new ColumnDefinition());
			ColumnDefinitions.Add(new ColumnDefinition());
			
			RowDefinitions.Add(new RowDefinition());

			Children.Add(SetGridColumnRow(CreateColumnNameBox(),0,0));
			Children.Add(SetGridColumnRow(CreateDataBox(), 0, 1));
		}

		private UIElement SetGridColumnRow(UIElement input, int row, int column)
		{
			input.SetValue(RowProperty, row);
			input.SetValue(ColumnProperty, column);

			return input;
		}

		public Label CreateColumnNameBox()
		{
			var columnNameBox = new Label();

			columnNameBox.SetBinding(Label.ContentProperty, new Binding("ColumnName"){Source=_data});

			return columnNameBox;
		}

		TextBox CreateDataBox()
		{
			var dataBox = new TextBox();

			dataBox.SetBinding(TextBox.TextProperty,new Binding("CellValue"){Source=_data});

			return dataBox;
		}

	}
}
