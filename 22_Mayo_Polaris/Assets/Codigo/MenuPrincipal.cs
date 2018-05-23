using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour {

    public void Jugar()
    {
        SceneManager.LoadScene(3);
    }
    
    public void Salir()
    {
        Application.Quit();
    }

    public void Controles()
    {
        SceneManager.LoadScene(1);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(2);
    }

    public void VolverAPrincipal()
    {
        SceneManager.LoadScene(0);
    }
}
