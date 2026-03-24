namespace Inicial;

public partial class TabbedPagina : TabbedPage
{
	public TabbedPagina()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		DisplayAlert("Radiobutton", $"Cambió: {e.Value}", "Aceptar");
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblSlider.Text = slider.Value.ToString();
    }
}