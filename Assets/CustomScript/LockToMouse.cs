using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockToMouse : MonoBehaviour
{


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Fetch the second GameObject's position
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);


    }
}
