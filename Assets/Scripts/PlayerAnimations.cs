using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void Jump()
    {
        _animator.SetBool("IsJumping", true);
        _animator.SetBool("IsRunning", false);
    }

    public void Run()
    {
        _animator.SetBool("IsRunning", true);
        _animator.SetBool("IsJumping", false);
    }

    public void Die()
    {
        _animator.SetBool("IsJumping", false);
        _animator.SetBool("IsRunning", false);
        _animator.SetBool("IsDie", true);
    }
}
