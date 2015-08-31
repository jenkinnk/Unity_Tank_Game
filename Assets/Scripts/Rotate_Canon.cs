using UnityEngine;
using System.Collections;

public class Rotate_Canon : MonoBehaviour {

    public Transform canonTransform;
    private Vector3 up = new Vector3(-1,0,0);
    private Vector3 down = new Vector3(1, 0, 0);

	// Use this for initialization
	void Start () {

        canonTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            if (canonTransform.eulerAngles.x <= 0)
            {
                canonTransform.Rotate(up);
            }
            else if (canonTransform.eulerAngles.x > 270)
            {
                canonTransform.Rotate(up);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (canonTransform.eulerAngles.x >= 270 && canonTransform.eulerAngles.x <= 359)
            {
                canonTransform.Rotate(down);
            }
        }
	}
}
