using System.Configuration;

namespace Amido.Testing.Social.Twitter.Configuration
{
    public class TwitterUserConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("userName", IsKey = true, IsRequired = true)]
        public string UserName
        {
            get
            {
                return this["userName"].ToString();
            }
            set
            {
                this["userName"] = value;
            }
        }

        [ConfigurationProperty("email", IsKey = true, IsRequired = true)]
        public string Email
        {
            get
            {
                return this["email"].ToString();
            }
            set
            {
                this["email"] = value;
            }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password
        {
            get
            {
                return this["password"].ToString();
            }
            set
            {
                this["password"] = value;
            }
        }
    }
}