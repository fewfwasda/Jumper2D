using System;
using UnityEngine;

[Serializable]
public class ScoreCoin
{
    public int Coin;

    public ScoreCoin()
    {
        Coin = Bank.ScoreCoin;
    }
}
