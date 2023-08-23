using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtChange : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject;
            Debug.Log("Change look target is not specified. Defalting to parent object.");
        }
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }
}
