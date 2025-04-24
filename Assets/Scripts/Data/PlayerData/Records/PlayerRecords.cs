using System;
using UnityEngine;

[Serializable]
public class PlayerRecords
{
    public int ScoreCoin;

    public PlayerRecords()
    {
        ScoreCoin = Bank.ScoreCoin;
    }
}
