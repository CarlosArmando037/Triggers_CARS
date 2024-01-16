using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CARS_Triggers
{
    internal class Deslizadorcolor : TriggerAction<Slider>
    {
        protected override void Invoke(Slider sender)
        {
            var value = sender.Value;

            if (value < 40)
                sender.BackgroundColor = Color.Red;
            else if (value > 60)
                sender.BackgroundColor = Color.Green;
            else
                sender.BackgroundColor = Color.Black;
        }
    }
}
