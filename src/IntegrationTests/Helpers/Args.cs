﻿using NSubstitute;

namespace IntegrationTests
{
    static class Args
    {
        public static string String { get { return Arg.Any<string>(); } }
        public static bool Bool { get { return Arg.Any<bool>(); } }
    }
}