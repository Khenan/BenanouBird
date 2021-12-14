using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject GameOverPanel;

    private void Start()
    {
        StartPanel.SetActive(true);
        GameOverPanel.SetActive(false);
    }

    public void TriggerGameOver()
    {
        GameOverPanel.SetActive(true);
    }
}
