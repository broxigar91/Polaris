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
		
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{   vida--;
		if(vida == 0)
			Destroy(gameObject);
		Debug.Log ("CHOQUE");
	}
}
