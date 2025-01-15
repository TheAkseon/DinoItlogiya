using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private PlayerAnimations _playerAnimations;
    [SerializeField] private Button _restartButton;

    private void Start()
    {
        _restartButton.onClick.AddListener(SetRestartButton);
        _restartButton.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            _playerAnimations.Die();
            Time.timeScale = 0f;
            _restartButton.gameObject.SetActive(true);
        }
    }

    private void SetRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
