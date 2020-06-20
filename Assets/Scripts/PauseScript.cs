using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    
    public GameObject inMenu;
    bool isPause = false;
    public GameObject player;
    public void pauseGame(){
        if(isPause){
            Time.timeScale = 1;
            isPause = false;
            inMenu.gameObject.SetActive(false);
        }else {
            Time.timeScale = 0;
            isPause = true;
           inMenu.gameObject.SetActive(true);
        }
    }
    void Update(){
        
    }
}
