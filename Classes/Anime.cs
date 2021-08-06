using System;

namespace DIO.Series
{
    public class Anime : EntidadeBase
    {
		private Genero GeneroAnime { get; set; }
		private string TituloAnime { get; set; }
		private string DescricaoAnime { get; set; }
		private int AnoAnime { get; set; }
        private bool ExcluidoAnime {get; set;}

		public Anime(int idAnime, Genero generoAnime, string tituloAnime, string descricaoAnime, int anoAnime)
		{
			this.IdAnime = idAnime;
			this.GeneroAnime = generoAnime;
			this.TituloAnime = tituloAnime;
			this.DescricaoAnime = descricaoAnime;
			this.AnoAnime = anoAnime;
            this.ExcluidoAnime = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.GeneroAnime + Environment.NewLine;
            retorno += "Titulo: " + this.TituloAnime + Environment.NewLine;
            retorno += "Descrição: " + this.DescricaoAnime + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.AnoAnime + Environment.NewLine;
            retorno += "Excluido: " + this.ExcluidoAnime;
			return retorno;
		}

        public string retornaTituloAnime()
		{
			return this.TituloAnime;
		}

		public int retornaIdAnime()
		{
			return this.IdAnime;
		}
        public bool retornaExcluidoAnime()
		{
			return this.ExcluidoAnime;
		}
        public void ExcluirAnime() {
            this.ExcluidoAnime = true;
        }
    }
}