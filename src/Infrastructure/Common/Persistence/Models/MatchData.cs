﻿namespace BettingSystem.Infrastructure.Common.Persistence.Models
{
    using System;
    using System.Collections.Generic;
    using Application.Common.Mapping;
    using Domain.Betting.Models.Matches;

    internal class MatchData : IMapFrom<Match>, IMapTo<Match>
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public int HomeTeamId { get; set; }

        public TeamData HomeTeam { get; set; } = default!;

        public int AwayTeamId { get; set; }

        public TeamData AwayTeam { get; set; } = default!;

        public int StadiumId { get; set; }

        public Stadium Stadium { get; set; } = default!;

        public Statistics Statistics { get; set; } = default!;

        public Status Status { get; set; } = default!;

        public ICollection<BetData> Bets { get; } = new HashSet<BetData>();
    }
}
