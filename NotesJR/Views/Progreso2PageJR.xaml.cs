namespace NotesJR.Views;

public partial class Progreso2PageJR : ContentPage
{
	public Progreso2PageJR()
	{
		InitializeComponent();
	}

    private void CalcularButton_Clicked(object sender, EventArgs e)
    {
        string text = TextEditorProgreso2.Text;

        // Contadores para el tipo de caracteres
        int letras = 0;
        int mayusculas = 0;
        int minusculas = 0;
        int numeros = 0;
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                letras++;
                if (char.IsUpper(c))
                    mayusculas++;
                else
                    minusculas++;
            }
            else if (char.IsDigit(c))
            {
                numeros++;
            }
        }
        CountLabel.Text = $"Letras: {letras}, Mayúsculas: {mayusculas}, Minúsculas: {minusculas}, Números: {numeros}";


    }
    private async void BorrarButton_Clicked(object sender, EventArgs e)
    {
        CountLabel.Text = "Letras: 0, Mayúsculas: 0, Minúsculas: 0, Números: 0";
    }
}