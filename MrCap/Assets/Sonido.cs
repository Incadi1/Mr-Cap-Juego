using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour {


    public GameObject sonido;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            sonido.SetActive(true);
        }

        /*else sonido.setactive(false)*///
    }
}
