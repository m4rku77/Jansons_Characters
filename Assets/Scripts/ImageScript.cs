using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject Default;
    public GameObject wizzard;
    public Sprite[] spriteArray;
    public GameObject darbibas;
    public GameObject SliderSize;
    public GameObject SliderRotation;


    public void showDefault(bool value)
    {
        Default.SetActive(value);
        
    }

  
    public void showWizzard(bool value)
    {
        wizzard.SetActive(value);
    }



    public void changeImage(int index)
    {
        if (index == 0)
            darbibas.GetComponent<Image>().sprite = spriteArray[0];

        else if(index == 1)
            darbibas.GetComponent<Image>().sprite = spriteArray[1];

    }


    public void changeSize()
    {
        float size = SliderSize.GetComponent<Slider>().value;
        darbibas.transform.localScale = new Vector2(1F * size, 1F * size);
    }

    public void changeRotation()
    {
        float rotation = SliderRotation.GetComponent<Slider>().value;
        darbibas.transform.localRotation = Quaternion.Euler(0, 0, rotation*360);
    }
}
