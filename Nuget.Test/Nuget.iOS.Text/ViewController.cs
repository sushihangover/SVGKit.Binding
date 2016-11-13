using System;
using Foundation;
using UIKit;
using SushiHangover.SVGKit;
using System.IO;

namespace Nuget.iOS.Text
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var image = new SVGKImage(Path.Combine(NSBundle.MainBundle.BundlePath, "Media/Joker.svg"));
			var imageView = new SVGKFastImageView(image);
			imageView.Frame = View.Frame;
			View.Add(imageView);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
