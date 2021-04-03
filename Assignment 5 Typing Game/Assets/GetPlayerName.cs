using UnityEngine;
using UnityEngine.UI;
public class GetPlayerName : MonoBehaviour
{
    public InputField PlayerName;
    public string myPlayerName;
    public static string Name;

    void Update()
    {
        Name = myPlayerName;
    }

    public void DisplayName()
    {
        myPlayerName = PlayerName.text;
        Name = PlayerName.text;
        //Debug.Log(Name);
    }
}