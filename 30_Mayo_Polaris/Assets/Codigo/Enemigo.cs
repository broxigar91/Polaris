using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	public int vida = 3;
    public int daño;
    public int topeVertical = 2;
    public bool orientacion;
    public bool movimientoVertical;
	public float speed; 
	//public Vector2 pos;

	// Use this for initialization
	void Start () {

        int range = Random.Range(0, 10);

        if(range < 5)
        {
            orientacion = false;
        }
        else
        {
            orientacion = true;
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (vida == 0)
            Destroy(gameObject);

        if(GameManager.instance.estado == EstadosJuego.JUGANDO)
        {
            float movY = 0;

            if(movimientoVertical == true)
            {
                if (orientacion)//arriba
                {
                    if (transform.position.y < topeVertical)
                        movY = speed/2 * Time.deltaTime;
                    else
                        orientacion = false;
                }
                else//abajo
                {
                    if (transform.position.y > -topeVertical)

                        movY = -speed/2 * Time.deltaTime;

                    else
                        orientacion = true;
                }
            }
    
            transform.Translate(new Vector2(-speed * Time.deltaTime, movY));
        }
		    
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.gameObject.tag == "Bullet"){
            vida--;
        }
        else if(collision.gameObject.tag == "Player"){
            if(Player.instance.inmunity == false)	
            {
                AudioManager.instance.Play("DanyoJugador");
                Player.instance.vida -= daño;
                Player.instance.inmunity = true;
				Player.instance.anim.SetTrigger ("Sufriendo");
            }

        }     
	}
}
