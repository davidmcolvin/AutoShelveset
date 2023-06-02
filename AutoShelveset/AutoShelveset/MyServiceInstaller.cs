using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

[RunInstaller(true)]
public class MyServiceInstaller : Installer
{
  public MyServiceInstaller()
  {
    var serviceProcessInstaller = new ServiceProcessInstaller();
    var serviceInstaller = new ServiceInstaller();

    // Set the service account to the current user
    serviceProcessInstaller.Account = ServiceAccount.User;

    // Set the username and password
    serviceProcessInstaller.Username = "xxxx\\xxxx";
    serviceProcessInstaller.Password = "xxxxxx";

    // Configure the service installer
    serviceInstaller.ServiceName = "AutoShelveset";
    serviceInstaller.DisplayName = "Auto Shelveset Service";
    serviceInstaller.Description = "Auto Creates Shelveset";
    serviceInstaller.StartType = ServiceStartMode.Automatic;

    // Add the installers to the installer collection
    Installers.Add(serviceProcessInstaller);
    Installers.Add(serviceInstaller);
  }
}
