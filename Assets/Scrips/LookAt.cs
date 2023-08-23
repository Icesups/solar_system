using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    static public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target=this.gameObject;
            Debug.Log("Look at target target not specified. Defalting to GameObject");
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform);
        }
    }
}
