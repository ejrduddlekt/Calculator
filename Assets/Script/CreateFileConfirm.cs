using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateFileConfirm : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject confirmPanel;

    public void OpenConfirm()
    {
        confirmPanel.SetActive(true);
    }
    public void CloseConfirm()
    {
        confirmPanel.SetActive(false);
    }
}
