using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace proyectoluisitacomunica
{
    public partial class DetalleMetricaPage : ContentPage
    {
        private string tipoMetrica;

        public DetalleMetricaPage(string metrica, Color color)
        {
            InitializeComponent();
            tipoMetrica = metrica;

            Title = $"Métrica: {metrica}";
            lblTituloHistorial.Text = $"Historial de {metrica}";
            lblTituloHistorial.TextColor = color;

            txtValor.Placeholder = $"Nuevo valor ({metrica})";
            btnGuardar.BackgroundColor = color;
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                await DisplayAlert("Validación", "El campo no puede estar vacío.", "OK");
                return;
            }

            await DisplayAlert("Éxito", "Cambios guardados correctamente.", "OK");
            await Navigation.PopAsync();
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}