﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NuGet.Frameworks;
using NuGet.Versioning;

namespace DotNetOutdated.Services
{
    internal interface INuGetPackageInfoService
    {
        Task<IReadOnlyList<NuGetVersion>> GetAllVersions(string package, IEnumerable<Uri> sources, bool includePrerelease, NuGetFramework targetFramework, string projectFilePath,
            bool isDevelopmentDependency);
    }
}