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
        AnimationSetting();
        _shopPanel.SetActive(false);
    }
    public void Shop()
    {
        _settingPanel.SetActive(false);
        AnimationShop();
        _shopPanel.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    private void AnimationSetting()
    {
        KillCirrentAnimationIfActive();
        _animation = DOTween.Sequence();
        _animation.Append(_settingPanel.transform.DOMoveX(-1, 1).From(-960));
    }
    private void AnimationShop()
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