using Login.ViewModels;

namespace Login.Views;

public partial class LoginPageView : ContentPage
{
	public LoginPageView()
	{
		InitializeComponent();
		this.BindingContext = new LoginPageViewModel();
	}
}