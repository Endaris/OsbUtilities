﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OsbAnalyzer.Contracts.Warnings
{
    /* this will probably change a lot over time 
     * USE this as an estimate of urgency (sort by desc), not exact figures as they're autogenerated based on some arbitrary metrics i came up with
     * these metrics WILL change over time as i get a better idea through real-world samples or the enum will change to an int value
     * rough idea:
     * levels 0 to 4 indicate the guessed confidence in the related issue being unrankable
     * levels beyond that indicate special states of definite unrankability
     */
    public enum WarningLevel
    {
        MostLikelyRankable = 0,
        LikelyRankable = 1,
        MaybeRankable = 2,
        LikelyNotRankable = 3,
        MostLikelyNotRankable = 4,
        CompletelyBroken = 5,
    }
}