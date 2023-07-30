using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick _joystick;
    public GameObject gameOver;    
    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, rb.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal !=0 || _joystick.Vertical !=0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
    }

    private void Update()
    {
        if (transform.position.y <-6)
        {
            gameOver.SetActive(true);
            Time.timeScale= 0.0f;
        }
    }
}
