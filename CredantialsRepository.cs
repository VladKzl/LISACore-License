using DocumentFormat.OpenXml.Spreadsheet;
using GoogleSheetsWrapper;

namespace LicenseManager
{
    public class CredantialsRepository : SheetHelper
    {
        public CredantialsRepository(string spreadsheetID, string serviceAccountEmail, string tabName)
        : base(spreadsheetID, serviceAccountEmail, tabName) 
        {
            Init(GoogleSecretsJson);
        }
        public string GoogleSecretsJson = File.ReadAllText("lisacore-license-451e3c997521.json");
        private List<string> GetRowValues(string licKey)
        {
            var allRows = GetRows(new SheetRange(TabName, 1, 1, 1000, 1000*1000));
            return new List<string>();
        }
    }
}
