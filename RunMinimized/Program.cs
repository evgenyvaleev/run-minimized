using System.Diagnostics;

var processInfo = new ProcessStartInfo
{
    FileName = args[0],
    WindowStyle = ProcessWindowStyle.Minimized
};

Process.Start(processInfo);