using Microsoft.Maui.Controls;
using System.Globalization;
using VozDelEsteMaui3.ViewModels;

namespace VozDelEsteMaui3.Vistas;

public partial class AgregarPatrocinador : ContentPage
{
    private readonly AgregarPatrocinadorViewModel _agregarPatrocinadorViewModel;

    public AgregarPatrocinador(AgregarPatrocinadorViewModel agregarPatrocinadorViewModel)
    {
        _agregarPatrocinadorViewModel = agregarPatrocinadorViewModel;

        InitializeComponent();
        BindingContext = _agregarPatrocinadorViewModel;
        var htmlSource = new HtmlWebViewSource
        {
            Html = @"<!DOCTYPE html>
<html>
<head>
  <meta charset='utf-8' />
  <title>Leaflet Map</title>
  <link rel='stylesheet' href='https://unpkg.com/leaflet/dist/leaflet.css' />
  <style>
    #map { height: 100vh; width: 100vw; }
  </style>
</head>
<body>
  <div id='map'></div>
  <script src='https://unpkg.com/leaflet/dist/leaflet.js'></script>
  <script>
    var map = L.map('map').setView([-34.9, -54.95], 13);
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      attribution: '© OpenStreetMap contributors'
    }).addTo(map);
let currentMarker = null;

map.on('click', function(e) {
  // Eliminar el marcador anterior si existe
  if (currentMarker) {
    map.removeLayer(currentMarker);
  }

  // Crear nuevo marcador y guardarlo
  currentMarker = L.marker(e.latlng)
    .addTo(map)
    .bindPopup('Ubicación seleccionada: ' + e.latlng.toString())
    .openPopup();

  // Comunicar la ubicación al WebView
  window.location.href = 'leaflet://location?lat=' + e.latlng.lat + '&lng=' + e.latlng.lng;
});

  </script>
</body>
</html>"
        };
        LeafletWebView.Source = htmlSource;

        LeafletWebView.Navigating += (s, e) =>
        {
            if (e.Url.StartsWith("leaflet://location"))
            {
                e.Cancel = true;
                var query = System.Web.HttpUtility.ParseQueryString(new Uri(e.Url).Query);
                var querylat = query["lat"];
                var querylng = query["lng"];
                double lat = double.Parse(querylat, CultureInfo.InvariantCulture);
                double lng = double.Parse(querylng, CultureInfo.InvariantCulture);

                _agregarPatrocinadorViewModel.GuardarUbicacionPatrocinador(lat, lng);
            }
        };

    }


}