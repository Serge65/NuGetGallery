// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace NuGetGallery
{
    public interface IPackageDeleteService
    {
        /// <summary>
        /// Determines whether a package can be deleted by a user. The <paramref name="onlyRejectedTelemetry"/> bool is
        /// necessary since this method can be multiple times within a user scenario. For example, the method can be
        /// called before presenting a UI to the user and again while validating the user's input. It is not desirable
        /// for telemetry to be emitted in both cases. In this case, <paramref name="onlyRejectedTelemetry"/> should be
        /// set to true on the first invocation and false on the second.
        /// </summary>
        /// <param name="package">The package to check.</param>
        /// <param name="onlyRejectedTelemetry">Only emit telemetry if the package can be deleted.</param>
        /// <returns>True if the package can be deleted by the users. False otherwise.</returns>
        Task<bool> CanPackageBeDeletedByUserAsync(Package package, bool onlyRejectedTelemetry);
        Task SoftDeletePackagesAsync(IEnumerable<Package> packages, User deletedBy, string reason, string signature);
        Task HardDeletePackagesAsync(IEnumerable<Package> packages, User deletedBy, string reason, string signature, bool deleteEmptyPackageRegistration);
        Task ReflowHardDeletedPackageAsync(string id, string version);
    }
}