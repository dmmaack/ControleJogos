using System;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
	public class EmprestimoEntity
	{
		public EmprestimoEntity(int emprestimoId, int jogoId, int amigoId, DateTime dtEmprestimo, DateTime dtDevolucao, string observacao)
		{
			EmprestimoId = emprestimoId;
			JogoId = jogoId;
			AmigoId = amigoId;
			DtEmprestimo = dtEmprestimo;
			DtDevolucao = dtDevolucao;
			Observacao = observacao;
		}

		[Key]
		public int EmprestimoId { get; set; }

		[Required]
		public int JogoId { get; set; }

		[Required]
		public int AmigoId { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime DtEmprestimo { get; set; } = DateTime.Now;

		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime	DtDevolucao { get; set; }

		[Required]
		[Display(Name = "Observação")]
		public string Observacao { get; set; }

		public JogoEntity Jogo { get; set; }
		public AmigoEntity Amigo { get; set; }
	}
}
