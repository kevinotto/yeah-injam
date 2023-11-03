using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitCanvas : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject QuitGameCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        MainCanvas.SetActive(true);
        QuitGameCanvas.SetActive(false);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }


}
