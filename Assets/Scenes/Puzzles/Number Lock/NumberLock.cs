using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberLock : MonoBehaviour
{
    [SerializeField] bool locked = true;
    [SerializeField] string password = "123";
    [SerializeField] NumberLockNumbers[] numbers;

    public void CheckNum() {
        string temp = "";
        for(int i = 0; i < numbers.Length; i++) {
            temp += numbers[i].getCurrNum() + "";
        }
        if(temp == password) {
            OnUnlocked();
        }
    }

    public void OnUnlocked() {
        print("yo u unlocked it!");
    }
}
