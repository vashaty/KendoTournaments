# Data map

### Player
- Id - int
- Name - string
- Lastname - string
- Email - string
- Phone - string
- Age - int
- Sex - enum
- Grade - enum

### Tournament
- Id - int
- Name - string
- Players - List\<Player>
- Matches - List<List\<Matchup>>
- DateStart - Datetime
- DateEnd - Datetime
- AgeLimit - enum
- SexLimit - enum
- GradeLimit - enum 

### Group
- Name - enum
- Tournament - Tournament
- Players - List\<Player>

### Matchup
- Id - int
- MatchupPlayers - List\<MatchupPlayer>
- Winner - Player
- DateTime - Datetime
- MatchupRound - int
- Group - Group
- Overtime - bool

### MatchupPlayer
- Player - Player
- Symbols - List\<Symbol>
- ParentMatchup - Matchup

### Symbol
- Symbol - char
