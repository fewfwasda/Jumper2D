using UnityEngine;

public class SaveScoreCoinManager : MonoBehaviour
{
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(SaveDataScore);
    }
    private void SaveDataScore(bool alivePlayer)
    {
        if (!alivePlayer) DataSaveLoad.SaveRecordsPlayer();
    }
}
