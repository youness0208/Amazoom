using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Dashboard
    {
        private CD_Dashboard objCapaDato = new CD_Dashboard();
        public DashBoard VerDashBoard()
        {
            return objCapaDato.VerDashBoard();
        }
        public List<Ventas> Ventas(string fechainicio, string fechafin, string idtransaccion)
        {
            return objCapaDato.Ventas(fechainicio, fechafin, idtransaccion);
        }
    }
}
