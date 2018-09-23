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


		public string Telefone { get; private set; }
		public bool Whats { get; private set; }
		public string CEP { get; private set; }
		public string Logradouro { get; private set; }
		public string Bairro { get; private set; }
		public string Localidade { get; private set; }
		public string UF { get; private set; }
		public string Observacao { get; private set; }
	}
}
