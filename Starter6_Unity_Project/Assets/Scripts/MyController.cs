using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetBool("MyBool", true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Animator>().SetBool("MyBool", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("Dead", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            GetComponent<Animator>().SetBool("Dead", false);
        }
    }
}
