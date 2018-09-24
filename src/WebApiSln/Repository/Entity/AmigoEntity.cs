using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
	public class AmigoEntity
	{
		public AmigoEntity(int amigoId, string nome, string telefone, bool whats, string cEP, string logradouro, string bairro, string localidade, string uF, string observacao)
		{
			AmigoId = amigoId;
			Nome = nome;
			Telefone = telefone;
			Whats = whats;
			CEP = cEP;
			Logradouro = logradouro;
			Bairro = bairro;
			Localidade = localidade;
			UF = uF;
			Observacao = observacao;
		}

		[Key]
		public int AmigoId { get; private set; }

		[Required]
		[StringLength(100)]
		[Display(Name = "Nome")]
		public string Nome { get; private set; }

		[Required]
		[StringLength(3)]
		[Display(Name = "DDD")]
		public string DDD { get; private set; }

		[Required]
		[StringLength(9)]
		[Display(Name = "Telefone")]
		public string Telefone { get; private set; }

		public bool Whats { get; private set; }

		[Required]
		[StringLength(8)]
		[Display(Name = "CEP")]
		public string CEP { get; private set; }

		[Required]
		[StringLength(200)]
		[Display(Name = "Logradouro")]
		public string Logradouro { get; private set; }

		[Required]
		[StringLength(30)]
		[Display(Name = "Bairro")]
		public string Bairro { get; private set; }

		[Required]
		[StringLength(30)]
		[Display(Name = "Localidade")]
		public string Localidade { get; private set; }

		[Required]
		[StringLength(3)]
		[Display(Name = "UF")]
		public string UF { get; private set; }

		[Required]
		[StringLength(300)]
		[Display(Name = "Observacao")]
		public string Observacao { get; private set; }

		public List<EmprestimoEntity> Emprestimos { get; set; }
	}
}
