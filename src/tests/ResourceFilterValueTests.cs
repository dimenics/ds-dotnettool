﻿using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ResourceFilterValueTests
    {
        [Fact]
        public void Mapping_ResourceFilterValue_TestProperties()
        {
            Options.ResourceFilterValueOptions options = new();
            options.AssertEqualProperties((Sdk.Import.ResourceFilterValue)options);
        }
    }
}