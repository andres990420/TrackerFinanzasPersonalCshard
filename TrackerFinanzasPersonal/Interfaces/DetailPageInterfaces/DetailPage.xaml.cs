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

namespace TrackerFinanzasPersonal.Interfaces.DetailPageInterfaces
{
    /// <summary>
    /// Interaction logic for DetailPage.xaml
    /// </summary>
    public partial class DetailPage : UserControl
    {
        public DetailPage()
        {
            InitializeComponent();

            MovimientosGastos listaGastos = new();

            listaGastos.categoria = "Comida";
            listaGastos.fecha = "10/20/2024";
            listaGastos.monto = 50.10;
            listaGastos.descripcion = "Cena de graduacion";

            dataGridGastos.Items.Add(listaGastos);

            MovimientosIngresos listaIngresos = new();

            listaIngresos.fecha = listaGastos.fecha;
            listaIngresos.categoria = "Sueldo y Salarios";
            listaIngresos.monto = 20.22;
            listaIngresos.descripcion = "Venta de comida";

            dataGridIngresos.Items.Add(listaIngresos);
        }

        public class MovimientosGastos
        {

            public string fecha { get; set; }
            public string categoria { get; set; }
            public double monto { set; get; }
            public string descripcion { set; get; }

        }

        public class MovimientosIngresos
        {
            public string fecha { get; set; }
            public string categoria { get; set; }
            public double monto { set; get; }
            public string descripcion { set; get; }
        }
    }
}
