using Inventory.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Inventory.Controllers
{
    [ApiController]
    [Route("parts")]
    public class PartController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using StreamReader Read = new("Data/partsJson.json");
                string Json = Read.ReadToEnd();
             
                ICollection<Part> Item = JsonConvert.DeserializeObject<ICollection<Part>>(Json);

                return Ok(Item);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post(Part newPart)
        {
            try
            {
                string UrlPath = "Data/partsJson.json";

                using StreamReader Reader = new(UrlPath);
                string Json = Reader.ReadToEnd();
                List<Part> Item = JsonConvert.DeserializeObject<List<Part>>(Json);

                if(Item?.Find(i => i.ID == newPart.ID) != null)
                {
                    
                    return BadRequest(new { message = "Product ID already existed" });
                }

                Item?.Add(newPart);

                using StreamWriter Write = new StreamWriter(UrlPath, false);
                Write.WriteLine(JsonConvert.SerializeObject(Item));

                return Ok(newPart);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}

