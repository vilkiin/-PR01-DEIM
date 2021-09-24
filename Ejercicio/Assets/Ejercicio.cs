using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("contador");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    IEnumerator contador()
    {
        int numero = 0;
        
        while (true)
        {
            numero++;
            print(numero);
            yield return null; 

            if (numero == 20)
            {
                StopCoroutine("contador");
            }

        }

    }


}
