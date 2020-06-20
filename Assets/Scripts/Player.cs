using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed = 500 ;
    public float directionalSpeed = 20;
    public bool jump = true;
    public bool slide = true;
    public Animator anim;
    public Button jumpButton;
    

    public void Start()
    {
        anim = GetComponent<Animator>();
       Button btn = jumpButton.GetComponent<Button>();
       btn.onClick.AddListener(JumpButton);
        
    }
    public void JumpButton(){
        jump = false;

    }

    // Update is called once per frame
    void Update()
    {
/*#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER
        float moveHorisontal = Input.GetAxis("Horizontal");
        transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(Mathf.Clamp(gameObject.transform.position.x + moveHorisontal,-1.5f, 1.5f), gameObject.transform.position.y ,gameObject.transform.position.z), directionalSpeed * Time.deltaTime);
        
#endif*/

       // GetComponent<Rigidbody> ().velocity = Vector3.forward * playerSpeed * Time.deltaTime;
       transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -1.5f,1.5f), transform.position.y, transform.position.z);
       transform.Translate(0,0,0.2f);
       if(Input.GetKey(KeyCode.LeftArrow)){
           transform.Translate(-0.09f,0 , 0 );
       }
       if(Input.GetKey(KeyCode.RightArrow)){
           transform.Translate(0.09f,0 , 0 );
       }
       /// Button Input : 
       
        /*if(Input.GetKeyDown(KeyCode.Space)){
            jump = false;
        }else {
            jump = true;
        }*/
        if(jump == true){
        anim.SetBool("isJump", jump);
        //transform.Translate(0, 0.5f, 0);
        }else if(jump == false){
        anim.SetBool("isJump", jump);  
        transform.Translate(0, 0.5f, 2f);
        
        }
 
        
        //MOBILE CONTROLS 
       /* Vector2 touch = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,10f));
        if(Input.touchCount > 0 ){
            transform.position = new Vector3(touch.x, transform.position.y, transform.position.z);

        }*/
        jump = true;

    }
}
