using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Curso_csharp.Classes
{

    public class IRoles
    {
        List_Roles list_Roles;

        public IRoles(List_Roles _list_Roles)
        {
            this.list_Roles = _list_Roles;
        }
        public Guid Id;

        public List<string> Roles = new List<string>();
            
        public void Valor()
        {
            Id = Id = new Guid("210dc302-31de-4539-8767-874878e8101e");
            Roles = list_Roles.ListaRoles;
        }

        
    }

}
 