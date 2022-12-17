using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.EventSystems;

public class HandleTabPress : MonoBehaviour
{
    private List<TMP_InputField> _textFields;
    private int _index = 0;

    // Start is called before the first frame update
    void Start()
    {
        _textFields = GetComponentsInChildren<TMP_InputField>().ToList();
        EventSystem.current.SetSelectedGameObject(_textFields[0].gameObject, null);

        _textFields[0].OnPointerClick(null);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            _index += 1;
            _index %= _textFields.Count();

            var input = _textFields[_index];

            EventSystem.current.SetSelectedGameObject(input.gameObject, null);
            input.OnPointerClick(null);
        }
    }
}
