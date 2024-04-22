using System.Net;

namespace ASPDotNETCoreWebApiBoilerPlate.Common
{
    public class ServiceResponse<T>
    {
        public T? result { get; set; }
        public HttpStatusCode? statusCode { get; set; } = HttpStatusCode.InternalServerError;
        public string? errorMessage {  get; set; }
    }
}
