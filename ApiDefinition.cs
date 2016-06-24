using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace YQLSDK
{
	interface IYQL {}

	[BaseType (typeof(NSObject))]
	interface YQL{
		[Export("query:")]
		NSDictionary Query (string query);
	}
}

