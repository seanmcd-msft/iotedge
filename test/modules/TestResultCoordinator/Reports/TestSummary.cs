// Copyright (c) Microsoft. All rights reserved.
namespace TestResultCoordinator.Reports
{
    using System;
    using System.Linq;
    using Microsoft.Azure.Devices.Edge.Util;

    class TestSummary
    {
        internal TestSummary(string testBuildNumber, string deviceId, ITestResultReport[] testResultReports, string blobContainerUri)
        {
            this.TestBuildNumber = Preconditions.CheckNonWhiteSpace(testBuildNumber, nameof(testBuildNumber));
            this.DeviceId = Preconditions.CheckNonWhiteSpace(deviceId, nameof(deviceId));
            this.TestResultReports = Preconditions.CheckNotNull(testResultReports, nameof(testResultReports));
            this.IsPassed = testResultReports.All(r => r.IsPassed);
            this.BlobContainerUri = blobContainerUri ?? string.Empty;
        }

        public string TestBuildNumber { get; }

        public string DeviceId { get; }

        public bool IsPassed { get; }

        public ITestResultReport[] TestResultReports { get; }

        public string BlobContainerUri { get; }
    }
}
