using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void cambiarTamaño(); 

public class PlayerControllerSara : MonoBehaviour {

	public Text energiaText;
	public Text oroText;

	private int energia;
	private int oro;

	public static event cambiarTamaño patada;

	// Use this for initialization
	void Start () {
		energia = 1;
		oro = 0;
		UpdateText();

		GameControllerSara.controlador.Saquear += AumentarOro;
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Rama") {
			// Cambiar color Piedra
			patada();
		}
	}

	public int Energia() {
		return energia;
	}

	public void ComprarEnergia() {
		if (oro >= 3) {
			energia++;
			oro -= 3;
			UpdateText();
		}
	}

	public void AumentarOro() {
		this.oro += 1;
		UpdateText();
	}

	void UpdateText() {
		energiaText.text = energia.ToString();
		oroText.text = oro.ToString();
	}

}
