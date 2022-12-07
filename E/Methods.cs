using System;
using System.Collections.Generic;

public static class Methods
{
#nullable enable
    public static int FindBestBiathlonistValue(List<Sportsman>? sportsmen)
    {
        int best = 0;
        if (sportsmen != null)
        {
            foreach (Sportsman s in sportsmen)
            {
                if (s is Biathlonist)
                {
                    IShooter? biathlonistShoot = s as Biathlonist;
                    ISkiRunner? biathlonistRun = s as Biathlonist;
                    if (biathlonistRun is not null && biathlonistShoot is not null)
                    {
                        int result = ((int)(0.4 * Math.Max(biathlonistShoot.Shoot(), biathlonistRun.Run()) + 0.6 *
                        Math.Min(biathlonistShoot.Shoot(), biathlonistRun.Run())));
                        if (result > best)
                            best = result;
                    }
                }
            }
        }
        return best;
    }

    public static int FindBestShooterValue(List<Sportsman>? sportsmen)
    {
        int best = 0;
        if (sportsmen != null)
        {
            foreach (Sportsman s in sportsmen)
            {
                if (s is Shooter)
                {
                    IShooter? shooter = (s as Shooter);
                    if (shooter is not null)
                    {
                        if (shooter.Shoot() > best)
                            best = shooter.Shoot();
                    }
                }
                if (s is Biathlonist)
                {
                    IShooter? biathlonistShoot = s as Biathlonist;
                    if (biathlonistShoot is not null && biathlonistShoot.Shoot() > best)
                    {
                        best = biathlonistShoot.Shoot();
                    }
                }
            }
        }
        return best;
    }

    public static int FindBestRunnerValue(List<Sportsman>? sportsmen)
    {
        int best = 0;
        if (sportsmen != null)
        {
            foreach (Sportsman s in sportsmen)
            {
                if (s is SkiRunner)
                {
                    ISkiRunner? skiRunner = (s as SkiRunner);
                    if (skiRunner is not null && skiRunner.Run() > best)
                    {
                        best = skiRunner.Run();
                    }
                }
                if (s is Biathlonist)
                {
                    ISkiRunner? biathlonistRun = s as Biathlonist;
                    if (biathlonistRun is not null && biathlonistRun.Run() > best)
                    {
                        best = biathlonistRun.Run();
                    }
                }
            }
        }
        return best;
    }
#nullable disable
}