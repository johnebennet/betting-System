﻿namespace BettingSystem.Domain.Betting.Rules;

using Common;
using Models.Bets;

internal class HomeWinningRule : Rule<Bet>
{
    public override bool IsSatisfiedBy(Bet value)
        => value.Match.Statistics.HomeScore > value.Match.Statistics.AwayScore &&
           value.Prediction == Prediction.Home;
}