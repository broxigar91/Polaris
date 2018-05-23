using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrera : MonoBehaviour {

	public int vida = 3;
	public float speed; 
	public Vector2 pos;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (vida == 0)
			Destroy(gameObject);

		transform.Translate (new Vector2 (-speed * Time.deltaTime, 0));
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Bullet"){
			vida--;
		}
		else if(collision.gameObject.tag == "Player"){
			if(Player.instance.inmunity == false)
			{
				Player.instance.vida--;
				Player.instance.inmunity = true;
			}
		}     
	}
}






