using System;
using Foundation;
using UIKit;
using SushiHangover.SVGKit;
using System.IO;
using System.Net.Http;

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

			var uriString = "https://upload.wikimedia.org/wikipedia/commons/6/6b/Bitmap_VS_SVG.svg";
			var button = new UIButton(UIButtonType.InfoDark);
			button.Frame = new CoreGraphics.CGRect(100, 40, 100, 40);
			button.SetTitle(uriString, UIControlState.Normal);
			button.TouchUpInside += async (sender, e) =>
			{
				using (HttpClient client = new HttpClient())
				using (HttpResponseMessage response = await client.GetAsync(uriString))
				using (HttpContent content = response.Content)
				{
					string result = await content.ReadAsStringAsync();
					if (result != null)
					{
						var svgSource = SVGKSourceString.SourceFromContentsOfString(result);
						var svgImage = SVGKImage.ImageWithSource(svgSource);
						imageView.Image = svgImage;
						imageView.Frame = View.Frame;
						imageView.ContentMode = UIViewContentMode.ScaleAspectFit;
					}
				}
			};
			View.Add(button);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
