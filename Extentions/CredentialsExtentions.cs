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
                case CredentialsCellName.IssuedTreads:
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
                case CredentialsCellName.Manufacture:
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
                case CredentialsCellName.BoaedCode:
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
        public static List<CredantialsItem> MapToItem(IList<IList<object>> values)
        {
            var items = new List<CredantialsItem>();
            foreach (var value in values)
            {
                CredantialsItem item = new()
                {
                    TG = value[GetCellIndex(CredentialsCellName.TG).number].ToString(),
                    T = value[1].ToString(),
                    Category = value[2].ToString(),
                    Price = value[3].ToString()
                };
                items.Add(item);
            }
            return items;
        }
        public static IList<IList<object>> MapFormItem(CredantialsItem item)
        {
            var objectList = new List<object>() { item.Id, item.Name, item.Category, item.Price };
            var rangeData = new List<IList<object>> { objectList };
            return rangeData;
        }
    }
}
