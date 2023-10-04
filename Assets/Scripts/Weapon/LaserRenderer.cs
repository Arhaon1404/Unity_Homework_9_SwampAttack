using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class LaserRenderer : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;

    [SerializeField] private float _waitingTime;

    private Coroutine _drawLineCoroutine;
    private bool _isDone;

    private void Start()
    {
        _isDone = true;
    }

    private IEnumerator DrawLine(Transform shootPoint, RaycastHit2D hit)
    {
        _lineRenderer.SetPosition(0, shootPoint.position);
        _lineRenderer.SetPosition(1, hit.point);
        _lineRenderer.enabled = true;

        yield return new WaitForSeconds(_waitingTime);

        _lineRenderer.enabled = false;
    }

    public void RunCoroutine(Transform shootPoint, RaycastHit2D hit)
    {
        _isDone = true;

        if (_drawLineCoroutine != null & _isDone == true)
        {
            StopCoroutine(_drawLineCoroutine);
        }

        if (_isDone == true)
        {
            _isDone = false;
            _drawLineCoroutine = StartCoroutine(DrawLine(shootPoint, hit));
        }
    }
}
