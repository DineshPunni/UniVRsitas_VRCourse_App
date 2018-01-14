using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitch : MonoBehaviour {

    public Light lightSwitch;

	void Start () {
		
	}
	
	void Update () {
		
	}


    public void ToggleLight()
    {
        lightSwitch.enabled = !lightSwitch.enabled;
    }
}
