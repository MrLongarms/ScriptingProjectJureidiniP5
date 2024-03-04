using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxies : MonoBehaviour
{
    public float range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0f);
        Debug.Log ("Value Returned: " + h.ToString("F2"));
    }
}
