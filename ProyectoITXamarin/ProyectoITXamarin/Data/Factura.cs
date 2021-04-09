using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ProyectoITXamarin.Data
{
    public class Factura : ModelObject
    {
        string codigo;
        string nombreEmpresa;
        string fecha;
        string name;
        public Factura()
        {
            this.codigo = "";
            this.nombreEmpresa = "";
            this.fecha = "";
            this.name = "";
        }
        public Factura(string codigo, string nombreEmpresa, string fecha, string name)
        {
            this.codigo = codigo;
            this.nombreEmpresa = nombreEmpresa;
            this.fecha = fecha;
            this.name = name;
        }
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (codigo != value)
                {
                    codigo = value;
                    RaisePropertyChanged("Codigo");
                }
            }
        }
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set
            {
                if (nombreEmpresa != value)
                {
                    nombreEmpresa = value;
                    RaisePropertyChanged("NombreEmpresa");
                }
            }
        }
        public string Fecha
        {
            get { return fecha; }
            set
            {
                if (fecha != value)
                {
                    fecha = value;
                    RaisePropertyChanged("Fecha");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
    }
    public class ModelObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string nombreEmpresa)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nombreEmpresa));
        }
    }
}
