using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{

    public Text text;
    public String[] data;
    private bool question;
    public appManager App;

    public void nextText()
    {
        if (!question)
        {
            text.text = data[1];
            question = true;
        }
        else
        {
            App.questionUp();
        }

    }

    public void fillText()
    {
        text.text = data[0];
    }
}
