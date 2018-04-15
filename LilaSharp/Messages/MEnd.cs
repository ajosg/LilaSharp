﻿using Newtonsoft.Json;

namespace LilaSharp.Messages
{
    public class MEnd : ITypeMessage, IVersionedMessage
    {
        public string Type => "end";

        public int Version { get; set; }

        [JsonProperty("d")]
        public string WinnerColor { get; set; }
    }
}
