using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Die : MonoBehaviour
{
    public GameObject Restart;
    private GameObject MessageSign;
    private Image MessageImage;
    bool messageShown = false;

    void Awake()
    {
        MessageSign = GameObject.Find("MessageBoxLose");
        MessageImage = GameObject.Find("MessageImageLose").GetComponent<Image>();
    }

    void Start()
    {
        MessageSign.SetActive(false);
    }

    public void ShowMessageBox()
    {
        MessageSign.SetActive(true);
        MessageImage.enabled = true;
        messageShown = true;
    }

    public void Die_restart()
    {
        if (messageShown)
        {
            hideMessageBox();
        }
    }

    public void hideMessageBox()
    {
        MessageSign.SetActive(false);
        MessageImage.enabled = false;
        messageShown = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ShowMessageBox();
            other.transform.position = Restart.transform.position;
        }
    }
}