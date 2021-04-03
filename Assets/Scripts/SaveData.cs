using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static int score = 0;

    public static int live = 3;

    public static string playerName = "NoName";

    public Slider speedSlider;

    public InputField nameinputField;

    public Text displayname;

    public Text displaySpeed;

    public void UpdateName()
    {
        playerName = nameinputField.text;

        displayname.text = "Welcome " + playerName + " To Typing Game!";
    }

    public void updateSpeed(float value)
    {
        WordDisplay.fallSpeed = speedSlider.value;

        displaySpeed.text = WordDisplay.fallSpeed.ToString("0");
    }


}
