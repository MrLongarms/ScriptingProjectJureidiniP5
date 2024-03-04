using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DualAxis : MonoBehaviour
{
    public float hRange;
    public float vRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horiszontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * hRange;

        transform.position = new Vector3(xPos, 0, yPos);
    }
}
