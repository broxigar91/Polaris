﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWinLose : MonoBehaviour {

    public static MenuWinLose instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        gameObject.SetActive(false);
    }


    public void VolverAPrincipal()
    {
        gameObject.SetActive(false);
        Player.instance.ReiniciarVida(); // esto se hace porque en caso de que vuelvas al menu principal y le das luego a jugar el jugador no tenga la vida en gris
        gameObject.GetComponent<MenuPrincipal>().VolverAPrincipal();
    }

    public void VolverAJugar()
    {
        gameObject.SetActive(false);
        Player.instance.ReiniciarVida();
        gameObject.GetComponent<MenuPrincipal>().Jugar();
    }
}
