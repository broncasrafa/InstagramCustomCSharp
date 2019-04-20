using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram.Core.Classes;

namespace Instagram.Core.API.Builder
{
    public class InstagramCustomApiBuilder : IInstagramCustomApiBuilder
    {
        private UserSessionData _user;

        private InstagramCustomApiBuilder()
        {
        }

        public static IInstagramCustomApiBuilder CreateBuilder()
        {
            return new InstagramCustomApiBuilder();
        }

        public IInstagramCustomApi Build()
        {
            if (_user == null)
                throw new ArgumentNullException("User auth data must be specified");

            var instagramCustomApi = new InstagramCustomApi(_user);
            return instagramCustomApi;
        }

        public IInstagramCustomApiBuilder SetUser(UserSessionData user)
        {
            _user = user;
            return this;
        }
    }
}
