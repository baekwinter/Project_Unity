using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
   private TopDownCharacterController _Controller;

    private Vector2 _movedirection = Vector2.zero;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _Controller = GetComponent<TopDownCharacterController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _Controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movedirection);
    }

    private void Move(Vector2 direction)
    {
        _movedirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5;

        _rigidbody2D.velocity = direction;
    }
}
