// Guids.cs
// MUST match guids.h
using System;

namespace IrwinHurst.ContextNavigator
{
    static class GuidList
    {
        public const string guidContextNavigatorPkgString = "bcd170bc-2301-4d20-b28e-680032d2b480";
        public const string guidContextNavigatorCmdSetString = "1d501810-21c3-4740-bb77-cf8d8b1a763b";
        public const string guidToolWindowPersistanceString = "c774602e-f4ab-45c9-aab7-558e90e91eb1";

        public static readonly Guid guidContextNavigatorCmdSet = new Guid(guidContextNavigatorCmdSetString);
    };
}