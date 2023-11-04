using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvasScript : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject AboutCanvas;
    public GameObject QuitCanvas;

    public AudioSource MouseClick;

    // Start is called before the first frame update
    void Start()
    {
        MainCanvas.SetActive(true);
        AboutCanvas.SetActive(false);
        QuitCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        MouseClick.Play();
        Application.LoadLevel("GameLevel");
    }

    public void AboutButton()
    {
        MouseClick.Play();
        MainCanvas.SetActive(false);
        AboutCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        MouseClick.Play();
        MainCanvas.SetActive(false);
        QuitCanvas.SetActive(true);
    }

    public void BackMenuButton()
    {
        MouseClick.Play();
        MainCanvas.SetActive(true);
        AboutCanvas.SetActive(false);
    }
}
