using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.name == "botella")
        {
            transform.Rotate(3, 3, 0);
        }

        if (gameObject.name == "Bombillo")
        {
            transform.Rotate(3, 3, 0);
        }
    }
}
