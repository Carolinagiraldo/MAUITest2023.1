using MAUITest.MVVM.ViewModels;

namespace MAUITest.MVVM.Views;

public partial class DemoAutoPropertyChangedView : ContentPage
{
	public DemoAutoPropertyChangedView()
	{
		InitializeComponent();
        BindingContext = new DemoAutoPropertyChangedViewModel();
    }
}