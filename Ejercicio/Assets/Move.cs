using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private int aleatorio;

    // Start is called before the first frame update
    void Start()
    {
        while (aleatorio != 8)
        {
            aleatorio = Random.Range(0, 20);
           print("tu numero es " + aleatorio);

        }
        
        

        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
