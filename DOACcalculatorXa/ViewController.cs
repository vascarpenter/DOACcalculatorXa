using System;

using AppKit;
using Foundation;

namespace DOACcalculatorXa
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        partial void radioGroupClicked(Foundation.NSObject sender)
        {   // radio groupを作るためのダミーaction
        }

        partial void buttonTapped(Foundation.NSObject sender)
        {
            double height = bodyHeightField.DoubleValue;
            double weight = bodyWeightField.DoubleValue;
            double age = ageField.DoubleValue;
            double crea = sCrField.DoubleValue;
            double egfr = 194 * Math.Pow(age, -0.287) * Math.Pow(crea, -1.094);
            double bsa = 0.007184 * Math.Pow(weight, 0.425) * Math.Pow(height, 0.725);
            if (femaleRadioButton.State == NSCellStateValue.On)
                egfr *= 0.739;
            double gfr = egfr * bsa;
            CcrField.StringValue = $"{gfr:0.0}";
            BSAField.StringValue = $"{bsa:0.0}";
            eGFRField.StringValue = $"{egfr:0.0}";

            string stage = "";
            if (egfr >= 90)
                stage = "正常";
            else if (egfr >= 60)
                stage = "軽度腎障害";
            else if (egfr >= 30)
                stage = "中等度腎障害";
            else if (egfr >= 15)
                stage = "高度腎障害";
            else
                stage = "末期腎不全";
            renalStageField.StringValue = stage;

            // プラザキサ
            if (gfr >= 50 && age < 70)
                stage = "75mg 4C / 2xMA";
            else if (gfr >= 30 || age >= 70)
                stage = "110mg 2C / 2xMA";
            else
                stage = "非推奨";
    
            prazaxaField.StringValue = stage;

            // イグザレルト
            if (gfr >= 50) stage = "15mg 1T / 1xM";
            else if (gfr >= 30) stage = "10mg 1T / 1xM";
            else if (gfr >= 15) stage = "10mg 1T / 1xM 慎重投与";
            else stage = "非推奨";

            xareltoField.StringValue = stage;

            // エリキュース
            int check = 0;
            if (age >= 80) check++; 
            if (weight <= 60) check++;
            if (crea >= 1.5) check++;

            if (gfr < 15)
                stage = "非推奨";
            else if (check >= 2)
                stage = "2.5mg 2T / 2xMA";
            else
                stage = "5mg 2T / 2xMA";
            eliquisField.StringValue = stage;

            // リクシアナ
            if (weight >= 60 && gfr >= 50)
                stage = "60mg 1T / 1xM";
            else if (gfr >= 30)
                stage = "30mg 1T / 1xM";
            else if (gfr >= 15)
                stage = "30mg 1T / 1xM 慎重投与";
            else
                stage = "非推奨";
            lixianaField.StringValue = stage;

        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
