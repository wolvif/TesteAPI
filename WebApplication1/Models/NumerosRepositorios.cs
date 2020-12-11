using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class NumerosRepositorios : INumeros
    {
        protected Numeros numeros = new Numeros();

        public NumerosRepositorios() { }

        /// <summary>
        /// Construtor que insere numero na lista "Sequence"
        /// lembrete: implementar para receber o target
        /// </summary>
        /// <param name="num"></param>
        public NumerosRepositorios(int num)
        {
            Adiciona(num);
        }

        /// <summary>
        /// Permite adicionar numeros na lista "Sequence"
        /// </summary>
        /// <param name="num">numero a ser adicionado</param>
        public void Adiciona(int num)
        {
            if (num == 0)
            {
                throw new ArgumentNullException("número deve ser diferente de zero");
            }
            numeros.sequence.Add(num);
        }

        /// <summary>
        /// Compara o número informado com a somatoria de números dentro da lista "Sequence"
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool Compara()
        {
            int soma = Somar();
            int num = numeros.target;
            if (num == soma)
            {
                return true;
            }
            return false;
        }

        public void Periodo(DateTime dtInicio, DateTime dtFim)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Definição do Target
        /// </summary>
        /// <param name="num"></param>
        public void DefineTarget(int num)
        {
            numeros.target = num;
        }

        /// <summary>
        /// Retorna a soma dos valores dentro da lista "Sequence"
        /// </summary>
        /// <returns></returns>
        public int Somar()
        {
            return numeros.sequence.Sum();
        }

        /// <summary>
        /// Pesquisa numeros existentes dentro da lista "Sequence"
        /// </summary>
        /// <param name="num">numero a ser pesquisado</param>
        /// <returns></returns>
        public int PesquisarNumero(int num)
        {
            return numeros.sequence.Find(p => p.Equals(num));
        }

        /// <summary>
        /// Mostra todos os numeros da lista "Sequence"
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> RetornaTodos() { return numeros.sequence; }
    }
}