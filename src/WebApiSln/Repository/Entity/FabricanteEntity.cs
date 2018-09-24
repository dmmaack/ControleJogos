using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
	public class FabricanteEntity
	{
		public FabricanteEntity(int fabricanteId, string nome, string imagemLogo, int tipoFabricante)
		{
			this.FabricanteId = fabricanteId;
			this.Nome = nome;
			this.ImagemLogo = imagemLogo;
			this.TipoFabricante = tipoFabricante;
		}

		[Key]
		public int FabricanteId { get; private set; }

		[Required]
		[StringLength(20)]
		[Display(Name = "Nome do Fabricante")]
		public string Nome { get; private set; }

		[Required]
		[StringLength(200)]
		[Display(Name = "Logo")]
		public string ImagemLogo { get; private set; }

		[Required]
		public int TipoFabricante { get; private set; }

		public List<JogoEntity> Jogos { get; set; }
		public List<ConsoleEntity> Consoles { get; set; }
	}
}
