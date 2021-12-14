using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if(p_collision.GetComponent<Player>() != null)
        {
            p_collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 5f, ForceMode2D.Force);
            p_collision.gameObject.GetComponent<Player>().enabled = false;
            p_collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;

            // On stop les Pipes
            for (int i = 0; i < FindObjectsOfType<Pipe>().Length; i++)
            {
                FindObjectsOfType<Pipe>()[i].enabled = false;
            }

            StartCoroutine(DisplayGameOver());

        }
    }

    IEnumerator DisplayGameOver()
    {
        yield return new WaitForSeconds(0.5f);
        FindObjectOfType<UIManager>().GameOverPanel.SetActive(true);
    }
}
