﻿using static ReconNess.Core.Providers.IAgentRunnerProvider;

namespace ReconNess.Core.Models
{
    public class AgentRunnerProviderArgs
    {
        public AgentRunner AgentRunner { get; set; }
        public string Channel { get; set; }
        public string Command { get; set; }
        public string AgentRunnerType { get; set; }
        public bool Last { get; set; }
        public bool AllowSkip { get; set; }
        public BeginHandlerAsync BeginHandlerAsync { get; set; }
        public SkipHandlerAsync SkipHandlerAsync { get; set; }
        public ParserOutputHandlerAsync ParserOutputHandlerAsync { get; set; }
        public EndHandlerAsync EndHandlerAsync { get; set; }
        public ExceptionHandlerAsync ExceptionHandlerAsync { get; set; }
    }
}
