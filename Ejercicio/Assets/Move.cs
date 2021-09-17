using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // valor al momento de declararlos
    public int num0 = 8;
    public int num1 = 20;
    public float num2 =7.5f;
    public float num3 = 4.3f;
    public string texto = "Hola mundo";
    public bool vida = true;
    
    // valor cambiable desde unity
    public int num10;
    public int num11;
    public float num12;
    public float num13;
    public string escrito;
    public bool life;

    // valor en start
    public int num20;
    public int num21;
    public float num22;
    public float num23;
    public string palabras;
    public bool die;

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

        // valor cambiable desde unity
        print(num10);
        print(num11);
        print(num12);
        print(num13);
        print(escrito);
        print(life);


        // valor en start
        print(num20 = 52);
        print(num21 = 23);
        print(num22 = 56.9f);
        print(num23 = 13.23f);
        print(palabras = "The End");
        print(die = true);
        
        

    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
