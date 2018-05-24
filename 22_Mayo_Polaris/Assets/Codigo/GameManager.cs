﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EstadosJuego
{
    JUGANDO,
    PAUSA,
    MENUPRINCIPAL,
    VICTORIA,
    DERROTA
}

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public EstadosJuego estado;
    public GameObject menuPausa;
    public GameObject menuDerrota;
    public GameObject menuVictoria;
    private bool victoria = false;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
		        
        estado = EstadosJuego.MENUPRINCIPAL;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            estado = EstadosJuego.PAUSA;
            menuPausa.SetActive(true);
            Time.timeScale = 0;
        }

        if(estado == EstadosJuego.DERROTA)
        {
            menuDerrota.SetActive(true);
        }

        if(estado == EstadosJuego.VICTORIA)
        {
            menuVictoria.SetActive(true);
        }

	}
}
