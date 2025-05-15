using Microsoft.Extensions.Configuration;

namespace Skyware.Vitosha.Model.Demo;

public class ConfigHelper
{

    public static IConfiguration BuildConfig()
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);
        builder.AddUserSecrets<Program>();
        return builder.Build();
    }

}
