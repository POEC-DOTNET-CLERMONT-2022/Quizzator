using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Quizzator.Entity;
using Quizzator.Persistance;
using Quizzator.Quizzator.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Quizzator.API_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemeController : ControllerBase
    {

        private readonly ThemeManager QuizzRepository;
        private readonly IMapper Mapper;

        public ThemeController(ThemeManager quizzRepository, IMapper mapper)
        {
            QuizzRepository = quizzRepository;
            Mapper = mapper;
        }

        // GET: api/<ThemeController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ThemeDtos>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<ThemeExEntity> l = QuizzRepository.GetAllTheme();
                var dto = Mapper.Map<IEnumerable<ThemeDtos>>(l);
                if (dto == null)
                {
                    return BadRequest();
                }
                return Ok(dto);

            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        // GET api/<ThemeController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof (ThemeDtos), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get(Guid id)
        {
            try
             {
                 var ThemeExEntity = QuizzRepository.Get(id);
                 var dto = Mapper.Map<ThemeDtos>(ThemeExEntity);
                 return Ok(dto);
             }
             catch (Exception e)
             {
                 return StatusCode(500);
             }
        }

        /*[HttpGet("name/{name}")]
        [ProducesResponseType(typeof(IEnumerable<ThemeDtos>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get(string name)
        {
            try
            {
                IEnumerable<ThemeExEntity> l = QuizzRepository.GetThemeByName(name);
                var dto = Mapper.Map<IEnumerable<ThemeDtos>>(l);
                if (dto == null)
                {
                    return BadRequest();
                }
                return Ok(dto);

            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }*/

        // POST api/<ThemeController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Post([FromBody] ThemeDtos themeDto)
        {
          
            var themeEntity = Mapper.Map<ThemeExEntity>(themeDto);
            QuizzRepository.CreateTheme(themeEntity);
            return Ok();


        }

        // PUT api/<ThemeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ThemeController>/5
        [HttpDelete("{guid}")]
        [ProducesResponseType(typeof(bool), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Delete(Guid guid)
        {
            try
            {
                var res = QuizzRepository.DeleteTheme(guid);
                if (res == 1)
                    return Ok();
                else if (res == 0)
                    return NotFound();
                else
                    return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
