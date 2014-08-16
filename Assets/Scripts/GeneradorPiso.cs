using UnityEngine;
using System.Collections;

public class GeneradorPiso : MonoBehaviour {

	public GameObject piso;
	public float tiempoMin = 5f;

	// Use this for initialization
	void Start () {
				
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeEmpezoACorrer");
	}

	void PersonajeEmpezoACorrer(Notification notification){
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generar(){
		Instantiate (piso, transform.position, Quaternion.identity);
		Invoke ("Generar", tiempoMin);
	}
}
