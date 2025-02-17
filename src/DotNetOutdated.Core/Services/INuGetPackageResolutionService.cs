﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NuGet.Frameworks;
using NuGet.Versioning;

namespace DotNetOutdated.Core.Services
{
    public interface INuGetPackageResolutionService
    {
        Task<NuGetVersion> ResolvePackageVersions(string packageName,
            NuGetVersion referencedVersion, IEnumerable<Uri> sources, VersionRange currentVersionRange, VersionLock versionLock, PrereleaseReporting prerelease,
            NuGetFramework targetFrameworkName, string projectFilePath, bool isDevelopmentDependency);
    }
}