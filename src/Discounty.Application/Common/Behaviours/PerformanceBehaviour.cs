using Discounty.Application.Common.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Discounty.Application.Common.Behaviours
{
    /// <summary>
    /// Behaviour which checks perfomance on each request.
    /// </summary>
    /// <typeparam name="TRequest">Type of the MediatR request.</typeparam>
    /// <typeparam name="TResponse">Type of the MediatR response.</typeparam>
    public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly Stopwatch timer;
        private readonly ILogger<TRequest> logger;
        private readonly ICurrentUserService currentUserService;

        public PerformanceBehaviour(ILogger<TRequest> logger, ICurrentUserService currentUserService)
        {
            timer = new Stopwatch();
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            timer.Start();
            TResponse response = await next();
            timer.Stop();
            long elapsedMilliseconds = timer.ElapsedMilliseconds;
            if (elapsedMilliseconds > 500)
            {
                string requestName = typeof(TRequest).Name;
                string userId = currentUserService.UserId ?? string.Empty;
                string userName = currentUserService.UserName ?? string.Empty;
                logger.LogWarning(
                    "Discounty Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@UserId} {@UserName} {@Request}",
                    requestName,
                    elapsedMilliseconds,
                    userId,
                    userName,
                    request);
            }

            return response;
        }
    }
}
