using UnityEngine;

public class Move : MonoBehaviour
{

    void Operacion(int number, int numero)
    {
          int resultado = number + numero;
        bool booleana;
        if (resultado == 8)
        {
            booleana = true;
            print(booleana);
            
        }
        else
        {

            booleana = false;
            print(booleana);

        }
        


    }

   


    // Start is called before the first frame update
    void Start()
    {
       // Se le pasa dos numeros si estos dos numeros llegan al 8 la booleana sera true si es distinto es false (de momento solo suma)
        Operacion(2, 3);
            
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
