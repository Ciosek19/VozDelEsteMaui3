using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VozDelEsteMaui3.Modelos;

namespace VozDelEsteMaui3.ViewModels
{
   public class AgregarPatrocinadorViewModel : ObservableObject
   {
      public Coordenadas UbicacionSeleccionada { get; set; }

      public ICommand ValidarUbicacionCommand { get; }


      public AgregarPatrocinadorViewModel()
      {

      }
   }
}

