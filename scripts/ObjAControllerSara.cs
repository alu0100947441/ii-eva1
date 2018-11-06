using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Piedra
public class ObjAControllerSara : MonoBehaviour {

	public int poder;

	private Transform tf;
	private Renderer rend; 

	// Use this for initialization
	void Start () {
		GameControllerSara.controlador.Atacar += Atacado;
		GameControllerSara.controlador.Saquear += Saqueado;
		PlayerControllerSara.patada += CambioTamaño;
		poder = 100;

		tf = GetComponent<Transform> ();
		rend = GetComponent<Renderer>();
	}

	void Atacado(int energia) {
		// Disminuye mi poder
		poder -= energia;
		// Disminuye mi tamaño
		float newScale = tf.localScale.x - (energia * 0.3f);
		if (newScale >= 0) {
			tf.localScale = new Vector3 (newScale, newScale, newScale);
			tf.localPosition = new Vector3 (tf.localPosition.x, newScale / 2, tf.localPosition.z);
		}

		Debug.Log ("Atacado ObjA " + tf.localScale.ToString());
	}

	void Saqueado() {
		// Cambia mi color
		if (rend.material.color == Color.blue)
			rend.material.color = Color.black;
		else
			rend.material.color = Color.blue;

		Debug.Log ("Saqueado ObjA");
	}

	void CambioTamaño() {
		float newScale = tf.localScale.x + 0.3f;
		tf.localScale = new Vector3 (newScale, newScale, newScale);
		tf.localPosition = new Vector3 (tf.localPosition.x, newScale / 2, tf.localPosition.z);
	}
}
