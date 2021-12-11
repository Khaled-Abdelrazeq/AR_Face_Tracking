using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject g1Info;
    [SerializeField] private GameObject g2Info;
    [SerializeField] private GameObject g3Info;

    [SerializeField] private Material g1Mat;
    [SerializeField] private Material g2Mat;
    [SerializeField] private Material g3Mat;

    private string buyG1URL = "https://www.amazon.com/Blocking-Glasses-Computer-Reading-Eyestrain/dp/B07W781XWF/ref=sr_1_3?dchild=1&keywords=glasses&qid=1632237508&sr=8-3";


    public void Glass1InfoEnable()
    {
        g1Info.SetActive(true);
    }

    public void Glass1InfoDisable()
    {
        g1Info.SetActive(false);
    }

    //************************************************************
    public void Glass2InfoEnable()
    {
        g2Info.SetActive(true);
    }

    public void Glass2InfoDisable()
    {
        g2Info.SetActive(false);
    }

    //*************************************************************
    public void Glass3InfoEnable()
    {
        g3Info.SetActive(true);
    }

    public void Glass3InfoDisable()
    {
        g3Info.SetActive(false);
    }

    //*************************************************************

    public void onCancelButtonClicked()
    {
        Glass1InfoDisable();
        Glass2InfoDisable();
        Glass3InfoDisable();
    }

    // ************************************************************


    public void Glass1ColorChanged()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Blue")
        {
            // Change the color to blue
            g1Mat.color = new Color(0.1f, 0.3f, 0.8f);
        }
        else if(buttonName == "Black")
        {
            // Change the color to black
            g1Mat.color = new Color(0, 0, 0);
        }
    }

    public void Glass2ColorChanged()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Blue")
        {
            // Change the color to blue
            g2Mat.color = new Color(0.1f, 0.3f, 0.8f);
        }
        else if(buttonName == "Black")
        {
            // Change the color to black
            g2Mat.color = new Color(0, 0, 0);
        }
    }

    public void Glass3ColorChanged()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Blue")
        {
            // Change the color to blue
            g3Mat.color = new Color(0.1f, 0.3f, 0.8f);
        }
        else if(buttonName == "Black")
        {
            // Change the color to black
            g3Mat.color = new Color(0, 0, 0);
        }
    }

    // ************************************************************

    public void BuyGlass1()
    {
        Application.OpenURL(buyG1URL);
    }
    public void BuyGlass2()
    {
        Application.OpenURL(buyG1URL);
    }
    public void BuyGlass3()
    {
        Application.OpenURL(buyG1URL);
    }

}
