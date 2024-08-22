using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{

    [ApiController]
    [Route("Api/v1/[Controller]")]
    public class SmjerController:ControllerBase
    {

        // dependency injection
        //1. definiraš privatno svojstvo
        private readonly EdunovaContext _context;


        // dependency injection
        //2. proslijediš instancu kroz konstruktor
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }


        //RUTE
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Smjerovi);
        }

        [HttpGet]
        [Route("{Sifra:int}")]
        public IActionResult GetBySifra(int Sifra) 
        {
            return Ok(_context.Smjerovi.Find(Sifra));
        }

        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {
            _context.Smjerovi.Add(smjer);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, smjer);
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, Smjer smjer)
        {
            var smjerIzBaze = _context.Smjerovi.Find(sifra);
            // za sada ručno, kasnije Mapper
            smjerIzBaze.Naziv = smjer.Naziv;
            smjerIzBaze.Trajanje = smjer.Trajanje;
            smjerIzBaze.Cijena = smjer.Cijena;
            smjerIzBaze.IzvodiSeOd = smjer.IzvodiSeOd;
            smjerIzBaze.Vaucer = smjer.Vaucer;

            _context.Smjerovi.Update(smjerIzBaze);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno promjenjeno" });
        }

        [HttpDelete]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int sifra)
        {
            var smjerIzBaze = _context.Smjerovi.Find(sifra);
            _context.Smjerovi.Remove(smjerIzBaze);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno obrisano" });
        }
    }
}
