using UnityEngine;
using System.Collections;

public class playerpickup_g : MonoBehaviour {

    private bool stationary = true;
    private Vector3 startpoint;
    private int resettimer = 0;

	// Use this for initialization
	void Start () {
        startpoint = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (stationary == true)
        {
            if (resettimer > 1)
            {
                resettimer--;
            }
            else if (resettimer == 1)
            {
                gameObject.transform.position = startpoint;
                resettimer = 0;
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("rp") || other.gameObject.CompareTag("yp") || other.gameObject.CompareTag("bp"))
        {
            if(stationary == true)
            {
                stationary = false;
                gameObject.transform.parent = other.transform;
            }
        }
        else if(other.gameObject.CompareTag("rb") || other.gameObject.CompareTag("yb") || other.gameObject.CompareTag("bb"))
        {
            gameObject.transform.position = startpoint;
            resettimer = 0;
            stationary = true;
            gameObject.transform.parent = null;
        }
    }
}
