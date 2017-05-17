using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Accion : MonoBehaviour {

	public void CambiarEscena(string nombre)
	{
		SceneManager.LoadScene (nombre);
		Preguntas.ganador = 0;
	}

	public void Salir (){
		Application.Quit ();
	}

}
