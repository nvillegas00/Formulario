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
            lblApellidos.Text = Session["apellidos"].ToString();
            lblDireccion.Text = Session["direccion"].ToString();
            lblTelefono.Text = Session["telefono"].ToString();
            lblCorreo.Text = Session["correo"].ToString();
            lblNacimiento.Text = Session["nacimiento"].ToString();
            lblPersona.Text = Session["persona"].ToString();
            lblCiudades.Text = Session["combo"].ToString();

        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario2.aspx");
        }
    }
}