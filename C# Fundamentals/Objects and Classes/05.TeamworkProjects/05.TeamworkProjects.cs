using System.Text;

List<Team> teams = new List<Team>();
int counterTeams = int.Parse(Console.ReadLine());
for (int i = 0; i < counterTeams; i++)
{
    string[] teamOwners = Console.ReadLine().Split('-');
    Team team = new Team(teamOwners[0], teamOwners[1]);
    if (teams.Any(name => name.Name == teamOwners[1]))
    {
        Console.WriteLine($"Team {teamOwners[1]} was already created!");
        continue;
    }
    else if (teams.Any(team => team.Owner == teamOwners[0]))
    {
        Console.WriteLine($"{teamOwners[0]} cannot create another team!");
        continue;
    }
    Console.WriteLine($"Team {team.Name} has been created by {team.Owner}!");
    teams.Add(team);
}
string input;
while ((input = Console.ReadLine()) != "end of assignment")
{
    string[] teamMembers = input.Split("->");
    if (!teams.Any(team => team.Name == teamMembers[1]))
    {
        Console.WriteLine($"Team {teamMembers[1]} does not exist!");
        continue;
    }
    else if (teams.Any(team => team.Owner == teamMembers[0]) || teams.Any(team => team.Members.Contains(teamMembers[0])))
    {
        Console.WriteLine($"Member {teamMembers[0]} cannot join team {teamMembers[1]}!");
        continue;
    }
    foreach (Team member in teams)
    {
        if (member.Name == teamMembers[1])
        {
            member.Members.Add(teamMembers[0]);
        }
    }
}
teams = teams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name).ToList();
var newTeam = teams.Where(team => team.Members.Count > 0);
foreach (Team team in newTeam)
{
    Console.WriteLine(team);
}
newTeam = teams.Where(team => team.Members.Count <= 0).OrderBy(team => team.Name).ToList();
Console.WriteLine("Teams to disband:");
foreach (Team team in newTeam)
{
    Console.WriteLine(team.Name);
}
class Team
{
    public Team(string owner, string name)
    {
        Owner = owner;
        Name = name;
        Members = new List<string>();
    }
    public string Owner { get; set; }
    public string Name { get; set; }
    public List<string> Members { get; set; }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(Name);
        stringBuilder.AppendLine($"- {Owner}");
        int counter = 0;
        foreach (var member in Members)
        {
            stringBuilder.Append($"-- {member}");
            counter++;
            if (counter == Members.Count)
            {
                break;
            }
            stringBuilder.AppendLine();
        }
        return stringBuilder.ToString();
    }
}