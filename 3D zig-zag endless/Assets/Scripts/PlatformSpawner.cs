using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

    public GameObject platform;
    Vector3 lastPosition;
    float size;
    public bool gameOver;

    // Use this for initialization
    void Start() {
        lastPosition = platform.transform.position;
        size = platform.transform.localScale.x;

        for (int i = 0; i < 20; i++) {
            SpawnPlatforms();
        }

        InvokeRepeating("SpawnPlatforms", 2f, 0.2f);
    }

    // Update is called once per frame
    void Update() {
        if (gameOver) {
            CancelInvoke("SpawnPlatforms");
        }
    }

    void SpawnPlatforms() {
        int random = Random.Range(0, 7);
        if(random < 3) {
            SpawnPlatformX();
        }
        else if(random >= 3) {
            SpawnPlatformZ();
        }
    }

    void SpawnPlatformX() {
        Vector3 position = lastPosition;
        position.x += size;
        lastPosition = position;
        GameObject newPlatformX = Instantiate(platform, position, Quaternion.identity) as GameObject;
        newPlatformX.transform.parent = this.gameObject.transform;
    }

    void SpawnPlatformZ() {
        Vector3 position = lastPosition;
        position.z += size;
        lastPosition = position;
        GameObject newPlatformZ = Instantiate(platform, position, Quaternion.identity) as GameObject;
        newPlatformZ.transform.parent = this.gameObject.transform;
    }
}
