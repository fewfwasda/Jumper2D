using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;
using TMPro;
[RequireComponent(typeof(Image))]
public class ProgressWave : MonoBehaviour
{
    private Image _imageProgress;
    [SerializeField]private TextMeshProUGUI _textWave;
    private int waveCount = 1;
    private int maxWaveCount = 2;
    private bool finishGame = true;
    private void Awake()
    {
        GlobalEventManager.StatePlayer.AddListener(StopFillSlider);
    }
    void Start()
    {
        _textWave.text = $"Wave: {waveCount}";
        _imageProgress = GetComponent<Image>();
        FillSlider();
    }
    private  void FillSlider()
    {
        _imageProgress.DOFillAmount(1, 20f).From(0).SetEase(Ease.Linear).OnStepComplete(NextWave);
    }
    private void NextWave()
    {
        waveCount++;
        _textWave.text = $"Wave: {waveCount}";
        if (waveCount <= maxWaveCount)
        {
            GlobalEventManager.SendNextWave();
            _imageProgress.DOFillAmount(0, 10f).From(1).OnStepComplete(FillSlider);
        }
        else FinishGame();
    }
    private void StopFillSlider(bool stop)
    {
        if(stop)_imageProgress.DOKill();
    }
    private void FinishGame()
    {
        GlobalEventManager.SendFinishGame(finishGame);
    }
}
