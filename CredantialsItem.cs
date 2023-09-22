using GoogleSheetsWrapper;

namespace LicenseManager
{
    public class CredentialsItem
    {
        public CredentialsItem() { }
        public string Key { get; set; }
        public string TG { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int IssuedDays { get; set; }
        public int LastDays { get; set; }
        public int IssuedThreads { get; set; }
        public int CurrentThreads { get; set; }
        public string FingerPrint { get; set; }
        public string WinName { get; set; }
        public string WinVer { get; set; }
        public string DeviceCode { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string CpuName { get; set; }
        public string CpuCode { get; set; }
        public int Cpus { get; set; }
        public string BoardName { get; set; }
        public string BoardCode { get; set; }
        public int Boards { get; set; }
        public string HddCode { get; set; }
    }
}
