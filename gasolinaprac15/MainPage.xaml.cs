using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
namespace gasolinaprac15;

//<Summary>
//<Createddate>16/7/2023</createddate>
//<company>INDEL</company>
//<lastmodificationdate>17/7/2023</lastmodificationdate>
//<lastmodificationdescription>
// Construya un programa en MAUI que solucione el siguiente problema que tienen en una gasolinera.
// Los surtidores de la misma registran lo que surten en galones,
// pero el precio de la gasolina esta fijado en litros, el programa debe calcular lo que hay que cobrarle al cliente.
//</lastmodificationdescription>
//<lastmodifierautor> Maycol Barrera </lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{
    private const double LitrosPorGalon = 3.78541; // Factor de conversión de galones a litros
   

    public MainPage()
    {
        InitializeComponent();
    }


    private void Button_Clicked(object sender, EventArgs e)
    {

        double precioPorLitros = Convert.ToDouble(PrecioPorLitros.Text);

        if (double.TryParse(GallonsEntry.Text, out double galones))
        {
         
            double litros = galones * LitrosPorGalon;

            double totalPrice = litros * precioPorLitros;
            ResultLabel.Text = $"Cantidad a cobrar: {totalPrice.ToString("C")}";

        }
                 else
                {
                    DisplayAlert("Error", "Introduce los datos solicitados", "Ok");

                }
            }
        }
    
    

