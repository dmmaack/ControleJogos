using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public class ConsoleEntity
    {
        public ConsoleEntity(int consoleId, string nome, int fabricanteId, string modelo, string energia, int qtdControles)
        {
            this.ConsoleId = consoleId;
            this.Nome = nome;
            this.FabricanteId = fabricanteId;
            this.Modelo = modelo;
            this.Energia = energia;
            this.QtdControles = qtdControles;

        }
        
        public int ConsoleId { get; private set; }

		[Required]
		[StringLength(20)]
		[Display(Name = "Nome")]
        public string Nome { get; private set; }

		[Required]
        public int FabricanteId { get; private set; }

		[Required]
		[StringLength(20)]
		[Display(Name = "Modelo")]
		public string Modelo { get; private set; }

		[Required]
		[StringLength(6)]
		[Display(Name = "Energia")]
		public string Energia { get; private set; }

		[Required]
		[Display(Name = "Quantidade de Controles")]
		public int QtdControles { get; private set; }
    }
}