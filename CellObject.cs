using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Reflection.Emit;
using System.Reflection;
using DocumentFormat.OpenXml.Office2019.Drawing.Model3D;

namespace LicenseManager
{
    public class CredentialsCellObject
    {
        public enum CellIndexType
        {
            String,
            Int
        }
        public CredentialsCellName Name { get; set; }
        public string Value { get; set; }
        public string NewValue { get; set; }
        public int RowIndex { get; set; }
        public string Range { get; set; }
/*        public static string CreateRange(CredentialsCellName cellName, int rowIndex)
        {
            string model = "{0}{1}:{0}{1}";
            switch (cellName)
            {
                case CredentialsCellName.TG:
                    return string.Format(model, "A", rowIndex);
                case CredentialsCellName.StartDate:
                case CredentialsCellName.EndDate:
                case CredentialsCellName.IssuedDays:
                case CredentialsCellName.LastDays:
                case CredentialsCellName.IssuedThreads:
                case CredentialsCellName.CurrentThreads:
                case CredentialsCellName.FingerPrint:
                case CredentialsCellName.WinName:
                case CredentialsCellName.WinVer:
                case CredentialsCellName.DeviceCode:
                case CredentialsCellName.Name:
                case CredentialsCellName.Manufacture:
                case CredentialsCellName.Model:
                case CredentialsCellName.CpuName:
                case CredentialsCellName.CpuCode:
                case CredentialsCellName.Cpus:
                case CredentialsCellName.BoardName:
                case CredentialsCellName.BoardCode:
                case CredentialsCellName.Boards:
                case CredentialsCellName.HddCode:
            }
        }*/
        
    }
}
