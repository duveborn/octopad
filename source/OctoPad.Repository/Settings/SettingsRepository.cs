using OctoPad.Models;

namespace OctoPad.Repository.Settings
{
    public class SettingsRepository : ISettingsRepository
    {
        public LoginCredentials LoginCredentials
        {
            get
            {
                return new LoginCredentials
                {
                    Server = Properties.Settings.Default.Server,
                    ApiKey = Properties.Settings.Default.ApiKey
                };
            }
            set
            {
                Properties.Settings.Default.Server = value.Server;
                Properties.Settings.Default.ApiKey = value.ApiKey;
                Properties.Settings.Default.Save();
            }
        }
    }
}