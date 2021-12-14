using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1000f;
    private float MaxHeight = 2.5f;
    private float MinHeight = 0f;
    private Vector3 initialPos;

    private void Start()
    {
        initialPos = transform.position;
        transform.position = new Vector2(transform.position.x, Random.RandomRange(MinHeight, MaxHeight));

        // On le stop avant la première partie
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * speed * Time.deltaTime;
    }

    public void RelaunchObject()
    {
        transform.position = initialPos;
    }
}
