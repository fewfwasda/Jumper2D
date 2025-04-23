using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;
using TMPro;
[RequireComponent(typeof(Image))]
public class ProgressWaveUI : MonoBehaviour
{
    private Image _imageProgress;
    [SerializeField] private TextMeshProUGUI _textWave;
    private int waveCount = 1;
    private void Awake()
    {
        GlobalEventManager.IsPlayerAlive.AddListener(StopFillBar);
    }
    void Start()
    {
        _textWave.text = $"Wave: {waveCount}";
        _imageProgress = GetComponent<Image>();
        FillBar();
    }
    private void FillBar()
    {
        _imageProgress.DOFillAmount(1, 60f).From(0).SetEase(Ease.Linear).OnStepComplete(ResetBar).SetLink(gameObject);
    }
    private void ResetBar()
    {
        waveCount++;
        _textWave.text = $"Wave: {waveCount}";
        _imageProgress.DOFillAmount(0, 10f).From(1).OnStepComplete(FillBar).SetLink(gameObject);
    }
    private void StopFillBar(bool alivePlayer)
    {
        if (!alivePlayer) _imageProgress.DOKill();
    }
}
