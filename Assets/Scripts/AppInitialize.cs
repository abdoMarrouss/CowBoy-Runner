using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppInitialize : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject inMenu;
    public GameObject inGame;
    public GameObject gameOver;
    public GameObject player;
    public GameObject inResume;
    public Button startButton;
    public Button pauseButton;
    public Button resumeButton;
    public int StartActive = 0;
    void Awake(){
        Shader.SetGlobalFloat("_Curvature",2.0f);
        Shader.SetGlobalFloat("_Triming", 0.1f);
        Application.targetFrameRate = 60;
        
    }
    void Start()
    {
        
        inMenu.gameObject.SetActive(true);
        inGame.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        Button starttBtn = startButton.GetComponent<Button>();
        starttBtn.onClick.AddListener(StartGame);
        Button pauseBtn = pauseButton.GetComponent<Button>();
        pauseBtn.onClick.AddListener(PauseGame);
        Button resumeBtn = resumeButton.GetComponent<Button>();
        resumeBtn.onClick.AddListener(ResumeGame);

    }
    public void StartGame(){
        inMenu.gameObject.SetActive(false);
        inGame.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        StartActive =1;
       
       
    }
    public void PauseGame(){
        StartActive = 2;
       }
       public void ResumeGame(){
           
           StartActive =1;
       }

    // Update is called once per frame
    void Update()
    {
        if(StartActive == 1){
            player.transform.Translate(0,0,0.2f);
            Time.timeScale = 1;
            inResume.gameObject.SetActive(false);
            inGame.gameObject.SetActive(true);
        } else if(StartActive == 2){
            inResume.gameObject.SetActive(true);
            inGame.gameObject.SetActive(false);
            player.transform.Translate(0,0,0);
            Time.timeScale = 0;
        }
        
        
    }
}
