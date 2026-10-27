using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var manager = new DownloadManager();

        manager.DownloadCompleted += (_, _) =>
        {
            Console.WriteLine("Download concluído!");
        };

        manager.Download();
    }
}

public class DownloadManager
{
    public event EventHandler? DownloadCompleted;

    public void Download()
    {
        Console.WriteLine("Download iniciado...");
        Thread.Sleep(2000);

        DownloadCompleted?.Invoke(this, EventArgs.Empty);
    }
}
