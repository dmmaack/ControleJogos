using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
	public class FabricanteJogosEntity
	{
		public FabricanteJogosEntity(int fabricanteJogosId, string nome, string imagemLogo)
		{
			FabricanteJogosId = fabricanteJogosId;
			Nome = nome;
			ImagemLogo = imagemLogo;
		}

		[Key]
		public int FabricanteJogosId { get; private set; }

		[Required]
		[StringLength(20)]
		[Display(Name = "Nome do Fabricante")]
		public string Nome { get; private set; }

		[Required]
		[StringLength(200)]
		[Display(Name = "Logo")]
		public string ImagemLogo { get; private set; }

		public List<JogoEntity> Jogos { get; set; }
	}
}
