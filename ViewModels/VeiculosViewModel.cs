using ConsultaVeiculos.Models;
using ConsultaVeiculos.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConsultaVeiculos.ViewModels
{
    public class VeiculosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _marca;
        public string Marca
        {
            get => _marca;
            set{
                if (_marca != value)
                {
                    _marca = value;
                    NotifyPropertyChanged("Marca");
                }
            }
        }

        public ObservableCollection<Veiculos> Veiculos { get; set; }

        public ICommand BuscarVeiculos {  get; set; }

        public VeiculosViewModel() 
        {
            BuscarVeiculos = new RelayCommand(ObterVeiculos);
        }

        public void ObterVeiculos(object obj)
        {
            var veiculosList = new Veiculos().ObterVeiculos(Marca);
            Veiculos = new ObservableCollection<Veiculos>(veiculosList as List<Veiculos>);
            NotifyPropertyChanged("Veiculos");
        }

        public void NotifyPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
