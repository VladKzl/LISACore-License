using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Reflection.Emit;
using System.Reflection;

namespace LicenseManager.Extentions
{
    public static class CredentialsExtentions
    {
        public static (string letter, int number) GetCellIndex(CredentialsCellName cellName)
        {
            (string letter, int number) index = new();
            switch (cellName)
            {
                case CredentialsCellName.Key:
                    index.number = 0;
                    index.letter = "A";
                    break;
                case CredentialsCellName.TG:
                    index.number = 1;
                    index.letter = "B";
                    break;
                case CredentialsCellName.StartDate:
                    index.number = 2;
                    index.letter = "C";
                    break;
                case CredentialsCellName.EndDate:
                    index.number = 3;
                    index.letter = "D";
                    break;
                case CredentialsCellName.IssuedDays:
                    index.number = 4;
                    index.letter = "E";
                    break;
                case CredentialsCellName.LastDays:
                    index.number = 5;
                    index.letter = "F";
                    break;
                case CredentialsCellName.IssuedThreads:
                    index.number = 6;
                    index.letter = "G";
                    break;
                case CredentialsCellName.CurrentThreads:
                    index.number = 7;
                    index.letter = "H";
                    break;
                case CredentialsCellName.FingerPrint:
                    index.number = 8;
                    index.letter = "I";
                    break;
                case CredentialsCellName.WinName:
                    index.number = 9;
                    index.letter = "J";
                    break;
                case CredentialsCellName.WinVer:
                    index.number = 10;
                    index.letter = "K";
                    break;
                case CredentialsCellName.DeviceCode:
                    index.number = 11;
                    index.letter = "L";
                    break;
                case CredentialsCellName.Name:
                    index.number = 12;
                    index.letter = "M";
                    break;
                case CredentialsCellName.Manufacturer:
                    index.number = 13;
                    index.letter = "N";
                    break;
                case CredentialsCellName.Model:
                    index.number = 14;
                    index.letter = "O";
                    break;
                case CredentialsCellName.CpuName:
                    index.number = 15;
                    index.letter = "P";
                    break;
                case CredentialsCellName.CpuCode:
                    index.number = 16;
                    index.letter = "Q";
                    break;
                case CredentialsCellName.Cpus:
                    index.number = 17;
                    index.letter = "R";
                    break;
                case CredentialsCellName.BoardName:
                    index.number = 18;
                    index.letter = "S";
                    break;
                case CredentialsCellName.BoardCode:
                    index.number = 19;
                    index.letter = "T";
                    break;
                case CredentialsCellName.Boards:
                    index.number = 20;
                    index.letter = "U";
                    break;
                case CredentialsCellName.HddCode:
                    index.number = 21;
                    index.letter = "V";
                    break;
            }
            return index;
        }
        public static string GetCellRange(string cellLetter, int rowIndex)
        {
            return $"{cellLetter}{rowIndex}:{cellLetter}{rowIndex}";
        }
        public static List<CredentialsItem> MapToItems(this IList<IList<object>> values)
        {
            List<CredentialsItem> items = new();
            foreach (IList<object> value in values)
            {
                CredentialsItem item = new()
                {
                    Key = value[GetCellIndex(CredentialsCellName.Key).number].ToString(),
                    TG = value[GetCellIndex(CredentialsCellName.TG).number].ToString(),
                    StartDate = value[GetCellIndex(CredentialsCellName.StartDate).number].ToString(),
                    EndDate = value[GetCellIndex(CredentialsCellName.EndDate).number].ToString(),
                    IssuedDays = (int)value[GetCellIndex(CredentialsCellName.IssuedDays).number],
                    LastDays = (int)value[GetCellIndex(CredentialsCellName.LastDays).number],
                    IssuedThreads = (int)value[GetCellIndex(CredentialsCellName.IssuedThreads).number],
                    CurrentThreads = (int)value[GetCellIndex(CredentialsCellName.CurrentThreads).number],
                    FingerPrint = value[GetCellIndex(CredentialsCellName.FingerPrint).number].ToString(),
                    WinName = value[GetCellIndex(CredentialsCellName.WinName).number].ToString(),
                    WinVer = value[GetCellIndex(CredentialsCellName.WinVer).number].ToString(),
                    DeviceCode = value[GetCellIndex(CredentialsCellName.DeviceCode).number].ToString(),
                    Name = value[GetCellIndex(CredentialsCellName.Name).number].ToString(),
                    Manufacturer = value[GetCellIndex(CredentialsCellName.Manufacturer).number].ToString(),
                    Model = value[GetCellIndex(CredentialsCellName.Model).number].ToString(),
                    CpuName = value[GetCellIndex(CredentialsCellName.CpuName).number].ToString(),
                    CpuCode = value[GetCellIndex(CredentialsCellName.CpuCode).number].ToString(),
                    Cpus = (int)value[GetCellIndex(CredentialsCellName.Cpus).number],
                    BoardName = value[GetCellIndex(CredentialsCellName.BoardName).number].ToString(),
                    BoardCode = value[GetCellIndex(CredentialsCellName.BoardCode).number].ToString(),
                    Boards = (int)value[GetCellIndex(CredentialsCellName.Boards).number],
                    HddCode = value[GetCellIndex(CredentialsCellName.HddCode).number].ToString(),
                };
                items.Add(item);
            }
            return items;
        }
        public static IList<IList<object>> MapFromItems(this CredentialsItem item)
        {
            var objectList = new List<object>() 
            {
                item.Key,
                item.TG,
                item.StartDate,
                item.EndDate,
                item.IssuedDays,
                item.LastDays,
                item.IssuedThreads,
                item.CurrentThreads,
                item.FingerPrint,
                item.WinName,
                item.WinVer,
                item.DeviceCode,
                item.Name,
                item.Manufacturer,
                item.Model,
                item.CpuName,
                item.CpuCode,
                item.Cpus,
                item.BoardName,
                item.BoardCode,
                item.Boards,
                item.HddCode
            };
            var rangeData = new List<IList<object>> { objectList };
            return rangeData;
        }
    }
}
