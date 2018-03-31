using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform PlayerFollow;
    public Vector3 myPos;

    public float moveSpeed = 10f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     
        //transform.position = PlayerFollow.position + myPos;
    }
}
