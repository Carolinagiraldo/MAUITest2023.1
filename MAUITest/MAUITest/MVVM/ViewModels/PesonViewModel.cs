


using MAUITest.BindingDemo;

namespace Sales.Mobile.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Carolina Giraldo",
                Age = 48,
                IsMarried = true,
                BirthDate = new DateTime(1974, 9, 23),
                Weight = 89,
                LunchTime = new TimeSpan(10, 0, 0)

            };
        }

        public Person Person { get; set; }
    }
}
