using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraStart : MonoBehaviour { 
	// Use this for initialization
	void Start () {
        Vector3 bike = GameObject.Find("bike").transform.position;
        GameObject.Find("fmcamera").transform.position = new Vector3(bike.x, bike.y, bike.z);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
