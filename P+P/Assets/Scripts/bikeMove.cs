﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeMove : MonoBehaviour {
    float speed=0;//加速の大きさ
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        if (speed < 0)
            speed = 0;
        if (Input.GetKey(KeyCode.UpArrow))//↑が押されているとき
        {
            speed = speed + 0.1f;//加速を上げる
        }
        else
        {
            if (speed != 0)
                speed = speed-0.1f;//加速を下げる
        }
        this.transform.Translate(0.01f + speed, 0,0);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Rotate(new Vector3(0,-1f,0));//左に旋回
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Rotate(new Vector3(0,1f,0));//右に旋回
        
    }
}
