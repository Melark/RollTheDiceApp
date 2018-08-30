using RollTheDiceApp.ViewModels.Base;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace RollTheDiceApp.ViewModels
{
  public class RollDicePageViewModel : BaseViewModel
  {
    Random _random = new Random();


    private int numberRolled;
    public int NumberRolled
    {
      get => numberRolled;
      set
      {
        numberRolled = value;
        OnPropertyChanged();
      }
    }

    private bool isDisplayLabelVisible = true;
    public bool IsDisplayLabelVisible
    {
      get => isDisplayLabelVisible;
      set
      {
        isDisplayLabelVisible = value;
        OnPropertyChanged();
      }
    }

    private bool isAnimationViewVisible;
    public bool IsAnimationViewVisible
    {
      get => isAnimationViewVisible;
      set
      {
        isAnimationViewVisible = value;
        OnPropertyChanged();
      }
    }


    private bool isAnimationPlaying;
    public bool IsAnimationPlaying
    {
      get => isAnimationPlaying;
      set
      {
        isAnimationPlaying = value;
        OnPropertyChanged();
      }
    }

    public ICommand RollDiceCommand
    {
      get
      {
        return new Command(()=> 
        {
          ApplyAnimation();
        });
      }
    }

    public ICommand AnimationCompletedCommand {
      get
      {
        return new Command(()=> {
          IsDisplayLabelVisible = true;
          NumberRolled = RollDice(1, 6); // TODO: Make dice type dynamic - Not just a 6 sided die
          //IsAnimationViewVisible = false;
          IsAnimationPlaying = false;

        });
      }
    }

    private void ApplyAnimation()
    {
      IsDisplayLabelVisible = false;
      IsAnimationViewVisible = true;
      IsAnimationPlaying = true;
    }

    private int RollDice(int min, int max)
    {
      return _random.Next(min, max + 1);
    }
  }
}
