using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimiento : MonoBehaviour
{


    public KeyCode moveL;
    public KeyCode moveR;

    public static float frontVel = 10f;
    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";

    public Interactivo BtIzq;
    public Interactivo BtDerecho;

    /*
    public float speed = 18;
    public float turnSpeed = 60;
    private Rigidbody rig;*/



    void Start()
    {
       // rig = GetComponent<Rigidbody>();
    }





    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, frontVel);

        if ((Input.GetKeyUp(moveL) || (BtIzq.pulsado)) && (laneNum > 1) && (controlLocked == "n"))//condicional
        {
            horizVel = -28;
            StartCoroutine(stopSlite());
            laneNum -= 1;
            controlLocked = "y";
        }

        if ((Input.GetKeyUp(moveR) || (BtDerecho.pulsado)) && (laneNum < 3) && (controlLocked == "n"))
        {
            horizVel = 28;
            StartCoroutine(stopSlite());
            laneNum += 1;
            controlLocked = "y";
        }
/*
        float dPadX = Input.GetAxis("X360_DPadX");
        float dPadY = Input.GetAxis("X360_DPadY");
        float triggerAxis = Input.GetAxis("X360_Triggers");

        if (dPadX != 0)
        {
            print("DPad Horizontal Value: " + dPadX);
        }
        if (dPadY != 0)
        {
            print("DPad Vertical Value: " + dPadY);
        }
        if (triggerAxis != 0)
        {
            print("Trigger Value: " + triggerAxis);
        }
        if (Input.GetButtonDown("X360_LBumper"))
        {
            print("Left Bumper");
        }
        if (Input.GetButtonDown("X360_RBumper"))
        {
            print("Right Bumper");
        }
        if (Input.GetButtonDown("X360_A"))
        {
            print("A Button");
        }
        if (Input.GetButtonDown("X360_B"))
        {
            print("B Button");
        }
        if (Input.GetButtonDown("X360_X"))
        {
            print("X Button");
        }
        if (Input.GetButtonDown("X360_Y"))
        {
            print("Y Button");
        }
        if (Input.GetButtonDown("X360_Back"))
        {
            print("Back Button");
        }
        if (Input.GetButtonDown("X360_Start"))
        {
            print("Start Button");
        }
        if (Input.GetButtonDown("X360_LStickClick"))
        {
            print("Clicked Left Stick");
        }
        if (Input.GetButtonDown("X360_RStickClick"))
        {
            print("Clicked Right Stick");
        }

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        float rStickX = Input.GetAxis("X360_RStickX");

        Vector3 movement = transform.TransformDirection(new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime);

        rig.MovePosition(transform.position + movement);

        Quaternion rotation = Quaternion.Euler(new Vector3(0, rStickX, 0) * turnSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, rStickX, 0), turnSpeed * Time.deltaTime);
        */
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Lethal")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "util")
        {
            Destroy(other.gameObject);
            Contadores.totalObjetos += 1;
            frontVel += 0.2f;
        }
        if (other.gameObject.tag == "Damage")
        {
            Destroy(other.gameObject);
            HealthBar.vida -= 1;
            if (HealthBar.vida == 0)
            {
                SceneManager.LoadScene("GameOver");
            }


        }

        if (other.gameObject.name == "accionar1")
        {
            Traslacion.posicion1 = Traslacion.posicion1 + 282f;
        }
        if (other.gameObject.name == "accionar2")
        {
            Traslacion.posicion2 = Traslacion.posicion2 + 282f;
        }
        if (other.gameObject.name == "accionar3")
        {
            Traslacion.posicion3 = Traslacion.posicion3 + 282f;
        }//trasladar terrenos
    }



    IEnumerator stopSlite()
    {
        yield return new WaitForSeconds(.2f);
       // turnSpeed = 0;
        horizVel = 0;
        controlLocked = "n";
    }


}