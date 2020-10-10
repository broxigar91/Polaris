using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sonido {

    public string nombre;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volumen;

    [HideInInspector]
    public AudioSource source;

    public bool bucle;


    public AudioSource GetAudioSource()
    {
        return source;
    }
}
