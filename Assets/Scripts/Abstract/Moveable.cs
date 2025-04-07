using UnityEngine;

public abstract class Moveable : MonoBehaviour
{
    protected virtual int Speed { get; set; }
    private void Awake()
    {
        GlobalEventManager.GameOver.AddListener(SpeedAfterDead);
    }
    protected virtual void Move(Vector2 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
    private void SpeedAfterDead()
    {
        Speed = 0;
    }
}