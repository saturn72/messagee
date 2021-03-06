﻿using System.Collections.Generic;

namespace Messagee.API.Services.Topics
{
    public class TopicPermissionTypes
    {
        public static readonly IEnumerable<string> All = new[] { Publisher, Subscriber };

        public const string Publisher = "pub";
        public const string Subscriber = "sub";
    }
}
