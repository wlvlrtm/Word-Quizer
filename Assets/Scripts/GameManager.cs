using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    [System.Serializable]
    public class Word {
        public string[] enText;
        public string[] krText;
    }

    private string[] enText;
    private string[] krText;

    [SerializeField] private TMP_Text enWord;
    [SerializeField] private TMP_Text krWord1;
    [SerializeField] private TMP_Text krWord2;

    public int answerIndex;
    public string answerText;

    public static GameManager instance;


    private void Init() {
        string path = Application.dataPath + "/savefile.json";
        string json;
        
        if (!File.Exists(path)) {    // 파일이 존재하지 않으면 새로 생성    
            Word word = new Word();
            json = JsonUtility.ToJson(word);
            File.WriteAllText(path, json);
        }
        else {                      // 저장되어 있는 값을 배열로 불러오기
            json = File.ReadAllText(path);
            Word word = JsonUtility.FromJson<Word>(json);

            this.enText = word.enText;
            this.krText = word.krText;
        }

        // SingleTon
        if (instance == null) {
            instance = this;
        }

        WordRandomSelect();
    }

    public void WordRandomSelect() {    // 단어 무작위 선정
        int index = Random.Range(0, enText.Length);
        this.answerIndex = Random.Range(0, 2);


        this.answerText = this.krText[index];   // 한국어 답안
        this.enWord.text = this.enText[index];  // 선정된 영어 단어

        
        Debug.Log("indx: " + index);
        Debug.Log("answerText: " + this.answerText);

        if (this.answerIndex == 0) {      // 1번이 정답
            this.krWord1.text = this.krText[index];
            
            int mix = Random.Range(0, enText.Length);

            while (mix == index) {
                mix = Random.Range(0, enText.Length);
            }

            this.krWord2.text = this.krText[mix];
        }
        else {                          // 2번이 정답
            this.krWord2.text = this.krText[index];

            int mix = Random.Range(0, enText.Length);

            while (mix == index) {
                mix = Random.Range(0, enText.Length);
            }

            this.krWord1.text = this.krText[mix];
        }
    }

    private void Awake() {
        Init();
    }
}