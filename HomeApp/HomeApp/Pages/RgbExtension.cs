using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    public class RgbExtension : IMarkupExtension
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Xamarin.Forms.Color.FromRgb(Red, Green, Blue);
        }
    }
}
