using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1;
    public static float Multiplier = SliderValueToText.sliderValueFloat;
    public void Start()
    {
        Multiplier = SliderValueToText.sliderValueFloat;
    }
    public void SetWord(string word)
    {
        text.text = word;
    }
    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;

    }
    public void RemoveWord()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Multiplier * Time.deltaTime, 0f);
        
    }
    
}
