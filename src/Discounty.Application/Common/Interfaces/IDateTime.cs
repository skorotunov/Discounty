﻿using System;

namespace Discounty.Application.Common.Interfaces
{
    /// <summary>
    /// Service which encapsulates dependency on time.
    /// </summary>
    public interface IDateTime
    {
        /// <summary>
        /// Current DateTime.
        /// </summary>
        DateTime Now { get; }
    }
}
