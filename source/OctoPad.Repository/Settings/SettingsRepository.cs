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
                    ApiKey = Properties.Settings.Default.ApiKey,
                    Username = Properties.Settings.Default.Username,
                    Password = EncryptionHelper.DecryptString(Properties.Settings.Default.Password)
                };
            }
            set
            {
                Properties.Settings.Default.Server = value.Server;
                Properties.Settings.Default.ApiKey = value.ApiKey;
                Properties.Settings.Default.Username = value.Username;
                Properties.Settings.Default.Password = EncryptionHelper.EncryptString(value.Password);

                Properties.Settings.Default.Save();
            }
        }
    }
}