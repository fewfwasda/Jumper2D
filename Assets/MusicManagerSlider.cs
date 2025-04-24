using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class MusicManagerSlider : MonoBehaviour
{
    private Slider _sliderMusic;
    private float _volume;
    [SerializeField] private AudioMixerGroup _audioMixer;
    private void Start()
    {
        _sliderMusic = GetComponent<Slider>();
        SetVolume();
    }
    private void SetVolume()
    {
        _sliderMusic.value = DataSaveLoad.LoadVolumeMusic();
        _audioMixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, DataSaveLoad.LoadVolumeMusic()));
    }
    public void SaveVolume()
    {
        DataSaveLoad.SaveVolumeMusic(_sliderMusic.value);
    }
    public void ChangeVolume()
    {
        _audioMixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, _sliderMusic.value));
    }
}
