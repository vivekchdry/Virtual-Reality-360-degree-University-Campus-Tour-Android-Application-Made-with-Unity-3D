using System.Collections;
using UnityEngine;

public class LoadWebsiteOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	public void LinkWeb () {
		Application.OpenURL("http://www.geu.ac.in/");
	}

	void Update(){
	}
}
