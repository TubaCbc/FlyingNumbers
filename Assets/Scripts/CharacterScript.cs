using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterScript : MonoBehaviour
{
    private bool isTouching;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float controlSpeed;
    private float TouchPosX;
    [SerializeField] private GameObject paperImage;
    [SerializeField] private GameObject bookImage;
    //private int paperCount=0;
    // private int bookCount=0;
    [SerializeField] private GameObject cinemaSprite;
    [SerializeField] private GameObject finishedpoint;
    private bool finishedControl = false;
    [SerializeField] private GameObject paperHolder;

    void Start()
    {
        cinemaSprite.SetActive(false);
    }


    void Update()
    {
        GetInput();
        MoveForward();
        SlideCharacter();
        if(finishedControl)
        {
            transform.position = finishedpoint.gameObject.transform.position;
        }
    }

    private void GetInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }

    private void MoveForward()
    {
        transform.position += Vector3.forward * movementSpeed * Time.deltaTime;
    }

    private void SlideCharacter()
    {
        if (isTouching)
        {
            TouchPosX += Input.GetAxis("Mouse X") * controlSpeed * Time.deltaTime;
        }

        transform.position = new Vector3(TouchPosX, transform.position.y, transform.position.z);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("paper"))
    //    {
    //        //other.gameObject.SetActive(false);
    //        other.transform.position = paperHolder.transform.position;
    //        paperImage.transform.localScale += new Vector3(0.5f,0.5f,0.5f);
    //        paperCount++;
    //    }
    //    if (other.CompareTag("book"))
    //    {
    //        other.gameObject.SetActive(false);
    //        bookImage.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
    //        bookCount++;
    //    }
    //    if (other.CompareTag("bookSprite"))
    //    {
    //        bookImage.transform.localScale = new Vector3(1, 1, 1);
    //        bookCount=0;
    //    }
    //    if (other.CompareTag("paperSprite"))
    //    {
    //        paperImage.transform.localScale = new Vector3(1, 1, 1);
    //        paperCount = 0;
    //    }
    //    if (other.CompareTag("finished"))
    //    {
    //        SceneManager.LoadScene("FinishScene");
    //    }
        
    //}
}
