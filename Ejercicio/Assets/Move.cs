using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private int num0 = 8;
    private int num1 = 20;
    private float num2 =7.5f;
    private float num3 = 4.3f;
    private string texto = "Hola mundo";
    private bool vida = true;
    
    


    // Start is called before the first frame update
    void Start()
    {
        int resultado = num0 + num1;
        float resultado1 = num2 - num3;
        print(resultado);
        print(resultado1);
        print(texto);
        print(vida);
        if (vida == true)
        {
            print("estas vivo");



        }
        else 
        {

            print("estas muerto");
        }
       
        
        



    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
