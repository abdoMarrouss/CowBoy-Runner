using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    public Button restartButton;
    void Start(){
         Button restartBtn = restartButton.GetComponent<Button>();
        restartBtn.onClick.AddListener(loadlevel);
    }

    public void loadlevel()
        {
            Debug.Log("hello");
        SceneManager.LoadScene("Game");
 
        }

}
