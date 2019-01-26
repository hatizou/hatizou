using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exsample : MonoBehaviour {
    private float speed;
    // Start is called before the first frame update
    void Start () {
        speed = 10;
    }

    // Update is called once per frame
    void Update () {
        speed--;
        if (speed < 0) {
            speed = 10;
        }
    }
}
