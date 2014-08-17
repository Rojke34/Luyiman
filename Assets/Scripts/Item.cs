using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	private bool haColisionadoConElJugador = false;
	public int puntosGanados = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D colision){
		if (!haColisionadoConElJugador && colision.gameObject.tag == "Player") {
			haColisionadoConElJugador = true;
			Destroy(gameObject);
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
		}
	}
}
