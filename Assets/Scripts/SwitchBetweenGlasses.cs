using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBetweenGlasses : MonoBehaviour
{

    private GameObject glass1;
    private GameObject glass2;
    private GameObject glass3;

    private Button glass1Button;
    private Button glass2Button;
    private Button glass3Button;    

    // Start is called before the first frame update
    void Awake()
    {
        glass1 = transform.GetChild(2).gameObject;
        glass2 = transform.GetChild(3).gameObject;
        glass3 = transform.GetChild(4).gameObject;

        glass1Button = GameObject.Find("Canvas/Glass 1").GetComponent<Button>();
        glass2Button = GameObject.Find("Canvas/Glass 2").GetComponent<Button>();
        glass3Button = GameObject.Find("Canvas/Glass 3").GetComponent<Button>();

        glass1Button.onClick.AddListener(onGlass1Clicked);
        glass2Button.onClick.AddListener(onGlass2Clicked);
        glass3Button.onClick.AddListener(onGlass3Clicked);        
    }

    public void onGlass1Clicked()
    {
        glass1.SetActive(true);
        glass2.SetActive(false);
        glass3.SetActive(false);
    }
    public void onGlass2Clicked()
    {
        glass1.SetActive(false);
        glass2.SetActive(true);
        glass3.SetActive(false);
    }
    public void onGlass3Clicked()
    {
        glass1.SetActive(false);
        glass2.SetActive(false);
        glass3.SetActive(true);
    }
}
