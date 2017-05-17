using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Preguntas : MonoBehaviour 
{
	public static int ganador = 0;
	public static int numeroclick = 0;


	static string pregunta1="Los virus poseen genomas sencillos que tienen toda la informacion \n para sintetizar sus propias proteinas utilizando la celula que infecta para este fin,\n deacuerdo con esto podriamos pensar: ";
	static string pregunta2 = "La replicacion viral puede causar daños en el genoma de una celula \n lo que ocaciona que eta pueda volverce cancerigena,\n los virus implicados en este'proceso a la fecha se cree que son:";
	static string pregunta3 = "Los plasmidos son moleculas de aminoacidos que le permiten a las bacterias \n poseer ventajas en condiciones de crecimiento determinadas,\n la frase es: ";
	static string pregunta4 = "En los laboratorios de investigacion es utilizado muchas veces modelos celulares\n bacterianos como E. coli.\n ¿Cual es una de las ventajas para utilizar este tipo de organismis\n y no celulas eucariotas";
	static string pregunta5 = "¿En cual de las fases de ciclo celular\n aumenta la posibilidad de generarse una mutacion?";
	static string pregunta6 = "El retículo endoplasmatico rugoso dentro\n de sus funciones permite realizar:";
	static string pregunta7 = "Rendimiento energético del ácido palmítico:";
	static string pregunta8 = "¿Producto ambiguo en el proceso de metilación:\n se ausencia es patológica pero su producción excesiva también.\n Cuál de los siguientes cumple con esas funciones?";
	static string pregunta9 = "En la membrana plasmática la función de receptor\n puede estar mediada por: ";
	static string pregunta10 = "¿Porque es importante conocer la clasificación de\n las bacterias y/o organismos de importancia medica\n como virus u otros?";
	static string pregunta11 = "¿Porque es importante conocer la clasificación de\n las bacterias y/o organismos de importancia\n médica como virus u otros?";
	static string pregunta12 = "Es el encargado de la síntesis de proteínas:";
	static string pregunta13 = "El uso de vectores basados en ácidos nucleicos,\n han demostrado ser eficientes en la inducción de respuesta\n inmune en organismos multicelulares:";
	static string pregunta14 = "Paciente con glicemia 127mg/dl y LDL 125mg/dl.\n Las cifras de LDL para este paciente son:";
	static string pregunta15 = "¿Qué ocurriría si en la síntesis de proteína\n se pierde la capacidad del péptido señal?";



	List<string> p = new List<string>(){pregunta1,pregunta2,pregunta3,pregunta4
		,pregunta5,pregunta6,pregunta7,pregunta8,pregunta9,pregunta10
		,pregunta11,pregunta12,pregunta13,pregunta14,pregunta15};

	List<string> respCorrecta = new List<string>(){"1","1","2","4","4","1","2","4","3","2","1","2","4","2","1"};

	List<int> numeros = new List<int> ();
	public static string respSeleccionada;
	public Transform objetoResultado;
	public static string seleccion="n";

	public static int RandPreg=-1;

	public int cateModificacion = 0;
	// Use this for initialization
	void Start () 
	{
		if(Escenario.categoria=="categoria 1")
		{
			ganador = 0;
			cateModificacion = 0;

		}
		if(Escenario.categoria=="categoria 2")
		{
			ganador = 0;
			cateModificacion = 5;

		}
		if(Escenario.categoria=="categoria 3")
		{
			ganador = 0;
			cateModificacion = 10;

		}
		//GetComponent<TextMesh> ().text = p [0];

	}

	// Update is called once per frame
	void Update () 
	{
		if(ganador == 50)
		{
			//SceneManager.LoadScene ("Ganadores");
		}
		if(RandPreg==-1)
		{

			RandPreg = Random.Range (0+cateModificacion, 5+cateModificacion);					
			numeros.Add (RandPreg);
		}
		if(RandPreg>-1)
		{
			GetComponent<TextMesh> ().text = p [RandPreg];
		}

		//Debug.Log (p[RandPreg]);
		if (seleccion == "y") 
		{
			seleccion="n";


			if (respCorrecta [RandPreg] == respSeleccionada) 
			{
				ganador += 10;
				numeroclick += 1;
				objetoResultado.GetComponent<TextMesh> ().text = "Correcto!!";

				if(ganador==50||numeroclick==5){
					nextEscene.OnMouseDown ();
				}else					
				nextButtom.OnMouseDown ();


			} else {
				
				numeroclick += 1;
				objetoResultado.GetComponent<TextMesh> ().text = "Incorrecto!!";
				objetoResultado.GetComponent<TextMesh> ().text = "respuesta";
				if(numeroclick==5)
				{
					nextEscene.OnMouseDown ();
				}else
					nextButtom.OnMouseDown ();


			}
		}
	}
}
