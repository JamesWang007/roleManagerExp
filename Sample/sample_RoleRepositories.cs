using Commencement_Mvc_Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.Repositories
{
    public class RoleRepositories : Repository<Roles>
    {
        public string[] GetByEmplid(string emplid)
        {
            return (
                from p in this.Set
                where p.Emplid == emplid
                select p.RoleName
                    ).ToArray();
        }
         

        public string[] GetAllRoles()
        {
            return (
                from p in this.Set
                select p.RoleName
                ).Distinct().ToArray();
        }
    }
}
