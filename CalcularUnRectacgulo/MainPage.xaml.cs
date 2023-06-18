namespace CalcularUnRectacgulo;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	//Creamos dos variables y las multiplicamos
    private void calcular_Clicked(object sender, EventArgs e)
    {
		var ValorB = Convert.ToInt32(basen.Text);
		var ValorA = Convert.ToInt32(altura.Text);
		double cal = ValorB * ValorA;
		respuesta.Text = Convert.ToString(cal);
    }
}

