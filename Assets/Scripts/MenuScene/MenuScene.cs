using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour
{
    private GameObject gameManager;
    private ADF adf;

    public Image backgroundImage;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        adf = gameManager.GetComponent<ADFParser>().adf;
    }
}
