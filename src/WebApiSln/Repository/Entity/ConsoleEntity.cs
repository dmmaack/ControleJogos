using System.Collections.Generic;
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
        
		[Key]
        public int ConsoleId { get; private set; }

		[Required]
		[StringLength(60)]
		[Display(Name = "Nome")]
        public string Nome { get; private set; }

		[Required]
        public int FabricanteId { get; private set; }

		[Required]
		[StringLength(100)]
		[Display(Name = "Modelo")]
		public string Modelo { get; private set; }

		[Required]
		[StringLength(6)]
		[Display(Name = "Energia")]
		public string Energia { get; private set; }

		[Required]
		[Display(Name = "Quantidade de Controles")]
		public int QtdControles { get; private set; }


		public FabricanteEntity FabricanteConsole { get; set; }

        public List<JogoEntity> Jogos { get; set; }
    }
}