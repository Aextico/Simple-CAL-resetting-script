using Microsoft.Win32;
using System.Diagnostics;
void ExecuteAsAdmin(string fileName)
{
    Process proc = new Process();
    proc.StartInfo.FileName = fileName;
    proc.StartInfo.UseShellExecute = true;
    proc.StartInfo.Verb = "runas";
    proc.Start();
}
System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName("mstsc");
if (proc.Length > 0)
{
    proc[0].Kill();
}
Registry.LocalMachine.DeleteSubKeyTree(@"SOFTWARE\Microsoft\MSLicensing\HardwareID");
Registry.LocalMachine.DeleteSubKeyTree(@"SOFTWARE\Microsoft\MSLicensing\Store");
ExecuteAsAdmin("mstsc.exe");



