using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorioAnime<T>
    {
        List<T> ListaAnime();
        T RetornaPorIdAnime(int id);        
        void InsereAnime(T entidade);        
        void ExcluiAnime(int id);        
        void AtualizaAnime(int id, T entidade);
        int ProximoIdAnime();
    }
}