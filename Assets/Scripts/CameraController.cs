using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public Transform target;

    public float smoothSpeed = 0.125f;

    //public Vector3 offset;

    void Start () {

       
    }
	

	void LateUpdate () {
        //Vector3 Pos = target.position + offset;
        //Vector3 SmoothPos = Vector3.Lerp(transform.position, Pos, smoothSpeed);
        //transform.position = SmoothPos;

        transform.position = target.position;

        transform.LookAt(target);

    }
}
