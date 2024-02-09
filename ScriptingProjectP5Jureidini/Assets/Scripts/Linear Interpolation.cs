using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{/*
    // Start is called before the first frame update
    void Start()
    {
        Float result = Math.Lerp (3f, 5f, 0.5f);
        Vector3 from = new Vector3 (1f, 2f, 3f);
        Vector3 to = new Vector3 (5f, 6f, 7f);

        //Here result = (4, 5, 6)
        Vector result = Vector3.Lerp (from, to, 0.75f);
    }

    // Update is called once per frame
    void Update()
    
    {
        //colours are represented by 4 floats representing red, blue, green and alpha.
        //When using Lerp, these floats are interpolated.
        
        Light.intensity = Math.Lerp(light.intensity, 8f, 0.5f
    }
    //this results in change to intensity would happen per second instead of per frame.
/*
}
