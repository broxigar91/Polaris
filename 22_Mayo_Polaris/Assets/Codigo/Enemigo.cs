using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	public int vida = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (vida == 0)
            Destroy(gameObject);
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.gameObject.tag == "Bullet")
        {
            vida--;
        }
        else if(collision.gameObject.tag == "Player")
        {
            if(Player.instance.inmunity == false)
            {
                Player.instance.vida--;
                Player.instance.inmunity = true;
            }
            
        }
        
        
	}
}
