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

    public static void SaveVolumeMusic(float volume)
    {
        MusicData data = new MusicData();

        data.Volume = volume;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/saveVolumeMusic.json", json);
    }

    public static float LoadVolumeMusic()
    {
        string path = Application.persistentDataPath + "/saveVolumeMusic.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            MusicData data = JsonUtility.FromJson<MusicData>(json);
            return data.Volume;
        }
        return 0;
    }
}