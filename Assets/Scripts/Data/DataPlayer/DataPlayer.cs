using UnityEngine;
using System.IO;
using System.Globalization;
[SerializeField]
public class DataPlayer
{
    public int ScoreCoin;
    public DataPlayer()
    {
        ScoreCoin = Bank.Instance.ScoreCoin;
    }
}
