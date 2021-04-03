using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "sidewalk", "robin", "three", "protect", "periodic", "somber", "majestic", "jump", "pretty", "wound", "jazzy", "memory", "join", "join",
     "crack", "grade", "boot", "cloudy", "sick", "mug", "hot", "tart", "dangerous", "mother", "rustic", "economic", "weird", "cut", "parallel", "wood", "encouraging", "interrupt", 
        "guide", "summary", "rider", "center", "seem", "color-blind", "pavement", "qualification", "presidential", "lend", "sign", "mill", "embox", "fuss", "top", "unlike", "college", 
        "suntan", "reputation", "oh", "young", "advantage", "freshman", "routine", "battle", "captivate", "discreet", "jam", "pepper", "addicted", "develop", "bake", "dose", "innovation", 
        "charismatic", "stimulation", "season", "collection", "export", "subway", "operation", "evolution", "conflict", "question", "spray", "emotion", "circulate", "helpless", 
        "taste", "network",};
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
