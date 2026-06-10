using Microsoft.Maui.Controls;
using Microcharts;
using SkiaSharp;
using System;

namespace proyectoluisitacomunica
{
    public partial class MainPage : ContentPage
    {
        private int pasosActuales = 4250;

        public MainPage()
        {
            InitializeComponent();
            ConfigurarGraficoAnillos();
        }

        private void ConfigurarGraficoAnillos()
        {
            var entradasGrafico = new[]
            {
                new ChartEntry(180) { Color = SKColor.Parse("#FF4500"), Label = "Movimiento" },
                new ChartEntry(15) { Color = SKColor.Parse("#7FFF00"), Label = "Ejercicio" },
                new ChartEntry(8) { Color = SKColor.Parse("#00FFFF"), Label = "De Pie" }
            };

            chartAnillos.Chart = new RadialGaugeChart
            {
                Entries = entradasGrafico,
                BackgroundColor = SKColors.Transparent,
                LabelTextSize = 30f,
                LineSize = 22f
            };
        }

        private async void OnPerfilClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Perfil", "ID Huawei: Luisa_2026\nSincronizado correctamente.", "Ok");
        }

        private void OnSimularPasoClicked(object sender, EventArgs e)
        {
            pasosActuales += 250;
            lblPasosContador.Text = $"{pasosActuales} / 10,000 pasos";
        }

        private async void OnMetricaTapped(object sender, TappedEventArgs e)
        {
            string tipoMetrica = e.Parameter as string;

            Color colorTematico = tipoMetrica switch
            {
                "Corazón" => Colors.Red,
                "Sueño" => Colors.MediumPurple,
                "SpO2" => Colors.DeepSkyBlue,
                _ => Colors.LightGreen
            };

            await Navigation.PushAsync(new DetalleMetricaPage(tipoMetrica, colorTematico));
        }
    }
}
