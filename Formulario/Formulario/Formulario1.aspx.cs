using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formulario
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDocumento.Text = Session["documento"].ToString();
            lblNombre.Text = Session["nombre"].ToString();
            lblApellidos.Text = Session["nombre"].ToString();
            lblDireccion.Text = Session["nombre"].ToString();
            lblTelefono.Text = Session["nombre"].ToString();
            lblCorreo.Text = Session["nombre"].ToString();
            lblNacimiento.Text = Session["nombre"].ToString();

        }
    }
}