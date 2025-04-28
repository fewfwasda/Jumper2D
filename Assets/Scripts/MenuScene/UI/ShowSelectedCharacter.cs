using DG.Tweening;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ShowSelectedCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _character;

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
        //if (DataSaveLoad.LoadCharacter() != null) _character = DataSaveLoad.LoadCharacter();
        _currentSprite = GetComponent<Image>();
        ShowCharacter(_character);
        RotationCharacter();
    }
    public void ShowCharacter(GameObject character)
    {
        _character = character;
        switch (_character.name)
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
    private void RotationCharacter()
    {
        transform.DORotate(new Vector3(0, 0, -360), 1.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear).SetLink(gameObject);
    }
}
