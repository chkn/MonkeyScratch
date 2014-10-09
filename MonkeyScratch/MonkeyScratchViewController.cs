using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonkeyScratch
{
	public partial class MonkeyScratchViewController : UIViewController, IUICollectionViewDataSource
	{
		NSIndexPath bananaPath;

		public MonkeyScratchViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			collectionView.WeakDataSource = this;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			bananaPath = NSIndexPath.FromItemSection (new Random ().Next (0, 8), 0);
		}

		public int GetItemsCount (UICollectionView collectionView, int section)
		{
			return 9;
		}

		public UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (ScratchCell)collectionView.DequeueReusableCell (ScratchCell.Id, indexPath);
			cell.HasBananas = indexPath.Equals (bananaPath);
			return cell;
		}

		public override bool ShouldPerformSegue (string segueIdentifier, NSObject sender)
		{
			return ((ScratchCell)sender).HasBananas;
		}
	}
}

