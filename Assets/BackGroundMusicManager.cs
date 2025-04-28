using UnityEngine;
using UnityEngine.Audio;
public class BackGroundMusicManager : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;
    void Start()
    {
        SetMusicVolume();
    }
    private void SetMusicVolume()
    {
        _audioMixer.audioMixer.SetFloat("BackgroundMusic", Mathf.Lerp(-80, 0, DataSaveLoad.LoadVolumeMusic()));
    }
}
