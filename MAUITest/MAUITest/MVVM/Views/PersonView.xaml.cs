using MAUITest.MVVM.Models;
using Sales.Mobile.MVVM.ViewModels;

namespace MAUITest.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
            BindingContext = new PersonViewModel();
    }

  }
