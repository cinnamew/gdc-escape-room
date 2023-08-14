using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsLock : MonoBehaviour
{
    
    [SerializeField] string ans = "100110";
    [SerializeField] string curr = "";
    [SerializeField] bool working = true;   //use if you're going to lock it
    

    public void updateCurr(string whatToAdd) {  //0, 1, etc
        if(!working) return;
        curr += whatToAdd;

        //if the current string doesn't match the password, reset it
        if(ans.Substring(0, curr.Length) != curr) { 
            //curr[curr.Length - 1] is the last character (whatToAdd)
            //here, we check if they're restarting the try
            if(curr[curr.Length - 1] != ans[0]) curr = "";
            else curr = curr[curr.Length - 1] + "";
        }

        if(ans == curr) {
            Debug.Log("YOU UNLOCKED THE ARROW LOCK!! YAYY");
            working = false;
        }
    }
}
