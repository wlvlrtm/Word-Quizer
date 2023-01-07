using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    private Button button;
    [SerializeField] private string scene;  // 로드할 씬 이름

    private void Init() {
        this.button = gameObject.GetComponent<Button>();
        this.button.onClick.AddListener(() => OnSceneLoad(this.scene));
    }

    private void Awake() {
        Init();
    }

    private void OnSceneLoad(string scene) {
        SceneManager.LoadScene(scene);
    }
}