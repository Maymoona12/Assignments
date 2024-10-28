using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentence : MonoBehaviour
{
    
    void Start(){

    // Array of words to create funny sentence
     string[] arrayOfwords ={"Cat","Dog","Car","Pizza","Hat","Fish", "Tree","Monkey","Ball","Bird"};

     // String to store the funny sentence of random words
     string funnySentence ="";

     // Counter to count the words that added to sentence
     int counter = 0;

     // Loop to add 7 random words from the arrayOfwords to sentence
     while(counter < 7){

     // Select a random word from the arrayOfwords 
     string randomWord = arrayOfwords[Random.Range(0,arrayOfwords.Length)];

     // Add the random word to funny sentence followed by a space
     funnySentence += randomWord + " ";

     // Increment the counter
     counter++ ;
     }
    // Log the final Funny Sentence to the console
     Debug.Log("Funny Sentence: "+ funnySentence);
    }
    
}
