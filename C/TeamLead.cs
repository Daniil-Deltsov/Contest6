using System;
using System.Collections.Generic;

internal class TeamLead : Programmer
{
    private readonly List<Programmer> programmers;

    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        this.programmers = programmers;
    }

    /// <summary>
    /// ≈сли написанное программистом число строк кода кратно идентификаторам нескольких тимлидов, 
    /// то его успевает "хантить" последний тимлид.
    /// </summary>

    public void HuntProgrammers(List<TeamLead> teamLeads)
    {
        int j = 0;
        while (j < teamLeads.Count)
        {
            if (teamLeads[j].Id != this.Id)
            {
                int i = 0;
                while (i < teamLeads[j].programmers.Count)
                {
                    if (teamLeads[j].programmers[i].LinesOfCode % (this.Id + 1) == 0)
                    {
                        programmers.Add(teamLeads[j].programmers[i]);
                        teamLeads[j].programmers.Remove(teamLeads[j].programmers[i]);
                        i--; // ??
                    }
                    i++;
                }
            }
            j++;
        }
    }

    public override string ToString()
    {
        return $"Team lead #{Id}\nAmount of programmers in team: {programmers.Count}";
    }

    internal int GetWrittenLinesOfCode()
    {
        int sum = 0;

        foreach (Programmer programmer in programmers)
            sum += programmer.LinesOfCode;

        return sum + this.LinesOfCode;
    }
}