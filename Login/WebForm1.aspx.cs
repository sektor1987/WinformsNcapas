using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OracleClient;
using DAL;
using BLL;

namespace Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            BLL.UsuarioBLL user = new UsuarioBLL();
            int UserName = Int32.Parse(TextBox_user_name.Text.Trim());
            string Password = TextBox_password.Text.Trim();

            Tuple<int, string> busqueda = user.getById(UserName);



            if (busqueda.Item1 !=null && busqueda.Item2==Password)
            {
                Session["UserName"] = user.nomberUsuario(UserName);
                Response.Redirect("Bienvenido.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Login Fallido')", true);
            }
            
            
        }
    }
}