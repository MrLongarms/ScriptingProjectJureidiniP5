using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {
        
=======
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public int fuel;
        
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = (int)fu;
        }
    }

    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStuff.bullets);
>>>>>>> 11367e5ea0cdb74fba6c932c48670443639ae27e
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
