using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    [SerializeField]
    float velocitat = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x, y;

        x= Input.GetAxis("Horizontal");
        y= Input.GetAxis("Vertical");
        //print("Horizontal: " + x + "/Vertical: "+y);
        transform.Translate(x*Time.deltaTime*velocitat, y * Time.deltaTime*velocitat, 0);
    }
}
