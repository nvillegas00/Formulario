using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Formulario
{
    public partial class Formulario2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (!IsPostBack)
            {
                ds.ReadXml(Server.MapPath("Ciudades.xml"));//va leer un archivo xml
                ddlpersona.DataSource = ds;//vamos a llamar el DropList
                ddlpersona.DataValueField = "idNombre";//vamos a cargar las variables-Se pasa el texto de XML
                ddlpersona.DataTextField = "nombreCiudad";//me va mostrar el nombre del campo
                ddlpersona.DataBind();//Mostrar o cargar. o enlazar los datos. 
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtNacimiento.Text = "";
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Session["documento"] = txtDocumento.Text;
            Session["nombre"] = txtNombre.Text;
            Session["apellidos"] = txtApellidos.Text;
            Session["direccion"] = txtDireccion.Text;
            Session["telefono"] = txtTelefono.Text;
            Session["correo"] = txtCorreo.Text;
            Session["nacimiento"] = txtNacimiento.Text;

            Session["combo"] = ddlpersona.SelectedItem.ToString();
            if (rbNatural.Checked==true)
            {
                Session["persona"] = " Natural"; 
            }
            if (rbJuridico.Checked==true)
            {
                Session["persona"] = " Juridica";
            }
            Response.Redirect("Formulario1.aspx");
        }
    }
}