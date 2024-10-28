using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenertor : MonoBehaviour
{
    void Start()
    {
      int randomNum ;
      while (true){
        // Generate a random number from 1 to 20
        randomNum = Random.Range(1,21);
        // If the number is 5, skip printing it
        if(randomNum == 5){
            continue ;
        }
        Debug.Log(randomNum);
         // If the number is 15, exit the loop
        if(randomNum == 15){
            break;
        }
      }
    }


}
