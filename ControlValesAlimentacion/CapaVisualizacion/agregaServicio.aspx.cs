using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaVisualizacion
{
    public partial class agregaServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombreServicio = this.nombreDelServicio.Text;
            string nombrePerfil = this.DropDownList1.Text;
            int valorServicio = Convert.ToInt32(this.valorDelServicio.Text);
            //DateTime horaInicio = 

        }
    }
}