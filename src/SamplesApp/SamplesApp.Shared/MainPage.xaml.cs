﻿using SampleControl.Presentation;
using Windows.UI.Xaml.Controls;

namespace SamplesApp
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();

			sampleControl.DataContext = new SampleChooserViewModel();
		}

		public void OnQuit(object sender, object args)
		{
			System.Console.WriteLine("OnQuit");
		}
	}
}
