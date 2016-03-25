using System;
using Xamarin.Forms;

namespace SearchBoxRecipe
{
	public class CustomCell : ViewCell
	{
		public static readonly BindableProperty NameProperty = 
			BindableProperty.Create ("Name", typeof(string), typeof(CustomCell), "");

		public string Name {
			get { return (string)GetValue (NameProperty); }
			set { SetValue (NameProperty, value); }
		}
	}
}

