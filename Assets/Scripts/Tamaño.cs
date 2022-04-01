using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tamaño : MonoBehaviour
{
    public void ChangeValue(float size)
    {
        this.GetComponent<TextMeshProUGUI>().text = "Tamaño: " + size + "x" + size;
    }

    public void GetTamaño(float size)
    {
        PlayerPrefs.SetInt("tamaño", (int)size);
    }
}
