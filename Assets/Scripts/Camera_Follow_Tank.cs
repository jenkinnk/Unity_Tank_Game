using UnityEngine;
using System.Collections;

public class Camera_Follow_Tank : MonoBehaviour {

    public GameObject tank;
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(tank.transform);

	}


}
