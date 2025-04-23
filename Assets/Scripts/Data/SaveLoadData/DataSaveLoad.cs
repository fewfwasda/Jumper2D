using UnityEngine;
using System.IO;
public class DataSaveLoad : MonoBehaviour
{
    public static void SaveRecordsPlayer()
    {
        PlayerRecords data = new PlayerRecords();

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savePlayerRecords.json", json);
    }
    public static int LoadCoin()
    {
        string path = Application.persistentDataPath + "/savePlayerRecords.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerRecords data = JsonUtility.FromJson<PlayerRecords>(json);
            return data.ScoreCoin;
        }
        return 0;
    }

    public static void SaveCharacter(GameObject character)
    {
        DataCharacter data = new DataCharacter();

        data.Character = character;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveCharacter.json", json);
    }
    public static GameObject LoadCharacter()
    {
        string path = Application.persistentDataPath + "/saveCharacter.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DataCharacter data = JsonUtility.FromJson<DataCharacter>(json);
            return data.Character;
        }
        return null;
    }
}