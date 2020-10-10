using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager instance;


    public Sonido[] sonidos;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sonido s in sonidos)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volumen;
            s.source.loop = s.bucle;
        }

        Play("Intro");
    }

    public void Play(string nombre)
    {
        Sonido sonido = Array.Find(sonidos, s => s.nombre == nombre);

        if (sonido != null)
        {
            sonido.source.Play();
        }

    }

    public void Stop(string nombre)
    {
        Sonido sonido = Array.Find(sonidos, s => s.nombre == nombre);

        if (sonido != null)
        {
            sonido.source.Stop();
        }
    }


    public AudioSource GetSource(string nombre)
    {
        Sonido sonido = Array.Find(sonidos, s => s.nombre == nombre);

        return sonido.GetAudioSource();
    }

    public void CambiaVolumen(string nombre, float nuevoVolumen)
    {
        Sonido sonido = Array.Find(sonidos, s => s.nombre == nombre);

        sonido.volumen = nuevoVolumen;
        sonido.source.volume = sonido.volumen;
    }

}
