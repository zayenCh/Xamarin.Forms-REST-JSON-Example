using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListView_Sample
{
	public partial class ListView_SamplePage : ContentPage
	{
		public ListView_SamplePage()
		{
			InitializeComponent();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();

			myListView.ItemsSource = await App.MYitemsManager.GetTasksAsync();
			await DisplayAlert("done", "yes" + (myListView.ItemsSource as List<Item>).Count , "ok");
		}
		void Event_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			DisplayAlert("Selected item", "you selected the Item ( " + (e.SelectedItem as Item).title +" )" ,"ok");
		}
	}
}
