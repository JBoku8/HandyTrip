using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace hackTbilisi
{
	public class CartSource:UITableViewSource
	{
		List<Souvenir> _dataSource;
		UIViewController _parentViewController;

		public CartSource (List<Souvenir> dataSource,UIViewController parentController)
		{
			_dataSource = dataSource;
			_parentViewController = parentController;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _dataSource.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("cartCell");

			Souvenir currSouvenir = _dataSource.ElementAt (indexPath.Row);

			cell.TextLabel.Text = currSouvenir.Name;
			cell.DetailTextLabel.Text = String.Format ("Price : {0}", currSouvenir.Price.ToString ("##.##"));

			UIImage currImage = UIImage.FromFile ("Images/" + currSouvenir.ImgUrls [0]);
			cell.ImageView.Image = currImage;

			return cell;
		}

		public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
		{
			if (editingStyle == UITableViewCellEditingStyle.Delete) {

				Globals.Cart.RemoveAt (indexPath.Row);
				tableView.DeleteRows (new Foundation.NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);

				if(Globals.Cart.Count==0)
					_parentViewController.TabBarController.TabBar.Items[1].BadgeValue=null;
				else
				_parentViewController.TabBarController.TabBar.Items[1].BadgeValue=Globals.Cart.Count.ToString();
			}
		}

		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 80;
		}

	}
}

