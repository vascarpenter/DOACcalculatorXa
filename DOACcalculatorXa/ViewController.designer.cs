// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DOACcalculatorXa
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ageField { get; set; }

		[Outlet]
		AppKit.NSTextField bodyHeightField { get; set; }

		[Outlet]
		AppKit.NSTextField bodyWeightField { get; set; }

		[Outlet]
		AppKit.NSTextField BSAField { get; set; }

		[Outlet]
		AppKit.NSTextField CcrField { get; set; }

		[Outlet]
		AppKit.NSTextField eGFRField { get; set; }

		[Outlet]
		AppKit.NSTextField eliquisField { get; set; }

		[Outlet]
		AppKit.NSButton femaleRadioButton { get; set; }

		[Outlet]
		AppKit.NSTextField lixianaField { get; set; }

		[Outlet]
		AppKit.NSButton maleRadioButton { get; set; }

		[Outlet]
		AppKit.NSTextField prazaxaField { get; set; }

		[Outlet]
		AppKit.NSTextField renalStageField { get; set; }

		[Outlet]
		AppKit.NSTextField sCrField { get; set; }

		[Outlet]
		AppKit.NSTextField xareltoField { get; set; }

		[Action ("buttonTapped:")]
		partial void buttonTapped (Foundation.NSObject sender);

		[Action ("radioGroupClicked:")]
		partial void radioGroupClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ageField != null) {
				ageField.Dispose ();
				ageField = null;
			}

			if (bodyHeightField != null) {
				bodyHeightField.Dispose ();
				bodyHeightField = null;
			}

			if (bodyWeightField != null) {
				bodyWeightField.Dispose ();
				bodyWeightField = null;
			}

			if (BSAField != null) {
				BSAField.Dispose ();
				BSAField = null;
			}

			if (CcrField != null) {
				CcrField.Dispose ();
				CcrField = null;
			}

			if (eGFRField != null) {
				eGFRField.Dispose ();
				eGFRField = null;
			}

			if (eliquisField != null) {
				eliquisField.Dispose ();
				eliquisField = null;
			}

			if (femaleRadioButton != null) {
				femaleRadioButton.Dispose ();
				femaleRadioButton = null;
			}

			if (lixianaField != null) {
				lixianaField.Dispose ();
				lixianaField = null;
			}

			if (maleRadioButton != null) {
				maleRadioButton.Dispose ();
				maleRadioButton = null;
			}

			if (prazaxaField != null) {
				prazaxaField.Dispose ();
				prazaxaField = null;
			}

			if (renalStageField != null) {
				renalStageField.Dispose ();
				renalStageField = null;
			}

			if (sCrField != null) {
				sCrField.Dispose ();
				sCrField = null;
			}

			if (xareltoField != null) {
				xareltoField.Dispose ();
				xareltoField = null;
			}
		}
	}
}
