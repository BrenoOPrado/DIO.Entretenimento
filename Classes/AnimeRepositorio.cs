using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class AnimeRepositorio : IRepositorioAnime<Anime>
	{
        private List<Anime> listaAnime = new List<Anime>();
		public void AtualizaAnime(int idAnime, Anime objetoAnime)
		{
			listaAnime[idAnime] = objetoAnime;
		}

		public void ExcluiAnime(int idAnime)
		{
			listaAnime[idAnime].ExcluirAnime();
		}

		public void InsereAnime(Anime objetoAnime)
		{
			listaAnime.Add(objetoAnime);
		}

		public List<Anime> ListaAnime()
		{
			return listaAnime;
		}

		public int ProximoIdAnime()
		{
			return listaAnime.Count;
		}

		public Anime RetornaPorIdAnime(int idAnime)
		{
			return listaAnime[idAnime];
		}
	}
}