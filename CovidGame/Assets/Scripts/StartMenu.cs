using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Button enterButton;
    public bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("nani");
        isClicked = false;
        Button btn = enterButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        Debug.Log("You have clicked the button!");
        isClicked = true;
        SceneManager.LoadScene("MainGame");
    }
}
