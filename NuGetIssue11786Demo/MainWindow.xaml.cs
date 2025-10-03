using System.Windows;

namespace NuGetIssue11786Demo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var socketType = typeof(NetMQ.Sockets.RequestSocket);
        var bitmapType = typeof(System.Drawing.Bitmap);
        var cipherDataType = typeof(System.Security.Cryptography.Xml.CipherData);
        
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (var x in assemblies.Select(x => x.GetName()).OrderBy(x => x.Name))
        {
            textBox.AppendText($"{x.Name} {x.Version}\n");
        }
    }
}