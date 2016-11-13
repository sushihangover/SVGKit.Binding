using System;
using UIKit;
using SushiHangover.SVGKit;

namespace SVGKit.SampleApp
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

			var image = new SVGKImage("Media/Sushi.svg");
			var imageView = new SVGKFastImageView(image);
			imageView.Frame = View.Frame;
			View.Add(imageView);
		}

		public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
		{
			return UIInterfaceOrientationMask.LandscapeLeft;
		}

		public override UIInterfaceOrientation PreferredInterfaceOrientationForPresentation()
		{
			return UIInterfaceOrientation.LandscapeLeft;
		}

		public override bool ShouldAutorotate()
		{
			return false;
		}
	}
}
