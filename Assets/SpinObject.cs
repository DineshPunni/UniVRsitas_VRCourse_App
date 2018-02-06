using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class SpinObject : VRTK_InteractableObject {

    Transform content;
    float rotationSpeed = 0;

	void Start () {

        content = transform.GetChild(0);
	}

    public override void StartUsing(VRTK_InteractUse currentUsingObj)
    {
        base.StartUsing(currentUsingObj);
        rotationSpeed = 200;
        Debug.Log("startusing");
    }


    public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
    {
        base.StopUsing(previousUsingObject, resetUsingObjectState);
        rotationSpeed = 0;

    }

    protected override void Update ()
    {
        content.transform.Rotate(new Vector3(0,rotationSpeed * Time.deltaTime, 0));	

	}

  
}
