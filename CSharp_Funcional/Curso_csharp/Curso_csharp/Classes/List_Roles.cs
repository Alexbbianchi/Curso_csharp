using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Curso_csharp.Classes
{
    public class List_Roles
    {

        public List<string> ListaRoles = new List<string>() {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8" 
        };
        
        public List<string> ListRolesCompare = new List<string>() {
            "A4",
            "A6",
            "A8" 
        };

        public string File_Cliente = "Manuel";
        public string License_Cliente = "Manuel";



        public List_Roles()
        {

        }
    }

}
 