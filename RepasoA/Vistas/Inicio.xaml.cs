namespace RepasoA.Vistas;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked_1(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;

		Navigation.PushAsync(new Vistas.Vistas2(usuario));
    }
}