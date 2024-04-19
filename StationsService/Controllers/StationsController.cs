using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NANUApp.Models.Stations;

namespace StationsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        [Route("GetStationList")]
        [HttpGet]
        public async Task<List<StationModel>> GetStationList()
        {
            List<StationModel> Productlist = new List<StationModel>
            {
                new StationModel { Id=1,Name="강남세븐일레븐", Lon = 456, Lat=123 },
                new StationModel { Id=1,Name="강북세븐일레븐", Lon = 456, Lat=123 },
                new StationModel { Id=1,Name="강서세븐일레븐", Lon = 456, Lat=123 },
                new StationModel { Id=1,Name="강동세븐일레븐", Lon = 456, Lat=123 },
                new StationModel { Id=1,Name="성남세븐일레븐", Lon = 456, Lat=123 },

            };

            return Productlist;


        }
    }
}
