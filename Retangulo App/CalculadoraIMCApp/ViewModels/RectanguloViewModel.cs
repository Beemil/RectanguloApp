using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RectanguloApp.Models;
using System.Globalization;

namespace RectanguloApp.ViewModels
{
    public partial class RectanguloViewModel : ObservableObject
    {
        // Campos privados con guion bajo
        [ObservableProperty]
        private string _baseText;

        [ObservableProperty]
        private string _alturaText;

        [ObservableProperty]
        private string _resultado;


        [RelayCommand]
        private void CalcularArea()
        {
            if (double.TryParse(_baseText, out double b) &&
                double.TryParse(_alturaText, out double h))
            {
                var rectangulo = new Rectangulo { Base = b, Altura = h };
                Resultado = $"El área es: {rectangulo.Base * rectangulo.Altura}";
            }
            else
            {
                Resultado = "Por favor ingrese valores válidos.";
            }
        }
    }
}

