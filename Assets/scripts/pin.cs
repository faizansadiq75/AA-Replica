using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 15f;
    private bool isPinned = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "rotator")
        {
            score.Pincount++;
            isPinned = true;
            transform.SetParent(collision.transform);
        }
        else if (collision.tag == "pin")
        {
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
