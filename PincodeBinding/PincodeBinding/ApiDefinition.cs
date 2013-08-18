using System;
using MonoTouch;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PincodeBinding {



	[BaseType(typeof(NSObject))]
	[Model]
	public partial interface CPLockControllerDelegate {

		[Export ("lockController:didFinish:")]
		void DidFinish (CPLockController lockController, string passcode);

		[Export ("lockControllerDidCancel:")]
		void  DidCancel (CPLockController lockController);

		[Export ("lockController:shouldAcceptPasscode:")]
		bool ShouldAcceptPasscode (CPLockController lockController, string passcode);
	}

	[BaseType (typeof (UIViewController))]
	public partial interface CPLockController { // : UITextFieldDelegate {

		[Export ("delegate", ArgumentSemantic.Assign)]
		IntPtr @Delegate { get; set; }

		[Export ("title", ArgumentSemantic.Copy)]
		string Title { get; set; }

		[Export ("style")]
		CPLockControllerStyle Style { get; set; }

		[Export ("passcode", ArgumentSemantic.Retain)]
		string Passcode { get; set; }

		[Export ("prompt", ArgumentSemantic.Retain)]
		string Prompt { get; set; }

		[Export ("hideCode")]
		bool HideCode { get; set; }
	}
}
