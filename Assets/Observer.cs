using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
 
    private void OnScoreChanged(int newScore)
    {
        Debug.Log("Score updated: " + newScore);
    }

    private void Awake()
    {
        ScoreManager.OnScoreChanged += OnScoreChanged;
    }

    private void OnDestroy()
    {
        ScoreManager.OnScoreChanged -= OnScoreChanged;
    }
}

