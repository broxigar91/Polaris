using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class Player : MonoBehaviour {

	public static Player instance;
	public float speed = 2f;
	public GameObject slashPrefab;
	public float delayArma;


    Animator anim;
    Rigidbody2D rb2d;
    Vector2 mov;  // Ahora es visible entre los métodos

    public int vida = 5;
	public float inmunityTime;
	public float tiempo;
	public bool inmunity = false;

	private void Awake()
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
			Debug.LogWarning ("Player ha sido instanciado por segunda vez");
		}
	}
    
	//COPIAR ESTA PARTE EN EL ARCHIVO DEL OSO


//	public float vida = 10033;
//	public float inmunityTime;
//	public float tiempo;
//	public bool inmunity = false;
//
	//COPIAR ESTA PARTE EN EL ARCHIVO DEL OSO, CUALQUIER PARTE
	//
//	public void OnCollisionEnter2D(Collision2D collision)
//	{
//		if (collision.collider.name == "Pedrusco") {
//			if(!inmunity)
//				vida--;
//			inmunity = true;
//			Debug.Log ("Se han chocado en PLAYER");
//		}
//
//	}
//
	//   //COPIAR ESTA PARTE EN VOID UPDATE() DEL OSO
//	Debug.Log (vida + "tienes");
//
//	if (inmunity) {
//		inmunityTime += Time.deltaTime;
//		if (inmunityTime >= 1.5) {
//			inmunity = false;
//			inmunityTime = 0;
//		}
//
//	}

	void awake () {

		Assert.IsNotNull (slashPrefab);
	}

	void Start () {
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}
    


	void Update () {  

		Debug.Log (vida + "tienes");

		if (inmunity) {
			inmunityTime += Time.deltaTime;
			if (inmunityTime >= 1.5) {
				inmunity = false;
				inmunityTime = 0;
			}

		}

		delayArma += Time.deltaTime;


        if(GameManager.instance.estado == EstadosJuego.JUGANDO)
        {
            // Detectamos el movimiento
            Movements();
            // Procesamos las animaciones
            Animations();

            // tristeza
            SlashAttack();
        }


        if(vida <=0)
        {
            GameManager.instance.estado = EstadosJuego.DERROTA;
            GameManager.instance.menuDerrota.SetActive(true);
            
        }
	}
		
	void Movements () {
		// Detectamos el movimiento en un vector 2D
		mov = new Vector2(
			Input.GetAxisRaw("Horizontal"),
			Input.GetAxisRaw("Vertical")
		);
	}

	void Animations () {

		if (mov != Vector2.zero) {
			anim.SetFloat("movX", mov.x);
			anim.SetFloat("movY", mov.y);
		}
	}



	void FixedUpdate () {

        if (GameManager.instance.estado == EstadosJuego.JUGANDO)
            // Nos movemos en el fixed por las físicas
            rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
	}


    void SlashAttack ()
    {
		// Buscamos el estado actual mirando la información del animador
		//AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo (0);

		// Ataque a distancia CAMBIAR DELAYARMA PARA QUE EL PROJECTIL VAYA MAS LENTO/RAPIDO
		if (Input.GetKeyUp (KeyCode.Space)){
		}
        else if (Input.GetKeyDown (KeyCode.Space) && delayArma >0.3) { 
				float angle = Mathf.Atan2 ( anim.GetFloat ("movY"), anim.GetFloat ("movX")) * Mathf.Rad2Deg;

				GameObject slashObj = Instantiate (slashPrefab, transform.position,Quaternion.AngleAxis (angle, Vector3.forward));

				Slash slash = slashObj.GetComponent<Slash> ();
				slash.mov.x = anim.GetFloat ("movX");
				slash.mov.y = anim.GetFloat ("movY");
			delayArma = 0;
		}
	}

    public void ReiniciarVida()
    {
        vida = 5;
    }

}





