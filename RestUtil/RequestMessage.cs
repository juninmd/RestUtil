using System.Net;

namespace RestUtil
{
    public class RequestMessageCore
    {
        public RequestMessageCore()
        {
            StatusCode = HttpStatusCode.OK;
        }

        /// <summary>
        /// Tipo do Status code de Erro
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        public bool IsError => StatusCode.GetHashCode() < 200 || StatusCode.GetHashCode() > 299;

        /// <summary>
        /// Mensagem do Erro
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Mensagem de Erro / Tecnica
        /// </summary>
        public string TechnicalMessage { get; set; }

        /// <summary>
        /// Indica a linha na qual aconteceu algum erro na aplicação
        /// </summary>
        public string StackTrace { get; set; }
    }
    public class RequestMessage : RequestMessageCore
    {
        /// <summary>
        /// Nome do Package + Procedure
        /// </summary>
        public string Procedure { get; set; }

        /// <summary>
        /// Query do Banco de Dados
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Tipo do Método da Requisição API
        /// </summary>
        public string TypeMethodApi { get; set; }

        /// <summary>
        /// Url da Requisição API
        /// </summary>
        public string UrlApi { get; set; }

    }
    public class RequestMessage<T> : RequestMessage
    {
        /// <summary>
        /// <para>Conteudo da Requisição da API</para>
        /// </summary>
        public T Content { get; set; }
    }

    public class RequestMessageCore<T> : RequestMessageCore
    {
        /// <summary>
        /// <para>Conteudo da Requisição da API</para>
        /// </summary>
        public T Content { get; set; }
    }
}
