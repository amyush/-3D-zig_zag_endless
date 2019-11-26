using UnityEngine;
using System.Collections;

class CameraFollow : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    public float lerpRate;
    public bool gameOver;

    void Start() {
        offset = ball.transform.position - transform.position;
        gameOver = false;
    }

    void Update() {
        if (!gameOver) {
            Follow();
        }
    }

    void Follow() {
        Vector3 position = transform.position;
        Vector3 targetPosition = ball.transform.position - offset;
        position = Vector3.Lerp(position, targetPosition, lerpRate * Time.deltaTime);
        transform.position = position;
    }
}