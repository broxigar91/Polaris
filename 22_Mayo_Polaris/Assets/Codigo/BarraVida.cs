using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraVida : MonoBehaviour {

	public int vida = 5;

	// Use this for initialization
	void Start () {
		
	}


	
	// Update is called once per frame
	void Update () {
		if(Player.instance.vida != vida)
		{
			vida = Player.instance.vida;

			switch(vida)
			{

			case 4:
				if (gameObject.name == "0Vidas")
					gameObject.GetComponent<Renderer> ().enabled = false;
				if (gameObject.name == "1Vidas")
					gameObject.GetComponent<Renderer> ().enabled = false;
				if (gameObject.name == "2Vidas")
					gameObject.GetComponent<Renderer> ().enabled = false;
				if (gameObject.name == "3Vidas")
					gameObject.GetComponent<Renderer> ().enabled = false;
				if (gameObject.name == "4Vidas") 
					gameObject.GetComponent<Renderer> ().enabled = true;
				if (gameObject.name == "5Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				break;
			case 3:
		
				if (gameObject.name == "0Vidas")
					gameObject.GetComponent<Renderer> ().enabled = false;
				if (gameObject.name == "1Vidas")
					gameObject.GetComponent<Renderer> ().enabled = false;
				if (gameObject.name == "2Vidas")
					gameObject.GetComponent<Renderer> ().enabled = false;
				if (gameObject.name == "3Vidas")
					gameObject.GetComponent<Renderer> ().enabled = true;
				if (gameObject.name == "4Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "5Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				break;
			case 2:
				
				if (gameObject.name == "0Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "1Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "2Vidas")
					gameObject.GetComponent<Renderer>().enabled = true;
				if (gameObject.name == "3Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "4Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "5Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				break;
			case 1:
				
				if (gameObject.name == "0Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "1Vidas")
					gameObject.GetComponent<Renderer>().enabled = true;
				if (gameObject.name == "2Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "3Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "4Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "5Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				break;
			case 0:
				
				if (gameObject.name == "0Vidas")
					gameObject.GetComponent<Renderer>().enabled = true;
				if (gameObject.name == "1Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "2Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "3Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "4Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				if (gameObject.name == "5Vidas")
					gameObject.GetComponent<Renderer>().enabled = false;
				break;

			}

		}
	}
}
