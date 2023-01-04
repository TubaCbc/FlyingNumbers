using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberController : MonoBehaviour
{
   
    public Text numberTxt;
    public GameObject player;
    private int number1;
    private int number2;
    private int numberLast;
    private int numCount;
    private int sayac = 0;
    private bool ops;

    private void Start()
    {
        numCount = player.GetComponent<Player>().numberCount;
        ops = player.GetComponent<Player>().ops; 
    }

    public void Update()
    {
        for (sayac = 0; sayac < 9; sayac++)
        {
            number1 = numCount;
            if (ops == true)
            {
                Calculation();
            }
                
        }

            print(numberLast);
    }
     private void Calculation()
    {
        numberLast = number1 + numCount;
        numberTxt.text = numberLast.ToString();
    }


}


