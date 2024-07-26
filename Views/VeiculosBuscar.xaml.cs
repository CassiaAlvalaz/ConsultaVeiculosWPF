using ConsultaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConsultaVeiculos.Views
{
    /// <summary>
    /// Interação lógica para VeiculosBuscar.xam
    /// </summary>
    public partial class VeiculosBuscar : Page
    {
        public VeiculosBuscar()
        {
            InitializeComponent();
            DataContext = new VeiculosViewModel();
        }
    }
}
