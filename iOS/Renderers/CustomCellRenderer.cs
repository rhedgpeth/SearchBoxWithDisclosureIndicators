using System;
using SearchBoxRecipe;
using Xamarin.Forms;
using SearchBoxRecipe.iOS;
using Xamarin.Forms.Platform.iOS;
using UIKit;

/* Example of using a custom renderer to get the > disclosure indicator to appear */
using Foundation;

[assembly: ExportRenderer (typeof (CustomCell), typeof (CustomCellRenderer))]

namespace SearchBoxRecipe.iOS
{
	public class CustomCellRenderer : ViewCellRenderer
	{
		static NSString rid = new NSString("CustomCell");

		public override UIKit.UITableViewCell GetCell (Xamarin.Forms.Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
		{
			var x = (CustomCell)item;

			var c = reusableCell as CustomiOSCell; 

			if (c == null) {
				c = new CustomiOSCell (rid);
			}

			UIImage i = null;

			c.UpdateCell (x.Name);

			c.Accessory = UITableViewCellAccessory.DisclosureIndicator;

			return c;
		}
	}
}