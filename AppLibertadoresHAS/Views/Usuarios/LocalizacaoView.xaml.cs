using AppLibertadoresHAS.ViewModels;

namespace AppLibertadoresHAS.Views.Usuarios;

public partial class LocalizacaoView : ContentPage
{
	LocalizacaoViewModel viewModel;
	public LocalizacaoView()
	{
		InitializeComponent();

		viewModel = new LocalizacaoViewModel();
		viewModel.InicializarMapa();

		BindingContext = viewModel;
	}
}