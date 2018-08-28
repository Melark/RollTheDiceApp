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

    public ICommand RollDiceCommand
    {
      get
      {
        return new Command(()=> 
        {
          ApplyAnimation();
          NumberRolled = RollDice(1, 6); // TODO: Make dice type dynamic - Not just a 6 sided die
        });
      }
    }

    private void ApplyAnimation()
    {
      // TODO: Add Rotation effect
    }

    private int RollDice(int min, int max)
    {
      return _random.Next(min, max + 1);
    }
  }
}
