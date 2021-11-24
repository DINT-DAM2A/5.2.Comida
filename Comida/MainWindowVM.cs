using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            ListaPlatos = Plato.GetSamples("FotosPlatos/");

            listaTiposComida = new ObservableCollection<string>();
            listaTiposComida.Add("China");
            listaTiposComida.Add("Americana");
            listaTiposComida.Add("Mexicana");

            hayPlatoSeleccionado = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Plato> listaPlatos;
        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set
            {
                listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }

        private ObservableCollection<string> listaTiposComida;
        public ObservableCollection<string> ListaTiposComida
        {
            get { return listaTiposComida; }
            set
            {
                listaTiposComida = value;
                NotifyPropertyChanged("ListaTiposComida");
            }
        }

        private Plato platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                HayPlatoSeleccionado = true;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        private bool hayPlatoSeleccionado;
        public bool HayPlatoSeleccionado
        {
            get { return hayPlatoSeleccionado; }
            set
            { 
                hayPlatoSeleccionado = value;
                NotifyPropertyChanged("HayPlatoSeleccionado");
            }
        }

        public void LimpiarSeleccion()
        {
            PlatoSeleccionado = null;
            HayPlatoSeleccionado = false;
        }

    }
}
