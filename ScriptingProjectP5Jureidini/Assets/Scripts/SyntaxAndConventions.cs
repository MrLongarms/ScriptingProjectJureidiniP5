using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyntaxAndConventions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to me the x postion of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}