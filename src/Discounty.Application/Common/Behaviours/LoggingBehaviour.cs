using Discounty.Application.Common.Interfaces;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Discounty.Application.Common.Behaviours
{
    /// <summary>
    /// Behaviour which is aimed on logging each request action and user info.
    /// </summary>
    /// <typeparam name="TRequest">Type of the MediatR request.</typeparam>
    public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger logger;
        private readonly ICurrentUserService currentUserService;

        public LoggingBehaviour(ILoggerFactory loggerFactory, ICurrentUserService currentUserService)
        {
            logger = (loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory))).CreateLogger<LoggingBehaviour<TRequest>>();
            this.currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            string requestName = typeof(TRequest).Name;
            string userId = currentUserService.UserId ?? string.Empty;
            string userName = currentUserService.UserName ?? string.Empty;
            logger.LogInformation("Discounty Request: {Name} {@UserId} {@UserName} {@Request}", requestName, userId, userName, request);
        }
    }
}
