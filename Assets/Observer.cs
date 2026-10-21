using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{

    //adjust score when the score changes
    private void OnScoreChanged(int newScore)
    {
        Debug.Log("Score updated: " + newScore);
    }

    //subscribe to the score changed event when the observer is created
    private void Awake()
    {
        ScoreManager.OnScoreChanged += OnScoreChanged;
    }

    //unsubscribe from the score changed event when the observer is destroyed
    private void OnDestroy()
    {
        ScoreManager.OnScoreChanged -= OnScoreChanged;
    }
}

