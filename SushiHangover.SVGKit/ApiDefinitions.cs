using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using CGColorRef = System.IntPtr;
using CGContextRef = System.IntPtr;
using CGPathRef = System.IntPtr;

namespace SushiHangover.SVGKit
{
	// @interface Node : NSObject
	[BaseType (typeof(NSObject))]
	interface Node
	{
		// @property (readonly, nonatomic, strong) NSString * nodeName;
		[Export ("nodeName", ArgumentSemantic.Strong)]
		string NodeName { get; }

		// @property (readonly, nonatomic, strong) NSString * nodeValue;
		[Export ("nodeValue", ArgumentSemantic.Strong)]
		string NodeValue { get; }

		// @property (readonly, nonatomic) DOMNodeType nodeType;
		[Export ("nodeType")]
		DOMNodeType NodeType { get; }

		// @property (readonly, nonatomic, weak) Node * parentNode;
		[Export ("parentNode", ArgumentSemantic.Weak)]
		Node ParentNode { get; }

		// @property (readonly, nonatomic, strong) NodeList * childNodes;
		[Export ("childNodes", ArgumentSemantic.Strong)]
		NodeList ChildNodes { get; }

		// @property (readonly, nonatomic, weak) Node * firstChild;
		[Export ("firstChild", ArgumentSemantic.Weak)]
		Node FirstChild { get; }

		// @property (readonly, nonatomic, weak) Node * lastChild;
		[Export ("lastChild", ArgumentSemantic.Weak)]
		Node LastChild { get; }

		// @property (readonly, nonatomic, weak) Node * previousSibling;
		[Export ("previousSibling", ArgumentSemantic.Weak)]
		Node PreviousSibling { get; }

		// @property (readonly, nonatomic, weak) Node * nextSibling;
		[Export ("nextSibling", ArgumentSemantic.Weak)]
		Node NextSibling { get; }

		// @property (readonly, nonatomic, strong) NamedNodeMap * attributes;
		[Export ("attributes", ArgumentSemantic.Strong)]
		NamedNodeMap Attributes { get; }

		// @property (readonly, nonatomic, weak) Document * ownerDocument;
		[Export ("ownerDocument", ArgumentSemantic.Weak)]
		Document OwnerDocument { get; }

		// -(Node *)insertBefore:(Node *)newChild refChild:(Node *)refChild;
		[Export ("insertBefore:refChild:")]
		Node InsertBefore (Node newChild, Node refChild);

		// -(Node *)replaceChild:(Node *)newChild oldChild:(Node *)oldChild;
		[Export ("replaceChild:oldChild:")]
		Node ReplaceChild (Node newChild, Node oldChild);

		// -(Node *)removeChild:(Node *)oldChild;
		[Export ("removeChild:")]
		Node RemoveChild (Node oldChild);

		// -(Node *)appendChild:(Node *)newChild;
		[Export ("appendChild:")]
		Node AppendChild (Node newChild);

		// @property (nonatomic) BOOL hasChildNodes;
		[Export ("hasChildNodes")]
		bool HasChildNodes { get; set; }

		// -(Node *)cloneNode:(BOOL)deep;
		[Export ("cloneNode:")]
		Node CloneNode (bool deep);

		// -(void)normalize;
		[Export ("normalize")]
		void Normalize ();

		// -(BOOL)isSupportedFeature:(NSString *)feature version:(NSString *)version;
		[Export ("isSupportedFeature:version:")]
		bool IsSupportedFeature (string feature, string version);

		// @property (readonly, nonatomic, strong) NSString * namespaceURI;
		[Export ("namespaceURI", ArgumentSemantic.Strong)]
		string NamespaceURI { get; }

		// @property (readonly, nonatomic, strong) NSString * prefix;
		[Export ("prefix", ArgumentSemantic.Strong)]
		string Prefix { get; }

		// @property (readonly, nonatomic, strong) NSString * localName;
		[Export ("localName", ArgumentSemantic.Strong)]
		string LocalName { get; }

		// @property (nonatomic) BOOL hasAttributes;
		[Export ("hasAttributes")]
		bool HasAttributes { get; set; }

		// @property (readonly, nonatomic, weak) NSString * textContent;
		[Export ("textContent", ArgumentSemantic.Weak)]
		string TextContent { get; }

		// -(id)initType:(DOMNodeType)nt name:(NSString *)n;
		[Export ("initType:name:")]
		IntPtr Constructor (DOMNodeType nt, string n);

		// -(id)initType:(DOMNodeType)nt name:(NSString *)n value:(NSString *)v;
		[Export ("initType:name:value:")]
		IntPtr Constructor (DOMNodeType nt, string n, string v);

		// -(id)initType:(DOMNodeType)nt name:(NSString *)n inNamespace:(NSString *)nsURI;
		[Export ("initType:name:inNamespace:")]
		IntPtr Constructor2 (DOMNodeType nt, string n, string nsURI);

		// -(id)initType:(DOMNodeType)nt name:(NSString *)n value:(NSString *)v inNamespace:(NSString *)nsURI;
		[Export ("initType:name:value:inNamespace:")]
		IntPtr Constructor (DOMNodeType nt, string n, string v, string nsURI);

		// -(void)appendXMLToString:(NSMutableString *)outputString availableNamespaces:(NSDictionary *)prefixesByKNOWNNamespace activeNamespaces:(NSMutableDictionary *)prefixesByACTIVENamespace;
		[Export ("appendXMLToString:availableNamespaces:activeNamespaces:")]
		void AppendXMLToString (NSMutableString outputString, NSDictionary prefixesByKNOWNNamespace, NSMutableDictionary prefixesByACTIVENamespace);
	}

	// @interface NamedNodeMap : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface NamedNodeMap : INSCopying
	{
		// -(Node *)getNamedItem:(NSString *)name;
		[Export ("getNamedItem:")]
		Node GetNamedItem (string name);

		// -(Node *)setNamedItem:(Node *)arg;
		[Export ("setNamedItem:")]
		Node SetNamedItem (Node arg);

		// -(Node *)removeNamedItem:(NSString *)name;
		[Export ("removeNamedItem:")]
		Node RemoveNamedItem (string name);

		// -(Node *)item:(unsigned long)index;
		[Export ("item:")]
		Node Item (nuint index);

		// @property (readonly) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(Node *)getNamedItemNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getNamedItemNS:localName:")]
		Node GetNamedItemNS (string namespaceURI, string localName);

		// -(Node *)setNamedItemNS:(Node *)arg;
		[Export ("setNamedItemNS:")]
		Node SetNamedItemNS (Node arg);

		// -(Node *)removeNamedItemNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("removeNamedItemNS:localName:")]
		Node RemoveNamedItemNS (string namespaceURI, string localName);

		// -(Node *)setNamedItemNS:(Node *)arg inNodeNamespace:(NSString *)nodesNamespace;
		[Export ("setNamedItemNS:inNodeNamespace:")]
		Node SetNamedItemNS (Node arg, string nodesNamespace);
	}

	// @interface DocumentType : Node
	[BaseType (typeof(Node))]
	interface DocumentType
	{
		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic, strong) NamedNodeMap * entities;
		[Export ("entities", ArgumentSemantic.Strong)]
		NamedNodeMap Entities { get; }

		// @property (readonly, nonatomic, strong) NamedNodeMap * notations;
		[Export ("notations", ArgumentSemantic.Strong)]
		NamedNodeMap Notations { get; }

		// @property (readonly, nonatomic, strong) NSString * publicId;
		[Export ("publicId", ArgumentSemantic.Strong)]
		string PublicId { get; }

		// @property (readonly, nonatomic, strong) NSString * systemId;
		[Export ("systemId", ArgumentSemantic.Strong)]
		string SystemId { get; }

		// @property (readonly, nonatomic, strong) NSString * internalSubset;
		[Export ("internalSubset", ArgumentSemantic.Strong)]
		string InternalSubset { get; }
	}

	// @interface AppleSucksDOMImplementation : NSObject
	[BaseType (typeof(NSObject))]
	interface AppleSucksDOMImplementation
	{
		// -(BOOL)hasFeature:(NSString *)feature version:(NSString *)version;
		[Export ("hasFeature:version:")]
		bool HasFeature (string feature, string version);

		// -(DocumentType *)createDocumentType:(NSString *)qualifiedName publicId:(NSString *)publicId systemId:(NSString *)systemId;
		[Export ("createDocumentType:publicId:systemId:")]
		DocumentType CreateDocumentType (string qualifiedName, string publicId, string systemId);

		// -(Document *)createDocument:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName doctype:(DocumentType *)doctype;
		[Export ("createDocument:qualifiedName:doctype:")]
		Document CreateDocument (string namespaceURI, string qualifiedName, DocumentType doctype);
	}

	// @interface Attr : Node
	[BaseType (typeof(Node))]
	interface Attr
	{
		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic) BOOL specified;
		[Export ("specified")]
		bool Specified { get; }

		// @property (readonly, nonatomic, strong) NSString * value;
		[Export ("value", ArgumentSemantic.Strong)]
		string Value { get; }

		// @property (readonly, nonatomic, strong) Element * ownerElement;
		[Export ("ownerElement", ArgumentSemantic.Strong)]
		Element OwnerElement { get; }

		// -(id)initWithName:(NSString *)n value:(NSString *)v;
		[Export ("initWithName:value:")]
		IntPtr Constructor (string n, string v);

		// -(id)initWithNamespace:(NSString *)ns qualifiedName:(NSString *)qn value:(NSString *)v;
		[Export ("initWithNamespace:qualifiedName:value:")]
		IntPtr Constructor (string ns, string qn, string v);
	}

	// @interface NodeList : NSObject <NSFastEnumeration>
	[BaseType (typeof(NSObject))]
	interface NodeList //: INSFastEnumeration
	{
		// @property (readonly) NSUInteger length;
		[Export ("length")]
		nuint Length { get; }

		// -(Node *)item:(NSUInteger)index;
		[Export ("item:")]
		Node Item (nuint index);
	}

	// @interface Element : Node
	[BaseType (typeof(Node))]
	interface Element
	{
		// @property (readonly, nonatomic, strong) NSString * tagName;
		[Export ("tagName", ArgumentSemantic.Strong)]
		string TagName { get; }

		// -(NSString *)getAttribute:(NSString *)name;
		[Export ("getAttribute:")]
		string GetAttribute (string name);

		// -(void)setAttribute:(NSString *)name value:(NSString *)value;
		[Export ("setAttribute:value:")]
		void SetAttribute (string name, string value);

		// -(void)removeAttribute:(NSString *)name;
		[Export ("removeAttribute:")]
		void RemoveAttribute (string name);

		// -(Attr *)getAttributeNode:(NSString *)name;
		[Export ("getAttributeNode:")]
		Attr GetAttributeNode (string name);

		// -(Attr *)setAttributeNode:(Attr *)newAttr;
		[Export ("setAttributeNode:")]
		Attr SetAttributeNode (Attr newAttr);

		// -(Attr *)removeAttributeNode:(Attr *)oldAttr;
		[Export ("removeAttributeNode:")]
		Attr RemoveAttributeNode (Attr oldAttr);

		// -(NodeList *)getElementsByTagName:(NSString *)name;
		[Export ("getElementsByTagName:")]
		NodeList GetElementsByTagName (string name);

		// -(NSString *)getAttributeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getAttributeNS:localName:")]
		string GetAttributeNS (string namespaceURI, string localName);

		// -(void)setAttributeNS:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName value:(NSString *)value;
		[Export ("setAttributeNS:qualifiedName:value:")]
		void SetAttributeNS (string namespaceURI, string qualifiedName, string value);

		// -(void)removeAttributeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("removeAttributeNS:localName:")]
		void RemoveAttributeNS (string namespaceURI, string localName);

		// -(Attr *)getAttributeNodeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getAttributeNodeNS:localName:")]
		Attr GetAttributeNodeNS (string namespaceURI, string localName);

		// -(Attr *)setAttributeNodeNS:(Attr *)newAttr;
		[Export ("setAttributeNodeNS:")]
		Attr SetAttributeNodeNS (Attr newAttr);

		// -(NodeList *)getElementsByTagNameNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getElementsByTagNameNS:localName:")]
		NodeList GetElementsByTagNameNS (string namespaceURI, string localName);

		// -(BOOL)hasAttribute:(NSString *)name;
		[Export ("hasAttribute:")]
		bool HasAttribute (string name);

		// -(BOOL)hasAttributeNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("hasAttributeNS:localName:")]
		bool HasAttributeNS (string namespaceURI, string localName);

		// -(id)initWithLocalName:(NSString *)n attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithLocalName:attributes:")]
		IntPtr Constructor (string n, NSMutableDictionary attributes);

		// -(id)initWithQualifiedName:(NSString *)n inNameSpaceURI:(NSString *)nsURI attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithQualifiedName:inNameSpaceURI:attributes:")]
		IntPtr Constructor (string n, string nsURI, NSMutableDictionary attributes);
	}

	// @interface  (Node)
	//[Category]
	//[BaseType (typeof(Node))]
	//interface Node_
	//{
	//	// @property (readwrite, nonatomic, strong) NSString * nodeName;
	//	[Export ("nodeName", ArgumentSemantic.Strong)]
	//	string NodeName { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * nodeValue;
	//	[Export ("nodeValue", ArgumentSemantic.Strong)]
	//	string NodeValue { get; set; }

	//	// @property (readwrite, nonatomic) DOMNodeType nodeType;
	//	[Export ("nodeType", ArgumentSemantic.Assign)]
	//	DOMNodeType NodeType { get; set; }

	//	// @property (readwrite, nonatomic, weak) Node * parentNode;
	//	[Export ("parentNode", ArgumentSemantic.Weak)]
	//	Node ParentNode { get; set; }

	//	// @property (readwrite, nonatomic, strong) NodeList * childNodes;
	//	[Export ("childNodes", ArgumentSemantic.Strong)]
	//	NodeList ChildNodes { get; set; }

	//	// @property (readwrite, nonatomic, strong) NamedNodeMap * attributes;
	//	[Export ("attributes", ArgumentSemantic.Strong)]
	//	NamedNodeMap Attributes { get; set; }

	//	// @property (readwrite, nonatomic, weak) Document * ownerDocument;
	//	[Export ("ownerDocument", ArgumentSemantic.Weak)]
	//	Document OwnerDocument { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * namespaceURI;
	//	[Export ("namespaceURI", ArgumentSemantic.Strong)]
	//	string NamespaceURI { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * prefix;
	//	[Export ("prefix", ArgumentSemantic.Strong)]
	//	string Prefix { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * localName;
	//	[Export ("localName", ArgumentSemantic.Strong)]
	//	string LocalName { get; set; }
	//}

	// @interface CSSValue : NSObject
	[BaseType (typeof(NSObject))]
	interface CSSValue
	{
		// @property (nonatomic, strong) NSString * cssText;
		[Export ("cssText", ArgumentSemantic.Strong)]
		string CssText { get; set; }

		// @property (nonatomic) CSSUnitType cssValueType;
		[Export ("cssValueType", ArgumentSemantic.Assign)]
		CSSUnitType CssValueType { get; set; }
	}

	// @interface CSSRule : NSObject
	[BaseType (typeof(NSObject))]
	interface CSSRule
	{
		// @property (nonatomic) unsigned short type;
		[Export ("type")]
		ushort Type { get; set; }

		// @property (nonatomic, strong) NSString * cssText;
		[Export ("cssText", ArgumentSemantic.Strong)]
		string CssText { get; set; }

		// @property (nonatomic, strong) CSSStyleSheet * parentStyleSheet;
		[Export ("parentStyleSheet", ArgumentSemantic.Strong)]
		CSSStyleSheet ParentStyleSheet { get; set; }

		// @property (nonatomic, strong) CSSRule * parentRule;
		[Export ("parentRule", ArgumentSemantic.Strong)]
		CSSRule ParentRule { get; set; }
	}

	// @interface CSSStyleDeclaration : NSObject
	[BaseType (typeof(NSObject))]
	interface CSSStyleDeclaration
	{
		// @property (nonatomic, strong) NSString * cssText;
		[Export ("cssText", ArgumentSemantic.Strong)]
		string CssText { get; set; }

		// -(NSString *)getPropertyValue:(NSString *)propertyName;
		[Export ("getPropertyValue:")]
		string GetPropertyValue (string propertyName);

		// -(CSSValue *)getPropertyCSSValue:(NSString *)propertyName;
		[Export ("getPropertyCSSValue:")]
		CSSValue GetPropertyCSSValue (string propertyName);

		// -(NSString *)removeProperty:(NSString *)propertyName;
		[Export ("removeProperty:")]
		string RemoveProperty (string propertyName);

		// -(NSString *)getPropertyPriority:(NSString *)propertyName;
		[Export ("getPropertyPriority:")]
		string GetPropertyPriority (string propertyName);

		// -(void)setProperty:(NSString *)propertyName value:(NSString *)value priority:(NSString *)priority;
		[Export ("setProperty:value:priority:")]
		void SetProperty (string propertyName, string value, string priority);

		// @property (nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; set; }

		// -(NSString *)item:(long)index;
		[Export ("item:")]
		string Item (nint index);

		// @property (nonatomic, strong) CSSRule * parentRule;
		[Export ("parentRule", ArgumentSemantic.Strong)]
		CSSRule ParentRule { get; set; }
	}

	// @protocol SVGStylable <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISVGStylable
	{
		// @required @property (retain, nonatomic) NSString * className;
		[Abstract]
		[Export ("className", ArgumentSemantic.Retain)]
		string ClassName { get; set; }

		// @required @property (retain, nonatomic) CSSStyleDeclaration * style;
		[Abstract]
		[Export ("style", ArgumentSemantic.Retain)]
		CSSStyleDeclaration Style { get; set; }

		// @required -(CSSValue *)getPresentationAttribute:(NSString *)name;
		[Abstract]
		[Export ("getPresentationAttribute:")]
		CSSValue GetPresentationAttribute (string name);
	}

	// @interface SVGLength : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGLength
	{
		// @property (readonly, nonatomic) SVG_LENGTH_TYPE unitType;
		[Export ("unitType")]
		SvgLengthType UnitType { get; }

		// @property (nonatomic) float value;
		[Export ("value")]
		float Value { get; set; }

		// @property (nonatomic) float valueInSpecifiedUnits;
		[Export ("valueInSpecifiedUnits")]
		float ValueInSpecifiedUnits { get; set; }

		// @property (nonatomic, strong) NSString * valueAsString;
		[Export ("valueAsString", ArgumentSemantic.Strong)]
		string ValueAsString { get; set; }

		// -(void)newValueSpecifiedUnits:(SVG_LENGTH_TYPE)unitType valueInSpecifiedUnits:(float)valueInSpecifiedUnits;
		[Export ("newValueSpecifiedUnits:valueInSpecifiedUnits:")]
		void NewValueSpecifiedUnits (SvgLengthType unitType, float valueInSpecifiedUnits);

		// -(void)convertToSpecifiedUnits:(SVG_LENGTH_TYPE)unitType;
		[Export ("convertToSpecifiedUnits:")]
		void ConvertToSpecifiedUnits (SvgLengthType unitType);

		// +(SVGLength *)svgLengthZero;
		[Static]
		[Export("svgLengthZero")]
		//[Verify (MethodToProperty)]
		SVGLength SVGLengthZero();

		// +(SVGLength *)svgLengthFromNSString:(NSString *)s;
		[Static]
		[Export ("svgLengthFromNSString:")]
		SVGLength SVGLengthFromNSString (string s);

		// -(float)pixelsValue;
		[Export("pixelsValue")]
		//[Verify (MethodToProperty)]
		float PixelsValue();

		// -(float)pixelsValueWithDimension:(float)dimension;
		[Export ("pixelsValueWithDimension:")]
		float PixelsValueWithDimension (float dimension);

		// -(float)numberValue;
		[Export("numberValue")]
		//[Verify (MethodToProperty)]
		float NumberValue();
	}

	// @interface SVGElement : Element <SVGStylable>
	[BaseType (typeof(Element))]
	interface SVGElement : ISVGStylable
	{
		// @property (readwrite, nonatomic, strong) NSString * identifier;
		[Export ("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; set; }

		// @property (nonatomic, strong) NSString * xmlbase;
		[Export ("xmlbase", ArgumentSemantic.Strong)]
		string Xmlbase { get; set; }

		// @property (nonatomic, weak) SVGSVGElement * rootOfCurrentDocumentFragment;
		[Export ("rootOfCurrentDocumentFragment", ArgumentSemantic.Weak)]
		SVGSVGElement RootOfCurrentDocumentFragment { get; set; }

		// @property (nonatomic, weak) SVGElement * viewportElement;
		[Export ("viewportElement", ArgumentSemantic.Weak)]
		SVGElement ViewportElement { get; set; }

		// -(id)initWithLocalName:(NSString *)n attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithLocalName:attributes:")]
		IntPtr Constructor (string n, NSMutableDictionary attributes);

		// -(id)initWithQualifiedName:(NSString *)n inNameSpaceURI:(NSString *)nsURI attributes:(NSMutableDictionary *)attributes;
		[Export ("initWithQualifiedName:inNameSpaceURI:attributes:")]
		IntPtr Constructor (string n, string nsURI, NSMutableDictionary attributes);

		// -(void)reCalculateAndSetViewportElementReferenceUsingFirstSVGAncestor:(SVGElement *)firstAncestor;
		[Export ("reCalculateAndSetViewportElementReferenceUsingFirstSVGAncestor:")]
		void ReCalculateAndSetViewportElementReferenceUsingFirstSVGAncestor (SVGElement firstAncestor);

		// -(SVGLength *)getAttributeAsSVGLength:(NSString *)attributeName;
		[Export ("getAttributeAsSVGLength:")]
		SVGLength GetAttributeAsSVGLength (string attributeName);

		// -(NSString *)cascadedValueForStylableProperty:(NSString *)stylableProperty;
		[Export ("cascadedValueForStylableProperty:")]
		string CascadedValueForStylableProperty (string stylableProperty);

		// -(NSString *)cascadedValueForStylableProperty:(NSString *)stylableProperty inherit:(BOOL)inherit;
		[Export ("cascadedValueForStylableProperty:inherit:")]
		string CascadedValueForStylableProperty (string stylableProperty, bool inherit);
	}

	// @protocol ConverterSVGToCALayer <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IConverterSVGToCALayer
	{
		// @required -(CALayer *)newLayer;
		[Abstract]
		[Export("newLayer")]
		//[Verify (MethodToProperty)]
		CALayer NewLayer();

		// @required -(void)layoutLayer:(CALayer *)layer;
		[Abstract]
		[Export ("layoutLayer:")]
		void LayoutLayer (CALayer layer);
	}

	// @protocol SVGTransformable <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISVGTransformable
	{
		// @required @property (nonatomic) CGAffineTransform transform;
		[Abstract]
		[Export ("transform", ArgumentSemantic.Assign)]
		CGAffineTransform Transform { get; set; }
	}

	// @interface BaseClassForAllSVGBasicShapes : SVGElement <SVGStylable, SVGTransformable, ConverterSVGToCALayer>
	[BaseType (typeof(SVGElement))]
	interface BaseClassForAllSVGBasicShapes : ISVGStylable, ISVGTransformable, IConverterSVGToCALayer
	{
		// @property (readonly, nonatomic) CGPathRef pathForShapeInRelativeCoords;
		[Export ("pathForShapeInRelativeCoords")]
		unsafe CGPathRef PathForShapeInRelativeCoords { get; }
	}

	//// @interface  (BaseClassForAllSVGBasicShapes)
	//[Category]
	//[BaseType (typeof(BaseClassForAllSVGBasicShapes))]
	//interface BaseClassForAllSVGBasicShapes_
	//{
	//	// @property (readwrite, nonatomic) CGPathRef pathForShapeInRelativeCoords;
	//	[Export ("pathForShapeInRelativeCoords", ArgumentSemantic.Assign)]
	//	unsafe CGPathRef PathForShapeInRelativeCoords { get; set; }
	//}

	// @interface RecursiveClone (CALayer)
	[Category]
	[BaseType (typeof(CALayer))]
	interface CALayer_RecursiveClone
	{
		// -(CALayer *)cloneRecursively;
		[Export("cloneRecursively")]
		//[Verify(MethodToProperty)]
		CALayer CloneRecursively();

		// -(CALayer *)cloneShallow;
		[Export("cloneShallow")]
		//[Verify (MethodToProperty)]
		CALayer CloneShallow();
	}

	// @interface CALayerWithClipRender : CALayer
	[BaseType (typeof(CALayer))]
	interface CALayerWithClipRender
	{
		// +(void)maskLayer:(CALayer *)layer inContext:(CGContextRef)ctx;
		[Static]
		[Export ("maskLayer:inContext:")]
		unsafe void MaskLayer (CALayer layer, CGContextRef ctx);
	}

	// @interface CALayerWithChildHitTest : CALayerWithClipRender
	[BaseType (typeof(CALayerWithClipRender))]
	interface CALayerWithChildHitTest
	{
	}

	// @interface CAShapeLayerWithClipRender : CAShapeLayer
	[BaseType (typeof(CAShapeLayer))]
	interface CAShapeLayerWithClipRender
	{
	}

	// @interface CAShapeLayerWithHitTest : CAShapeLayerWithClipRender
	[BaseType (typeof(CAShapeLayerWithClipRender))]
	interface CAShapeLayerWithHitTest
	{
	}

	// @interface CharacterData : Node
	[BaseType (typeof(Node))]
	interface CharacterData
	{
		// @property (readonly, nonatomic, strong) NSString * data;
		[Export ("data", ArgumentSemantic.Strong)]
		string Data { get; }

		// @property (readonly, nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(NSString *)substringData:(unsigned long)offset count:(unsigned long)count;
		[Export ("substringData:count:")]
		string SubstringData (nuint offset, nuint count);

		// -(void)appendData:(NSString *)arg;
		[Export ("appendData:")]
		void AppendData (string arg);

		// -(void)insertData:(unsigned long)offset arg:(NSString *)arg;
		[Export ("insertData:arg:")]
		void InsertData (nuint offset, string arg);

		// -(void)deleteData:(unsigned long)offset count:(unsigned long)count;
		[Export ("deleteData:count:")]
		void DeleteData (nuint offset, nuint count);

		// -(void)replaceData:(unsigned long)offset count:(unsigned long)count arg:(NSString *)arg;
		[Export ("replaceData:count:arg:")]
		void ReplaceData (nuint offset, nuint count, string arg);
	}

	// @interface Text : CharacterData
	[BaseType (typeof(CharacterData))]
	interface Text
	{
		// -(id)initWithValue:(NSString *)v;
		[Export ("initWithValue:")]
		IntPtr Constructor (string v);

		// -(Text *)splitText:(unsigned long)offset;
		[Export ("splitText:")]
		Text SplitText (nuint offset);
	}

	// @interface CDATASection : Text
	[BaseType (typeof(Text))]
	interface CDATASection
	{
		// -(id)initWithValue:(NSString *)v;
		[Export ("initWithValue:")]
		IntPtr Constructor (string v);
	}

	// @interface CSSPrimitiveValue : CSSValue
	[BaseType (typeof(CSSValue))]
	interface CSSPrimitiveValue
	{
		// @property (nonatomic) CSSPrimitiveType primitiveType;
		[Export ("primitiveType", ArgumentSemantic.Assign)]
		CSSPrimitiveType PrimitiveType { get; set; }

		// -(void)setFloatValue:(CSSPrimitiveType)unitType floatValue:(float)floatValue;
		[Export ("setFloatValue:floatValue:")]
		void SetFloatValue (CSSPrimitiveType unitType, float floatValue);

		// -(float)getFloatValue:(CSSPrimitiveType)unitType;
		[Export ("getFloatValue:")]
		float GetFloatValue (CSSPrimitiveType unitType);

		// -(void)setStringValue:(CSSPrimitiveType)stringType stringValue:(NSString *)stringValue;
		[Export ("setStringValue:stringValue:")]
		void SetStringValue (CSSPrimitiveType stringType, string stringValue);

		// -(NSString *)getStringValue;
		[Export ("getStringValue")]
		//[Verify (MethodToProperty)]
		//DOM\ classes/Core\ DOM/CSSPrimitiveValue.m is property
		string StringValue { get; }

		// -(void)getCounterValue;
		[Export ("getCounterValue")]
		void GetCounterValue ();

		// -(void)getRectValue;
		[Export ("getRectValue")]
		void GetRectValue ();

		// -(void)getRGBColorValue;
		[Export ("getRGBColorValue")]
		void GetRGBColorValue ();
	}

	//// @interface  (CSSPrimitiveValue)
	//[Category]
	//[BaseType (typeof(CSSPrimitiveValue))]
	//interface CSSPrimitiveValue_
	//{
	//	// @property (nonatomic) float pixelsPerInch;
	//	[Export ("pixelsPerInch")]
	//	float PixelsPerInch { get; set; }
	//}

	// @interface CSSRuleList : NSObject
	[BaseType (typeof(NSObject))]
	interface CSSRuleList
	{
		// @property (readonly, nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(CSSRule *)item:(unsigned long)index;
		[Export ("item:")]
		CSSRule Item (nuint index);
	}

	// @interface  (CSSRuleList)
	//[Category]
	//[BaseType (typeof(CSSRuleList))]
	//interface CSSRuleList_
	//{
	//	// @property (nonatomic, strong) NSMutableArray * internalArray;
	//	[Export ("internalArray", ArgumentSemantic.Strong)]
	//	NSMutableArray InternalArray { get; set; }
	//}

	// @interface CSSStyleRule : CSSRule
	[BaseType (typeof(CSSRule))]
	interface CSSStyleRule
	{
		// @property (nonatomic, strong) NSString * selectorText;
		[Export ("selectorText", ArgumentSemantic.Strong)]
		string SelectorText { get; set; }

		// @property (nonatomic, strong) CSSStyleDeclaration * style;
		[Export ("style", ArgumentSemantic.Strong)]
		CSSStyleDeclaration Style { get; set; }

		// -(id)initWithSelectorText:(NSString *)selector styleText:(NSString *)styleText;
		[Export ("initWithSelectorText:styleText:")]
		IntPtr Constructor (string selector, string styleText);
	}

	// @interface CSSStyleSheet : NSObject
	[BaseType (typeof(NSObject))]
	interface CSSStyleSheet
	{
		// @property (nonatomic, strong) CSSRule * ownerRule;
		[Export ("ownerRule", ArgumentSemantic.Strong)]
		CSSRule OwnerRule { get; set; }

		// @property (nonatomic, strong) CSSRuleList * cssRules;
		[Export ("cssRules", ArgumentSemantic.Strong)]
		CSSRuleList CssRules { get; set; }

		// -(long)insertRule:(NSString *)rule index:(unsigned long)index;
		[Export ("insertRule:index:")]
		nint InsertRule (string rule, nuint index);

		// -(void)deleteRule:(unsigned long)index;
		[Export ("deleteRule:")]
		void DeleteRule (nuint index);

		// -(id)initWithString:(NSString *)styleSheetBody;
		[Export ("initWithString:")]
		IntPtr Constructor (string styleSheetBody);
	}

	// @interface CSSValueList : CSSValue
	[BaseType (typeof(CSSValue))]
	interface CSSValueList
	{
		// @property (readonly, nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(CSSValue *)item:(unsigned long)index;
		[Export ("item:")]
		CSSValue Item (nuint index);
	}

	//// @interface  (CSSValue)
	//[Category]
	//[BaseType (typeof(CSSValue))]
	//interface CSSValue_
	//{
	//	// -(id)initWithUnitType:(CSSUnitType)t;
	//	[Export ("initWithUnitType:")]
	//	IntPtr Constructor (CSSUnitType t);
	//}

	// @interface Comment : CharacterData
	[BaseType (typeof(CharacterData))]
	interface Comment
	{
		// -(id)initWithValue:(NSString *)v;
		[Export ("initWithValue:")]
		IntPtr Constructor (string v);
	}

	// @interface DOMHelperUtilities : NSObject
	[BaseType (typeof(NSObject))]
	interface DOMHelperUtilities
	{
		// +(void)privateGetElementsByName:(NSString *)name inNamespace:(NSString *)namespaceURI childrenOfElement:(Node *)parent addToList:(NodeList *)accumulator;
		[Static]
		[Export ("privateGetElementsByName:inNamespace:childrenOfElement:addToList:")]
		void PrivateGetElementsByName (string name, string namespaceURI, Node parent, NodeList accumulator);

		// +(Element *)privateGetElementById:(NSString *)idValue childrenOfElement:(Node *)parent;
		[Static]
		[Export ("privateGetElementById:childrenOfElement:")]
		Element PrivateGetElementById (string idValue, Node parent);
	}

	// @interface DocumentFragment : Node
	[BaseType (typeof(Node))]
	interface DocumentFragment
	{
	}

	// @interface EntityReference : Node
	[BaseType (typeof(Node))]
	interface EntityReference
	{
	}

	// @interface ProcessingInstruction : Node
	[BaseType (typeof(Node))]
	interface ProcessingInstruction
	{
		// @property (readonly, nonatomic, strong) NSString * target;
		[Export ("target", ArgumentSemantic.Strong)]
		string Target { get; }

		// @property (readonly, nonatomic, strong) NSString * data;
		[Export ("data", ArgumentSemantic.Strong)]
		string Data { get; }

		// -(id)initProcessingInstruction:(NSString *)target value:(NSString *)data;
		[Export ("initProcessingInstruction:value:")]
		IntPtr Constructor (string target, string data);
	}

	// @interface Document : Node
	[BaseType (typeof(Node))]
	interface Document
	{
		// @property (readonly, nonatomic, strong) DocumentType * doctype;
		[Export ("doctype", ArgumentSemantic.Strong)]
		DocumentType Doctype { get; }

		// @property (readonly, nonatomic, strong) AppleSucksDOMImplementation * implementation;
		[Export ("implementation", ArgumentSemantic.Strong)]
		AppleSucksDOMImplementation Implementation { get; }

		// @property (readonly, nonatomic, strong) Element * documentElement;
		[Export ("documentElement", ArgumentSemantic.Strong)]
		Element DocumentElement { get; }

		// -(Element *)createElement:(NSString *)tagName __attribute__((ns_returns_retained));
		[Export ("createElement:")]
		Element CreateElement (string tagName);

		// -(DocumentFragment *)createDocumentFragment __attribute__((ns_returns_retained));
		[Export("createDocumentFragment")]
		//[Verify (MethodToProperty)]
		DocumentFragment CreateDocumentFragment();

		// -(Text *)createTextNode:(NSString *)data __attribute__((ns_returns_retained));
		[Export ("createTextNode:")]
		Text CreateTextNode (string data);

		// -(Comment *)createComment:(NSString *)data __attribute__((ns_returns_retained));
		[Export ("createComment:")]
		Comment CreateComment (string data);

		// -(CDATASection *)createCDATASection:(NSString *)data __attribute__((ns_returns_retained));
		[Export ("createCDATASection:")]
		CDATASection CreateCDATASection (string data);

		// -(ProcessingInstruction *)createProcessingInstruction:(NSString *)target data:(NSString *)data __attribute__((ns_returns_retained));
		[Export ("createProcessingInstruction:data:")]
		ProcessingInstruction CreateProcessingInstruction (string target, string data);

		// -(Attr *)createAttribute:(NSString *)data __attribute__((ns_returns_retained));
		[Export ("createAttribute:")]
		Attr CreateAttribute (string data);

		// -(EntityReference *)createEntityReference:(NSString *)data __attribute__((ns_returns_retained));
		[Export ("createEntityReference:")]
		EntityReference CreateEntityReference (string data);

		// -(NodeList *)getElementsByTagName:(NSString *)data;
		[Export ("getElementsByTagName:")]
		NodeList GetElementsByTagName (string data);

		// -(Node *)importNode:(Node *)importedNode deep:(BOOL)deep;
		[Export ("importNode:deep:")]
		Node ImportNode (Node importedNode, bool deep);

		// -(Element *)createElementNS:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName __attribute__((ns_returns_retained));
		[Export ("createElementNS:qualifiedName:")]
		Element CreateElementNS (string namespaceURI, string qualifiedName);

		// -(Attr *)createAttributeNS:(NSString *)namespaceURI qualifiedName:(NSString *)qualifiedName;
		[Export ("createAttributeNS:qualifiedName:")]
		Attr CreateAttributeNS (string namespaceURI, string qualifiedName);

		// -(NodeList *)getElementsByTagNameNS:(NSString *)namespaceURI localName:(NSString *)localName;
		[Export ("getElementsByTagNameNS:localName:")]
		NodeList GetElementsByTagNameNS (string namespaceURI, string localName);

		// -(Element *)getElementById:(NSString *)elementId;
		[Export ("getElementById:")]
		Element GetElementById (string elementId);
	}

	// @interface  (Document)
	//[Category]
	//[BaseType (typeof(Document))]
	//interface Document_
	//{
	//	// @property (readwrite, nonatomic, strong) Element * documentElement;
	//	[Export ("documentElement", ArgumentSemantic.Strong)]
	//	Element DocumentElement { get; set; }
	//}

	// @interface StyleSheet : NSObject
	[BaseType (typeof(NSObject))]
	interface StyleSheet
	{
		// @property (nonatomic, strong) NSString * type;
		[Export ("type", ArgumentSemantic.Strong)]
		string Type { get; set; }

		// @property (nonatomic) BOOL disabled;
		[Export ("disabled")]
		bool Disabled { get; set; }

		// @property (nonatomic, strong) Node * ownerNode;
		[Export ("ownerNode", ArgumentSemantic.Strong)]
		Node OwnerNode { get; set; }

		// @property (nonatomic, strong) StyleSheet * parentStyleSheet;
		[Export ("parentStyleSheet", ArgumentSemantic.Strong)]
		StyleSheet ParentStyleSheet { get; set; }

		// @property (nonatomic, strong) NSString * href;
		[Export ("href", ArgumentSemantic.Strong)]
		string Href { get; set; }

		// @property (nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) MediaList * media;
		[Export ("media", ArgumentSemantic.Strong)]
		MediaList Media { get; set; }
	}

	// @interface StyleSheetList : NSObject
	[BaseType (typeof(NSObject))]
	interface StyleSheetList
	{
		// @property (readonly, nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(StyleSheet *)item:(unsigned long)index;
		[Export ("item:")]
		StyleSheet Item (nuint index);
	}

	// @protocol DocumentStyle <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IDocumentStyle
	{
		// @required @property (retain, nonatomic) StyleSheetList * styleSheets;
		[Abstract]
		[Export ("styleSheets", ArgumentSemantic.Retain)]
		StyleSheetList StyleSheets { get; set; }
	}

	// @protocol DocumentCSS <DocumentStyle>
	[Protocol]
	interface IDocumentCSS : IDocumentStyle
	{
		// @required -(CSSStyleDeclaration *)getOverrideStyle:(Element *)element pseudoElt:(NSString *)pseudoElt;
		[Abstract]
		[Export ("getOverrideStyle:pseudoElt:")]
		CSSStyleDeclaration PseudoElt (Element element, string pseudoElt);
	}

	// @interface MediaList : NSObject
	[BaseType (typeof(NSObject))]
	interface MediaList
	{
		// @property (nonatomic, strong) NSString * mediaText;
		[Export ("mediaText", ArgumentSemantic.Strong)]
		string MediaText { get; set; }

		// @property (nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; set; }

		// -(NSString *)item:(unsigned long)index;
		[Export ("item:")]
		string Item (nuint index);

		// -(void)deleteMedium:(NSString *)oldMedium;
		[Export ("deleteMedium:")]
		void DeleteMedium (string oldMedium);

		// -(void)appendMedium:(NSString *)newMedium;
		[Export ("appendMedium:")]
		void AppendMedium (string newMedium);
	}

	// @interface SVGKExtensions (NSCharacterSet)
	[Category]
	[BaseType (typeof(NSCharacterSet))]
	interface NSCharacterSet_SVGKExtensions
	{
		// +(NSCharacterSet *)SVGWhitespaceCharacterSet;
		//[Static]
		[Export("SVGWhitespaceCharacterSet")]
		//[Verify (MethodToProperty)]
		NSCharacterSet SVGWhitespaceCharacterSet();
	}

	// @interface  (NamedNodeMap)
	[Category]
	[BaseType (typeof(NamedNodeMap))]
	interface NamedNodeMap_
	{
		// -(NSArray *)allNodesUnsortedDOM1;
		[Export("allNodesUnsortedDOM1")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		// NSMutableDictionary allValues
		NSObject[] AllNodesUnsortedDOM1();

		// -(NSDictionary *)allNodesUnsortedDOM2;
		[Export("allNodesUnsortedDOM2")]
		//[Verify (MethodToProperty)]
		NSDictionary AllNodesUnsortedDOM2();
	}

	// @interface  (NodeList)
	//[Category]
	//[BaseType (typeof(NodeList))]
	//interface NodeList_
	//{
	//	// @property (nonatomic, strong) NSMutableArray * internalArray;
	//	[Export ("internalArray", ArgumentSemantic.Strong)]
	//	NSMutableArray InternalArray { get; set; }
	//}

	// @interface SVGAngle : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGAngle
	{
		// @property (readonly, nonatomic) SVGKAngleType unitType;
		[Export ("unitType")]
		SVGKAngleType UnitType { get; }

		// @property (nonatomic) float value;
		[Export ("value")]
		float Value { get; set; }

		// @property (nonatomic) float valueInSpecifiedUnits;
		[Export ("valueInSpecifiedUnits")]
		float ValueInSpecifiedUnits { get; set; }

		// @property (nonatomic, strong) NSString * valueAsString;
		[Export ("valueAsString", ArgumentSemantic.Strong)]
		string ValueAsString { get; set; }

		// -(void)newValueSpecifiedUnits:(SVGKAngleType)unitType valueInSpecifiedUnits:(float)valueInSpecifiedUnits;
		[Export ("newValueSpecifiedUnits:valueInSpecifiedUnits:")]
		void NewValueSpecifiedUnits (SVGKAngleType unitType, float valueInSpecifiedUnits);

		// -(void)convertToSpecifiedUnits:(SVGKAngleType)unitType;
		[Export ("convertToSpecifiedUnits:")]
		void ConvertToSpecifiedUnits (SVGKAngleType unitType);
	}

	// @interface SVGPreserveAspectRatio : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGPreserveAspectRatio
	{
		// @property (nonatomic) SVG_PRESERVEASPECTRATIO align;
		[Export ("align", ArgumentSemantic.Assign)]
		SVG_PRESERVEASPECTRATIO Align { get; set; }

		// @property (nonatomic) SVG_MEETORSLICE meetOrSlice;
		[Export ("meetOrSlice", ArgumentSemantic.Assign)]
		SVG_MEETORSLICE MeetOrSlice { get; set; }
	}

	// @interface SVGAnimatedPreserveAspectRatio : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGAnimatedPreserveAspectRatio
	{
		// @property (nonatomic, strong) SVGPreserveAspectRatio * baseVal;
		[Export ("baseVal", ArgumentSemantic.Strong)]
		SVGPreserveAspectRatio BaseVal { get; set; }

		// @property (readonly, nonatomic, strong) SVGPreserveAspectRatio * animVal;
		[Export ("animVal", ArgumentSemantic.Strong)]
		SVGPreserveAspectRatio AnimVal { get; }
	}

	// @interface SVGEllipseElement : BaseClassForAllSVGBasicShapes
	[BaseType (typeof(BaseClassForAllSVGBasicShapes))]
	interface SVGEllipseElement
	{
		// @property (readonly, nonatomic) CGFloat cx;
		[Export ("cx")]
		nfloat Cx { get; }

		// @property (readonly, nonatomic) CGFloat cy;
		[Export ("cy")]
		nfloat Cy { get; }

		// @property (readonly, nonatomic) CGFloat rx;
		[Export ("rx")]
		nfloat Rx { get; }

		// @property (readonly, nonatomic) CGFloat ry;
		[Export ("ry")]
		nfloat Ry { get; }
	}

	// @interface SVGCircleElement : SVGEllipseElement
	[BaseType (typeof(SVGEllipseElement))]
	interface SVGCircleElement
	{
		// @property (readonly, nonatomic) CGFloat r;
		[Export ("r")]
		nfloat R { get; }
	}

	// @protocol SVGFitToViewBox <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISVGFitToViewBox
	{
		// @required @property (nonatomic) SVGRect viewBox;
		[Abstract]
		[Export ("viewBox", ArgumentSemantic.Assign)]
		SVGRect ViewBox { get; set; }

		// @required @property (retain, nonatomic) SVGAnimatedPreserveAspectRatio * preserveAspectRatio;
		[Abstract]
		[Export ("preserveAspectRatio", ArgumentSemantic.Retain)]
		SVGAnimatedPreserveAspectRatio PreserveAspectRatio { get; set; }
	}

	// @interface SVGViewSpec : NSObject
	[BaseType (typeof(NSObject))]
	[Protocol]
	interface SVGViewSpec
	{
		// @property (readonly, nonatomic) SVGElement * viewTarget;
		[Export ("viewTarget")]
		SVGElement ViewTarget { get; }

		// @property (readonly, nonatomic) NSString * viewBoxString;
		[Export ("viewBoxString")]
		string ViewBoxString { get; }

		// @property (readonly, nonatomic) NSString * preserveAspectRatioString;
		[Export ("preserveAspectRatioString")]
		string PreserveAspectRatioString { get; }

		// @property (readonly, nonatomic) NSString * transformString;
		[Export ("transformString")]
		string TransformString { get; }

		// @property (readonly, nonatomic) NSString * viewTargetString;
		[Export ("viewTargetString")]
		string ViewTargetString { get; }
	}

	// @interface SVGMatrix : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGMatrix
	{
		// @property (nonatomic) float a;
		[Export ("a")]
		float A { get; set; }

		// @property (nonatomic) float b;
		[Export ("b")]
		float B { get; set; }

		// @property (nonatomic) float c;
		[Export ("c")]
		float C { get; set; }

		// @property (nonatomic) float d;
		[Export ("d")]
		float D { get; set; }

		// @property (nonatomic) float e;
		[Export ("e")]
		float E { get; set; }

		// @property (nonatomic) float f;
		[Export ("f")]
		float F { get; set; }

		// -(SVGMatrix *)multiply:(SVGMatrix *)secondMatrix;
		[Export ("multiply:")]
		SVGMatrix Multiply (SVGMatrix secondMatrix);

		// -(SVGMatrix *)inverse;
		[Export("inverse")]
		//[Verify (MethodToProperty)]
		SVGMatrix Inverse();

		// -(SVGMatrix *)translate:(float)x y:(float)y;
		[Export ("translate:y:")]
		SVGMatrix Translate (float x, float y);

		// -(SVGMatrix *)scale:(float)scaleFactor;
		[Export ("scale:")]
		SVGMatrix Scale (float scaleFactor);

		// -(SVGMatrix *)scaleNonUniform:(float)scaleFactorX scaleFactorY:(float)scaleFactorY;
		[Export ("scaleNonUniform:scaleFactorY:")]
		SVGMatrix ScaleNonUniform (float scaleFactorX, float scaleFactorY);

		// -(SVGMatrix *)rotate:(float)angle;
		[Export ("rotate:")]
		SVGMatrix Rotate (float angle);

		// -(SVGMatrix *)rotateFromVector:(float)x y:(float)y;
		[Export ("rotateFromVector:y:")]
		SVGMatrix RotateFromVector (float x, float y);

		// -(SVGMatrix *)flipX;
		[Export("flipX")]
		//[Verify (MethodToProperty)]
		SVGMatrix FlipX();

		// -(SVGMatrix *)flipY;
		[Export("flipY")]
		//[Verify (MethodToProperty)]
		SVGMatrix FlipY();

		// -(SVGMatrix *)skewX:(float)angle;
		[Export ("skewX:")]
		SVGMatrix SkewX (float angle);

		// -(SVGMatrix *)skewY:(float)angle;
		[Export ("skewY:")]
		SVGMatrix SkewY (float angle);
	}

	// @interface SVGPoint : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGPoint
	{
		// @property (readonly, nonatomic) float x;
		[Export ("x")]
		float X { get; }

		// @property (readonly, nonatomic) float y;
		[Export ("y")]
		float Y { get; }

		// -(SVGPoint *)matrixTransform:(SVGMatrix *)matrix;
		[Export ("matrixTransform:")]
		SVGPoint MatrixTransform (SVGMatrix matrix);
	}

	// @interface SVGTransform : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGTransform
	{
		// @property (nonatomic) SVGKTransformType type;
		[Export ("type", ArgumentSemantic.Assign)]
		SVGKTransformType Type { get; set; }

		// @property (nonatomic, strong) SVGMatrix * matrix;
		[Export ("matrix", ArgumentSemantic.Strong)]
		SVGMatrix Matrix { get; set; }

		// @property (readonly, nonatomic) float angle;
		[Export ("angle")]
		float Angle { get; }

		// -(void)setTranslate:(float)tx ty:(float)ty;
		[Export ("setTranslate:ty:")]
		void SetTranslate (float tx, float ty);

		// -(void)setScale:(float)sx sy:(float)sy;
		[Export ("setScale:sy:")]
		void SetScale (float sx, float sy);

		// -(void)setRotate:(float)angle cx:(float)cx cy:(float)cy;
		[Export ("setRotate:cx:cy:")]
		void SetRotate (float angle, float cx, float cy);

		// -(void)setSkewX:(float)angle;
		[Export ("setSkewX:")]
		void SetSkewX (float angle);

		// -(void)setSkewY:(float)angle;
		[Export ("setSkewY:")]
		void SetSkewY (float angle);
	}

	// @interface SVGKSource : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface SVGKSource : INSCopying
	{
		// @property (nonatomic, strong) NSString * svgLanguageVersion;
		[Export ("svgLanguageVersion", ArgumentSemantic.Strong)]
		string SvgLanguageVersion { get; set; }

		// @property (nonatomic, strong) NSInputStream * stream;
		[Export ("stream", ArgumentSemantic.Strong)]
		NSInputStream Stream { get; set; }

		// @property (nonatomic) uint64_t approximateLengthInBytesOr0;
		[Export ("approximateLengthInBytesOr0")]
		ulong ApproximateLengthInBytesOr0 { get; set; }

		// @property (nonatomic, strong) NSString * keyForAppleDictionaries;
		[Export ("keyForAppleDictionaries", ArgumentSemantic.Strong)]
		string KeyForAppleDictionaries { get; set; }

		// -(id)initWithInputSteam:(NSInputStream *)stream;
		[Export ("initWithInputSteam:")]
		IntPtr Constructor (NSInputStream stream);

		// -(SVGKSource *)sourceFromRelativePath:(NSString *)path;
		[Export ("sourceFromRelativePath:")]
		SVGKSource SourceFromRelativePath (string path);
	}

	// @interface SVGSVGElement : SVGElement <DocumentCSS, SVGFitToViewBox, ConverterSVGToCALayer>
	[BaseType (typeof(SVGElement))]
	interface SVGSVGElement : IDocumentCSS, ISVGFitToViewBox, IConverterSVGToCALayer
	{
		// @property (readonly, nonatomic, strong) SVGLength * x;
		[Export ("x", ArgumentSemantic.Strong)]
		SVGLength X { get; }

		// @property (readonly, nonatomic, strong) SVGLength * y;
		[Export ("y", ArgumentSemantic.Strong)]
		SVGLength Y { get; }

		// @property (readonly, nonatomic, strong) SVGLength * width;
		[Export ("width", ArgumentSemantic.Strong)]
		SVGLength Width { get; }

		// @property (readonly, nonatomic, strong) SVGLength * height;
		[Export ("height", ArgumentSemantic.Strong)]
		SVGLength Height { get; }

		// @property (readonly, nonatomic, strong) NSString * contentScriptType;
		[Export ("contentScriptType", ArgumentSemantic.Strong)]
		string ContentScriptType { get; }

		// @property (readonly, nonatomic, strong) NSString * contentStyleType;
		[Export ("contentStyleType", ArgumentSemantic.Strong)]
		string ContentStyleType { get; }

		// @property (readonly, nonatomic) SVGRect viewport;
		[Export ("viewport")]
		SVGRect Viewport { get; }

		// @property (readonly, nonatomic) float pixelUnitToMillimeterX;
		[Export ("pixelUnitToMillimeterX")]
		float PixelUnitToMillimeterX { get; }

		// @property (readonly, nonatomic) float pixelUnitToMillimeterY;
		[Export ("pixelUnitToMillimeterY")]
		float PixelUnitToMillimeterY { get; }

		// @property (readonly, nonatomic) float screenPixelToMillimeterX;
		[Export ("screenPixelToMillimeterX")]
		float ScreenPixelToMillimeterX { get; }

		// @property (readonly, nonatomic) float screenPixelToMillimeterY;
		[Export ("screenPixelToMillimeterY")]
		float ScreenPixelToMillimeterY { get; }

		// @property (readonly, nonatomic) BOOL useCurrentView;
		[Export ("useCurrentView")]
		bool UseCurrentView { get; }

		// @property (readonly, nonatomic, strong) SVGViewSpec * currentView;
		[Export ("currentView", ArgumentSemantic.Strong)]
		SVGViewSpec CurrentView { get; }

		// @property (readonly, nonatomic) float currentScale;
		[Export ("currentScale")]
		float CurrentScale { get; }

		// @property (readonly, nonatomic, strong) SVGPoint * currentTranslate;
		[Export ("currentTranslate", ArgumentSemantic.Strong)]
		SVGPoint CurrentTranslate { get; }

		// @property (readwrite, nonatomic, strong) SVGKSource * source;
		[Export ("source", ArgumentSemantic.Strong)]
		SVGKSource Source { get; set; }

		// -(long)suspendRedraw:(long)maxWaitMilliseconds;
		[Export ("suspendRedraw:")]
		nint SuspendRedraw (nint maxWaitMilliseconds);

		// -(void)unsuspendRedraw:(long)suspendHandleID;
		[Export ("unsuspendRedraw:")]
		void UnsuspendRedraw (nint suspendHandleID);

		// -(void)unsuspendRedrawAll;
		[Export ("unsuspendRedrawAll")]
		void UnsuspendRedrawAll ();

		// -(void)forceRedraw;
		[Export ("forceRedraw")]
		void ForceRedraw ();

		// -(void)pauseAnimations;
		[Export ("pauseAnimations")]
		void PauseAnimations ();

		// -(void)unpauseAnimations;
		[Export ("unpauseAnimations")]
		void UnpauseAnimations ();

		// -(BOOL)animationsPaused;
		[Export ("animationsPaused")]
		//[Verify (MethodToProperty)]
		bool AnimationsPaused { get; }

		// -(float)getCurrentTime;
		[Export ("getCurrentTime")]
		//[Verify (MethodToProperty)]
		float CurrentTime { get; }

		// -(void)setCurrentTime:(float)seconds;
		[Export ("setCurrentTime:")]
		void SetCurrentTime (float seconds);

		// -(NodeList *)getIntersectionList:(SVGRect)rect referenceElement:(SVGElement *)referenceElement;
		[Export ("getIntersectionList:referenceElement:")]
		NodeList GetIntersectionList (SVGRect rect, SVGElement referenceElement);

		// -(NodeList *)getEnclosureList:(SVGRect)rect referenceElement:(SVGElement *)referenceElement;
		[Export ("getEnclosureList:referenceElement:")]
		NodeList GetEnclosureList (SVGRect rect, SVGElement referenceElement);

		// -(BOOL)checkIntersection:(SVGElement *)element rect:(SVGRect)rect;
		[Export ("checkIntersection:rect:")]
		bool CheckIntersection (SVGElement element, SVGRect rect);

		// -(BOOL)checkEnclosure:(SVGElement *)element rect:(SVGRect)rect;
		[Export ("checkEnclosure:rect:")]
		bool CheckEnclosure (SVGElement element, SVGRect rect);

		// -(void)deselectAll;
		[Export ("deselectAll")]
		void DeselectAll ();

		// -(SVGNumber)createSVGNumber;
		[Export("createSVGNumber")]
		//[Verify (MethodToProperty)]
		SVGNumber CreateSVGNumber();

		// -(SVGLength *)createSVGLength __attribute__((ns_returns_retained));
		[Export("createSVGLength")]
		//[Verify (MethodToProperty)]
		SVGLength CreateSVGLength();

		// -(SVGAngle *)createSVGAngle;
		[Export("createSVGAngle")]
		//[Verify (MethodToProperty)]
		SVGAngle CreateSVGAngle();

		// -(SVGPoint *)createSVGPoint;
		[Export("createSVGPoint")]
		//[Verify (MethodToProperty)]
		SVGPoint CreateSVGPoint();

		// -(SVGMatrix *)createSVGMatrix;
		[Export("createSVGMatrix")]
		//[Verify (MethodToProperty)]
		SVGMatrix CreateSVGMatrix();

		// -(SVGRect)createSVGRect;
		[Export("createSVGRect")]
		//[Verify (MethodToProperty)]
		SVGRect CreateSVGRect();

		// -(SVGTransform *)createSVGTransform;
		[Export("createSVGTransform")]
		//[Verify (MethodToProperty)]
		SVGTransform CreateSVGTransform();

		// -(SVGTransform *)createSVGTransformFromMatrix:(SVGMatrix *)matrix;
		[Export ("createSVGTransformFromMatrix:")]
		SVGTransform CreateSVGTransformFromMatrix (SVGMatrix matrix);

		// -(Element *)getElementById:(NSString *)elementId;
		[Export ("getElementById:")]
		Element GetElementById (string elementId);

		// -(SVGElement *)findFirstElementOfClass:(Class)classParameter;
		[Export ("findFirstElementOfClass:")]
		SVGElement FindFirstElementOfClass (Class classParameter);

		// @property (readonly, nonatomic) SVGRect requestedViewport;
		[Export ("requestedViewport")]
		SVGRect RequestedViewport { get; }

		// @property (readonly) double aspectRatioFromWidthPerHeight;
		[Export ("aspectRatioFromWidthPerHeight")]
		double AspectRatioFromWidthPerHeight { get; }

		// @property (readonly) double aspectRatioFromViewBox;
		[Export ("aspectRatioFromViewBox")]
		double AspectRatioFromViewBox { get; }
	}

	// @interface SVGDocument : Document
	[BaseType (typeof(Document))]
	interface SVGDocument
	{
		// @property (readonly, nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; }

		// @property (readonly, nonatomic, strong) NSString * referrer;
		[Export ("referrer", ArgumentSemantic.Strong)]
		string Referrer { get; }

		// @property (readonly, nonatomic, strong) NSString * domain;
		[Export ("domain", ArgumentSemantic.Strong)]
		string Domain { get; }

		// @property (readonly, nonatomic, strong) NSString * URL;
		[Export ("URL", ArgumentSemantic.Strong)]
		string URL { get; }

		// @property (readonly, nonatomic, strong) SVGSVGElement * rootElement;
		[Export ("rootElement", ArgumentSemantic.Strong)]
		SVGSVGElement RootElement { get; }

		// -(NSMutableDictionary *)allPrefixesByNamespace;
		[Export("allPrefixesByNamespace")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary AllPrefixesByNamespace();

		// -(NSMutableDictionary *)allPrefixesByNamespaceNormalized;
		[Export("allPrefixesByNamespaceNormalized")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary AllPrefixesByNamespaceNormalized();
	}

	// @protocol SVGKParserExtension <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SVGKParserExtension
	{
		// @required -(NSArray *)supportedNamespaces;
		[Abstract]
		[Export("supportedNamespaces")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] SupportedNamespaces();

		// @required -(NSArray *)supportedTags;
		[Abstract]
		[Export("supportedTags")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] SupportedTags();

		// @required -(Node *)handleStartElement:(NSString *)name document:(SVGKSource *)document namePrefix:(NSString *)prefix namespaceURI:(NSString *)XMLNSURI attributes:(NSMutableDictionary *)attributes parseResult:(SVGKParseResult *)parseResult parentNode:(Node *)parentNode;
		[Abstract]
		[Export ("handleStartElement:document:namePrefix:namespaceURI:attributes:parseResult:parentNode:")]
		Node HandleStartElement (string name, SVGKSource document, string prefix, string XMLNSURI, NSMutableDictionary attributes, SVGKParseResult parseResult, Node parentNode);

		// @required -(void)handleEndElement:(Node *)newNode document:(SVGKSource *)document parseResult:(SVGKParseResult *)parseResult;
		[Abstract]
		[Export ("handleEndElement:document:parseResult:")]
		void HandleEndElement (Node newNode, SVGKSource document, SVGKParseResult parseResult);
	}

	// @interface SVGKParseResult : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGKParseResult
	{
		// @property (nonatomic, strong) NSMutableArray * warnings;
		[Export ("warnings", ArgumentSemantic.Strong)]
		NSMutableArray Warnings { get; set; }

		// @property (nonatomic, strong) NSMutableArray * errorsRecoverable;
		[Export ("errorsRecoverable", ArgumentSemantic.Strong)]
		NSMutableArray ErrorsRecoverable { get; set; }

		// @property (nonatomic, strong) NSMutableArray * errorsFatal;
		[Export ("errorsFatal", ArgumentSemantic.Strong)]
		NSMutableArray ErrorsFatal { get; set; }

		// @property (nonatomic) BOOL libXMLFailed;
		[Export ("libXMLFailed")]
		bool LibXMLFailed { get; set; }

		// @property (nonatomic) double parseProgressFractionApproximate;
		[Export ("parseProgressFractionApproximate")]
		double ParseProgressFractionApproximate { get; set; }

		// @property (nonatomic, strong) SVGSVGElement * rootOfSVGTree;
		[Export ("rootOfSVGTree", ArgumentSemantic.Strong)]
		SVGSVGElement RootOfSVGTree { get; set; }

		// @property (nonatomic, strong) SVGDocument * parsedDocument;
		[Export ("parsedDocument", ArgumentSemantic.Strong)]
		SVGDocument ParsedDocument { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * namespacesEncountered;
		[Export ("namespacesEncountered", ArgumentSemantic.Strong)]
		NSMutableDictionary NamespacesEncountered { get; set; }

		// -(void)addSourceError:(NSError *)fatalError;
		[Export ("addSourceError:")]
		void AddSourceError (NSError fatalError);

		// -(void)addParseWarning:(NSError *)warning;
		[Export ("addParseWarning:")]
		void AddParseWarning (NSError warning);

		// -(void)addParseErrorRecoverable:(NSError *)recoverableError;
		[Export ("addParseErrorRecoverable:")]
		void AddParseErrorRecoverable (NSError recoverableError);

		// -(void)addParseErrorFatal:(NSError *)fatalError;
		[Export ("addParseErrorFatal:")]
		void AddParseErrorFatal (NSError fatalError);

		// -(void)addSAXError:(NSError *)saxError;
		[Export ("addSAXError:")]
		void AddSAXError (NSError saxError);
	}

	// @interface  (SVGElement)
	[Category]
	[BaseType (typeof(SVGElement))]
	interface SVGElement_
	{
		// +(BOOL)shouldStoreContent;
		[Static]
		[Export ("shouldStoreContent")]
		//[Verify (MethodToProperty)]
		bool ShouldStoreContent { get; }

		// -(void)loadDefaults;
		[Export ("loadDefaults")]
		void LoadDefaults ();

		// -(void)postProcessAttributesAddingErrorsTo:(SVGKParseResult *)parseResult;
		[Export ("postProcessAttributesAddingErrorsTo:")]
		void PostProcessAttributesAddingErrorsTo (SVGKParseResult parseResult);
	}

	// @interface SVGClipPathElement : SVGElement <SVGTransformable, SVGStylable>
	[BaseType (typeof(SVGElement))]
	interface SVGClipPathElement : ISVGTransformable, ISVGStylable
	{
		// @property (readonly, nonatomic) SVG_UNIT_TYPE clipPathUnits;
		[Export ("clipPathUnits")]
		SvgUnitType ClipPathUnits { get; }

		// -(CALayer *)newLayer;
		[Export("newLayer")]
		//[Verify (MethodToProperty)]
		CALayer NewLayer();

		// -(void)layoutLayer:(CALayer *)layer toMaskLayer:(CALayer *)maskThis;
		[Export ("layoutLayer:toMaskLayer:")]
		void LayoutLayer (CALayer layer, CALayer maskThis);
	}

	// @interface SVGDefsElement : SVGElement
	[BaseType (typeof(SVGElement))]
	interface SVGDefsElement
	{
	}

	// @interface SVGDescriptionElement : SVGElement
	[BaseType (typeof(SVGElement))]
	interface SVGDescriptionElement
	{
	}

	// @interface  (SVGDocument)
	//[Category]
	//[BaseType (typeof(SVGDocument))]
	//interface SVGDocument_
	//{
	//	// @property (readwrite, nonatomic, strong) NSString * title;
	//	[Export ("title", ArgumentSemantic.Strong)]
	//	string Title { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * referrer;
	//	[Export ("referrer", ArgumentSemantic.Strong)]
	//	string Referrer { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * domain;
	//	[Export ("domain", ArgumentSemantic.Strong)]
	//	string Domain { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * URL;
	//	[Export ("URL", ArgumentSemantic.Strong)]
	//	string URL { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGSVGElement * rootElement;
	//	[Export ("rootElement", ArgumentSemantic.Strong)]
	//	SVGSVGElement RootElement { get; set; }
	//}

	// @interface SVGElementInstanceList : SVGElement
	[BaseType (typeof(SVGElement))]
	interface SVGElementInstanceList
	{
		// @property (readonly, nonatomic) unsigned long length;
		[Export ("length")]
		nuint Length { get; }

		// -(SVGElementInstance *)item:(unsigned long)index;
		[Export ("item:")]
		SVGElementInstance Item (nuint index);
	}

	// @interface SVGUseElement : SVGElement <SVGTransformable, ConverterSVGToCALayer>
	[BaseType (typeof(SVGElement))]
	interface SVGUseElement : ISVGTransformable, IConverterSVGToCALayer
	{
		// @property (readonly, nonatomic, strong) SVGLength * x;
		[Export ("x", ArgumentSemantic.Strong)]
		SVGLength X { get; }

		// @property (readonly, nonatomic, strong) SVGLength * y;
		[Export ("y", ArgumentSemantic.Strong)]
		SVGLength Y { get; }

		// @property (readonly, nonatomic, strong) SVGLength * width;
		[Export ("width", ArgumentSemantic.Strong)]
		SVGLength Width { get; }

		// @property (readonly, nonatomic, strong) SVGLength * height;
		[Export ("height", ArgumentSemantic.Strong)]
		SVGLength Height { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstance * instanceRoot;
		[Export ("instanceRoot", ArgumentSemantic.Strong)]
		SVGElementInstance InstanceRoot { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstance * animatedInstanceRoot;
		[Export ("animatedInstanceRoot", ArgumentSemantic.Strong)]
		SVGElementInstance AnimatedInstanceRoot { get; }
	}

	// @interface SVGElementInstance : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGElementInstance
	{
		// @property (readonly, nonatomic, weak) SVGElement * correspondingElement;
		[Export ("correspondingElement", ArgumentSemantic.Weak)]
		SVGElement CorrespondingElement { get; }

		// @property (readonly, nonatomic, weak) SVGUseElement * correspondingUseElement;
		[Export ("correspondingUseElement", ArgumentSemantic.Weak)]
		SVGUseElement CorrespondingUseElement { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstance * parentNode;
		[Export ("parentNode", ArgumentSemantic.Strong)]
		SVGElementInstance ParentNode { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstanceList * childNodes;
		[Export ("childNodes", ArgumentSemantic.Strong)]
		SVGElementInstanceList ChildNodes { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstance * firstChild;
		[Export ("firstChild", ArgumentSemantic.Strong)]
		SVGElementInstance FirstChild { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstance * lastChild;
		[Export ("lastChild", ArgumentSemantic.Strong)]
		SVGElementInstance LastChild { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstance * previousSibling;
		[Export ("previousSibling", ArgumentSemantic.Strong)]
		SVGElementInstance PreviousSibling { get; }

		// @property (readonly, nonatomic, strong) SVGElementInstance * nextSibling;
		[Export ("nextSibling", ArgumentSemantic.Strong)]
		SVGElementInstance NextSibling { get; }
	}

	//// @interface  (SVGElementInstanceList)
	//[Category]
	//[BaseType (typeof(SVGElementInstanceList))]
	//interface SVGElementInstanceList_
	//{
	//	// @property (nonatomic, strong) NSMutableArray * internalArray;
	//	[Export ("internalArray", ArgumentSemantic.Strong)]
	//	NSMutableArray InternalArray { get; set; }
	//}

	// @interface  (SVGElementInstance)
	//[Category]
	//[BaseType (typeof(SVGElementInstance))]
	//interface SVGElementInstance_
	//{
	//	// @property (readwrite, nonatomic, weak) SVGElement * correspondingElement;
	//	[Export ("correspondingElement", ArgumentSemantic.Weak)]
	//	SVGElement CorrespondingElement { get; set; }

	//	// @property (readwrite, nonatomic, weak) SVGUseElement * correspondingUseElement;
	//	[Export ("correspondingUseElement", ArgumentSemantic.Weak)]
	//	SVGUseElement CorrespondingUseElement { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGElementInstance * parentNode;
	//	[Export ("parentNode", ArgumentSemantic.Strong)]
	//	SVGElementInstance ParentNode { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGElementInstanceList * childNodes;
	//	[Export ("childNodes", ArgumentSemantic.Strong)]
	//	SVGElementInstanceList ChildNodes { get; set; }
	//}

	// @interface SVGGElement : SVGElement <SVGTransformable, SVGStylable, ConverterSVGToCALayer>
	[BaseType (typeof(SVGElement))]
	interface SVGGElement : ISVGTransformable, ISVGStylable, IConverterSVGToCALayer
	{
	}

	// @interface SVGGradientStop : SVGElement
	[BaseType (typeof(SVGElement))]
	interface SVGGradientStop
	{
		// @property (readonly, nonatomic) CGFloat offset;
		[Export ("offset")]
		nfloat Offset { get; }

		// @property (readonly, nonatomic) CGFloat stopOpacity;
		[Export ("stopOpacity")]
		nfloat StopOpacity { get; }

		// @property (readonly, nonatomic) SVGColor stopColor;
		[Export ("stopColor")]
		SVGColor StopColor { get; }
	}

	// @interface SVGGradientLayer : CAGradientLayer <SVGTransformable>
	[BaseType (typeof(CAGradientLayer))]
	interface SVGGradientLayer : ISVGTransformable
	{
		// @property (readwrite, nonatomic) CGPathRef maskPath;
		[Export ("maskPath", ArgumentSemantic.Assign)]
		unsafe CGPathRef MaskPath { get; set; }

		// @property (readwrite, nonatomic, strong) NSArray * stopIdentifiers;
		[Export ("stopIdentifiers", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		// NSString QuartzCore additions/SVGGradientLayer.m
		NSString[] StopIdentifiers { get; set; }

		// @property (nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; set; }

		// @property (nonatomic) CGPoint centerPoint;
		[Export ("centerPoint", ArgumentSemantic.Assign)]
		CGPoint CenterPoint { get; set; }

		// @property (nonatomic) CGAffineTransform radialTransform;
		[Export ("radialTransform", ArgumentSemantic.Assign)]
		CGAffineTransform RadialTransform { get; set; }

		// -(void)setStopColor:(UIColor *)color forIdentifier:(NSString *)identifier;
		[Export ("setStopColor:forIdentifier:")]
		void SetStopColor (UIColor color, string identifier);
	}

	// @interface SVGGradientElement : SVGElement <SVGTransformable>
	[BaseType (typeof(SVGElement))]
	interface SVGGradientElement : ISVGTransformable
	{
		// @property (readonly, strong) NSArray * stops;
		[Export ("stops", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		// DOM classes/Unported or Partial DOM/SVGGradientElement.m
		// for (SVGGradientStop *theStop in _stops)
		SVGGradientStop[] Stops { get; }

		// @property (readonly, strong) NSArray * locations;
		[Export ("locations", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		// DOM classes/Unported or Partial DOM/SVGGradientElement.m
		NSNumber[] Locations { get; }

		// @property (readonly, strong) NSArray * colors;
		[Export ("colors", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		// "DOM classes/Unported or Partial DOM/SVGGradientElement.m"
		// ? CGColorWithSVGColor ?
		NSObject[] Colors { get; }

		// -(void)addStop:(SVGGradientStop *)gradientStop;
		[Export ("addStop:")]
		void AddStop (SVGGradientStop gradientStop);

		// -(SVGGradientLayer *)newGradientLayerForObjectRect:(CGRect)objectRect viewportRect:(SVGRect)viewportRect transform:(CGAffineTransform)transform;
		[Export ("newGradientLayerForObjectRect:viewportRect:transform:")]
		SVGGradientLayer NewGradientLayerForObjectRect (CGRect objectRect, SVGRect viewportRect, CGAffineTransform transform);

		// -(void)synthesizeProperties;
		[Export ("synthesizeProperties")]
		void SynthesizeProperties ();
	}

	// @interface SVGGroupElement : SVGElement <ConverterSVGToCALayer>
	[BaseType (typeof(SVGElement))]
	interface SVGGroupElement : IConverterSVGToCALayer
	{
		// @property (readonly, nonatomic) CGFloat opacity;
		[Export ("opacity")]
		nfloat Opacity { get; }
	}

	// @interface SVGHelperUtilities : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGHelperUtilities
	{
		// +(CGAffineTransform)transformRelativeIncludingViewportForTransformableOrViewportEstablishingElement:(SVGElement *)transformableOrSVGSVGElement;
		[Static]
		[Export ("transformRelativeIncludingViewportForTransformableOrViewportEstablishingElement:")]
		CGAffineTransform TransformRelativeIncludingViewportForTransformableOrViewportEstablishingElement (SVGElement transformableOrSVGSVGElement);

		// +(CGAffineTransform)transformAbsoluteIncludingViewportForTransformableOrViewportEstablishingElement:(SVGElement *)transformableOrSVGSVGElement;
		[Static]
		[Export ("transformAbsoluteIncludingViewportForTransformableOrViewportEstablishingElement:")]
		CGAffineTransform TransformAbsoluteIncludingViewportForTransformableOrViewportEstablishingElement (SVGElement transformableOrSVGSVGElement);

		// +(void)configureCALayer:(CALayer *)layer usingElement:(SVGElement *)nonStylableElement;
		[Static]
		[Export ("configureCALayer:usingElement:")]
		void ConfigureCALayer (CALayer layer, SVGElement nonStylableElement);

		// +(CALayer *)newCALayerForPathBasedSVGElement:(SVGElement *)svgElement withPath:(CGPathRef)path;
		[Static]
		[Export ("newCALayerForPathBasedSVGElement:withPath:")]
		unsafe CALayer NewCALayerForPathBasedSVGElement (SVGElement svgElement, CGPathRef path);

		// +(CGColorRef)parseFillForElement:(SVGElement *)svgElement;
		[Static]
		[Export ("parseFillForElement:")]
		unsafe CGColorRef ParseFillForElement (SVGElement svgElement);

		// +(void)parsePreserveAspectRatioFor:(Element<SVGFitToViewBox> *)element;
		[Static]
		[Export ("parsePreserveAspectRatioFor:")]
		void ParsePreserveAspectRatioFor (ISVGFitToViewBox element);
	}

	// @interface SVGImageElement : SVGElement <SVGTransformable, SVGStylable, ConverterSVGToCALayer, SVGFitToViewBox>
	[BaseType (typeof(SVGElement))]
	interface SVGImageElement : ISVGTransformable, ISVGStylable, IConverterSVGToCALayer, ISVGFitToViewBox
	{
		// @property (readonly, nonatomic) CGFloat x;
		[Export ("x")]
		nfloat X { get; }

		// @property (readonly, nonatomic) CGFloat y;
		[Export ("y")]
		nfloat Y { get; }

		// @property (readonly, nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; }

		// @property (readonly, nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; }

		// @property (readonly, nonatomic, strong) NSString * href;
		[Export ("href", ArgumentSemantic.Strong)]
		string Href { get; }
	}

	// @interface SVGKParser : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGKParser
	{
		// @property (readonly, nonatomic, strong) SVGKSource * source;
		[Export ("source", ArgumentSemantic.Strong)]
		SVGKSource Source { get; }

		// @property (readonly, nonatomic, strong) NSMutableArray * externalStylesheets;
		[Export ("externalStylesheets", ArgumentSemantic.Strong)]
		NSMutableArray ExternalStylesheets { get; }

		// @property (readonly, nonatomic, strong) SVGKParseResult * currentParseRun;
		[Export ("currentParseRun", ArgumentSemantic.Strong)]
		SVGKParseResult CurrentParseRun { get; }

		// @property (nonatomic, strong) NSMutableArray * parserExtensions;
		[Export ("parserExtensions", ArgumentSemantic.Strong)]
		NSMutableArray ParserExtensions { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * parserKnownNamespaces;
		[Export ("parserKnownNamespaces", ArgumentSemantic.Strong)]
		NSMutableDictionary ParserKnownNamespaces { get; set; }

		// +(void)cancelParser:(SVGKParser *)parserToCancel;
		[Static]
		[Export ("cancelParser:")]
		void CancelParser (SVGKParser parserToCancel);

		// +(SVGKParser *)newParserWithDefaultSVGKParserExtensions:(SVGKSource *)source;
		[Static]
		[Export ("newParserWithDefaultSVGKParserExtensions:")]
		SVGKParser NewParserWithDefaultSVGKParserExtensions (SVGKSource source);

		// +(SVGKParseResult *)parseSourceUsingDefaultSVGKParser:(SVGKSource *)source;
		[Static]
		[Export ("parseSourceUsingDefaultSVGKParser:")]
		SVGKParseResult ParseSourceUsingDefaultSVGKParser (SVGKSource source);

		// -(SVGKParseResult *)parseSynchronously;
		[Export("parseSynchronously")]
		//[Verify (MethodToProperty)]
		SVGKParseResult ParseSynchronously();

		// +(NSDictionary *)NSDictionaryFromCSSAttributes:(Attr *)styleAttribute;
		[Static]
		[Export ("NSDictionaryFromCSSAttributes:")]
		NSDictionary NSDictionaryFromCSSAttributes (Attr styleAttribute);

		// -(id)initWithSource:(SVGKSource *)doc;
		[Export ("initWithSource:")]
		IntPtr Constructor (SVGKSource doc);

		// -(void)addDefaultSVGParserExtensions;
		[Export ("addDefaultSVGParserExtensions")]
		void AddDefaultSVGParserExtensions ();

		// -(void)addParserExtension:(NSObject<SVGKParserExtension> *)extension;
		[Export ("addParserExtension:")]
		void AddParserExtension (SVGKParserExtension extension);
	}

	// typedef void (^SVGKImageAsynchronousLoadingDelegate)(SVGKImage *, SVGKParseResult *);
	delegate void SVGKImageAsynchronousLoadingDelegate (SVGKImage arg0, SVGKParseResult arg1);

	// @interface SVGKImage : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGKImage
	{
		// @property (readonly, nonatomic, weak) UIImage * UIImage;
		[Export ("UIImage", ArgumentSemantic.Weak)]
		UIImage UIImage { get; }

		// @property (readonly, nonatomic, strong) SVGKSource * source;
		[Export ("source", ArgumentSemantic.Strong)]
		SVGKSource Source { get; }

		// @property (readonly, nonatomic, strong) SVGKParseResult * parseErrorsAndWarnings;
		[Export ("parseErrorsAndWarnings", ArgumentSemantic.Strong)]
		SVGKParseResult ParseErrorsAndWarnings { get; }

		// @property (readonly, nonatomic, strong) SVGDocument * DOMDocument;
		[Export ("DOMDocument", ArgumentSemantic.Strong)]
		SVGDocument DOMDocument { get; }

		// @property (readonly, nonatomic, strong) SVGSVGElement * DOMTree;
		[Export ("DOMTree", ArgumentSemantic.Strong)]
		SVGSVGElement DOMTree { get; }

		// @property (readonly, nonatomic, strong) CALayer * CALayerTree;
		[Export ("CALayerTree", ArgumentSemantic.Strong)]
		CALayer CALayerTree { get; }

		// @property (readonly, nonatomic, strong) NSString * nameUsedToInstantiate;
		[Export ("nameUsedToInstantiate", ArgumentSemantic.Strong)]
		string NameUsedToInstantiate { get; }

		// +(SVGKImage *)imageNamed:(NSString *)name;
		[Static]
		[Export ("imageNamed:")]
		SVGKImage ImageNamed (string name);

		// +(SVGKImage *)imageNamed:(NSString *)name inBundle:(NSBundle *)bundle;
		[Static]
		[Export ("imageNamed:inBundle:")]
		SVGKImage ImageNamed (string name, NSBundle bundle);

		// +(SVGKParser *)imageAsynchronouslyNamed:(NSString *)name onCompletion:(SVGKImageAsynchronousLoadingDelegate)blockCompleted;
		[Static]
		[Export ("imageAsynchronouslyNamed:onCompletion:")]
		SVGKParser ImageAsynchronouslyNamed (string name, SVGKImageAsynchronousLoadingDelegate blockCompleted);

		// +(SVGKImage *)imageWithContentsOfFile:(NSString *)path;
		[Static]
		[Export ("imageWithContentsOfFile:")]
		SVGKImage ImageWithContentsOfFile (string path);

		// +(SVGKImage *)imageWithContentsOfFileAsynchronously:(NSString *)aPath onCompletion:(SVGKImageAsynchronousLoadingDelegate)blockCompleted;
		[Static]
		[Export ("imageWithContentsOfFileAsynchronously:onCompletion:")]
		SVGKImage ImageWithContentsOfFileAsynchronously (string aPath, SVGKImageAsynchronousLoadingDelegate blockCompleted);

		// +(SVGKImage *)imageWithData:(NSData *)newNSData;
		[Static]
		[Export ("imageWithData:")]
		SVGKImage ImageWithData (NSData newNSData);

		// +(SVGKImage *)imageWithDataAsynchronously:(NSData *)newNSData onCompletion:(SVGKImageAsynchronousLoadingDelegate)blockCompleted;
		[Static]
		[Export ("imageWithDataAsynchronously:onCompletion:")]
		SVGKImage ImageWithDataAsynchronously (NSData newNSData, SVGKImageAsynchronousLoadingDelegate blockCompleted);

		// +(SVGKImage *)imageWithSource:(SVGKSource *)newSource;
		[Static]
		[Export ("imageWithSource:")]
		SVGKImage ImageWithSource (SVGKSource newSource);

		// +(SVGKParser *)imageWithSource:(SVGKSource *)source onCompletion:(SVGKImageAsynchronousLoadingDelegate)blockCompleted;
		[Static]
		[Export ("imageWithSource:onCompletion:")]
		SVGKParser ImageWithSource (SVGKSource source, SVGKImageAsynchronousLoadingDelegate blockCompleted);

		// -(id)initWithContentsOfFile:(NSString *)path;
		[Export ("initWithContentsOfFile:")]
		IntPtr Constructor (string path);

		// -(id)initWithData:(NSData *)data;
		[Export ("initWithData:")]
		IntPtr Constructor (NSData data);

		// -(BOOL)hasSize;
		[Export ("hasSize")]
		//[Verify (MethodToProperty)]
		bool HasSize { get; }

		// @property (nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }

		// -(void)drawAtPoint:(CGPoint)point;
		[Export ("drawAtPoint:")]
		void DrawAtPoint (CGPoint point);

		// @property (nonatomic) CGFloat scale;
		[Export ("scale")]
		nfloat Scale { get; set; }

		// -(void)drawAtPoint:(CGPoint)point blendMode:(CGBlendMode)blendMode alpha:(CGFloat)alpha;
		[Export ("drawAtPoint:blendMode:alpha:")]
		void DrawAtPoint (CGPoint point, CGBlendMode blendMode, nfloat alpha);

		// -(void)drawInRect:(CGRect)rect;
		[Export ("drawInRect:")]
		void DrawInRect (CGRect rect);

		// -(void)drawInRect:(CGRect)rect blendMode:(CGBlendMode)blendMode alpha:(CGFloat)alpha;
		[Export ("drawInRect:blendMode:alpha:")]
		void DrawInRect (CGRect rect, CGBlendMode blendMode, nfloat alpha);

		// -(void)drawAsPatternInRect:(CGRect)rect;
		[Export ("drawAsPatternInRect:")]
		void DrawAsPatternInRect (CGRect rect);

		// +(UIImage *)animatedImageNamed:(NSString *)name duration:(NSTimeInterval)duration;
		[Static]
		[Export ("animatedImageNamed:duration:")]
		UIImage AnimatedImageNamed (string name, double duration);

		// +(UIImage *)animatedResizableImageNamed:(NSString *)name capInsets:(UIEdgeInsets)capInsets duration:(NSTimeInterval)duration;
		[Static]
		[Export ("animatedResizableImageNamed:capInsets:duration:")]
		UIImage AnimatedResizableImageNamed (string name, UIEdgeInsets capInsets, double duration);

		// +(UIImage *)animatedImageWithImages:(NSArray *)images duration:(NSTimeInterval)duration;
		[Static]
		[Export ("animatedImageWithImages:duration:")]
		//[Verify (StronglyTypedNSArray)]
		UIImage AnimatedImageWithImages (UIImage[] images, double duration);

		// +(SVGKImage *)imageWithContentsOfURL:(NSURL *)url;
		[Static]
		[Export ("imageWithContentsOfURL:")]
		SVGKImage ImageWithContentsOfURL (NSUrl url);

		// -(id)initWithSource:(SVGKSource *)source;
		[Export ("initWithSource:")]
		IntPtr Constructor (SVGKSource source);

		// -(id)initWithParsedSVG:(SVGKParseResult *)parseResult fromSource:(SVGKSource *)parseSource;
		[Export ("initWithParsedSVG:fromSource:")]
		IntPtr Constructor (SVGKParseResult parseResult, SVGKSource parseSource);

		// -(CALayer *)newCALayerTree;
		[Export("newCALayerTree")]
		[Advice("This should ONLY be used if you specifically need to duplicate the CALayer")]
		//[Verify(MethodToProperty)]
			//Creates a new instance each time you call it.This should ONLY be used if you specifically need to duplicate
			//the CALayer's (e.g. because you want to render a temporary clone of the CALayers somewhere else on screen,
			//and you're going to modify them).

			//For all other use-cases, you should probably use the.CALayerTree property, which is automatically cached between
			//calls - but MUST NOT be altered!
		CALayer NewCALayerTree();

		// -(CALayer *)layerWithIdentifier:(NSString *)identifier;
		[Export ("layerWithIdentifier:")]
		CALayer LayerWithIdentifier (string identifier);

		// -(CALayer *)layerWithIdentifier:(NSString *)identifier layer:(CALayer *)layer;
		[Export ("layerWithIdentifier:layer:")]
		CALayer LayerWithIdentifier (string identifier, CALayer layer);

		// -(CALayer *)newCopyPositionedAbsoluteLayerWithIdentifier:(NSString *)identifier;
		[Export ("newCopyPositionedAbsoluteLayerWithIdentifier:")]
		CALayer NewCopyPositionedAbsoluteLayerWithIdentifier (string identifier);

		// -(CALayer *)newCopyPositionedAbsoluteOfLayer:(CALayer *)originalLayer;
		[Export ("newCopyPositionedAbsoluteOfLayer:")]
		CALayer NewCopyPositionedAbsoluteOfLayer (CALayer originalLayer);

		// -(CALayer *)newCopyPositionedAbsoluteOfLayer:(CALayer *)originalLayer withSubLayers:(BOOL)recursive;
		[Export ("newCopyPositionedAbsoluteOfLayer:withSubLayers:")]
		CALayer NewCopyPositionedAbsoluteOfLayer (CALayer originalLayer, bool recursive);

		// -(NSDictionary *)dictionaryOfLayers;
		[Export("dictionaryOfLayers")]
		//[Verify (MethodToProperty)]
		NSDictionary DictionaryOfLayers();

		// -(void)scaleToFitInside:(CGSize)maxSize;
		[Export ("scaleToFitInside:")]
		void ScaleToFitInside (CGSize maxSize);
	}

	// @interface SVGKExporterNSData : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGKExporterNSData
	{
		// +(NSData *)exportAsNSData:(SVGKImage *)image;
		[Static]
		[Export ("exportAsNSData:")]
		NSData ExportAsNSData (SVGKImage image);

		// +(NSData *)exportAsNSData:(SVGKImage *)image flipYaxis:(BOOL)flipYaxis;
		[Static]
		[Export ("exportAsNSData:flipYaxis:")]
		NSData ExportAsNSData (SVGKImage image, bool flipYaxis);

		// +(NSData *)exportAsNSData:(SVGKImage *)image antiAliased:(BOOL)shouldAntialias curveFlatnessFactor:(CGFloat)multiplyFlatness interpolationQuality:(CGInterpolationQuality)interpolationQuality flipYaxis:(BOOL)flipYaxis;
		[Static]
		[Export ("exportAsNSData:antiAliased:curveFlatnessFactor:interpolationQuality:flipYaxis:")]
		NSData ExportAsNSData (SVGKImage image, bool shouldAntialias, nfloat multiplyFlatness, CGInterpolationQuality interpolationQuality, bool flipYaxis);
	}

	// @interface SVGKExporterUIImage : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGKExporterUIImage
	{
		// +(UIImage *)exportAsUIImage:(SVGKImage *)image;
		[Static]
		[Export ("exportAsUIImage:")]
		UIImage ExportAsUIImage (SVGKImage image);

		// +(UIImage *)exportAsUIImage:(SVGKImage *)image antiAliased:(BOOL)shouldAntialias curveFlatnessFactor:(CGFloat)multiplyFlatness interpolationQuality:(CGInterpolationQuality)interpolationQuality;
		[Static]
		[Export ("exportAsUIImage:antiAliased:curveFlatnessFactor:interpolationQuality:")]
		UIImage ExportAsUIImage (SVGKImage image, bool shouldAntialias, nfloat multiplyFlatness, CGInterpolationQuality interpolationQuality);
	}

	// @interface SVGKImageView : UIView
	[BaseType (typeof(UIView))]
	interface SVGKImageView
	{
		// @property (nonatomic, strong) SVGKImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		SVGKImage Image { get; set; }

		// @property (nonatomic) BOOL showBorder;
		[Export ("showBorder")]
		bool ShowBorder { get; set; }

		// @property (readonly, nonatomic) NSTimeInterval timeIntervalForLastReRenderOfSVGFromMemory;
		[Export ("timeIntervalForLastReRenderOfSVGFromMemory")]
		double TimeIntervalForLastReRenderOfSVGFromMemory { get; }

		// -(id)initWithSVGKImage:(SVGKImage *)im;
		[Export ("initWithSVGKImage:")]
		IntPtr Constructor (SVGKImage im);
	}

	// @interface SVGLineElement : BaseClassForAllSVGBasicShapes
	[BaseType (typeof(BaseClassForAllSVGBasicShapes))]
	interface SVGLineElement
	{
		// @property (readonly, nonatomic) CGFloat x1;
		[Export ("x1")]
		nfloat X1 { get; }

		// @property (readonly, nonatomic) CGFloat y1;
		[Export ("y1")]
		nfloat Y1 { get; }

		// @property (readonly, nonatomic) CGFloat x2;
		[Export ("x2")]
		nfloat X2 { get; }

		// @property (readonly, nonatomic) CGFloat y2;
		[Export ("y2")]
		nfloat Y2 { get; }
	}

	// @interface SVGPathElement : BaseClassForAllSVGBasicShapes
	[BaseType (typeof(BaseClassForAllSVGBasicShapes))]
	interface SVGPathElement
	{
	}

	// @interface SVGPolygonElement : BaseClassForAllSVGBasicShapes
	[BaseType (typeof(BaseClassForAllSVGBasicShapes))]
	interface SVGPolygonElement
	{
	}

	// @interface SVGPolylineElement : BaseClassForAllSVGBasicShapes
	[BaseType (typeof(BaseClassForAllSVGBasicShapes))]
	interface SVGPolylineElement
	{
	}

	// @interface SVGRectElement : BaseClassForAllSVGBasicShapes <SVGStylable, SVGTransformable>
	[BaseType (typeof(BaseClassForAllSVGBasicShapes))]
	interface SVGRectElement : ISVGStylable, ISVGTransformable
	{
		// @property (readonly, nonatomic, strong) SVGLength * x;
		[Export ("x", ArgumentSemantic.Strong)]
		SVGLength X { get; }

		// @property (readonly, nonatomic, strong) SVGLength * y;
		[Export ("y", ArgumentSemantic.Strong)]
		SVGLength Y { get; }

		// @property (readonly, nonatomic, strong) SVGLength * width;
		[Export ("width", ArgumentSemantic.Strong)]
		SVGLength Width { get; }

		// @property (readonly, nonatomic, strong) SVGLength * height;
		[Export ("height", ArgumentSemantic.Strong)]
		SVGLength Height { get; }

		// @property (readonly, nonatomic, strong) SVGLength * rx;
		[Export ("rx", ArgumentSemantic.Strong)]
		SVGLength Rx { get; }

		// @property (readonly, nonatomic, strong) SVGLength * ry;
		[Export ("ry", ArgumentSemantic.Strong)]
		SVGLength Ry { get; }
	}

	// @interface SVGTitleElement : SVGElement
	[BaseType (typeof(SVGElement))]
	interface SVGTitleElement
	{
	}

	// @interface SVGKPattern : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGKPattern
	{
		// +(SVGKPattern *)patternWithUIColor:(UIColor *)color;
		[Static]
		[Export ("patternWithUIColor:")]
		SVGKPattern PatternWithUIColor (UIColor color);

		// +(SVGKPattern *)patternWithImage:(UIImage *)image;
		[Static]
		[Export ("patternWithImage:")]
		SVGKPattern PatternWithImage (UIImage image);

		// @property (readwrite, nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// -(CGColorRef)CGColor;
		[Export ("CGColor")]
		//[Verify (MethodToProperty)]
		unsafe CGColorRef CGColor { get; }
	}

	// @interface SVGKLayeredImageView : SVGKImageView
	[BaseType (typeof(SVGKImageView))]
    interface SVGKLayeredImageView : SVGKImageView
	{
	}

	// @interface SVGKLayer : CALayer
	[BaseType (typeof(CALayer))]
	interface SVGKLayer
	{
		// @property (nonatomic, strong) SVGKImage * SVGImage;
		[Export ("SVGImage", ArgumentSemantic.Strong)]
		SVGKImage SVGImage { get; set; }

		// @property (nonatomic) BOOL showBorder;
		[Export ("showBorder")]
		bool ShowBorder { get; set; }

		// @property (nonatomic, strong) NSDate * startRenderTime;
		[Export ("startRenderTime", ArgumentSemantic.Strong)]
		NSDate StartRenderTime { get; set; }

		// @property (nonatomic, strong) NSDate * endRenderTime;
		[Export ("endRenderTime", ArgumentSemantic.Strong)]
		NSDate EndRenderTime { get; set; }
	}

	// @interface SVGTextContentElement : SVGElement <SVGStylable>
	[BaseType (typeof(SVGElement))]
	interface SVGTextContentElement : ISVGStylable
	{
		// @property (readonly, nonatomic, weak) SVGLength * textLength;
		[Export ("textLength", ArgumentSemantic.Weak)]
		SVGLength TextLength { get; }
	}

	// @interface SVGTextPositioningElement : SVGTextContentElement
	[BaseType (typeof(SVGTextContentElement))]
	interface SVGTextPositioningElement
	{
		// @property (readonly, nonatomic, strong) SVGLength * x;
		[Export ("x", ArgumentSemantic.Strong)]
		SVGLength X { get; }

		// @property (readonly, nonatomic, strong) SVGLength * y;
		[Export ("y", ArgumentSemantic.Strong)]
		SVGLength Y { get; }

		// @property (readonly, nonatomic, strong) SVGLength * dx;
		[Export ("dx", ArgumentSemantic.Strong)]
		SVGLength Dx { get; }

		// @property (readonly, nonatomic, strong) SVGLength * dy;
		[Export ("dy", ArgumentSemantic.Strong)]
		SVGLength Dy { get; }

		// @property (readonly, nonatomic, strong) SVGLength * rotate;
		[Export ("rotate", ArgumentSemantic.Strong)]
		SVGLength Rotate { get; }
	}

	// @interface SVGTextElement : SVGTextPositioningElement <SVGTransformable, ConverterSVGToCALayer>
	[BaseType (typeof(SVGTextPositioningElement))]
	interface SVGTextElement : ISVGTransformable, IConverterSVGToCALayer
	{
	}

	// @interface TinySVGTextAreaElement : SVGTextElement
	[BaseType (typeof(SVGTextElement))]
	interface TinySVGTextAreaElement
	{
		// @property (readonly, nonatomic, strong) SVGLength * width;
		[Export ("width", ArgumentSemantic.Strong)]
		SVGLength Width { get; }

		// @property (readonly, nonatomic, strong) SVGLength * height;
		[Export ("height", ArgumentSemantic.Strong)]
		SVGLength Height { get; }
	}

	// @interface SVGKit : NSObject
	[BaseType (typeof(NSObject))]
	interface SVGKit
	{
		// +(void)enableLogging;
		[Static]
		[Export ("enableLogging")]
		void EnableLogging ();
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		//// extern double SVGKitFramework_VersionNumber;
		//[Field ("SVGKitFramework_VersionNumber", "__Internal")]
		////[Export("SVGKitFramework_VersionNumber")]
		//double SVGKitFramework_VersionNumber { get; }

		//// extern const unsigned char [] SVGKitFramework_VersionString;
		//[Field ("SVGKitFramework_VersionString", "__Internal")]
		////[Export("SVGKitFramework_VersionString")]
		//[PlainString] string SVGKitFramework_VersionString { get; }
	}

	// @interface  (StyleSheetList)
	//[Category]
	//[BaseType (typeof(StyleSheetList))]
	//interface StyleSheetList_
	//{
	//	// @property (nonatomic, strong) NSMutableArray * internalArray;
	//	[Export ("internalArray", ArgumentSemantic.Strong)]
	//	NSMutableArray InternalArray { get; set; }
	//}

	// @interface  (SVGSVGElement)
	//[Category]
	//[BaseType (typeof(SVGSVGElement))]
	//interface SVGSVGElement_
	//{
	//	// @property (readwrite, nonatomic, strong) SVGLength * x;
	//	[Export ("x", ArgumentSemantic.Strong)]
	//	SVGLength X { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * y;
	//	[Export ("y", ArgumentSemantic.Strong)]
	//	SVGLength Y { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * width;
	//	[Export ("width", ArgumentSemantic.Strong)]
	//	SVGLength Width { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * height;
	//	[Export ("height", ArgumentSemantic.Strong)]
	//	SVGLength Height { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * contentScriptType;
	//	[Export ("contentScriptType", ArgumentSemantic.Strong)]
	//	string ContentScriptType { get; set; }

	//	// @property (readwrite, nonatomic, strong) NSString * contentStyleType;
	//	[Export ("contentStyleType", ArgumentSemantic.Strong)]
	//	string ContentStyleType { get; set; }

	//	// @property (readwrite, nonatomic) SVGRect viewport;
	//	[Export ("viewport", ArgumentSemantic.Assign)]
	//	SVGRect Viewport { get; set; }

	//	// @property (readwrite, nonatomic) float pixelUnitToMillimeterX;
	//	[Export ("pixelUnitToMillimeterX")]
	//	float PixelUnitToMillimeterX { get; set; }

	//	// @property (readwrite, nonatomic) float pixelUnitToMillimeterY;
	//	[Export ("pixelUnitToMillimeterY")]
	//	float PixelUnitToMillimeterY { get; set; }

	//	// @property (readwrite, nonatomic) float screenPixelToMillimeterX;
	//	[Export ("screenPixelToMillimeterX")]
	//	float ScreenPixelToMillimeterX { get; set; }

	//	// @property (readwrite, nonatomic) float screenPixelToMillimeterY;
	//	[Export ("screenPixelToMillimeterY")]
	//	float ScreenPixelToMillimeterY { get; set; }

	//	// @property (readwrite, nonatomic) BOOL useCurrentView;
	//	[Export ("useCurrentView")]
	//	bool UseCurrentView { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGViewSpec * currentView;
	//	[Export ("currentView", ArgumentSemantic.Strong)]
	//	SVGViewSpec CurrentView { get; set; }

	//	// @property (readwrite, nonatomic) float currentScale;
	//	[Export ("currentScale")]
	//	float CurrentScale { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGPoint * currentTranslate;
	//	[Export ("currentTranslate", ArgumentSemantic.Strong)]
	//	SVGPoint CurrentTranslate { get; set; }
	//}

	// @interface  (SVGUseElement)
	//[Category]
	//[BaseType (typeof(SVGUseElement))]
	//interface SVGUseElement_
	//{
	//	// @property (readwrite, nonatomic, strong) SVGLength * x;
	//	[Export ("x", ArgumentSemantic.Strong)]
	//	SVGLength X { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * y;
	//	[Export ("y", ArgumentSemantic.Strong)]
	//	SVGLength Y { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * width;
	//	[Export ("width", ArgumentSemantic.Strong)]
	//	SVGLength Width { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * height;
	//	[Export ("height", ArgumentSemantic.Strong)]
	//	SVGLength Height { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGElementInstance * instanceRoot;
	//	[Export ("instanceRoot", ArgumentSemantic.Strong)]
	//	SVGElementInstance InstanceRoot { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGElementInstance * animatedInstanceRoot;
	//	[Export ("animatedInstanceRoot", ArgumentSemantic.Strong)]
	//	SVGElementInstance AnimatedInstanceRoot { get; set; }
	//}

	// @interface  (SVGTextPositioningElement)
	//[Category]
	//[BaseType (typeof(SVGTextPositioningElement))]
	//interface SVGTextPositioningElement_
	//{
	//	// @property (readwrite, nonatomic, strong) SVGLength * x;
	//	[Export ("x", ArgumentSemantic.Strong)]
	//	SVGLength X { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * y;
	//	[Export ("y", ArgumentSemantic.Strong)]
	//	SVGLength Y { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * dx;
	//	[Export ("dx", ArgumentSemantic.Strong)]
	//	SVGLength Dx { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * dy;
	//	[Export ("dy", ArgumentSemantic.Strong)]
	//	SVGLength Dy { get; set; }

	//	// @property (readwrite, nonatomic, strong) SVGLength * rotate;
	//	[Export ("rotate", ArgumentSemantic.Strong)]
	//	SVGLength Rotate { get; set; }
	//}

	// @protocol SVGStyleCatcher <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SVGStyleCatcher
	{
		// @required -(void)styleCatchLayer:(CALayer *)styledLayer forClass:(NSString *)colorIndex;
		[Abstract]
		[Export ("styleCatchLayer:forClass:")]
		void StyleCatchLayer (CALayer styledLayer, string colorIndex);

		// @required -(UIColor *)styleCatchOverrideFill:(NSString *)fillClassName;
		[Abstract]
		[Export ("styleCatchOverrideFill:")]
		UIColor StyleCatchOverrideFill (string fillClassName);
	}

	// @interface SVGStyleElement : SVGElement
	[BaseType (typeof(SVGElement))]
	interface SVGStyleElement
	{
	}

	// @interface CGContext (SVGKImage)
	[Category]
	[BaseType (typeof(SVGKImage))]
	interface SVGKImage_CGContext
	{
		// -(CGContextRef)newCGContextAutosizedToFit;
		[Export("newCGContextAutosizedToFit")]
		//[Verify (MethodToProperty)]
		unsafe CGContextRef NewCGContextAutosizedToFit();

		// -(void)renderInContext:(CGContextRef)ctx;
		[Export ("renderInContext:")]
		unsafe void RenderInContext (CGContextRef ctx);

		// -(void)renderToContext:(CGContextRef)context antiAliased:(BOOL)shouldAntialias curveFlatnessFactor:(CGFloat)multiplyFlatness interpolationQuality:(CGInterpolationQuality)interpolationQuality flipYaxis:(BOOL)flipYaxis;
		[Export ("renderToContext:antiAliased:curveFlatnessFactor:interpolationQuality:flipYaxis:")]
		unsafe void RenderToContext (CGContextRef context, bool shouldAntialias, nfloat multiplyFlatness, CGInterpolationQuality interpolationQuality, bool flipYaxis);
	}

	// @interface SVGKSourceLocalFile : SVGKSource
	[BaseType (typeof(SVGKSource))]
	interface SVGKSourceLocalFile
	{
		// @property (nonatomic, strong) NSString * filePath;
		[Export ("filePath", ArgumentSemantic.Strong)]
		string FilePath { get; set; }

		// @property (readonly, nonatomic) BOOL wasRelative;
		[Export ("wasRelative")]
		bool WasRelative { get; }

		// +(SVGKSourceLocalFile *)sourceFromFilename:(NSString *)p;
		[Static]
		[Export ("sourceFromFilename:")]
		SVGKSourceLocalFile SourceFromFilename (string p);

		// +(SVGKSourceLocalFile *)internalSourceAnywhereInBundleUsingName:(NSString *)name;
		[Static]
		[Export ("internalSourceAnywhereInBundleUsingName:")]
		SVGKSourceLocalFile InternalSourceAnywhereInBundleUsingName (string name);

		// +(SVGKSourceLocalFile *)internalSourceAnywhereInBundle:(NSBundle *)bundle usingName:(NSString *)name;
		[Static]
		[Export ("internalSourceAnywhereInBundle:usingName:")]
		SVGKSourceLocalFile InternalSourceAnywhereInBundle (NSBundle bundle, string name);
	}

	// @interface SVGKSourceString : SVGKSource
	[BaseType (typeof(SVGKSource))]
	interface SVGKSourceString
	{
		// @property (nonatomic, strong) NSString * rawString;
		[Export ("rawString", ArgumentSemantic.Strong)]
		string RawString { get; set; }

		// +(SVGKSource *)sourceFromContentsOfString:(NSString *)rawString;
		[Static]
		[Export ("sourceFromContentsOfString:")]
		SVGKSource SourceFromContentsOfString (string rawString);
	}

	// @interface SVGKSourceURL : SVGKSource
	[BaseType (typeof(SVGKSource))]
	interface SVGKSourceURL
	{
		// @property (nonatomic, strong) NSURL * URL;
		[Export ("URL", ArgumentSemantic.Strong)]
		NSUrl URL { get; set; }

		// +(SVGKSource *)sourceFromURL:(NSURL *)u;
		[Static]
		[Export ("sourceFromURL:")]
		SVGKSource SourceFromURL (NSUrl u);
	}

	// @interface SVGKParserDefsAndUse : NSObject <SVGKParserExtension>
	//[BaseType (typeof(NSObject))]
	//interface SVGKParserDefsAndUse : ISVGKParserExtension
	//{
	//}

	// @interface SVGKParserDOM : NSObject <SVGKParserExtension>
	//[BaseType (typeof(NSObject))]
	//interface SVGKParserDOM : ISVGKParserExtension
	//{
	//}

	// @interface SVGKParserSVG : NSObject <SVGKParserExtension>
	//[BaseType (typeof(NSObject))]
	//interface SVGKParserSVG : ISVGKParserExtension
	//{
	//}

	// @interface SVGKParserGradient : SVGKParserSVG
	//[BaseType (typeof(SVGKParserSVG))]
	//interface SVGKParserGradient
	//{
	//}

	// @interface SVGKParserPatternsAndGradients : NSObject <SVGKParserExtension>
	//[BaseType (typeof(NSObject))]
	//interface SVGKParserPatternsAndGradients : ISVGKParserExtension
	//{
	//}

	// @interface SVGKParserStyles : NSObject <SVGKParserExtension>
	//[BaseType (typeof(NSObject))]
	//interface SVGKParserStyles : ISVGKParserExtension
	//{
	//}

	//// @interface SVGKPointsAndPathsParser : NSObject
	//[BaseType (typeof(NSObject))]
	//interface SVGKPointsAndPathsParser
	//{
	//	// +(void)readWhitespace:(NSScanner *)scanner;
	//	[Static]
	//	[Export ("readWhitespace:")]
	//	void ReadWhitespace (NSScanner scanner);

	//	// +(void)readCommaAndWhitespace:(NSScanner *)scanner;
	//	[Static]
	//	[Export ("readCommaAndWhitespace:")]
	//	void ReadCommaAndWhitespace (NSScanner scanner);

	//	// +(void)readCoordinate:(NSScanner *)scanner intoFloat:(CGFloat *)floatPointer;
	//	[Static]
	//	[Export ("readCoordinate:intoFloat:")]
	//	unsafe void ReadCoordinate (NSScanner scanner, nfloat* floatPointer);

	//	// +(CGPoint)readCoordinatePair:(NSScanner *)scanner;
	//	[Static]
	//	[Export ("readCoordinatePair:")]
	//	CGPoint ReadCoordinatePair (NSScanner scanner);

	//	// +(CGPoint)readMovetoDrawtoCommandGroups:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readMovetoDrawtoCommandGroups:path:relativeTo:isRelative:")]
	//	unsafe CGPoint ReadMovetoDrawtoCommandGroups (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(CGPoint)readMovetoDrawto:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readMovetoDrawto:path:relativeTo:isRelative:")]
	//	unsafe CGPoint ReadMovetoDrawto (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(CGPoint)readMoveto:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readMoveto:path:relativeTo:isRelative:")]
	//	unsafe CGPoint ReadMoveto (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(CGPoint)readMovetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readMovetoArgumentSequence:path:relativeTo:isRelative:")]
	//	unsafe CGPoint ReadMovetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(CGPoint)readLinetoCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readLinetoCommand:path:relativeTo:isRelative:")]
	//	unsafe CGPoint ReadLinetoCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(CGPoint)readLinetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readLinetoArgumentSequence:path:relativeTo:isRelative:")]
	//	unsafe CGPoint ReadLinetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(CGPoint)readVerticalLinetoCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readVerticalLinetoCommand:path:relativeTo:")]
	//	unsafe CGPoint ReadVerticalLinetoCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);

	//	// +(CGPoint)readVerticalLinetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readVerticalLinetoArgumentSequence:path:relativeTo:")]
	//	unsafe CGPoint ReadVerticalLinetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);

	//	// +(CGPoint)readHorizontalLinetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readHorizontalLinetoArgumentSequence:path:relativeTo:")]
	//	unsafe CGPoint ReadHorizontalLinetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);

	//	// +(CGPoint)readHorizontalLinetoCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readHorizontalLinetoCommand:path:relativeTo:")]
	//	unsafe CGPoint ReadHorizontalLinetoCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);

	//	// +(SVGCurve)readQuadraticCurvetoCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readQuadraticCurvetoCommand:path:relativeTo:isRelative:")]
	//	unsafe SVGCurve ReadQuadraticCurvetoCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(SVGCurve)readQuadraticCurvetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readQuadraticCurvetoArgumentSequence:path:relativeTo:isRelative:")]
	//	unsafe SVGCurve ReadQuadraticCurvetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(SVGCurve)readQuadraticCurvetoArgument:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readQuadraticCurvetoArgument:path:relativeTo:")]
	//	unsafe SVGCurve ReadQuadraticCurvetoArgument (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);

	//	// +(SVGCurve)readSmoothQuadraticCurvetoCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin withPrevCurve:(SVGCurve)prevCurve;
	//	[Static]
	//	[Export ("readSmoothQuadraticCurvetoCommand:path:relativeTo:withPrevCurve:")]
	//	unsafe SVGCurve ReadSmoothQuadraticCurvetoCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, SVGCurve prevCurve);

	//	// +(SVGCurve)readSmoothQuadraticCurvetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin withPrevCurve:(SVGCurve)prevCurve;
	//	[Static]
	//	[Export ("readSmoothQuadraticCurvetoArgumentSequence:path:relativeTo:withPrevCurve:")]
	//	unsafe SVGCurve ReadSmoothQuadraticCurvetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, SVGCurve prevCurve);

	//	// +(SVGCurve)readSmoothQuadraticCurvetoArgument:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin withPrevCurve:(SVGCurve)prevCurve;
	//	[Static]
	//	[Export ("readSmoothQuadraticCurvetoArgument:path:relativeTo:withPrevCurve:")]
	//	unsafe SVGCurve ReadSmoothQuadraticCurvetoArgument (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, SVGCurve prevCurve);

	//	// +(SVGCurve)readCurvetoCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readCurvetoCommand:path:relativeTo:isRelative:")]
	//	unsafe SVGCurve ReadCurvetoCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(SVGCurve)readCurvetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin isRelative:(BOOL)isRelative;
	//	[Static]
	//	[Export ("readCurvetoArgumentSequence:path:relativeTo:isRelative:")]
	//	unsafe SVGCurve ReadCurvetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, bool isRelative);

	//	// +(SVGCurve)readCurvetoArgument:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readCurvetoArgument:path:relativeTo:")]
	//	unsafe SVGCurve ReadCurvetoArgument (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);

	//	// +(SVGCurve)readSmoothCurvetoCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin withPrevCurve:(SVGCurve)prevCurve;
	//	[Static]
	//	[Export ("readSmoothCurvetoCommand:path:relativeTo:withPrevCurve:")]
	//	unsafe SVGCurve ReadSmoothCurvetoCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, SVGCurve prevCurve);

	//	// +(SVGCurve)readSmoothCurvetoArgumentSequence:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin withPrevCurve:(SVGCurve)prevCurve;
	//	[Static]
	//	[Export ("readSmoothCurvetoArgumentSequence:path:relativeTo:withPrevCurve:")]
	//	unsafe SVGCurve ReadSmoothCurvetoArgumentSequence (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, SVGCurve prevCurve);

	//	// +(SVGCurve)readSmoothCurvetoArgument:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin withPrevCurve:(SVGCurve)prevCurve;
	//	[Static]
	//	[Export ("readSmoothCurvetoArgument:path:relativeTo:withPrevCurve:")]
	//	unsafe SVGCurve ReadSmoothCurvetoArgument (NSScanner scanner, CGMutablePathRef* path, CGPoint origin, SVGCurve prevCurve);

	//	// +(SVGCurve)readEllipticalArcArguments:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readEllipticalArcArguments:path:relativeTo:")]
	//	unsafe SVGCurve ReadEllipticalArcArguments (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);

	//	// +(CGPoint)readCloseCommand:(NSScanner *)scanner path:(CGMutablePathRef)path relativeTo:(CGPoint)origin;
	//	[Static]
	//	[Export ("readCloseCommand:path:relativeTo:")]
	//	unsafe CGPoint ReadCloseCommand (NSScanner scanner, CGMutablePathRef* path, CGPoint origin);
	//}

	// @interface SVGKSourceNSData : SVGKSource
	[BaseType (typeof(SVGKSource))]
	interface SVGKSourceNSData
	{
		// @property (nonatomic, strong) NSData * rawData;
		[Export ("rawData", ArgumentSemantic.Strong)]
		NSData RawData { get; set; }

		// @property (nonatomic, strong) NSURL * effectiveURL;
		[Export ("effectiveURL", ArgumentSemantic.Strong)]
		NSUrl EffectiveURL { get; set; }

		// +(SVGKSource *)sourceFromData:(NSData *)data URLForRelativeLinks:(NSURL *)url;
		[Static]
		[Export ("sourceFromData:URLForRelativeLinks:")]
		SVGKSource SourceFromData (NSData data, NSUrl url);
	}

	// @interface SVGSwitchElement : SVGElement <ConverterSVGToCALayer>
	[BaseType (typeof(SVGElement))]
	interface SVGSwitchElement : IConverterSVGToCALayer
	{
		// @property (readonly, nonatomic, strong) NodeList * visibleChildNodes;
		[Export ("visibleChildNodes", ArgumentSemantic.Strong)]
		NodeList VisibleChildNodes { get; }
	}

	// @interface SVGKFastImageView : SVGKImageView
	[BaseType (typeof(SVGKImageView))]
	interface SVGKFastImageView
	{
		// -(id)initWithSVGKImage:(SVGKImage *)im;
		[Export("initWithSVGKImage:")]
		IntPtr Constructor(SVGKImage im);

		// @property (nonatomic) CGSize tileRatio;
		[Export ("tileRatio", ArgumentSemantic.Assign)]
		CGSize TileRatio { get; set; }

		// @property (nonatomic) BOOL disableAutoRedrawAtHighestResolution;
		[Export ("disableAutoRedrawAtHighestResolution")]
		bool DisableAutoRedrawAtHighestResolution { get; set; }

		// +(BOOL)svgImageHasNoGradients:(SVGKImage *)image;
		[Static]
		[Export ("svgImageHasNoGradients:")]
		bool SvgImageHasNoGradients (SVGKImage image);

		// +(BOOL)svgElementAndDescendentsHaveNoGradients:(SVGElement *)element;
		[Static]
		[Export ("svgElementAndDescendentsHaveNoGradients:")]
		bool SvgElementAndDescendentsHaveNoGradients (SVGElement element);
	}
}
