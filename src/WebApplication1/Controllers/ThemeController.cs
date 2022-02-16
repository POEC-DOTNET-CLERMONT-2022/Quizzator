using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Quizzator.Persistance;
using Quizzator.Quizzator.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Quizzator.API_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemeController : ControllerBase
    {

        private readonly ThemeManager _quizzRepository;
        private readonly IMapper _mapper;

        public ThemeController(ThemeManager quizzRepository, IMapper mapper)
        {
            _quizzRepository = quizzRepository;
            _mapper = mapper;
        }

        // GET: api/<ThemeController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ThemeDtos>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<Entity.ThemeExEntity> l = _quizzRepository.GetAllTheme();
                var dto = _mapper.Map<IEnumerable<ThemeDtos>>(l);
                if (dto == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(dto);
                }

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
                 var ThemeExEntity = _quizzRepository.Get(id);
                 var dto = _mapper.Map<ThemeDtos>(ThemeExEntity);
                 return Ok(dto);
             }
             catch (Exception e)
             {
                 return StatusCode(500);
             }
        }

        // POST api/<ThemeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Console.WriteLine(value);
        }

        // PUT api/<ThemeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ThemeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
