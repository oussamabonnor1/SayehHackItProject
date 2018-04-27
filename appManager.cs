using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class appManager : MonoBehaviour
{
    public GameObject tapPanel;
    public GameObject mapPanel;
    public GameObject shopPanel;
    public GameObject quizPanel;


    public void tapUp()
    {
        tapPanel.GetComponent<Animation>()["TapUp"].speed = 1;
        tapPanel.GetComponent<Animation>().Play();
    }

    public void tapDown()
    {
        tapPanel.GetComponent<Animation>()["TapUp"].speed = -1;
        tapPanel.GetComponent<Animation>()["TapUp"].time = tapPanel.GetComponent<Animation>()["TapUp"].length;
        tapPanel.GetComponent<Animation>().Play();
    }

    public void mapLeft()
    {
        mapPanel.GetComponent<Animation>()["ShopLeft"].speed = 1;
        mapPanel.GetComponent<Animation>().Play();
    }

    public void mapRight()
    {
        mapPanel.GetComponent<Animation>()["ShopLeft"].speed = -1;
        mapPanel.GetComponent<Animation>()["ShopLeft"].time =
            mapPanel.GetComponent<Animation>()["ShopLeft"].length;
        mapPanel.GetComponent<Animation>().Play();
    }

    public void shopLeft()
    {
        shopPanel.GetComponent<Animation>()["mapRight"].speed = 1;
        shopPanel.GetComponent<Animation>().Play();
    }

    public void shopRight()
    {
        shopPanel.GetComponent<Animation>()["mapRight"].speed = -1;
        shopPanel.GetComponent<Animation>()["mapRight"].time =
            shopPanel.GetComponent<Animation>()["mapRight"].length;
        shopPanel.GetComponent<Animation>().Play();
    }

    public void tapToShop()
    {
        tapUp();
        shopRight();
    }

    public void tapToMap()
    {
        tapUp();
        mapRight();
    }

    public void mapToShop()
    {
        mapRight();
        shopRight();
    }

    public void mapToTap()
    {
        mapLeft();
        tapDown();
    }

    public void shopToTap()
    {
        shopLeft();
        tapDown();
    }

    public void shopToMap()
    {
        shopLeft();
        mapLeft();
    }

    public void questionDown()
    {
        quizPanel.GetComponent<Animation>()["quizUp"].speed = -1;
        quizPanel.GetComponent<Animation>()["quizUp"].time =
        quizPanel.GetComponent<Animation>()["quizUp"].length;
        quizPanel.GetComponent<Animation>().Play();
    }

    public void questionUp()
    {
        quizPanel.GetComponent<Animation>()["quizUp"].speed = 1;
        quizPanel.GetComponent<Animation>().Play();
    }

    public IEnumerator tapAnimation()
    {
        float position = tapPanel.transform.position.y;
        float height = Screen.height;

        while (tapPanel.transform.position.y < position + height * 2)
        {
            tapPanel.transform.position = Vector3.Lerp(tapPanel.transform.position,
                new Vector3(tapPanel.transform.position.x, position + height * 2,
                    tapPanel.transform.position.z), 0.05f);
            yield return new WaitForSeconds(0.01f);
        }
    }
}