using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    class Program
    {
        static void Main(string[] args)
        {

            Entities_ contexto = new Entities_();
            
            //var rsptaa = contexto.PKG_MANTENEDOR_USUARIO_SP_AGREGAR_USUARIO(1234, "ORTUZAR", "OYANEDEL", "JEFE", "1313", "4234", "DIRECCION", 1001, "CC@CC.CL", "CARGUITO");
            ////contexto.p(12345, "asd", "asd", "asd", "gdf", "asdad", "asdsad", 1001, "af", "af");
            //contexto.SaveChanges();
            //UsuarioBLL ubl = new UsuarioBLL();
            ////int registrarUsuario = ubl.agregarUsuario(1233, "Ortuzar", "oyanedel", "carmelo", "123123", "321312", "direccion", 1001, "cortuzar@asd.cl", "jefe");
            ////int loginUser = ubl.validarLoginUsuario(1234, "1234");
           
            //if (loginUser == 1)
            //{
            //    Console.WriteLine("registrado");
            //}
            //else {
            //    Console.WriteLine("no registrado");

            //}
            //foreach (var item in tes3.ToList())
            //{
            //    item.ToString();
            //}

        }
    }
}
