using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpForce;
    [SerializeField] private PlayerAnimations _playerAnimations;

    private bool _isGrounded;

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _playerAnimations.Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Ground ground))
        {
            _isGrounded = true;
            _playerAnimations.Run();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            _isGrounded = false;
        }
    }
}
