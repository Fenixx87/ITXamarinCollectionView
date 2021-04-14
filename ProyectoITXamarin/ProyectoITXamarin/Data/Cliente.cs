using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProyectoITXamarin.DataModel
{

    public class Cliente
    {
        string name;
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
            }
        }

        public Cliente(string name, string ruc, string codigo)
        {
            Name = name;
            Ruc = ruc;
            Codigo = codigo;
        }
        public string Ruc { get; set; }
        public string Codigo { get; set; }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        public List<Cliente> Clientes { get; }
        Cliente selectedCliente;
        public Cliente SelectedCliente
        {
            get { return selectedCliente; }
            set
            {
                if (selectedCliente != value)
                {
                    selectedCliente = value;
                }
            }
        }

        public ViewModel()
        {
            Clientes = new List<Cliente>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}