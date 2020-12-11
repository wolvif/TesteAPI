using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NumerosController : ApiController
    {
        static readonly INumeros repositorio = new NumerosRepositorios();

        public IEnumerable<int> GetRetornaTodos()
        {
            return repositorio.RetornaTodos();
        }

        public void GetDefineTarget(int num)
        {
            repositorio.DefineTarget(num);
        }

        public int GetPesquisarNumero(int num)
        {
            int numero = repositorio.PesquisarNumero(num);
            if (numero == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return numero;
        }

        public void PostAdiciona(int num)
        {
            repositorio.Adiciona(num);
        }

        public HttpResponseMessage PostNumeroInserido(int num)
        {
            var response = Request.CreateResponse<int>(HttpStatusCode.Created, num);
            string uri = Url.Link("DefaultApi", new { num });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public bool PostComparar()
        {
            return repositorio.Compara();
        }

    }
}