using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Discounty.Application.Common.Exceptions
{
    /// <summary>
    /// Custom exception aimed to represnt incorrect input data for the request.
    /// </summary>
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("One or more validation failures have occurred.")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            foreach (IGrouping<string, string> failureGroup in failures.GroupBy(x => x.PropertyName, x => x.ErrorMessage))
            {
                string propertyName = failureGroup.Key;
                string[] propertyFailures = failureGroup.ToArray();
                Errors.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Errors { get; }
    }
}
