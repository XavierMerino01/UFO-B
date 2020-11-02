using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    [SerializeField]
    float forsa = 3;
    float x, y;
    Rigidbody2D rb;
    ScriptPickUp scrP;
    AudioSource a;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(x*forsa, y*forsa));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "PickUp") Destroy(collision.gameObject);
        if (collision.CompareTag("PickUp"))
        {
            AudioSource audioP;

            audioP = collision.GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(audioP.clip, Camera.main.transform.position);

            scrP = collision.GetComponent<ScriptPickUp>();
            ScrControlGame.punts += scrP.valor;
            Destroy(collision.gameObject);
            ScrControlGame.pickups--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        a.Play();
    }

}
