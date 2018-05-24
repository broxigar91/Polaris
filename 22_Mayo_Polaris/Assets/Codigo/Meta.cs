using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour {

    public int speed;

    private void Update()
    {
        if (GameManager.instance.estado == EstadosJuego.JUGANDO)
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.instance.estado = EstadosJuego.VICTORIA;
        }
    }
}
