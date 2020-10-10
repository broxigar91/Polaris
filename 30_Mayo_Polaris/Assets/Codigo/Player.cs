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
    public Animator anim;
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
    


	void awake () {

		Assert.IsNotNull (slashPrefab);
	}

	void Start () {
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}
    


	void Update () {  
		

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
			anim.SetFloat("MovX", mov.x);
			anim.SetFloat("MovY", mov.y);

				
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
			anim.SetBool ("Atacando", false);
		}
        else if (Input.GetKeyDown (KeyCode.Space) && delayArma >0.3) { 
			anim.SetBool ("Atacando", true);
			float angle = Mathf.Atan2 ( anim.GetFloat ("MovY"), anim.GetFloat ("MovX")) * Mathf.Rad2Deg;

			GameObject slashObj = Instantiate (slashPrefab, transform.position,Quaternion.AngleAxis (angle, Vector3.forward));
            AudioManager.instance.Play("Disparo");

            Slash slash = slashObj.GetComponent<Slash> ();



			delayArma = 0;
		}
	}

    public void ReiniciarVida()
    {
        vida = 5;
    }

}





