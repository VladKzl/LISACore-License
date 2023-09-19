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
        [HttpGet("{licKey:guid}")]
        public IActionResult GetRowCellValue([FromQuery] string licKey, [FromQuery] string _cellName)
        {
            if(licKey == "" || licKey == null)
                throw new Exception("�� �� �������� ������������ ����.");
            object cellName;
            if (!Enum.TryParse(typeof(LicenseInfoCellName), _cellName, out cellName))
                throw new Exception("�� ������ ��� ������.");
            cellName = (LicenseInfoCellName)cellName;
            return Ok();
        }
    }
}