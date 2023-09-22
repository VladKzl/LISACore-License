using Microsoft.AspNetCore.Mvc;

namespace LicenseManager
{

    [Route("/pcInfo")]
    [ApiController]
    public class PcInfoController : ControllerBase
    {
        CredantialsRepository Repo { get; set; }
        public PcInfoController(CredantialsRepository repo)
        {
            Repo = repo;
        }
        [HttpGet]
        public IActionResult GetRowCellValue(Guid licKey, string _cellName)
        {
            object cellName;
            if (!Enum.TryParse(typeof(PcInfoCellName), _cellName, out cellName))
                throw new Exception("Не верное имя ячейки.");//return BadRequest("Не верное имя ячейки.");

            cellName = Enum.Parse(typeof(CredentialsCellName), _cellName);
            object cellValue = Repo.GetRowCellValue(licKey.ToString(), (CredentialsCellName)cellName);
            return Ok(cellValue);
        }
        [HttpPost]
        public IActionResult SetRowCellValue(Guid licKey, string _cellName, string cellValue)
        {
            object cellName;
            if (!Enum.TryParse(typeof(PcInfoCellName), _cellName, out cellName))
                throw new Exception("Не верное имя ячейки.");//return BadRequest("Не верное имя ячейки.");

            cellName = Enum.Parse(typeof(CredentialsCellName), _cellName);
            Repo.SetRowCellValue(licKey.ToString(), (CredentialsCellName)cellName, cellValue);
            return Ok();
        }
    }
}