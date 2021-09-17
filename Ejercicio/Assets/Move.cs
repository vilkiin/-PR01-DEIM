using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (contador <= 100)
        {
            print(contador);
            contador++;


        }
        for (int x = 0; x <= 10; x++)
        {
            print(x);
            
        }


        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
