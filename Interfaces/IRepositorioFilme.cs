using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorioFilme<T>
    {
        List<T> ListaFilme();
        T RetornaPorIdFilme(int id);        
        void InsereFilme(T entidade);        
        void ExcluiFilme(int id);        
        void AtualizaFilme(int id, T entidade);
        int ProximoIdFilme();
    }
}