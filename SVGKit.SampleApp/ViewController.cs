using System;
using UIKit;
using SushiHangover.SVGKit;
using CoreAnimation;
using CoreGraphics;
using CoreFoundation;
using Foundation;

namespace SVGKit.SampleApp
{
    public static class Extension
    {
        public static UIColor Inverse(this UIColor color)
        {
            try
            {
                var cgcolor = color.CGColor;
                if (cgcolor.NumberOfComponents == 1)
                    return color;

                var comps = cgcolor.Components;
                var newComps = new nfloat[comps.Length];
                var i = comps.Length - 1;
                newComps[i] = comps[i];
                while (i-- > -0)
                {
                    newComps[i] = 1 - comps[i];
                }
                using (var newCGColor = new CGColor(cgcolor.ColorSpace, newComps))
                {
                    var newUIColor = UIColor.FromCGColor(newCGColor);
                    return newUIColor;
                }
            }
            catch
            {
                return UIColor.Black;
            }
        }
    }

    public partial class ViewController : UIViewController
    {
        NSTimer timer;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            void RecurseLayers(CALayer[] layers)
            {
                foreach (var layer in layers)
                {
                    if (layer is CAShapeLayer && (layer as CAShapeLayer).FillColor != null)
                        (layer as CAShapeLayer).FillColor = UIColor.FromCGColor((layer as CAShapeLayer).FillColor).Inverse().CGColor;
                    if (layer.Sublayers != null)
                        RecurseLayers(layer.Sublayers);
                }
            }
            //var imageView = new SVGKLayeredImageView(new SVGKImage("Media/Sushi.svg"));
            var imageView = new SVGKFastImageView(new SVGKImage("Media/Sushi.svg"));
            imageView.Frame = View.Bounds;
            View.Add(imageView);
            //timer = NSTimer.CreateRepeatingScheduledTimer(2, (_) => InvokeOnMainThread(() => RecurseLayers(imageView.Layer.Sublayers)));
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
