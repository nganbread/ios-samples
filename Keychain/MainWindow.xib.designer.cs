// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Keychain {

	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[Foundation.Register("AppDelegate")]
	public partial class AppDelegate {

		private UIKit.UIWindow __mt_window;

		#pragma warning disable 0169
		[Foundation.Connect("window")]
		private UIKit.UIWindow window {
			get {
				this.__mt_window = ((UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
	}
}
