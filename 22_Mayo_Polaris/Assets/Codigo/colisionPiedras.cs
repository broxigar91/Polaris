using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionPiedras : MonoBehaviour {

	public int vida = 3;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(Player.instance.inmunity == false)
        {
            Player.instance.vida--;
            Player.instance.inmunity = true;
        }
    }



}
