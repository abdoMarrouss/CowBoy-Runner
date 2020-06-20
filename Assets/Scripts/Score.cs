using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public TextMeshProUGUI scoreUI;

    
    

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
    }

    void OnTriggerEnter(Collider other){
        Debug.Log("collider is working");
        if(other.gameObject.tag == "scoreup"){
            score++;

        }
        Debug.Log("the score is : " + score);
    }
}
