using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverTerreno2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody>().position = new Vector3(0, 0, Traslacion.posicion2);
    }
}
