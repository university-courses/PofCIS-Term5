﻿using System.Windows;
using System.Windows.Controls;

namespace CargoDelivery
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void SenderName_TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void ReceiverName_TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void SenderCity_ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void SenderAddress_TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void Weight_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{

		}

		private void ReceiverCity_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void SenderAddress_TextBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void CreateOrder_Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Thank you for your order!");
		}
	}
}
