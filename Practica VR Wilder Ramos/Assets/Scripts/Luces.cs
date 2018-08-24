using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour {

    private Light myLight;
    // Use this for initialization
    void Start () {
        myLight = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        if (Input.GetButtonDown("Fire2"))
        {
            myLight.enabled = !myLight.enabled;
        }
    }    
}
