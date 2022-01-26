using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour, IMoveEightDirections
{
    public int speed;
    public Camera cam;

    public int _movementSpeed {get; set;}
    public Vector2 _moveDirection{get; set;}
    private Vector2 _mousePosition;
    private Rigidbody2D _rigidbody;
    private float _hor, _ver;

    void Start() 
    {
        _movementSpeed = speed;
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update() 
    {
        UpdateInputValues();
    }
    void FixedUpdate() 
    {
        MovePlayer();
        RotatePlayer();
    }

    public void MovePlayer()
    {
        _moveDirection = new Vector2(_hor, _ver);
        _rigidbody.MovePosition(_rigidbody.position + _moveDirection.normalized * (_movementSpeed * 1/2) * Time.fixedDeltaTime);
    }

    private void RotatePlayer()
    {
        Vector2 lookDir = _mousePosition - _rigidbody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        _rigidbody.rotation = angle;
    }

    private void UpdateInputValues()
    {
        _hor = Input.GetAxis("Horizontal");
        _ver = Input.GetAxis("Vertical");

        _mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
