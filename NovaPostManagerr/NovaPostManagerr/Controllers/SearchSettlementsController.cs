using System.Text.Json;
using Core.Dto.InternetDocument.Request;
using Core.Dto.InternetDocument.Response;
using Core.Dto.SearchSettlement.Response;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace NovaPostManagerr.Controllers
{///
    [ApiController]
    [Route("[controller]")]
    public class SearchSettlementsController : ControllerBase
    {
        private readonly ISearchSettlementService _searchSettlementService;
        public SearchSettlementsController(ISearchSettlementService searchSettlementService)
        {
            _searchSettlementService = searchSettlementService;
        }

        [HttpGet("GetCityData")]
        public async Task<ActionResult<SearchSettlementResponse>> GetCityData(string cityName)
        {

            var response = await _searchSettlementService.GetCityData(cityName);
            return Ok(response);
        }
    }
}