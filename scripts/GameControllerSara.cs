using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void delegadoAtaque(int energia);
public delegate void delegadoSaqueo();

public class GameControllerSara : MonoBehaviour {

	public static GameControllerSara controlador;
	private PlayerControllerSara jugador;

	public event delegadoAtaque Atacar;
	public event delegadoSaqueo Saquear;

	void Awake() {
		if (controlador == null) {
			controlador = this;
			DontDestroyOnLoad (this);
		}
		else if (controlador != this) {
			Destroy (gameObject);
		}

		GameObject Ethan = GameObject.Find ("ThirdPersonController");
		jugador = Ethan.GetComponent<PlayerControllerSara> ();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.X))
			Atacar(jugador.Energia());

		if (Input.GetKeyDown(KeyCode.Z))
			Saquear();
	}
}
