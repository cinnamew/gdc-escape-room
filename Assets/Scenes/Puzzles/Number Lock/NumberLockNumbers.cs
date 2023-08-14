using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberLockNumbers : MonoBehaviour
{
    
    [SerializeField] TMP_Text txt;
    [SerializeField] int currNum;
    [SerializeField] NumberLock numLock;

    // Start is called before the first frame update
    void Start()
    {
        //text = this.GetComponent<TMPro.TextMeshProUGUI>();
        //i can't rlly figure this out (L unity api) so i'm just gonna set it up in the inspector

    }


    public void Add() {
        currNum++;
        if(currNum == 10) currNum = 0;
        txt.text = currNum + "";
        numLock.CheckNum(); //UNCOMMENT THIS
    }

    public void Remove() {
        currNum--;
        if(currNum == -1) currNum = 9;
        txt.text = currNum + "";
        numLock.CheckNum(); //UNCOMMENT THIS
    }

    public int getCurrNum() {
        return currNum;
    }
}
