using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ShowSelectCharacter : MonoBehaviour
{
    private GameObject _charcter;

    [SerializeField] private Sprite _circleSprite;
    [SerializeField] private Sprite _squareSprite;
    private Image _currentSprite;
    public static ShowSelectCharacter Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _currentSprite = GetComponent<Image>();
        _charcter = DataSaveLoad.LoadCharacter();
        SetCharacter(_charcter);
        RotationTringle();
    }
    public void SetCharacter(GameObject character)
    {
        _charcter = character;
        switch (_charcter.name)
        {
            case "CircleCharacter":
                _currentSprite.sprite = _circleSprite;
                break;
            case "SquareCharacter":
                _currentSprite.sprite = _squareSprite;
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
