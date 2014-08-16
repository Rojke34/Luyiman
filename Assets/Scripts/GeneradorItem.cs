using UnityEngine;
using System.Collections;

public class GeneradorItem : MonoBehaviour {

	public GameObject[] obj;
	public float tiempoMin = 1f;
	public float tiempoMax = 3f;

	// Use this for initialization
	void Start () {
		GenerarItem ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GenerarItem(){
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke("GenerarItem", Random.Range(tiempoMin, tiempoMax));
	}
}
