using Lottie.Forms;
using Xamarin.Forms;

namespace RollTheDiceApp.Behaviors
{
  public static class AnimationBehavior
  {
    public static readonly BindableProperty PlayAnimationProperty =
      BindableProperty.Create("PlayAnimation",
                  typeof(bool),
                  typeof(AnimationBehavior),
                  false,
                  propertyChanged:OnPlayAnimationPropertyChanged);

    public static bool GetPlayAnimationProperty(BindableObject bindable, bool oldValue, bool newValue)
    {
      return (bool)bindable.GetValue(PlayAnimationProperty);
    }


    public static void SetPlayAnimationPropery(BindableObject bindable, bool oldValue, bool newValue)
    {
      bindable.SetValue(PlayAnimationProperty, newValue);
    }

    static void OnPlayAnimationPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
      var animationView = bindable as AnimationView;
      if (animationView == null)
      {
        return;
      }

      if ((bool)newValue)
      {
        animationView.Play();
      }
    }

  }
}
