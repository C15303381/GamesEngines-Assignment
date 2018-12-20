using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    private Rigidbody rb;
    //public GameObject bulletPrefab;
    //public Transform bulletSpawn;

	void Start () {
       
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 6.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Fire();
        //}
	}


    //void Fire()
    //{
    //    var bullet = (GameObject)Instantiate 
    //    (
    //        bulletPrefab,
    //        bulletSpawn.position,
    //        bulletSpawn.rotation
    //    );
    //
    //    bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
    //
    //    Destroy(bullet, 5.0f);
    //}
    
}
