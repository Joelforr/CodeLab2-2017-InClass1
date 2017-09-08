using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual int Next()
    {
        return (int)Random.Range(0, 4);
    }
}
