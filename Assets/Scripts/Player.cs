using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forceJump = 30f;
    public float speedYJump = 10f;
    public float speedYFall = -1f;
    public float speedRotation = 5f;
    internal Rigidbody2D rb;
    private CircleCollider2D col;
    private Vector3 initialPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();
        initialPos = transform.position;

        // On le stop avant de commencer la première partie
        rb.bodyType = RigidbodyType2D.Static;
    }
    private void Update()
    {
        ////////// ANDROID //////////
        // Jump Force and Speed
        if (Input.touchCount > 0 && Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * forceJump, ForceMode2D.Force);
            if (rb.velocity.y > speedYJump)
            {
                rb.velocity = new Vector2(0, speedYJump);
            }
            if (rb.velocity.y < speedYFall)
            {
                rb.velocity = new Vector2(0, speedYFall);
            }
        }

        ////////// PC //////////
        // Jump Force and Speed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * forceJump, ForceMode2D.Force);
            if (rb.velocity.y > speedYJump)
            {
                rb.velocity = new Vector2(0, speedYJump);
            }
            if (rb.velocity.y < speedYFall)
            {
                rb.velocity = new Vector2(0, speedYFall);
            }
        }

        ////////// ALL PLATFORM //////////
        // Rotation
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * speedRotation);
        if(transform.rotation.z > 90f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90f);
        }
    }

    public void RelaunchObject()
    {
        transform.position = initialPos;
        rb.velocity = Vector2.zero;
        GetComponent<Player>().enabled = true;
        col.enabled = true;
    }
}
