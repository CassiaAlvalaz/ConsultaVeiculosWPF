using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaVeiculos.Models
{
    public class Veiculos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }

        public List<Veiculos> ObterVeiculos()
        {
            List<Veiculos> listaVeiculos = new List<Veiculos>()
            {
                new Veiculos { Id = 1, Nome = "FORD FIESTA", Modelo = "1.0 MPI PERSONNALITÉ SEDAN 4P", Ano = 2005 },
                new Veiculos { Id = 2, Nome = "HONDA CRV", Modelo = "2.0 LX 4X2 16V 4P", Ano = 2018 },
                new Veiculos { Id = 3, Nome = "LAND ROVER DISCOVERY 4", Modelo = "3.0 SE 4X4 V6 24V BI-TURBO 4P", Ano = 2021 }
            };

            return listaVeiculos;
        }

        public List<Veiculos> ObterVeiculos(string filtro)
        {
            var listaFiltrada = from c in ObterVeiculos()
                                where c.Nome.ToUpper().Contains(filtro.ToUpper())
                                select c;


            return listaFiltrada.ToList();
        }
    }
}
