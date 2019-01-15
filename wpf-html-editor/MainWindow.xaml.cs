using System.Windows;

namespace WPFHtmlEditor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		#region Constructor

		public MainWindow()
		{
			InitializeComponent();

			//Prepare the html content
			string html = @"<P><STRONG>Lorem Ipsum is simply dummy text.</STRONG></P>";

			//Bind the html content to Html Editor
			txtMessage.BindingContent = html;
		}

		#endregion
	}
}
