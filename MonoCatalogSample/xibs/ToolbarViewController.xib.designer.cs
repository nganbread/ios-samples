﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
[MonoTouch.Foundation.Register("ToolbarViewController")]
public partial class ToolbarViewController {

	private MonoTouch.UIKit.UIView __mt_view;

	private MonoTouch.UIKit.UISegmentedControl __mt_barStyleSegControl;

	private MonoTouch.UIKit.UISegmentedControl __mt_buttonItemStyleSegControl;

	private MonoTouch.UIKit.UIPickerView __mt_systemButtonPicker;

	private MonoTouch.UIKit.UISwitch __mt_tintSwitch;

	#pragma warning disable 0169
	[MonoTouch.Foundation.Export("toggleStyle:")]
	partial void toggleStyle (MonoTouch.UIKit.UISegmentedControl sender);

	[MonoTouch.Foundation.Export("toggleBarStyle:")]
	partial void toggleBarStyle (MonoTouch.UIKit.UISegmentedControl sender);

	[MonoTouch.Foundation.Export("toggleTintColor:")]
	partial void toggleTintColor (MonoTouch.UIKit.UISwitch sender);

	[MonoTouch.Foundation.Connect("view")]
	private MonoTouch.UIKit.UIView view {
		get {
			this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
			return this.__mt_view;
		}
		set {
			this.__mt_view = value;
			this.SetNativeField("view", value);
		}
	}

	[MonoTouch.Foundation.Connect("barStyleSegControl")]
	private MonoTouch.UIKit.UISegmentedControl barStyleSegControl {
		get {
			this.__mt_barStyleSegControl = ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("barStyleSegControl")));
			return this.__mt_barStyleSegControl;
		}
		set {
			this.__mt_barStyleSegControl = value;
			this.SetNativeField("barStyleSegControl", value);
		}
	}

	[MonoTouch.Foundation.Connect("buttonItemStyleSegControl")]
	private MonoTouch.UIKit.UISegmentedControl buttonItemStyleSegControl {
		get {
			this.__mt_buttonItemStyleSegControl = ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("buttonItemStyleSegControl")));
			return this.__mt_buttonItemStyleSegControl;
		}
		set {
			this.__mt_buttonItemStyleSegControl = value;
			this.SetNativeField("buttonItemStyleSegControl", value);
		}
	}

	[MonoTouch.Foundation.Connect("systemButtonPicker")]
	private MonoTouch.UIKit.UIPickerView systemButtonPicker {
		get {
			this.__mt_systemButtonPicker = ((MonoTouch.UIKit.UIPickerView)(this.GetNativeField("systemButtonPicker")));
			return this.__mt_systemButtonPicker;
		}
		set {
			this.__mt_systemButtonPicker = value;
			this.SetNativeField("systemButtonPicker", value);
		}
	}

	[MonoTouch.Foundation.Connect("tintSwitch")]
	private MonoTouch.UIKit.UISwitch tintSwitch {
		get {
			this.__mt_tintSwitch = ((MonoTouch.UIKit.UISwitch)(this.GetNativeField("tintSwitch")));
			return this.__mt_tintSwitch;
		}
		set {
			this.__mt_tintSwitch = value;
			this.SetNativeField("tintSwitch", value);
		}
	}
}
