using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using System.Collections.Generic;

namespace AvaloniaDataGridMultiLine;
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		List<TestItem> list = new();
		for (int i = 0; i < 100; i++)
		{
			string text = i % 2 == 0 ? "aaa" : "b\nb\nb\nb\nb\nb\nb\nb\nb\nb\nb";
			list.Add(new TestItem(i, text));
		}

		Content = new DataGrid()
		{
			HorizontalAlignment = HorizontalAlignment.Stretch,
			VerticalAlignment = VerticalAlignment.Stretch,
			Background = Brushes.White,
			RowBackground = Brushes.White,
			ItemsSource = new DataGridCollectionView(list),
			AutoGenerateColumns = true,
			FontSize = 16,
			[Grid.RowProperty] = 2,
		};
	}

	public class TestItem
	{
		public int Index { get; set; } = 0;
		public string? Text { get; set; }

		public TestItem(int index, string? text)
		{
			Index = index;
			Text = text;
		}

		public override string ToString() => Index.ToString();
	}
}
