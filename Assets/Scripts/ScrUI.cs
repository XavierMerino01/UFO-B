using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class ScrUI : MonoBehaviour
{
    /// <summary>
    /// DESCRIPCIÓ
    ///         Script per a interaccionar amb la interfície.
    /// AUTOR:  Xavier Merino
    /// DATA:   26/10/2020
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: Primera versió. Mostra i actualitza puntuació.
    /// </summary>
    /// 
    // Start is called before the first frame update

    [SerializeField]
    Text puntuació;
    public Text pickups;
    public Text temps;
    public Text finaljuego;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntuació.text = ("Puntuació: "+ScrControlGame.punts);
        pickups.text = ("PickUps restants: " + ScrControlGame.pickups);
        temps.text = Time.time.ToString("0.0"); 
        if (ScrControlGame.pickups == 0)
        {
            finaljuego.text = ("Nivell COMPLETAT!!!");
        }
    }
}
