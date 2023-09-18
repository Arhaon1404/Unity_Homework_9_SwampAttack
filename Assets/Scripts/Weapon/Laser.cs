using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class Laser : Weapon
{
    [SerializeField] private int _damage;
    [SerializeField] private float _waitingTime;

    public override void Shoot(Transform shootPoint)
    {
        RaycastHit2D Hit = Physics2D.Raycast(shootPoint.position, Vector2.left);

        Debug.DrawRay(shootPoint.position, Vector2.left * 15, Color.red, _waitingTime);

        if (Hit.collider.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
        }
    }
}
