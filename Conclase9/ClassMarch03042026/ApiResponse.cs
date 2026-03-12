namespace Conclase9.ClassMarch03042026
{
    internal class ApiResponse<T>
    {
        public string Message { get; set; } = default!;
        public int Status { get; set; }
        public bool Success { get; set; }
        public T? Data { get; set; }

        public static ApiResponse<T> Fail(string message, int status)
        {
            return new ApiResponse<T> { Message = message, Status = status };
        }

        public static ApiResponse<T> Ok(T data, int status = 200, string message = "Success")
        {
            return new ApiResponse<T> { Message = message, Status = status, Success = true, Data = data };
        }
    }
}
