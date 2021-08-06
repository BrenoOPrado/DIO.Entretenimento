using System;

namespace DIO.Series
{
    public class Filme : EntidadeBase
    {
		private Genero GeneroFilme { get; set; }
		private string TituloFilme { get; set; }
		private string DescricaoFilme { get; set; }
		private int AnoFilme { get; set; }
        private bool ExcluidoFilme {get; set;}

		public Filme(int idFilme, Genero generoFilme, string tituloFilme, string descricaoFilme, int anoFilme)
		{
			this.IdFilme = idFilme;
			this.GeneroFilme = generoFilme;
			this.TituloFilme = tituloFilme;
			this.DescricaoFilme = descricaoFilme;
			this.AnoFilme = anoFilme;
            this.ExcluidoFilme = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.GeneroFilme + Environment.NewLine;
            retorno += "Titulo: " + this.TituloFilme + Environment.NewLine;
            retorno += "Descrição: " + this.DescricaoFilme + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.AnoFilme + Environment.NewLine;
            retorno += "Excluido: " + this.ExcluidoFilme;
			return retorno;
		}

        public string retornaTituloFilme()
		{
			return this.TituloFilme;
		}

		public int retornaIdFilme()
		{
			return this.IdFilme;
		}
        public bool retornaExcluidoFilme()
		{
			return this.ExcluidoFilme;
		}
        public void ExcluirFilme() {
            this.ExcluidoFilme = true;
        }
    }
}