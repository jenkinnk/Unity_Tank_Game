using UnityEngine;
using System.Collections;

public class Detect_Sniper_Hit : MonoBehaviour {

    public GameObject sniperBullet;
    public int lifeCount = 10;

	// Use this for initialization
	void Start () {

        sniperBullet = gameObject;
	}
	
    void OnCollisionEnter(Collision col){
        if (col.gameObject == sniperBullet)
        {
            --lifeCount;
        }
    }

    void Update()
    {
        OnGUI();
        if (lifeCount <= 0)
        {
            Destroy(this);
            Application.LoadLevel(0);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 55, 200, 50), "Player Lifes: " + lifeCount);
    }
}
