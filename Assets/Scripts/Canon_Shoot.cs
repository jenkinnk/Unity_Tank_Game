using UnityEngine;
using System.Collections;

public class Canon_Shoot : MonoBehaviour {

    public GameObject tankShell;
    public Transform canonBarrel;
    private GameObject newShell;

	// Use this for initialization
	void Start () {

        tankShell = gameObject;
        canonBarrel = transform;
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.Space)) {

            GameObject newShell = Instantiate(tankShell, canonBarrel.position, canonBarrel.rotation) as GameObject;

            newShell.GetComponent<Rigidbody>().velocity = canonBarrel.TransformDirection(new Vector3(0,0,100));

        }

	
	}
}
