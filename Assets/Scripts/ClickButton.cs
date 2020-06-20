using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    public Button yourButton;
    public int AlreadyClicked = 0; 

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
       AlreadyClicked =1;
	}
}
