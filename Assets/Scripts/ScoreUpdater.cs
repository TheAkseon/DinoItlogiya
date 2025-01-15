using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private int _currentScore = 0;

    private void Start()
    {
        _scoreText.text = _currentScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out ScoreTrigger scoreTrigger))
        {
            _currentScore++;
            _scoreText.text = _currentScore.ToString();
        }
    }
}
