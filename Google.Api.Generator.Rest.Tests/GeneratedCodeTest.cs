﻿// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.ManufacturerCenter.v1;
using Google.Apis.ManufacturerCenter.v1.Data;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System;
using Xunit;

namespace Google.Apis.Tests.Apis.Services;

/// <summary>
/// Tests for the behavior of the generated code. This uses the services in the golden test data -
/// if new tests are needed for code which doesn't happen to be generated by any of the existing
/// golden tests, just add a new service.
/// </summary>
public class GeneratedCodeTest
{
#pragma warning disable CS0618 // Type or member is obsolete
    // Tests around Discovery date-time format properties.
    [Fact]
    public void StorageBucketCreatedTime_Default()
    {
        var bucket = new Bucket();
        Assert.Null(bucket.TimeCreatedRaw);
        Assert.Null(bucket.TimeCreated);
        Assert.Null(bucket.TimeCreatedDateTimeOffset);
    }

    [Fact]
    public void StorageBucketCreatedTime_ParsedFromJson()
    {
        string json = "{'timeCreated':'2023-06-14T12:34:45.123Z'}".Replace('\'', '"');
        var bucket = (Bucket) new StorageService().Serializer.Deserialize(json, typeof(Bucket));
        AssertStorageBucketCreatedTimeProperties(bucket);
    }

    [Fact]
    public void StorageBucket_SetCreatedTimeDateTimeOffset()
    {
        var bucket = new Bucket();
        bucket.TimeCreatedDateTimeOffset = new DateTimeOffset(2023, 6, 14, 12, 34, 45, 123, TimeSpan.Zero);
        AssertStorageBucketCreatedTimeProperties(bucket);
        Assert.Equal("2023-06-14T12:34:45.123Z", bucket.TimeCreatedRaw);
        Assert.Equal(new DateTime(2023, 6, 14, 12, 34, 45, 123, DateTimeKind.Utc).ToLocalTime(), bucket.TimeCreated);
    }

    [Fact]
    public void StorageBucket_SetCreatedTimeRaw()
    {
        var bucket = new Bucket();
        bucket.TimeCreatedRaw = "2023-06-14T12:34:45.123Z";
        AssertStorageBucketCreatedTimeProperties(bucket);
    }

    [Fact]
    public void StorageBucket_SetCreatedTime()
    {
        var bucket = new Bucket();
        // Our conversion code (which we don't want to change) will convert Unspecified to UTC,
        // but not local... so we'll effectively change the type here to force the conversion.
        var local = new DateTime(2023, 6, 14, 12, 34, 45, 123, DateTimeKind.Utc).ToLocalTime();
        var unspecified = DateTime.SpecifyKind(local, DateTimeKind.Unspecified);
        bucket.TimeCreated = unspecified;
        AssertStorageBucketCreatedTimeProperties(bucket);
    }

    private static void AssertStorageBucketCreatedTimeProperties(Bucket bucket)
    {
        Assert.Equal("2023-06-14T12:34:45.123Z", bucket.TimeCreatedRaw);
        Assert.Equal(new DateTime(2023, 6, 14, 12, 34, 45, 123, DateTimeKind.Utc).ToLocalTime(), bucket.TimeCreated);
        Assert.Equal(new DateTimeOffset(2023, 6, 14, 12, 34, 45, 123, TimeSpan.Zero), bucket.TimeCreatedDateTimeOffset);
        string expectedJson = "{'timeCreated':'2023-06-14T12:34:45.123Z'}".Replace('\'', '"');
        var actualJson = new StorageService().SerializeObject(bucket);
        Assert.Equal(expectedJson, actualJson);
    }

    // Tests around Discovery google-datetime format properties.
    [Fact]
    public void IssueTimestamp_Default()
    {
        var issue = new Issue();
        Assert.Null(issue.TimestampRaw);
        Assert.Null(issue.Timestamp);
        Assert.Null(issue.TimestampDateTimeOffset);
    }

    [Fact]
    public void IssueTimestamp_ParsedFromJson()
    {
        string json = "{'timestamp':'2023-06-14T12:34:45.123Z'}".Replace('\'', '"');
        var issue = (Issue) new ManufacturerCenterService().Serializer.Deserialize(json, typeof(Issue));
        AssertIssueTimestampProperties(issue);
    }

    [Fact]
    public void Issue_SetTimestampDateTimeOffset_Utc()
    {
        var issue = new Issue();
        issue.TimestampDateTimeOffset = new DateTimeOffset(2023, 6, 14, 12, 34, 45, 123, TimeSpan.Zero);
        AssertIssueTimestampProperties(issue);
    }

    [Fact]
    public void Issue_SetTimestampDateTimeOffset_NonUtc()
    {
        var issue = new Issue();
        // This gets normalized to the UTC version.
        issue.TimestampDateTimeOffset = new DateTimeOffset(2023, 6, 14, 13, 34, 45, 123, TimeSpan.FromHours(1));
        AssertIssueTimestampProperties(issue);
    }

    [Fact]
    public void Issue_SetTimestampRaw()
    {
        var issue = new Issue();
        issue.TimestampRaw = "2023-06-14T12:34:45.123Z";
        AssertIssueTimestampProperties(issue);
    }

    [Fact]
    public void Issue_SetTimestamp_DateTime()
    {
        var issue = new Issue();
        var dateTime = new DateTime(2023, 6, 14, 12, 34, 45, 123, DateTimeKind.Utc);
        issue.Timestamp = dateTime;
        AssertIssueTimestampProperties(issue);
    }

    [Fact]
    public void Issue_SetTimestamp_String()
    {
        var issue = new Issue();
        var text = "2023-06-14T12:34:45.123Z";
        issue.Timestamp = text;
        // Can't call AssertIssueTimestampProperties as Timestamp is a string.
        Assert.Equal(text, issue.TimestampRaw);
        Assert.Equal(text, issue.Timestamp);
        Assert.Equal(new DateTimeOffset(2023, 6, 14, 12, 34, 45, 123, TimeSpan.Zero), issue.TimestampDateTimeOffset);
    }

    [Fact]
    public void Issue_SetTimestamp_DateTimeOffset()
    {
        var issue = new Issue();
        var dateTimeOffset = new DateTimeOffset(2023, 6, 14, 12, 34, 45, 123, TimeSpan.Zero);
        issue.Timestamp = dateTimeOffset;
        // Can't call AssertIssueTimestampProperties as Timestamp is a DTO, and the string representation
        // uses +00:00 instead of Z. This unfortunately means that TimestampDateTimeOffset will fail,
        // but it matches the current behavior - basically setting a google-datetime to a DateTimeOffset
        // (via the object property) in a request will cause a failure (unless the server-side parsing is lenient).
        Assert.Equal("2023-06-14T12:34:45.123+00:00", issue.TimestampRaw);
        Assert.Equal(dateTimeOffset, issue.Timestamp);
        Assert.Throws<FormatException>(() => issue.TimestampDateTimeOffset);
    }

    private static void AssertIssueTimestampProperties(Issue issue)
    {
        Assert.Equal("2023-06-14T12:34:45.123Z", issue.TimestampRaw);
        Assert.Equal(new DateTime(2023, 6, 14, 12, 34, 45, 123, DateTimeKind.Utc), issue.Timestamp);
        Assert.Equal(new DateTimeOffset(2023, 6, 14, 12, 34, 45, 123, TimeSpan.Zero), issue.TimestampDateTimeOffset);
        string expectedJson = "{'timestamp':'2023-06-14T12:34:45.123Z'}".Replace('\'', '"');
        var actualJson = new ManufacturerCenterService().SerializeObject(issue);
        Assert.Equal(expectedJson, actualJson);
    }
#pragma warning restore CS0618 // Type or member is obsolete

}
