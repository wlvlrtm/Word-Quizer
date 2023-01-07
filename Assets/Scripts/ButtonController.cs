using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour {
    private static int count = 0;
    private Button button;
    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private TMP_Text answerText;
    [SerializeField] private TMP_Text countText;

    private void Init() {
        this.button = gameObject.GetComponent<Button>();
        this.button.onClick.AddListener(() => OnButtonEventer());
    }

    private void Awake() {
        Init();
    }

    private void OnButtonEventer() {
        if (this.buttonText.text == GameManager.instance.answerText) {   // 정답이라면,
            this.answerText.text = "Right";
            count += 1;
            this.countText.text = "Right: " + count;
        }
        else {
            this.answerText.text = "Wrong";
        }

        GameManager.instance.WordRandomSelect();
    }
}