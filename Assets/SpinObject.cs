using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class SpinObject : VRTK_InteractableObject {

    [Header("Content")]
    public Transform museumObject;
    public GameObject spawnObject;

    float rotationSpeed = 0;

	void Start () {

	}

    public override void StartUsing(VRTK_InteractUse currentUsingObj)
    {
        base.StartUsing(currentUsingObj);
        rotationSpeed = 100;
        if (spawnObject != null)
            spawnObject.SetActive(true);
    }


    public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
    {
        base.StopUsing(previousUsingObject, resetUsingObjectState);
        rotationSpeed = 0;
        if(spawnObject!=null)
            spawnObject.SetActive(false);

    }

    protected override void Update ()
    {
        museumObject.transform.Rotate(new Vector3(0,rotationSpeed * Time.deltaTime, 0));	
	}

  
}
