using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Encuestas.Core.Model
{
    public class Persona :INotifyPropertyChanged
    {
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        private string pais;

        public string Pais
        {
            get { return pais; }
            set
            {
                pais = value;
                OnPropertyChanged("Pais");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

       
    }
}
