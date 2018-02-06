using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public GameObject treassureChest;
    Animator anim;

	// Use this for initialization
	void Start () {
	
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnEnable()
    {
        treassureChest.GetComponentInChildren<Animator>().SetTrigger("Open");
    }
}
