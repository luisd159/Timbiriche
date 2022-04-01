using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject inicioPanel;
    public GameObject boardManager;
    [Header("Slider")]
    public Slider tamaño;
    
    public void OpenPanel(GameObject panel)
    {
        boardManager.SetActive(false);
        inicioPanel.SetActive(false);

        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

}
