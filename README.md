# API Client Generator for C#

A generator for protocol buffer described APIs for and in C#.

[![GitHub Actions status](https://img.shields.io/github/actions/workflow/status/googleapis/gapic-generator-csharp/build.yml?branch=main)](https://github.com/googleapis/gapic-generator-csharp/actions/workflows/build.yml)

This is a generator for API client libraries for APIs specified by protocol buffers, such as those inside Google.
It takes a protocol buffer (with particular annotations) and uses it to generate a client library, as specified at [aip.dev/client-libraries](https://google.aip.dev/client-libraries).

## Purpose

This generator replaces the [older monolithic generator](https://github.com/googleapis/gapic-generator),
and is suitable for production use.

## Bazel support

Bazel support is currently experimental, and may change without warning.

See [`bazel_example/README.md`](./bazel_example/README.md) for an example
of using the C# bazel rules.
