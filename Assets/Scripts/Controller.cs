using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOver;
    public bool jump = false;
    public Button jumpButton;
    
    public Button slideButton;
    public Button leftButton;
    public Button rightButton;
    public bool slide = false;
    public int test = 0;
    public int test2 = 0;
    public Animator anim;
    public AudioClip scoreUp;
    public AudioClip damage;
    
    void Start()
    {
        anim = GetComponent<Animator>();
         Button jumpBtn = jumpButton.GetComponent<Button>();
        jumpBtn.onClick.AddListener(JumpButton);
        Button slideBtn = slideButton.GetComponent<Button>();
        slideBtn.onClick.AddListener(SlideButton);
        Button leftBtn = leftButton.GetComponent<Button>();
        leftBtn.onClick.AddListener(LeftButton);
        Button rightBtn = rightButton.GetComponent<Button>();
        rightBtn.onClick.AddListener(RightButton);

    }
    
    public void LeftButton(){
       test2 = 1;
       test = 0;
    }
    public void RightButton (){
         test = 1;
         test2 = 0;
    }
    public void InvokeMethod(){
        GetComponent<CapsuleCollider>().center = new Vector3(0, 0.70f,0);
        GetComponent<CapsuleCollider>().height = 1.5f;
    }

    public void JumpButton(){
        jump = true;
        if(jump == true){
            GetComponent<CapsuleCollider>().center = new Vector3(0, 1.20f,0);
            GetComponent<CapsuleCollider>().height = 0.2f;
        }
        Invoke("InvokeMethod", 1f);
        
    }
    public void SlideButton(){
        slide = true;
        if(slide == true){
            GetComponent<CapsuleCollider>().center = new Vector3(0, 0.25f,0);
            GetComponent<CapsuleCollider>().height =0.5f;
        }
        Invoke("InvokeMethod", 1f);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -1.5f,1.5f), Mathf.Clamp(transform.position.y , 0.06f, 5f), transform.position.z);
        //transform.Translate(0, 0 , 0);
        

        if(test2 == 1){
           transform.Translate(-0.1f,0 , 0 );
           
           
       }
       if(test == 1){
           transform.Translate(0.1f,0 , 0 );
           
       }
      /* if(Input.GetKey(KeyCode.Space)){
           jump = true;
       }else {
           jump = false;
       }*/
      /* if(Input.GetKey(KeyCode.DownArrow)){
           slide = true;
       }else {
           slide = false;
       }*/

      
       if(jump == true){
           anim.SetBool("isJump", jump);
           transform.Translate(0 , 0, 0);
           
           //Capsule.height = 0.5f;
           
       }else if(jump == false){
           anim.SetBool("isJump", jump);
            //Capsule.height = 1.5f;
            //GetComponent<CapsuleCollider>().center = new Vector3(0, 0.25f,0);
           
       }

        if(slide == true){
           anim.SetBool("isSlide", slide);
           transform.Translate(0 , 0 , 0);
          
       }else if(slide == false){
           anim.SetBool("isSlide", slide);
           
           
       }

       jump = false;
       slide = false;
       
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "scoreup"){
            GetComponent<AudioSource>().PlayOneShot(scoreUp, 1.0f);

        }
         if(other.gameObject.tag == "Obstacle"){
            GetComponent<AudioSource>().PlayOneShot(damage, 1.0f);

        }
        
    }
      void OnCollisionEnter(Collision other) {
          if (other.gameObject.tag == "Obstacle")
        {
            gameOver.gameObject.SetActive(true);
            Debug.Log("Do something else here");
        }
     }

   
}
