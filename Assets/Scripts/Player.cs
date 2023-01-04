using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int speed = 3;
    public int numberCount;
    public bool ops;
    public Text numberTxt;
    public GameObject panel;
    private GameObject number;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            GetComponent<Rigidbody>().velocity = -transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            GetComponent<Rigidbody>().velocity = -transform.right * speed;
            //transform.Rotate(Vector3.down);
        }
        else if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            GetComponent<Rigidbody>().velocity = transform.right * speed;
            //transform.Rotate(Vector3.up);
        }
        number.transform.position += Vector3.up * 10f * Time.deltaTime;
        numberTxt.text = numberCount.ToString();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("num1"))
        {
            numberCount = 1;
            number= other.gameObject;
            panel.transform.GetChild(1).gameObject.SetActive(true);
        }
        if (other.CompareTag("num2"))
        {
            numberCount = 2;
            number = other.gameObject;
            panel.transform.GetChild(2).gameObject.SetActive(true);
        }
        if (other.CompareTag("num3"))
        {
            numberCount = 3;
            number = other.gameObject;
            panel.transform.GetChild(3).gameObject.SetActive(true);
        }
        if (other.CompareTag("num4"))
        {
            numberCount = 4;
            number = other.gameObject;
            panel.transform.GetChild(4).gameObject.SetActive(true);
        }
        if (other.CompareTag("num5"))
        {
            numberCount = 5;
            number = other.gameObject;
            panel.transform.GetChild(5).gameObject.SetActive(true);
        }
        if (other.CompareTag("num6"))
        {
            numberCount = 6;
            number = other.gameObject;
            panel.transform.GetChild(6).gameObject.SetActive(true);
        }
        if (other.CompareTag("num7"))
        {
            numberCount = 7;
            number = other.gameObject;
            panel.transform.GetChild(7).gameObject.SetActive(true);
        }
        if (other.CompareTag("num8"))
        {
            numberCount = 8;
            number = other.gameObject;
            panel.transform.GetChild(8).gameObject.SetActive(true);
        }
        if (other.CompareTag("num9"))
        {
            numberCount = 9;
            number = other.gameObject;
            panel.transform.GetChild(9).gameObject.SetActive(true);
        }

        if (other.CompareTag("="))
        {
            SceneManager.LoadScene("FinishScene");
        }
        /*
        if (other.CompareTag("-"))
        {
            ops = "-";
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("*"))
        {
            ops = "*";
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("bol"))
        {
            ops = "bol";
            other.gameObject.SetActive(false);
        }
        */
    }
    

    //public void Calculation()
    //{
    //    switch (ops)
    //    {
    //        case "+":
    //            numberLast = number1 + number2;
    //            print(numberLast);
    //            break;
    //        case "-":
    //            numberLast = number1 - number2;
    //            print(numberLast);
    //            break;
    //        case "*":
    //            numberLast = number1 * number2;
    //            print(numberLast);
    //            break;
    //        case "bol":
    //            numberLast = number1 / number2;
    //            print(numberLast);
    //            break;
    //    }
    //}
}
