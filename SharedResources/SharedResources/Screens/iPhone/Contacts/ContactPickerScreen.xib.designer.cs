// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_SharedResources.Screens.iPhone.Contacts {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("ContactPickerScreen")]
	public partial class ContactPickerScreen {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIButton __mt_btnChooseContact;
		
		private UIKit.UILabel __mt_lblFirstName;
		
		private UIKit.UILabel __mt_lblLastName;
		
		private UIKit.UIButton __mt_btnViewSelectedContact;
		
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
		
		[Foundation.Connect("btnChooseContact")]
		private UIKit.UIButton btnChooseContact {
			get {
				this.__mt_btnChooseContact = ((UIKit.UIButton)(this.GetNativeField("btnChooseContact")));
				return this.__mt_btnChooseContact;
			}
			set {
				this.__mt_btnChooseContact = value;
				this.SetNativeField("btnChooseContact", value);
			}
		}
		
		[Foundation.Connect("lblFirstName")]
		private UIKit.UILabel lblFirstName {
			get {
				this.__mt_lblFirstName = ((UIKit.UILabel)(this.GetNativeField("lblFirstName")));
				return this.__mt_lblFirstName;
			}
			set {
				this.__mt_lblFirstName = value;
				this.SetNativeField("lblFirstName", value);
			}
		}
		
		[Foundation.Connect("lblLastName")]
		private UIKit.UILabel lblLastName {
			get {
				this.__mt_lblLastName = ((UIKit.UILabel)(this.GetNativeField("lblLastName")));
				return this.__mt_lblLastName;
			}
			set {
				this.__mt_lblLastName = value;
				this.SetNativeField("lblLastName", value);
			}
		}
		
		[Foundation.Connect("btnViewSelectedContact")]
		private UIKit.UIButton btnViewSelectedContact {
			get {
				this.__mt_btnViewSelectedContact = ((UIKit.UIButton)(this.GetNativeField("btnViewSelectedContact")));
				return this.__mt_btnViewSelectedContact;
			}
			set {
				this.__mt_btnViewSelectedContact = value;
				this.SetNativeField("btnViewSelectedContact", value);
			}
		}
	}
}
