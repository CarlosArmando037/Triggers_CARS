using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CARS_Triggers
{
    public class BotonTrigger : TriggerAction<Button>
    {
        protected override void Invoke(Button btn)
        {
            btn.BackgroundColor = Color.DarkOrange;
            btn.Text = "Here we go!!!";
        }
    }
}
