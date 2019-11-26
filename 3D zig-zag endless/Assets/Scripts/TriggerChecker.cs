using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour {

    //public GameManager instance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider collider) {
        if (collider.gameObject.tag == "Ball") {
            Invoke("FallDown", 0.1f);
        }
    }

    void FallDown() {
        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(transform.gameObject, 2f);
    }
}
