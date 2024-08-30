using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public GameObject LOSER;
    public float flapStrength;
    
    void Start()
    {
        //   Destroy(gameObject,3f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //  Destroy(gameObject);
            
           rb.AddForce (Vector2.up * flapStrength);
          // rb.velocity = Vector2.right * 7f;
        }
        
       // rb.velocity = Vector2.right * 5f;
    }
    private void OnMouseDown()
    {
       // Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

            LOSER.SetActive(true);
        }
        else if(collision.gameObject.tag=="kill")
        {
            Destroy(collision.gameObject);

          //  kill.SetActive(true);
        }
        
    }
}
