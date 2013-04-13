using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bizobj
{
    public class User
    {
        public string Name { get; set; }

        public List<UserAuthorization> UserAuthorizations { get; set; }
    }
    public class UserAuthorization
    {
        public Authorizations Authorization { get; set; }

        public enum Authorizations
        {
            Admin,
            UserAdmin,
            FormEdit,
            FormApprove,
            QARInitiate,
            QARDisposition
        }
    }
    public class MenuItem
    {
        public string DisplayName { get; set; }
        public string SiteURL { get; set; }

    }
}
