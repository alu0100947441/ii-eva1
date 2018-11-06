using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rama
public class ObjBControllerSara : MonoBehaviour {

	private Renderer rend; 

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();

		GameControllerSara.controlador.Saquear += Saqueado;
	}

	void Saqueado () {
		// Cambia mi color
		if (rend.material.color == Color.red)
			rend.material.color = Color.black;
		else
			rend.material.color = Color.red;
		
		Debug.Log("Saqueado ObjB");
	}
}
