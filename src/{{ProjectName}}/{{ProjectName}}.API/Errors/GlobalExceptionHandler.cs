using __ProjectName__.Domain.Exceptions;
using Serilog;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace __ProjectName__.API.Errors
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public override Task HandleAsync(
            ExceptionHandlerContext context,
            CancellationToken cancellationToken)
        {
            var exception = context.Exception;

            var traceId = Guid.NewGuid().ToString();

            Log.Error(
                exception,
                "API exception. TraceId: {TraceId}",
                traceId);

            var statusCode = GetStatusCode(exception);

            var response = new ErrorResponse
            {
                Status = "Error",
                Message = GetClientMessage(exception),
                TraceId = traceId
            };

            context.Result = new ErrorResult(
                context.Request,
                statusCode,
                response);

            return Task.CompletedTask;
        }

        private static HttpStatusCode GetStatusCode(Exception exception)
        {
            if (exception is ValidationException)
                return HttpStatusCode.BadRequest;

            if (exception is UnauthorizedException)
                return HttpStatusCode.Unauthorized;

            if (exception is ForbiddenException)
                return HttpStatusCode.Forbidden;

            if (exception is NotFoundException)
                return HttpStatusCode.NotFound;

            return HttpStatusCode.InternalServerError;
        }

        private static string GetClientMessage(Exception exception)
        {
            if (exception is DomainException)
                return exception.Message;

            return "An unexpected error occurred.";
        }
    }

    internal class ErrorResult : IHttpActionResult
    {
        private readonly System.Net.Http.HttpRequestMessage _request;
        private readonly HttpStatusCode _statusCode;
        private readonly ErrorResponse _response;

        public ErrorResult(
            System.Net.Http.HttpRequestMessage request,
            HttpStatusCode statusCode,
            ErrorResponse response)
        {
            _request = request;
            _statusCode = statusCode;
            _response = response;
        }

        public Task<System.Net.Http.HttpResponseMessage> ExecuteAsync(
            CancellationToken cancellationToken)
        {
            var response = _request.CreateResponse(
                _statusCode,
                _response,
                "application/json");

            return Task.FromResult(response);
        }
    }
}