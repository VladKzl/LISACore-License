using GoogleSheetsWrapper;

namespace LicenseManager
{
    public class CredantialsItem
    {
        public CredantialsItem() { }
        public string Key { get; set; }
        public string TG { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IssuedDays { get; set; }
        public int LastDays { get; set; }
        public int IssuedTreads { get; set; }
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
        public string BoaedCode { get; set; }
        public int Boards { get; set; }
        public string HddCode { get; set; }
    }
}
