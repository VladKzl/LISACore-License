using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Google.Apis.Sheets.v4.Data;
using GoogleSheetsWrapper;
using LicenseManager.Extentions;
using System;
using static LicenseManager.Extentions.CredentialsExtentions;


namespace LicenseManager
{
    public class CredantialsRepository : SheetHelper
    {
        public CredantialsRepository(string spreadsheetID, string serviceAccountEmail, string tabName)
        : base(spreadsheetID, serviceAccountEmail, tabName) 
        {
            Range = $"{tabName}!A1:X10000";
            GoogleSecretsJson = File.ReadAllText("lisacore-license-451e3c997521.json");

            Init(GoogleSecretsJson);
        }
        public string GoogleSecretsJson;
        public string Range;
        private (IList<object> row, int index) GetRow(string licKey)
        {
            var rows = GetRows(new SheetRange(Range));

            rows.Remove(rows.First());
            if (!rows.Any(x => x[GetCellIndex(CredentialsCellName.Key).number].ToString() == licKey))
                throw new Exception("Не валидный лицензионный ключ. Введите валидный или преобретите новый.");

            var row = rows.Single(x => x[GetCellIndex(CredentialsCellName.Key).number].ToString() == licKey);
            return (row, rows.IndexOf(row) + 2);
        }
        public object GetRowCellValue(string licKey, CredentialsCellName cellName)
        {
            IList<object> row = GetRow(licKey).row;
            return row[GetCellIndex(cellName).number];
        }
        public void SetRowCellValue(string licKey, CredentialsCellName cellName, object newValue)
        {
            int rowIndex = GetRow(licKey).index;
            string cellLeter = GetCellIndex(cellName).letter;
            string cellRange = GetCellRange(cellLeter, rowIndex);

            List<BatchUpdateRequestObject> updates = new();
            updates.Add(new BatchUpdateRequestObject()
            {
                Range = new SheetRange(cellRange),
                Data = new CellData()
                {
                    UserEnteredValue = new ExtendedValue()
                    {
                        StringValue = newValue.ToString()
                    }
                }
            });
            BatchUpdate(updates);
        }
    }
}
