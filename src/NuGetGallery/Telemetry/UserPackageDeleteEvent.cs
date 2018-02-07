﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace NuGetGallery
{
    public class UserPackageDeleteEvent
    {
        public UserPackageDeleteEvent(
            TimeSpan sinceCreated,
            string packageId,
            string packageVersion,
            int idDatabaseDownloads,
            int idReportDownloads,
            int versionDatabaseDownloads,
            int versionReportDownloads)
        {
            SinceCreated = sinceCreated;
            PackageId = packageId ?? throw new ArgumentNullException(nameof(packageId));
            PackageVersion = packageVersion ?? throw new ArgumentNullException(nameof(packageVersion));
            IdDatabaseDownloads = idDatabaseDownloads;
            IdReportDownloads = idReportDownloads;
            VersionDatabaseDownloads = versionDatabaseDownloads;
            VersionReportDownloads = versionReportDownloads;
        }

        public TimeSpan SinceCreated { get; }
        public string PackageId { get; }
        public string PackageVersion { get; }
        public int IdDatabaseDownloads { get; }
        public int IdReportDownloads { get; }
        public int VersionDatabaseDownloads { get; }
        public int VersionReportDownloads { get; }
    }
}