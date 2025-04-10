using UnityEngine;
using System.IO;
public class DataSaveLoad : MonoBehaviour
{
    public static void SaveSacoreCoin()
    {
        DataPlayer data = new DataPlayer();

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/saveScore.json", json);
    }
    public static int LoadScoreCoin()
    {
        string path = Application.persistentDataPath + "/saveScore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DataPlayer data = JsonUtility.FromJson<DataPlayer>(json);
            return data.ScoreCoin;
        }
        return -1;
    }
}