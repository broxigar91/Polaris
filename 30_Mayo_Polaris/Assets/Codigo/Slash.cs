using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour {

	[Tooltip("Esperar X segundos antes de destruir el objeto")]

	[HideInInspector]
	public Vector2 mov;

	public int speed = 4;
	public int vida = 10;


	void Start (){
		Destroy (gameObject, 1.1f);
	}

	void Update () {
		transform.position += new Vector3(mov.x= 4,mov.y,0) * speed * Time.deltaTime;
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{   
		if(collision.tag != "Player")
			Destroy(gameObject);
	}



}