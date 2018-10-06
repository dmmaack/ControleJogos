using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity
{
	public class JogoEntity
	{
		public JogoEntity(int jogoId, int consoleId, int generoId, int fabricanteId, string nome, int numJogadores, string classificacaoEtaria, string linkVideo, string idioma, string observacao, string foto)
		{
			JogoId = jogoId;
			ConsoleId = consoleId;
			GeneroId = generoId;
			FabricanteId = fabricanteId;
			Nome = nome;
			NumJogadores = numJogadores;
			ClassificacaoEtaria = classificacaoEtaria;
			LinkVideo = linkVideo;
			Idioma = idioma;
			Observacao = observacao;
			Foto = foto;
		}

		[Key]
		public int JogoId { get; private set; }

		[Required]
		public int ConsoleId { get; private set; }

		[Required]
		public int GeneroId { get; private set; }

		[Required]
		//[ForeignKey("FabricanteJogo")]
		public int FabricanteId { get; private set; }

		[Required]
		[StringLength(60)]
		[Display(Name = "Nome")]
		public string Nome { get; private set; }

		[Required]
		[Display(Name = "Numero de Jogadores")]
		public int NumJogadores { get; private set; }

		[Required]
		[StringLength(8)]
		[Display(Name = "Classificação Etária")]
		public string ClassificacaoEtaria { get; private set; }

		[Required]
		[StringLength(8)]
		[Display(Name = "Vídeo")]
		public string LinkVideo { get; private set; }

		[Required]
		[StringLength(3)]
		[Display(Name = "Idioma")]
		public string Idioma { get; private set; }

		[Required]
		[StringLength(8000)]
		[Display(Name = "Observacao")]
		public string Observacao { get; private set; }

		[Required]
		[StringLength(200)]
		[Display(Name = "Foto")]
		public string Foto { get; private set; }

		public FabricanteEntity FabricanteJogo { get; set; }

        public EmprestimoEntity Emprestimo { get; set; }

        public ConsoleEntity Console { get; set; }
    }
}
