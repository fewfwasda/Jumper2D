using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject _settingScreen;
    [SerializeField] private GameObject _shopScreen;
    private Sequence _animation;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Setting()
    {
        if(_shopScreen.activeSelf) CloseScreen(_shopScreen);
        if (!_settingScreen.activeSelf) OpenScreen(_settingScreen);
        else CloseScreen(_settingScreen);
    }
    public void Shop()
    {
        if (_settingScreen.activeSelf) CloseScreen(_settingScreen);
        if (!_shopScreen.activeSelf) OpenScreen(_shopScreen);
        else CloseScreen(_shopScreen);
    }
    public void Quit()
    {
        Application.Quit();
    }
    private void OpenScreen(GameObject screen)
    {
        screen.SetActive(true);
        KillCurrentAnimationIfActive();
        _animation = DOTween.Sequence();
        _animation.Append(screen.transform.DOScale(1, 0.5f).SetEase(Ease.Linear));
    }
    private void CloseScreen(GameObject screen)
    {
        KillCurrentAnimationIfActive();
        screen.transform.localScale = new Vector3(0, 0, 0);
        screen.SetActive(false);
    }

    private bool InAnimation() => _animation != null && _animation.active;
    private void KillCurrentAnimationIfActive()
    {
        if (InAnimation()) _animation.Kill();
    }
}