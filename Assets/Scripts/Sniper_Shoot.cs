using UnityEngine;
using System.Collections;

public class Sniper_Shoot : MonoBehaviour {

    public GameObject Target;
    private Transform sniperTarget;

    public GameObject sniperBullet;
    public Transform sniperRifle;

    //public static Sniper_Shoot instance;


    // Use this for initialization
    void Start()
    {

        sniperTarget = Target.transform;
    }

    void Update()
    {

        transform.LookAt(sniperTarget);

        //LaunchProjectile();
    }

    void LaunchProjectile()
    {
        GameObject nBullet = (GameObject) Instantiate(sniperBullet, sniperRifle.position, sniperRifle.rotation);
        nBullet.GetComponent<Rigidbody>().velocity = Random.insideUnitSphere * 5;
    }

}
