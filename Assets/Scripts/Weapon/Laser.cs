using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

//[RequireComponent(typeof(LaserRenderer))]
public class Laser : Weapon
{
    [SerializeField] private int _damage;

    public override void Shoot(Transform shootPoint)
    {
        RaycastHit2D hit = Physics2D.Raycast(shootPoint.position, Vector2.left);


        if (hit.collider.gameObject.TryGetComponent(out Enemy enemy))
        {
            shootPoint.GetComponent<LaserRenderer>().RunCoroutine(shootPoint, hit);
            enemy.TakeDamage(_damage);
        }
    }
}
