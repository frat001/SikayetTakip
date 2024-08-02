using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.DtoLayer.SikayetDTO;
using ProjectAPI.EntityLayer.Entities;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SikayetController : ControllerBase
    {


        private readonly ISikayetService _sikayetService;

        public SikayetController(ISikayetService sikayetService)
        {
            _sikayetService = sikayetService;
        }

        [HttpGet]
        public IActionResult SikayetList()
        {
            var values = _sikayetService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult getSikayet(int id)
        {
            var values = _sikayetService.TGetByID(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult createSikayet(CreateSikayetDTO createSikayetDTO)
        {
            Sikayet sikayet = new Sikayet()
            {
                SikayetNo = createSikayetDTO.SikayetNo,
                Aciklama = createSikayetDTO.Aciklama,
                BakimImage = createSikayetDTO.BakimImage,
                BeyazMasaNo = createSikayetDTO.BeyazMasaNo,
                BolgeSefligi = createSikayetDTO.BolgeSefligi,
                ParkIsmi = createSikayetDTO.BolgeSefligi,
                SikayetImage = createSikayetDTO.SikayetImage
            };
            _sikayetService.TInsert(sikayet);
            return Ok("Başarıyla Eklendi.");
        }
        [HttpPut]
        public IActionResult updateSikayet(UpdateSikayetDTO updateSikayetDTO)
        {
            Sikayet sikayet = new Sikayet()
            {
                ID = updateSikayetDTO.ID,
                SikayetNo = updateSikayetDTO.SikayetNo,
                Aciklama = updateSikayetDTO.Aciklama,
                BakimImage = updateSikayetDTO.BakimImage,
                BeyazMasaNo = updateSikayetDTO.BeyazMasaNo,
                BolgeSefligi = updateSikayetDTO.BolgeSefligi,
                ParkIsmi = updateSikayetDTO.BolgeSefligi,
                SikayetImage = updateSikayetDTO.SikayetImage
            };
            _sikayetService.TUpdate(sikayet);
            return Ok("Başarıyla Güncellendi.");

        }
        [HttpDelete]
        public IActionResult deleteSikayet(int id)
        {
            var values = _sikayetService.TGetByID(id);
            _sikayetService.TDelete(values);
            return Ok("Başarıyla Silindi.");
        }
    }
}



