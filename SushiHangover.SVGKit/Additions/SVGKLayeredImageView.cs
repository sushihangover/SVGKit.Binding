using System;
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace SushiHangover.SVGKit
{
    public unsafe partial class SVGKLayeredImageView : SVGKImageView
    {
        [Export("initWithSVGKImage:")]
        public SVGKLayeredImageView(SVGKImage im) : base (im)
            {
            if (im == null)
                throw new ArgumentNullException("im");
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.Messaging.this_assembly;
            if (IsDirectBinding)
            {
                InitializeHandle(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("initWithSVGKImage:"), im.Handle), "initWithSVGKImage:");
            }
            else
            {
                InitializeHandle(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("initWithSVGKImage:"), im.Handle), "initWithSVGKImage:");
            }
        }        
    }
}
