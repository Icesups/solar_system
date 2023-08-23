using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Around The first parameter target position
        //Rotate Around needs second parameter about the axis or rotation
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);

    }
}
