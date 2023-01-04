using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumImageScript : MonoBehaviour
{
    void Start()
    {
        for (int i=0; i<transform.childCount; i++)
        {
            print(transform.childCount);
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
