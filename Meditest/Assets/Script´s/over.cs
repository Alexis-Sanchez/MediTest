using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class over : MonoBehaviour {
	public Text textPuntaje;
	public int puntos;
	public string nombre;

	// Use this for initialization
	void Start () {
		nombre = puntos.ToString ();
		StartCoroutine (ditado(nombre));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator ditado(string frase)
	{
		textPuntaje.text = "";
		textPuntaje.text = Preguntas.ganador.ToString ();

		yield return new WaitForSeconds (0.02f);
	}
}
