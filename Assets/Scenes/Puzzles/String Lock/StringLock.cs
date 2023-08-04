using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fungus;
using UnityEngine.SceneManagement;

public class StringLock : MonoBehaviour
{
    private InputField inputTextField;
    [SerializeField] TMP_Text txt;
    [SerializeField] Fungus.Flowchart flowchart;
    
    // Start is called before the first frame update
    void Start()
    {
        inputTextField = GetComponent<InputField>();
    }

    public void CheckPassword() {
        //print(txt.text);
        switch(txt.text) {
            case "put your string here​":
                //print("correct!");
                //flowchart.ExecuteBlock("spider correct");
                break;
            case "this is an easter egg!​":
                //print("so true");
                //SceneManager.LoadScene("Joke");
                break;
            default:
                //flowchart.ExecuteBlock("spider incorrect");
                //print("wrong!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
