using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private PlayerAnimations _playerAnimations;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            _playerAnimations.Die();
            Time.timeScale = 0f;
        }
    }
}
