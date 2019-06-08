using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contadores : MonoBehaviour
{

    public static int totalObjetos = 0;
    public static float timeTotal = 0;

    public Transform botellaObj;
    public Transform bombilloObj;

    public float zScenePos1 = 31.6f;
    public float zScenePos2 = 35.6f;
    public float zScenePos3 = 40.6f;

    public float zBombillo1 = 50f;
    public float zBombillo2 = 80f;
    public float zBombillo3 = 110f;


    void Start()
    {

    }


    void FixedUpdate()
    {

        if (zScenePos1 < 100000)
        {

            Instantiate(botellaObj, new Vector3(2.4f, 1.93f, zScenePos1), botellaObj.rotation);//Centro
            zScenePos1 += 30;
        }//Aparicion aleatoria de botellas en el centro

        if (zScenePos2 < 100000)
        {

            Instantiate(botellaObj, new Vector3(-4.33f, 1.93f, zScenePos2), botellaObj.rotation);//Izquierda
            zScenePos2 += 30;

        }//Aparicion aleatoria de botellas en el lado izquierdo

        if (zScenePos3 < 100000)
        {

            Instantiate(botellaObj, new Vector3(10f, 1.93f, zScenePos3), botellaObj.rotation);//Derecha
            zScenePos3 += 30;

        }//Aparicion aleatoria de botellas en el lado derecho


        if (zBombillo1 < 1000)
        {
            Instantiate(bombilloObj, new Vector3(-4.33f, 1.93f, zBombillo1), bombilloObj.rotation);//Izquierda
            zBombillo1 += 50;
        }

        if (zBombillo2 < 1000)
        {
            Instantiate(bombilloObj, new Vector3(2f, 1.93f, zBombillo2), bombilloObj.rotation);
            zBombillo2 += 50;
        }

        if (zBombillo3 < 1000)
        {
            Instantiate(bombilloObj, new Vector3(2f, 1.93f, zBombillo3), bombilloObj.rotation);
            zBombillo3 += 50;
        }

        timeTotal += Time.deltaTime;
    }
}