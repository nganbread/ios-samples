// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace StateRestoration
{
	[Register ("CollectionCell")]
	partial class CollectionCell
	{
		[Outlet]
		public MonoTouch.UIKit.UIImageView ImageView { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel Label { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
		}
	}
}
