// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MonkeyScratch
{
	[Register ("ScratchCell")]
	partial class ScratchCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView bananaImage { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (bananaImage != null) {
				bananaImage.Dispose ();
				bananaImage = null;
			}
		}
	}
}
