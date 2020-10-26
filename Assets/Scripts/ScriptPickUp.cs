using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScriptPickUp : MonoBehaviour
{
    [SerializeField]
    int angle = 0;

    public int valor = 1;

    // Start is called before the first frame update
    void Awake()
    {
        ScrControlGame.pickups++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, angle*Time.deltaTime);
    }
}
