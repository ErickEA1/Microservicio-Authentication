namespace Auth.Api.Microservicio.Models.Dto
{
    public class ResponseDto
    {
        public object Data { get; set; }
        public bool IsScuccess { get; set; } = true;
        public string Message { get; set; }=string.Empty;
    }
}
