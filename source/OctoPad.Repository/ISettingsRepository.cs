using OctoPad.Models;

namespace OctoPad.Repository
{
    public interface ISettingsRepository
    {
        LoginCredentials LoginCredentials { get; set; }
    }
}