using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health2 : MonoBehaviour
{
    public int health = 1;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {   //if the health is less than 0
            Die();



        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<Collider>().tag == "Player")
        {
            health--;
        }
    }
    void Die()
    {
        Destroy(gameObject);
        //then destroy this gameObject
        SceneManager.LoadScene("StartScene");
    }



}
