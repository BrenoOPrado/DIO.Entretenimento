using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class FilmeRepositorio : IRepositorioFilme<Filme>
	{
        private List<Filme> listaFilme = new List<Filme>();
		public void AtualizaFilme(int idFilme, Filme objetoFilme)
		{
			listaFilme[idFilme] = objetoFilme;
		}

		public void ExcluiFilme(int idFilme)
		{
			listaFilme[idFilme].ExcluirFilme();
		}

		public void InsereFilme(Filme objetoFilme)
		{
			listaFilme.Add(objetoFilme);
		}

		public List<Filme> ListaFilme()
		{
			return listaFilme;
		}

		public int ProximoIdFilme()
		{
			return listaFilme.Count;
		}

		public Filme RetornaPorIdFilme(int idFilme)
		{
			return listaFilme[idFilme];
		}
	}
}