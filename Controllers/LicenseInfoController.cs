using GoogleSheetsWrapper;
using Microsoft.AspNetCore.Mvc;

namespace LicenseManager
{
    [Route("/licenseInfo")]
    [ApiController]
    public class LicenseInfoController : ControllerBase
    {
        CredantialsRepository Repo { get; set; }
        public LicenseInfoController(CredantialsRepository repo)
        {
            Repo = repo;
        }
        [HttpGet]
        public IActionResult GetRowCellValue(Guid licKey, string _cellName)
        {
            object cellName;
            if (!Enum.TryParse(typeof(LicenseInfoCellName), _cellName, out cellName))
                throw new Exception("Не верное имя ячейки.");//return BadRequest("Не верное имя ячейки.");

            cellName = Enum.Parse(typeof(CredentialsCellName), _cellName);
            object cellValue = Repo.GetRowCellValue(licKey.ToString(), (CredentialsCellName)cellName);
            return Ok(cellValue);
        }
        [HttpPost]
        public IActionResult SetCurrentThreadsCell(Guid licKey, int threads)
        {
            Repo.SetRowCellValue(licKey.ToString(), CredentialsCellName.CurrentThreads, threads);
            return Ok();
        }
    }
}