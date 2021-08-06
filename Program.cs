using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
		static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
		static AnimeRepositorio repositorioAnime = new AnimeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "6":
						ListarFilme();
						break;
					case "7":
						InserirFilme();
						break;
					case "8":
						AtualizarFilme();
						break;
					case "9":
						ExcluirFilme();
						break;
					case "10":
						VisualizarFilme();
						break;
					case "11":
						ListarAnime();
						break;
					case "12":
						InserirAnime();
						break;
					case "13":
						AtualizarAnime();
						break;
					case "14":
						ExcluirAnime();
						break;
					case "15":
						VisualizarAnime();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços!");
			Console.ReadLine();
        }

        private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}
		private static void ExcluirFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorioFilme.ExcluiFilme(indiceFilme);
		}

        private static void VisualizarFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var filme = repositorioFilme.RetornaPorIdFilme(indiceFilme);

			Console.WriteLine(filme);
		}

        private static void AtualizarFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do filme: ");
			string entradaTituloFilme = Console.ReadLine();

			Console.Write("Digite o Ano do filme: ");
			int entradaAnoFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do filme: ");
			string entradaDescricaoFilme = Console.ReadLine();

			Filme atualizaFilme = new Filme(idFilme: indiceFilme,
										generoFilme: (Genero)entradaGeneroFilme,
										tituloFilme: entradaTituloFilme,
										anoFilme: entradaAnoFilme,
										descricaoFilme: entradaDescricaoFilme);

			repositorioFilme.AtualizaFilme(indiceFilme, atualizaFilme);
		}
		private static void ListarFilme()
		{
			Console.WriteLine("Listar Filmes");

			var listaFilme = repositorioFilme.ListaFilme();

			if (listaFilme.Count == 0)
			{
				Console.WriteLine("Nenhum filme cadastrado.");
				return;
			}

			foreach (var Filme in listaFilme)
			{
                var excluidoFilme = Filme.retornaExcluidoFilme();
                
				Console.WriteLine("#ID {0}: - {1} {2}", Filme.retornaIdFilme(), Filme.retornaTituloFilme(), (excluidoFilme ? "*Excluído*" : ""));
			}
		}

        private static void InserirFilme()
		{
			Console.WriteLine("Inserir novo filme");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do filme: ");
			string entradaTituloFilme = Console.ReadLine();

			Console.Write("Digite o Ano de lançamento do filme: ");
			int entradaAnoFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do filme: ");
			string entradaDescricaoFilme = Console.ReadLine();

			Filme novoFilme = new Filme(idFilme: repositorioFilme.ProximoIdFilme(),
										generoFilme: (Genero)entradaGeneroFilme,
										tituloFilme: entradaTituloFilme,
										anoFilme: entradaAnoFilme,
										descricaoFilme: entradaDescricaoFilme);

			repositorioFilme.InsereFilme(novoFilme);
		}
        private static void ListarAnime()
		{
			Console.WriteLine("Listar Animes");

			var listaAnime = repositorioAnime.ListaAnime();

			if (listaAnime.Count == 0)
			{
				Console.WriteLine("Nenhum anime cadastrado.");
				return;
			}

			foreach (var Anime in listaAnime)
			{
                var excluidoAnime = Anime.retornaExcluidoAnime();
                
				Console.WriteLine("#ID {0}: - {1} {2}", Anime.retornaIdAnime(), Anime.retornaTituloAnime(), (excluidoAnime ? "*Excluído*" : ""));
			}
		}

        private static void InserirAnime()
		{
			Console.WriteLine("Inserir novo anime");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroAnime = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do anime: ");
			string entradaTituloAnime = Console.ReadLine();

			Console.Write("Digite o Ano de lançamento do anime: ");
			int entradaAnoAnime = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do anime: ");
			string entradaDescricaoAnime = Console.ReadLine();

			Anime novoAnime = new Anime(idAnime: repositorioAnime.ProximoIdAnime(),
										generoAnime: (Genero)entradaGeneroAnime,
										tituloAnime: entradaTituloAnime,
										anoAnime: entradaAnoAnime,
										descricaoAnime: entradaDescricaoAnime);

			repositorioAnime.InsereAnime(novoAnime);
		}
		private static void ExcluirAnime()
		{
			Console.Write("Digite o id do anime: ");
			int indiceAnime = int.Parse(Console.ReadLine());

			repositorioAnime.ExcluiAnime(indiceAnime);
		}

        private static void VisualizarAnime()
		{
			Console.Write("Digite o id do anime: ");
			int indiceAnime = int.Parse(Console.ReadLine());

			var anime = repositorioAnime.RetornaPorIdAnime(indiceAnime);

			Console.WriteLine(anime);
		}

        private static void AtualizarAnime()
		{
			Console.Write("Digite o id do anime: ");
			int indiceAnime = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroAnime = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do anime: ");
			string entradaTituloAnime = Console.ReadLine();

			Console.Write("Digite o Ano do anime: ");
			int entradaAnoAnime = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do anime: ");
			string entradaDescricaoAnime = Console.ReadLine();

			Anime atualizaAnime = new Anime(idAnime: indiceAnime,
										generoAnime: (Genero)entradaGeneroAnime,
										tituloAnime: entradaTituloAnime,
										anoAnime: entradaAnoAnime,
										descricaoAnime: entradaDescricaoAnime);

			repositorioAnime.AtualizaAnime(indiceAnime, atualizaAnime);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Entretenimento");
			Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine();
			Console.WriteLine("6- Listar filmes");
			Console.WriteLine("7- Inserir novo filme");
			Console.WriteLine("8- Atualizar filme");
			Console.WriteLine("9- Excluir filme");
			Console.WriteLine("10- Visualizar filme");
			Console.WriteLine();
			Console.WriteLine("11- Listar anime");
			Console.WriteLine("12- Inserir novo anime");
			Console.WriteLine("13- Atualizar anime");
			Console.WriteLine("14- Excluir anime");
			Console.WriteLine("15- Visualizar anime");
			Console.WriteLine();
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
