using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Texto : MonoBehaviour
{

    int recordObjetos = 0;
    float recordTiempo = 0;

   /* public void guardar()
    {
         string carpeta = Application.StartupPath + @"\registros";
        [SerializeField]
         string archivo = @"\ArchivoTexto.txt";
        [SerializeField]
         string crear = carpeta + archivo;
        
         try

         {

         if(File.Exists(crear))
             {
                 
             }


             else{
                 MesaggeBox.Show("No existe. Creando...");
                 Directory.CreateDirectory(carpeta);
                 using(File.Create(crear));

                 string[] texto = { recordObjetos, recordTiempo };
     File.WriteAllLines(crear, texto);
         }
        S}

    }*/
    

    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update()
    {

        if (Contadores.totalObjetos > recordObjetos)
        {
            recordObjetos = Contadores.totalObjetos;
        }
        if (Contadores.timeTotal > recordTiempo)
        {
            recordTiempo = Contadores.timeTotal;
        }

        if (gameObject.name == "Vida")
        {
            GetComponent<TextMesh>().text = HealthBar.vida + "x";
        }
        if (gameObject.name == "Objetos")
        {
            GetComponent<TextMesh>().text = "" + Contadores.totalObjetos;
        }

        if (gameObject.name == "Tiempo")
        {
            GetComponent<TextMesh>().text = "Tiempo: " + Contadores.timeTotal.ToString("f2") + " segundos";
        }

        if (gameObject.name == "RecordObjetos")
        {
            GetComponent<TextMesh>().text = "Record de objetos reciclados: " + recordObjetos;
        }

        if (gameObject.name == "RecordTiempo")
        {
            GetComponent<TextMesh>().text = "Record de tiempo: " + recordTiempo.ToString("f2") + " segundos";
        }
    }
}