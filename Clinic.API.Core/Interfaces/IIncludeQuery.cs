﻿using Clinic.Api.Core.Helpers.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Interfaces
{
    public interface IIncludeQuery
    {
        Dictionary<IIncludeQuery, string> PathMap { get; }
        IncludeVisitor Visitor { get; }
        HashSet<string> Paths { get; }
    }

    public interface IIncludeQuery<TEntity, out TPreviousProperty> : IIncludeQuery
    {
    }
}
