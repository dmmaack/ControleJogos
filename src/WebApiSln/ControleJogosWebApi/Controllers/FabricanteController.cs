using System.Collections.Generic;

namespace ControleJogosWebApi.Controllers
{
    public class FabricanteController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class FabricanteController : ControllerBase
        {
            private readonly IFabricanteService _service;

            public FabricanteController(IFabricanteService service)
            {
                _service = service;
            }

            // GET api/values
            [HttpGet]
            public ActionResult<IEnumerable<FabricanteEntity>> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // GET api/values/5
            [HttpGet("{id}")]
            public ActionResult<FabricanteEntity> Get(int id)
            {
                return "value";
            }

            // POST api/values
            [HttpPost]
            public void Post([FromBody] FabricanteEntity value)
            {
            }

            // PUT api/values/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] FabricanteEntity value)
            {
            }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }
}