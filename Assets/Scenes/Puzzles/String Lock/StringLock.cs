using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fungus;   //this line is needed if you have imported Fungus & want to connect dialogue
using UnityEngine.SceneManagement;  //this line is only needed for switching scenes

public class StringLock : MonoBehaviour
{
    private InputField inputTextField;  //assigned in script
    [SerializeField] TMP_Text txt;  //the text in the box
    [SerializeField] Fungus.Flowchart flowchart;    //same as line 6
    [SerializeField] string pw; //password
    [SerializeField] string id; //id, to know what to do after unlocking
    
    // Start is called before the first frame update
    void Start()
    {
        inputTextField = GetComponent<InputField>();
    }

    public void CheckPassword() {
        //print(txt.text);
        if(txt.text == pw + "​") {
            OnUnlocked();
        }else {
            switch(txt.text) {
                case "this is an easter egg!​":
                    print("easter egg unlocked!");
                    //here, you can do whatever! for example, you could switch to a secret scene, display an element, etc.
                        //switch to scene: SceneManager.LoadScene("scene name");
                        //display element: use a variable to track it, then variablename.SetActive(true);
                    break;
                default:
                    print("womp womp.. wrong :(");
                    break;
            }
        }
    }

    private void OnUnlocked() {
        print("YAY! You unlocked the " + id + " lock.");

        //here, you can do anything else! based on the id, you may want to do different things.
        //just remember you CANNOT use a switch statement for non-const variables! use if/else :)
    }

    //here is an example of what i did in my calc bc game haha
    /*
    public void OnUnlocked() {
        if(setWorkingAfter) flowchart.ExecuteBlock("set working true"); //another implementation
        if(id == "bracelet") {
            whatToHide.SetActive(false);    //another variable, smth i needed
        }else if(id == "rgb" || id == "rgb final") {
            whatToHide.SetActive(false);
        }

        if(id == "rgb final") {
            flowchart.ExecuteBlock("sink done");    //connecting dialogue! will cover later
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}
