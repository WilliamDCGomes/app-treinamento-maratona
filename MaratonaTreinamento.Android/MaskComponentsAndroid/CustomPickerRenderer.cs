using Android.Graphics.Drawables;
using MaratonaTreinamento.Droid.MaskComponentsAndroid;
using MaratonaTreinamento.FormattingClass;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace MaratonaTreinamento.Droid.MaskComponentsAndroid
{
    [System.Obsolete]
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}
