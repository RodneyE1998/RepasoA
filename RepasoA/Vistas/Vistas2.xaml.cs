namespace RepasoA.Vistas;

public partial class Vistas2 : ContentPage
{
	public Vistas2(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text= "Bienvenido "+ usuario;
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

    }
}