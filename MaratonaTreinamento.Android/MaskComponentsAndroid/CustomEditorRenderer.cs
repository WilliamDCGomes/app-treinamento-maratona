using Android.Graphics.Drawables;
using MaratonaTreinamento.Droid.MaskComponentsAndroid;
using MaratonaTreinamento.FormattingClass;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace MaratonaTreinamento.Droid.MaskComponentsAndroid
{
    [System.Obsolete]
    public class CustomEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}
