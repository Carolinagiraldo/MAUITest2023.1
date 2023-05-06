namespace MAUITest.BindingDemo;

public partial class BindingDemo1 : ContentPage
{
	public BindingDemo1()
	{
		InitializeComponent();
	}
    public void btnOk_Clicked(Object sender, EventArgs e)
    {
        var person = new Person
        {
            Name = "Carolina Giraldo",
            Phone = "322 311 4620",
            Address = "Calle Luna Calle Sol"
        };

        var personBinding = new Binding();
        personBinding.Source = person;
        personBinding.Path = "Name";

        lblName.SetBinding(Label.TextProperty, personBinding);

    }

}