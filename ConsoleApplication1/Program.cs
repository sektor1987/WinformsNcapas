using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Entidades contexto = new Entidades();
                TBL_USUARIO usuario = new TBL_USUARIO();
                TBL_ROL rol = new TBL_ROL();
                 //idRol = Convert.ToInt16(contexto.TBL_ROL.Max(u => u.ID_ROL));
                //user.ID = id+1;
                //usuario.RUT_USUARIO = 166485606;
                //usuario.NOMBRE = "CAMILO";
                //usuario.AP_PATERNO = "BOSS";
                //usuario.AP_MATERNO = "BOSS";
                //usuario.DIR_PARTICULAR = "HELL 666";
                //usuario.PASSWORD = "macoy123";
                //rol.ID_ROL = idRol;
                rol.NOMBRE_ROL = "rolsito";
                rol.DESC_ROL = "es un rol muy loco";
                //agregamos el objeto
               // contexto.TBL_USUARIO.Add(usuario); //Deshabilitado xq faltan datos en tablas relacionadas :V
                contexto.TBL_ROL.Add(rol);
                //guardamos cambios
                contexto.SaveChanges();
                Console.WriteLine("insertado");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                try
                {
                    Console.WriteLine(((ex.InnerException).InnerException).Message);
                    Console.ReadKey();
                }
                catch (Exception ex2)
                {
                    
                    Console.WriteLine(ex2.ToString());
                    Console.ReadKey();
                }
              
            }
   
        }
    }
}
