﻿using Ray.BiliBiliTool.Infrastructure.Helpers;

namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos.Live;

public class Silver2CoinRequest
{
    public Silver2CoinRequest(string csrf)
    {
        Csrf = csrf;
    }

    public string Csrf { get; set; }

    public string Csrf_token => Csrf;

    /// <summary>
    ///
    /// </summary>
    /// <sample>8u0w3cesz1o0</sample>
    /// <sample>33moy4vugle0</sample>
    /// <sample>9zys612vo0c0</sample>
    /// <sample>3uu2mkxt21c0</sample>
    /// <sample>8orqn5vf4i00</sample>
    public string Visit_id { get; set; } = _visitId; //todo

    public static string GetRandomVisitId()
    {
        var ran = new Random();
        int first = ran.Next(1, 10);
        int last = 0;

        var s = new RandomHelper().GenerateCode(10).ToLower();

        return $"{first}{s}{last}";
    }

    private static string _visitId = GetRandomVisitId();
}
