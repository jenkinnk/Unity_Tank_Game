using UnityEngine;
using System.Collections;

public class Detect_Tank_Hit : MonoBehaviour {

    public GameObject tankShell;

    // Use this for initialization
    void Start()
    {

        tankShell = gameObject;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == tankShell)
        {
            Destroy(this);
        }

    }
}
