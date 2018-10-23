using Microsoft.AspNetCore.Mvc;
using Repository.Entity;
using Repository.Services;
using System.Collections.Generic;
 
namespace ControleJogosWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FabricanteController : ControllerBase
	{
		private readonly IFabricanteRepository _service;

		public FabricanteController(IFabricanteRepository service)
		{
			_service = service;
		}

		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<FabricanteEntity>> Get()
		{
			return null;
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<FabricanteEntity> Get(int id)
		{
			return null;
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