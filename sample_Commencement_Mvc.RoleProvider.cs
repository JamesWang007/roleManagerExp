using Chico.Security;
using Commencement_Mvc_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Commencement_Mvc
{
    public class CMRoleProvider : RoleProvider
    {
        public static string UserId { get; set; }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            // get all roles
            using (var roleRepositories = new RoleRepositories())
            {
                var roles = roleRepositories.GetAllRoles();
                if (roles == null)
                {
                    return null;
                }
                return roles.ToArray();
            }
        }

        public override string[] GetRolesForUser(string username)
        {
            // get roles for user
            if (UserId == null)
            {
                return null;
            }
            using (var roleRepositories = new RoleRepositories())
            {
                var role = roleRepositories.GetByEmplid(UserId);
                if (role == null)
                {
                    return null;
                }
                return role.ToArray();
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string userId, string roleName)
        {
            using (var roleRepositories = new RoleRepositories())
            {
                var role = roleRepositories.GetByEmplid(userId);
                //var user = roleRepositories.Users.SingleOrDefault(u => u.UserName == username);
                if (role == null)
                    return false;
                return role != null && role.Any(r => r == roleName);
            }
        }

        public bool IsUserInRole(string roleName)
        {
            return IsUserInRole("004690674", roleName);
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
