using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace hackTbilisi
{
	public class MarketSource:UITableViewSource
	{
		private List<SouvenirCompany> _companies;
		private UIViewController _parentViewController;

		public Action<Souvenir> SouvenirClicked {
			get;
			set;
		}

		public MarketSource (List<SouvenirCompany> companies,UIViewController parentController)
		{
			_companies = companies;
			_parentViewController = parentController;

		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var currSovenier = _companies.ElementAt (indexPath.Section).Souveniers.ElementAt (indexPath.Row);

			if (SouvenirClicked != null)
				SouvenirClicked (currSovenier);
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return _companies.Count;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _companies [(int)section].Souveniers.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var currCell = tableView.DequeueReusableCell ("marketCell");

			var currSouvenir = _companies.ElementAt (indexPath.Section).Souveniers.ElementAt (indexPath.Row);

			UIImage image = UIImage.FromFile ("Images/"+currSouvenir.ImgUrls [0]);

			currCell.ImageView.Image = image;
			currCell.TextLabel.Text = currSouvenir.Name;
			currCell.DetailTextLabel.Text = String.Format("Price : {0}$",currSouvenir.Price.ToString ("##.##"));

			return currCell;
		}

		public override string TitleForHeader (UITableView tableView, nint section)
		{
			return _companies.ElementAt ((int)section).Name;
		}

		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 60;
		}

	}
}

