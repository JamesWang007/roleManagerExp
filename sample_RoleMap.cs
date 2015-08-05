using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings
{
    public class RoleMap : ClassMap<Roles>
    {
        public RoleMap()
        {
            Id(x => x.Emplid);
            Map(p => p.RoleName, "role_name");
            Map(p => p.RoleId, "roleid");
            Table("graduation_role_vw");
            SchemaAction.None();
        }
    }
}
