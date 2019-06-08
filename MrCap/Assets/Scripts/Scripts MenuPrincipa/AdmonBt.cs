using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmonBt : MonoBehaviour {

    public void btJugar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void btInformacion()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void btOpciones()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }

    public void SalirApp()
    {
        UnityEngine.Application.Quit();
    }
}
