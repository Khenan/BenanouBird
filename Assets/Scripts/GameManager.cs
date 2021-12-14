using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        // On relance le RigidBody du Joueur et le script des Pipes
        FindObjectOfType<Player>().rb.bodyType = RigidbodyType2D.Dynamic;
        for (int i = 0; i < FindObjectsOfType<Pipe>().Length; i++)
        {
            FindObjectsOfType<Pipe>()[i].enabled = true;
        }
        // On ferme l'UI Start
        FindObjectOfType<UIManager>().StartPanel.SetActive(false);
    }
    public void RelaunchGame()
    {
        // On relaunch tous le Joueur et les Pipes
        FindObjectOfType<Player>().RelaunchObject();
        for (int i = 0; i < FindObjectsOfType<Pipe>().Length; i++)
        {
            FindObjectsOfType<Pipe>()[i].enabled = true;
            FindObjectsOfType<Pipe>()[i].RelaunchObject();
        }

        // On reset le Score
        FindObjectOfType<Score>().ResetScore();

        // On ferme l'UI Game Over
        FindObjectOfType<UIManager>().GameOverPanel.SetActive(false);
    }
}
