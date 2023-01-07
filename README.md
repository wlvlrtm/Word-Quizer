# Word-Quizer

빌드 파일 다운로드: https://drive.google.com/file/d/1KGrK4jjnCySOLC4cH9nYXRN5hrMkVxWo/view?usp=share_link

가장 먼저 해야 할 일은 savefile.json 파일 안에 출력시키고 싶은 단어들을 입력하는 것입니다.

savefile.json은 아래와 같은 위치에 존재합니다.

- 빌드한 파일을 실행할 경우,
Word-Quizer\Builds\V.1.0 (x86)\Word-Quizer_Data\savefile.json

- 유니티 에디터 상에서 프로젝트를 실행할 경우,
Word-Quizer\Assets\savefile.json

일반적으로 빌드한 파일을 실행하지, 유니티 에디터 상에서 프로젝트를 실행할 일은 거의 없을 것입니다.

savefile.json은 아래와 같은 형식으로 구성되어 있습니다.
```json
{
    "enText":[
        "Inventions", 
        "be credited with", 
        "Influence", 
        "Look over"
    ],
    "krText":[
        "발명품", 
        "~의 공을 인정받다", 
        "영향", 
        "살펴보다"
    ]
}
```

만약 savefile.json 파일이 텅 비어 있는 상태라면, 위의 예시를 참고하여 내용을 먼저 작성해주면 됩니다.

제작된 앱은 윈도우 환경에서만 빌드 테스트가 이루어졌습니다. 참고 바랍니다.



