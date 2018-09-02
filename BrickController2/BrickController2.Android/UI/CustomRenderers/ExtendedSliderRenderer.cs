﻿using Android.Content;
using BrickController2.Droid.UI.CustomRenderers;
using BrickController2.UI.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedSlider), typeof(ExtendedSliderRenderer))]
namespace BrickController2.Droid.UI.CustomRenderers
{
    public class ExtendedSliderRenderer : SliderRenderer
    {
        public ExtendedSliderRenderer(Context context) : base(context)
        {
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            if (Control == null)
            {
                return;
            }

            var extendedSlider = (ExtendedSlider)Element;

            Control.StartTrackingTouch += (sender, args) => extendedSlider.TouchDown();
            Control.StopTrackingTouch += (sender, args) => extendedSlider.TouchUp();
        }
    }
}