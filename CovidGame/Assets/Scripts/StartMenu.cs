using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Button enterButton;
 
    // Start is called before the first frame update
    void Start()
    {
     
 
        Button btn = enterButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || (Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            SceneManager.LoadScene("MainGame");
        }
    }

    void StartGame()
    {

        SceneManager.LoadScene("MainGame");
    }
}
