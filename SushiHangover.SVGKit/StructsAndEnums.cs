using System;
using System.Runtime.InteropServices;
using CoreGraphics;

namespace SushiHangover.SVGKit
{
	public enum DOMNodeType : uint
	{
		ElementNode = 1,
		AttributeNode = 2,
		TextNode = 3,
		CdataSectionNode = 4,
		EntityReferenceNode = 5,
		EntityNode = 6,
		ProcessingInstructionNode = 7,
		CommentNode = 8,
		DocumentNode = 9,
		DocumentTypeNode = 10,
		DocumentFragmentNode = 11,
		NotationNode = 12
	}

	public enum CSSUnitType : uint
	{
		Inherit = 0,
		PrimitiveValue = 1,
		ValueList = 2,
		Custom = 3
	}

	public enum CSSRuleType : uint
	{
		UnknownRule = 0,
		StyleRule = 1,
		CharsetRule = 2,
		ImportRule = 3,
		MediaRule = 4,
		FontFaceRule = 5,
		PageRule = 6
	}

	public enum SvgLengthType : uint
	{
		Unknown = 0,
		Number = 1,
		Percentage = 2,
		Ems = 3,
		Exs = 4,
		Px = 5,
		Cm = 6,
		Mm = 7,
		In = 8,
		Pt = 9,
		Pc = 10
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct SVGColor
	{
		public byte r;

		public byte g;

		public byte b;

		public byte a;
	}

	//static class CFunctions
	//{
	//	// extern SVGColor SVGColorMake (uint8_t r, uint8_t g, uint8_t b, uint8_t a);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern SVGColor SVGColorMake (byte r, byte g, byte b, byte a);

	//	// extern SVGColor SVGColorFromString (const char *string);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern unsafe SVGColor SVGColorFromString (sbyte* @string);

	//	// extern CGFloat SVGPercentageFromString (const char *string);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern unsafe nfloat SVGPercentageFromString (sbyte* @string);

	//	// extern CGMutablePathRef createPathFromPointsInString (const char *string, boolean_t close);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern unsafe CGMutablePathRef* createPathFromPointsInString (sbyte* @string, int close);

	//	// extern CGColorRef CGColorWithSVGColor (SVGColor color);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern unsafe CGColorRef* CGColorWithSVGColor (SVGColor color);

	//	// extern CGPathRef CGPathCreateByOffsettingPath (CGPathRef aPath, CGFloat x, CGFloat y);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern unsafe CGPathRef* CGPathCreateByOffsettingPath (CGPathRef* aPath, nfloat x, nfloat y);

	//	// extern CGPathRef CGPathCreateByTranslatingPath (CGPathRef aPath, CGFloat x, CGFloat y);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern unsafe CGPathRef* CGPathCreateByTranslatingPath (CGPathRef* aPath, nfloat x, nfloat y);

	//	// extern SVGRect SVGRectUninitialized ();
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern SVGRect SVGRectUninitialized ();

	//	// extern BOOL SVGRectIsInitialized (SVGRect rect);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern bool SVGRectIsInitialized (SVGRect rect);

	//	// extern SVGRect SVGRectMake (float x, float y, float width, float height);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern SVGRect SVGRectMake (float x, float y, float width, float height);

	//	// extern CGRect CGRectFromSVGRect (SVGRect rect);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern CGRect CGRectFromSVGRect (SVGRect rect);

	//	// extern CGSize CGSizeFromSVGRect (SVGRect rect);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern CGSize CGSizeFromSVGRect (SVGRect rect);

	//	// extern SVGCurve SVGCurveMake (CGFloat cx1, CGFloat cy1, CGFloat cx2, CGFloat cy2, CGFloat px, CGFloat py);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern SVGCurve SVGCurveMake (nfloat cx1, nfloat cy1, nfloat cx2, nfloat cy2, nfloat px, nfloat py);

	//	// extern BOOL SVGCurveEqualToCurve (SVGCurve curve1, SVGCurve curve2);
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern bool SVGCurveEqualToCurve (SVGCurve curve1, SVGCurve curve2);
	//}

	public enum CSSPrimitiveType : uint
	{
		Unknown = 0,
		Number = 1,
		Percentage = 2,
		Ems = 3,
		Exs = 4,
		Px = 5,
		Cm = 6,
		Mm = 7,
		In = 8,
		Pt = 9,
		Pc = 10,
		Deg = 11,
		Rad = 12,
		Grad = 13,
		Ms = 14,
		S = 15,
		Hz = 16,
		Khz = 17,
		Dimension = 18,
		String = 19,
		Uri = 20,
		Ident = 21,
		Attr = 22,
		Counter = 23,
		Rect = 24,
		Rgbcolor = 25
	}

	public enum SVGKAngleType : uint
	{
		Unknown = 0,
		Unspecified = 1,
		Deg = 2,
		Rad = 3,
		Grad = 4
	}

	public enum SvgPreserveaspectratio : uint
	{
		Unknown = 0,
		None = 1,
		Xminymin = 2,
		Xmidymin = 3,
		Xmaxymin = 4,
		Xminymid = 5,
		Xmidymid = 6,
		Xmaxymid = 7,
		Xminymax = 8,
		Xmidymax = 9,
		Xmaxymax = 10
	}

	public enum SvgMeetorslice : uint
	{
		Unknown = 0,
		Meet = 1,
		Slice = 2
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct SVGRect
	{
		public float x;

		public float y;

		public float width;

		public float height;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct SVGNumber
	{
		public float value;
	}

	public enum SVGKTransformType : uint
	{
		Unknown = 0,
		Matrix = 1,
		Translate = 2,
		Scale = 3,
		Rotate = 4,
		Skewx = 5,
		Skewy = 6
	}

	///*! Transform Types */
	//typedef enum SVGKTransformType
	//{
	//	SVG_TRANSFORM_UNKNOWN = 0,
	//	SVG_TRANSFORM_MATRIX = 1,
	//	SVG_TRANSFORM_TRANSLATE = 2,
	//	SVG_TRANSFORM_SCALE = 3,
	//	SVG_TRANSFORM_ROTATE = 4,
	//	SVG_TRANSFORM_SKEWX = 5,
	//	SVG_TRANSFORM_SKEWY = 6
	//}
	//SVGKTransformType;



	public enum SvgUnitType : uint
	{
		Unknown = 0,
		Userspaceonuse = 1,
		Objectboundingbox = 2
	}

	public enum SVGLengthAdjust : uint
	{
		Unknown = 0,
		Spacing = 1,
		SpacingAndGlyphs = 2
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct SVGCurve
	{
		public CGPoint c1;

		public CGPoint c2;

		public CGPoint p;
	}
}
