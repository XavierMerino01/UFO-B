using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrControlGame : MonoBehaviour
{
    public static int punts = 0; // puntuació
    public static int pickups = 0; // pick ups en escena

    private void Update()
    {
        if (pickups == 0)
        {
            //JuegoAcabado();
            Time.timeScale = 0;
        }
    }

    /*void JuegoAcabado()
    {
        print("Has superat el nivell");
    }*/
}
