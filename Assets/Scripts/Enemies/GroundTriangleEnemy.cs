using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


public class GroundTriangleEnemy : Enemy
{
    protected override void Start()
    {
        Speed = 15;
        Damage = 2;
        base.Start();
    }
    protected override void Update()
    {
        base.Update();
        SpinX();
    }
    private void SpinX()
    {
        transform.Rotate(Vector3.forward, 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CharacterHealth.Instance.Remove(Damage);
        }
    }
}