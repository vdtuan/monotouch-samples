// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_SharedResources.Screens.iPhone.Battery {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("BatteryStatusScreen")]
	public partial class BatteryStatusScreen {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIProgressView __mt_barBatteryLevel;
		
		private UIKit.UILabel __mt_lblBatteryState;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("barBatteryLevel")]
		private UIKit.UIProgressView barBatteryLevel {
			get {
				this.__mt_barBatteryLevel = ((UIKit.UIProgressView)(this.GetNativeField("barBatteryLevel")));
				return this.__mt_barBatteryLevel;
			}
			set {
				this.__mt_barBatteryLevel = value;
				this.SetNativeField("barBatteryLevel", value);
			}
		}
		
		[Foundation.Connect("lblBatteryState")]
		private UIKit.UILabel lblBatteryState {
			get {
				this.__mt_lblBatteryState = ((UIKit.UILabel)(this.GetNativeField("lblBatteryState")));
				return this.__mt_lblBatteryState;
			}
			set {
				this.__mt_lblBatteryState = value;
				this.SetNativeField("lblBatteryState", value);
			}
		}
	}
}
