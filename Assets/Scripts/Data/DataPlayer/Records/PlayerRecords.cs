using System;
using UnityEngine;

[Serializable]
public class PlayerRecords
{
    public int ScoreCoin;
    public int ScoreWave;

    public PlayerRecords()
    {
        ScoreCoin = Bank.ScoreCoin;
        ScoreWave = 0;
    }
}
