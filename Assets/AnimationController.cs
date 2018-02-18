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


/*
1. Deconstruct 
2. One thing at a time
3. Repetition
4. Test everything and find out what works for you
5. Debrief: Don't make the same mistake twice 
     */
