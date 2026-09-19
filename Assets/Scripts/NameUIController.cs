using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameUIController : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private Button saveButton;
    [SerializeField] private TextMeshPro nameText;

    private void Awake()
    {
        saveButton.onClick.AddListener(Save);
    }

    private void Save()
    {
        nameText.text = nameInputField.text;

        gameObject.SetActive(false);
    }


}
