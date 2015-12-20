using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace hackTbilisi
{
	public class SightSource:UITableViewSource
	{
		List<Sight> _dataSource;

		public Action<Sight> SightSelected{get;set;}

		public SightSource (List<Sight> dataSource)
		{
			_dataSource = dataSource;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _dataSource.Count;
		}


		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var curCell = tableView.DequeueReusableCell ("sightCell");

			Sight currSignt = _dataSource.ElementAt (indexPath.Row);
			UIImage currImage = UIImage.FromFile ("Images/"+currSignt.ImageUrl);

			curCell.ImageView.Image = currImage;

			curCell.TextLabel.Text = currSignt.Name;
			curCell.DetailTextLabel.Text = String.Format ("Distance : --KM");

			return curCell;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			Sight currSight = _dataSource.ElementAt (indexPath.Row);

			if (SightSelected != null)
				SightSelected (currSight);
		}
	}
}

