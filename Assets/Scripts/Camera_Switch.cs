using UnityEngine;
using System.Collections;

public class Camera_Switch : MonoBehaviour {

    public Camera Main_Camera;
    public Camera Tank_Camera;
    private string angle;

	// Use this for initialization
	void Start () {
        Tank_Camera.enabled = true;
        Main_Camera.enabled = false;
        angle = "Tank Camera";
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
        if (Input.GetKey(KeyCode.F))
        {
            if(Main_Camera.enabled == true)
            {
                Main_Camera.enabled = false;
                Tank_Camera.enabled = true;
                angle = "Tank Camera";
                OnGUI();
            }
            else
            {
                Main_Camera.enabled = true;
                Tank_Camera.enabled = false;
                angle = "Main Camera";
                OnGUI();
            }
        }	
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 5, 200, 50), angle);

    }
}
