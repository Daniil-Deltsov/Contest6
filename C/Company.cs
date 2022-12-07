using System;
using System.Collections.Generic;

internal class Company
{
    private List<TeamLead> teamLeads;
    public Company(int teamLeadsAmount, int[] programmersAmount)
    {
        teamLeads = new List<TeamLead>();
        for (int i = 0; i < teamLeadsAmount; i++)
        {
            List<Programmer> programmers = new List<Programmer>();
            for (int j = 0; j < programmersAmount[i]; j++)
                programmers.Add(new Programmer(int.Parse($"{i + 1}{j + 1}")));
            teamLeads.Add(new TeamLead(i + 1, programmers));
        }
    }
    public List<TeamLead> TeamLeads
    {
        get { return teamLeads; }
    }

    public void PrintTeams()
    {
        foreach (var teamLead in teamLeads)
        {
            Console.WriteLine(teamLead);
            Console.WriteLine("Written lines of code: {0}", teamLead.GetWrittenLinesOfCode());
        }

        Console.WriteLine();
    }
}