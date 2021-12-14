using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private float MaxHeight = 2.5f;
    private float MinHeight = 0f;
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if(p_collision.GetComponent<Pipe>() != null)
        {
            p_collision.transform.position = new Vector3(7f, Random.RandomRange(MinHeight, MaxHeight), 0f);
        }
    }
}
