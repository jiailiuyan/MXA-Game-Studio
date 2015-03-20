// Guids.cs
// MUST match guids.h
using System;

namespace InsmaSoftware.MXA_Game_Studio
{
    static class GuidList
    {
        public const string guidMXA_Game_StudioPkgString = "971b8205-128c-436c-988d-2d561a8d02e2";
        public const string guidMXA_Game_StudioCmdSetString = "73509bb3-5951-4ed4-950e-cede26b02bbd";

        public static readonly Guid guidMXA_Game_StudioCmdSet = new Guid(guidMXA_Game_StudioCmdSetString);
    };
}