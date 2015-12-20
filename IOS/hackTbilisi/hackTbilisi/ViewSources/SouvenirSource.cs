using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace hackTbilisi
{
	public class SouvenirSource:UITableViewSource
	{
		List<Souvenir> _dataSource;
		UIViewController _parentController;
		
		public SouvenirSource (List<Souvenir> dataSource,UIViewController parentController)
		{
			_dataSource = dataSource;
			_parentController = parentController;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _dataSource.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var currCell = tableView.DequeueReusableCell ("favoriteCell") as FavoriteCell;
			currCell.SelectionStyle = UITableViewCellSelectionStyle.None;

			currCell.AddClicked = delegate {

				Globals.Cart.Add(_dataSource.ElementAt(indexPath.Row));

				Globals.MyFavorites.Remove(Globals.MyFavorites.Where(o=>o.Id==_dataSource.ElementAt(indexPath.Row).Id).SingleOrDefault());

				tableView.DeleteRows(new Foundation.NSIndexPath[]{indexPath},UITableViewRowAnimation.Fade);


				_parentController.TabBarController.TabBar.Items[1].BadgeValue=Globals.Cart.Count.ToString();
				
				currCell.RemoveClicked=null;
				tableView.ReloadData();

			};

			currCell.RemoveClicked = delegate {

				Console.WriteLine (_dataSource.ElementAt(indexPath.Row).Name);

				Globals.MyFavorites.Remove(Globals.MyFavorites.Where(o=>o.Id==_dataSource.ElementAt(indexPath.Row).Id).SingleOrDefault());

				tableView.DeleteRows(new Foundation.NSIndexPath[]{indexPath},UITableViewRowAnimation.Fade);
				//tableView.ReloadData();
				currCell.RemoveClicked=null;
				tableView.ReloadData();
			};

			currCell.Initdata (_dataSource.ElementAt (indexPath.Row));
			return currCell;
		}

		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return (nfloat)220;
		}
	}
}

