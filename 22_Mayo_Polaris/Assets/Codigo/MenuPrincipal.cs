using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour {
   
    public void Jugar()
    {
        AudioManager.instance.Stop("Intro");
        AudioManager.instance.CambiaVolumen("PlayMode", 0.7f);
        AudioManager.instance.Play("PlayMode");
        GameManager.instance.estado = EstadosJuego.JUGANDO;
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
        AudioManager.instance.Stop("PlayMode");

        if(AudioManager.instance.GetSource("Intro").isPlaying == false)
        {
            AudioManager.instance.Play("Intro");
        }
        
        GameManager.instance.estado = EstadosJuego.MENUPRINCIPAL;
        SceneManager.LoadScene(0);
    }
}
