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
        int minuto = 0;
        int hora = 0;
        while (true)
        {
            print(hora.ToString("D2") + ":" + minuto.ToString("D2") + ":" + numero.ToString("D2"));
            numero++;
            yield return new WaitForSeconds(1f); 

            if (numero == 60)
            {
                numero = 0;
                minuto++;
   
            }
            if (minuto == 60)
            {
                minuto = 0;
                hora++;
            }
            if (hora == 23)
            {
                hora = 0;


            }
        }

    }


}
