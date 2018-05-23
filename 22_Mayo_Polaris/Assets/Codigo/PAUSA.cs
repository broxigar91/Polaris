using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {

    public static Pausa instance;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        gameObject.SetActive(false);
    }

    public void Continuar()
    {
        GameManager.instance.estado = EstadosJuego.JUGANDO;
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void Salir()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    

}
