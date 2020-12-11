using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface INumeros
    {
        void Adiciona(int num);
        int Somar();
        bool Compara();
        void DefineTarget(int num);
        void Periodo(DateTime dtInicio, DateTime dtFim);
        int PesquisarNumero(int num);
        IEnumerable<int> RetornaTodos();
    }
}
