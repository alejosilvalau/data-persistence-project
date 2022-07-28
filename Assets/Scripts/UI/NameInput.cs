using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    private InputField field;

    private void Start()
    {
        field = GetComponent<InputField>();
        field.text = DataManager.Instance.Name;
    }

    public void SaveInput()
    {
        DataManager.Instance.Name = field.text;
        DataManager.Instance.SaveName();
    }
}
