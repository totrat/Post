using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject bike;
	// Update is called once per frame
	void Update () {
        transform.LookAt(bike.transform);
	}
}
