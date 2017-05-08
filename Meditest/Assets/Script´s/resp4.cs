using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp4 : MonoBehaviour {

	static string respuesta1="Usar los virus para infectar priones";
	static string respuesta2="Virus ARN no retrovirus";
	static string respuesta3="Ninguna de las anteriores";
	static string respuesta4="Rapido crecimiento";
	static string respuesta5="S";
	static string respuesta6="Almacenar Cl-.";
	static string respuesta7="97";
	static string respuesta8="Homocisteina";
	static string respuesta9="Ninguna de las anteriores.";
	static string respuesta10="Ninguna de las anteriores.";
	static string respuesta11="para saber cómo infecta.";
	static string respuesta12="Aparato de Golgi.";
	static string respuesta13="Vacunas de ADN.";
	static string respuesta14="No hay correlación";
	static string respuesta15="hay síntesis pero no unión al retículo endoplasmatico liso.";

	List<string> res4= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5
		,respuesta6,respuesta7,respuesta8,respuesta9,respuesta10,
		respuesta11,respuesta12,respuesta13,respuesta14,respuesta15};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = res4 [0];
	}

	// Update is called once per frame
	void Update () {
		if(Preguntas.RandPreg>-1){
			GetComponent<TextMesh> ().text = res4 [Preguntas.RandPreg];
		}
	}

	void OnMouseDown()
	{
		//Debug.Log (gameObject.name);
		Preguntas.respSeleccionada = gameObject.name;
		Preguntas.seleccion= "y";
	}
}
