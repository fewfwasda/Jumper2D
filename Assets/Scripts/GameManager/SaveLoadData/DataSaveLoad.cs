using UnityEngine;
using System.IO;
public class DataSaveLoad : MonoBehaviour
{
    public static void SaveScoreCoin()
    {
        int score 

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/saveScore.json", json);
    }
    public static void SaveCharacter(GameObject character)
    {
        DataPlayer data = new DataPlayer();

        data.Character = character;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/saveScore.json", json);
    }
    public static GameObject LoadCharacter()
    {
        string path = Application.persistentDataPath + "/saveScore.json";
        //if (File.Exists(path))
        //{
            
        //}
        string json = File.ReadAllText(path);
        DataPlayer data = JsonUtility.FromJson<DataPlayer>(json);
        return data.Character;
        //return null;
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