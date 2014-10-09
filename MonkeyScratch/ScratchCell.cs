using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MonkeyScratch
{
	partial class ScratchCell : UICollectionViewCell
	{
		public static readonly NSString Id = new NSString ("scratchCell");

		public bool HasBananas {
			get { return !bananaImage.Hidden; }
			set { bananaImage.Hidden = !value; }
		}

		public ScratchCell (IntPtr handle) : base (handle)
		{
		}
	}
}
