using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class Laser : Weapon
{
    [SerializeField] private int _damage;
    private float _elapsedTime;
    [SerializeField] private float _waitingTime;

    private bool _isDone;
    private Transform _shootPoint;

    private void Start()
    {
        _isDone = true;
    }

    private void Update()
    {
        if (_isDone == false)
        {
            Debug.DrawRay(_shootPoint.position, Vector2.left, Color.red);

            if (_elapsedTime >= _waitingTime)
            {
                _isDone = true;
            }

            _elapsedTime += Time.deltaTime;
        }
    }

    public override void Shoot(Transform shootPoint)
    {
        _isDone = false;
        _elapsedTime = 0;

        _shootPoint = shootPoint;

        RaycastHit2D Hit = Physics2D.Raycast(_shootPoint.position, Vector2.left);

        if (Hit.collider.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
        }
    }
}
