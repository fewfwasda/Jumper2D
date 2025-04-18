using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject _settingPanel;
    [SerializeField] private GameObject _shopPanel;
    private Sequence _animation;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Setting()
    {
        _settingPanel.SetActive(true);
        ShowSetting();
        _shopPanel.SetActive(false);
    }
    public void Shop()
    {
        _settingPanel.SetActive(false);
        ShowShop();
        _shopPanel.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    private void ShowSetting()
    {
        KillCirrentAnimationIfActive();
        _animation = DOTween.Sequence();
        _animation.Append(_settingPanel.transform.DOMoveX(-1, 1).From(-960));
    }
    private void ShowShop()
    {
        KillCirrentAnimationIfActive();
        _animation = DOTween.Sequence();
        _animation.Append(_shopPanel.transform.DOMoveX(-1, 1).From(-960));
    }
    private bool InAnimation() => _animation != null && _animation.active;
    private void KillCirrentAnimationIfActive()
    {
        if (InAnimation()) _animation.Kill();
    }
}