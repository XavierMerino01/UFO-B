using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    [SerializeField]
    float forsa = 3;
    float x, y;
    Rigidbody2D rb;
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
            Destroy(collision.gameObject);
            ScrControlGame.punts += 5;
            print("La teva puntuació és: " + ScrControlGame.punts);
        }
    }
}
