using DG.Tweening;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ShowSelectedCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _charcter;

    [SerializeField] private Sprite _circleSprite;
    [SerializeField] private Sprite _rectangleSprite;
    private Image _currentSprite;
    public static ShowSelectedCharacter Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        if (DataSaveLoad.LoadCharacter() != null) _charcter = DataSaveLoad.LoadCharacter();
        _currentSprite = GetComponent<Image>();
        ShowCharacter(_charcter);
        RotationTringle();
    }
    public void ShowCharacter(GameObject character)
    {
        _charcter = character;
        switch (_charcter.name)
        {
            case "CircleCharacter":
                _currentSprite.sprite = _circleSprite;
                break;
            case "RectangleCharacter":
                _currentSprite.sprite = _rectangleSprite;
                break;
            default:
                _currentSprite.sprite = _circleSprite;
                break;
        }
    }
    private void RotationTringle()
    {
        transform.DORotate(new Vector3(0, 0, -360), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
}
