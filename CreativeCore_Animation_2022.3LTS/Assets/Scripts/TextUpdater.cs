using UnityEngine;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    public TMP_Text _text;

    public void updateText()
    {
        _text.text = "Party on, dudes";
    }
}
