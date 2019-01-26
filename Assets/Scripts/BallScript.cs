﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {
    // Start is called before the first frame update
    private float speed;
    void Start () {
        speed = Random.Range (5f, 15f);

    }

    // Update is called once per frame
    void Update () {
        transform.position += new Vector3 (0f, 0f, -1 * speed * Time.deltaTime);
        if (transform.position.z < -13.0f) {
            // Debug.Log ("Game Over");
            // Time.timeScale = 0;

            SceneManager.LoadScene ("GameOverScene");
        }
    }

    private void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.CompareTag ("Paddle")) {
            Destroy (gameObject);
            collision.gameObject.transform.localScale -= new Vector3 (Random.Range (0.2f, 1f), 0f, 0f);
            if (collision.gameObject.transform.localScale.x < 1) {
                collision.gameObject.transform.localScale = new Vector3 (1f, 1f, 1f);
            }
        }
    }
}
