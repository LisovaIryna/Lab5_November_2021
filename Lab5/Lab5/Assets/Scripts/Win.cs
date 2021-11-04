using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private GameObject MessageSign;
    private Image MessageImage;
    bool messageShown = false;

    void Awake()
    {
        MessageSign = GameObject.Find("MessageBoxWin");
        MessageImage = GameObject.Find("MessageImageWin").GetComponent<Image>();
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

    public void Backtomain()
    {
        if (messageShown)
        {
            hideMessageBox();
            SceneManager.LoadScene("main");
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
        }
    }
}