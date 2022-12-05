using System;
using System.Collections.Generic;

public static class Methods
{
    public static int FindBestBiathlonistValue(List<Sportsman> sportsmen)
    {
        int best = 0;
        foreach (Sportsman s in sportsmen)
        {
            if (s is Biathlonist)
            {
                IShooter? biathlonistShoot = s as Biathlonist;
                ISkiRunner? biathlonistRun = s as Biathlonist;
                int result = ((int)(0.4 * Math.Max(biathlonistShoot.Shoot(), biathlonistRun.Run()) + 0.6 *
                    Math.Min(biathlonistShoot.Shoot(), biathlonistRun.Run())));
                if (result > best)
                    best = result;
            }
        }
        return best;
    }
    public static int FindBestShooterValue(List<Sportsman> sportsmen)
    {
        int best = 0;
        foreach (Sportsman s in sportsmen)
        {
            if (s is Shooter)
            {
                IShooter? shooter = (s as Shooter);
                if (shooter.Shoot() > best)
                    best = shooter.Shoot();
            }
        }
        return Math.Max(best, FindBestBiathlonistValue(sportsmen));
    }

    public static int FindBestRunnerValue(List<Sportsman> sportsmen)
    {
        int best = 0;

        foreach (Sportsman s in sportsmen)
        {
            if (s is SkiRunner)
            {
                ISkiRunner? skiRunner = (s as SkiRunner);
                if (skiRunner.Run() > best)
                    best = skiRunner.Run();
            }
        }

        return Math.Max(best, FindBestBiathlonistValue(sportsmen));
    }
}