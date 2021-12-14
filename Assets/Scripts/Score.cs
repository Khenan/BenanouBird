using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    internal void AddScore()
    {
        score += 1;
        SetTextScore();
    }
    internal void ResetScore()
    {
        score = 0;
        SetTextScore();
    }
    private void SetTextScore()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
