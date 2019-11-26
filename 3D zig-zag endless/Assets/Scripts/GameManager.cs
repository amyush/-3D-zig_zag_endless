using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] private float platformFallingTime = 0.2f;

    public static GameManager gameManager;

    public static GameManager instance {
        get {
            return gameManager;
        }

        set {
            gameManager = value;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
