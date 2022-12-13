using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Quiz
{
    Math = 0,
    Science = 1,
    History = 2,
    Riddle = 3
}
public class QuizManager : MonoBehaviour
{
    #region SingletoneMake
    public static QuizManager instance = null;
    public static QuizManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@QuizManager");
            instance = go.AddComponent<QuizManager>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion

    public Quiz quiztype;
    public Dictionary<Quiz, QuizGen[]> quizList = new Dictionary<Quiz, QuizGen[]>();

    public void InitQuiz()
    {
        quizList.Add(Quiz.Math, new QuizGen[]
        {
            new QuizGen("1번 문제 ","23 x 37 = ?",
            new string[]{"1. 851","2. 436","3. 0","4. 1" },20,0),

            new QuizGen("2번 문제 ","4+8(3*7)/3-7*8 = ?",
            new string[]{"1. 252","2. 116","3. 4"},20,2),

            new QuizGen("3번 문제 ","57의 약수의 개수는?",
            new string[]{"1. 2개","2. 3개","3. 4개" },20,2),

            new QuizGen("4번 문제 ","골을 차서 막을 확률이 11%라면 골을 3번 차서 모두 막힐 확률은?",
            new string[]{"1. 33%","2. 11%","3. 0.33%","4. 0.001331%" },20,3),

            new QuizGen("5번 문제 ","오늘 안에 Quiz 과제를 완수할 확률은?",
            new string[]{"1. 0%","2. 100%"},20,1),


        });

        quizList.Add(Quiz.Science, new QuizGen[]
        {
            new QuizGen("1번 문제 ","서로 다른 농도의 소금물 A,B에서 각각 100g, 400g씩 퍼내서 섞었더니 8%의 소금물이 되었고 각각 400g,100g씩 퍼내서 섞었더니 14%의 소금물이 되었다. A,B를 같은 양을 퍼내서 섞으면 몇%의 소금물이 될까?",
            new string[]{"1. 7","2. 9","3. 11","4. 13" },20,2),

            new QuizGen("2번 문제 ","우리 몸에 필요한 산소를 공급해 주기 위해 호흡을 조절해주는 기관은 무엇입니까?",
            new string[]{"1. 심장","2. 기도","3. 횡경막", "4. 폐"},20,3),

            new QuizGen("3번 문제 ","다음 중 가장 빠른 물체는?",
            new string[]{"1. 30분에 50km를 이동","2. 3시간에 220km를 이동","3. 15분에 20km를 이동" },20,0),

            new QuizGen("4번 문제 ","태양계 6번째 행성의 이름은?",
            new string[]{"1. 지구","2. 목성","3. 천왕성","4. 토성 " },20,3),

            new QuizGen("5번 문제 ","과학이 중요한 이유는?",
            new string[]{"1. 삶을 살아가는데 있어 실용적이기 때문이다.","2. 질문다운 질문을 해라."},20,1),


        });

        quizList.Add(Quiz.History, new QuizGen[]
        {
            new QuizGen("1번 문제 ","병자호란이 일어난 년도는?",
            new string[]{"1. 1588년","2. 1627년","3. 1636년","4. 1652년" },20,2),

            new QuizGen("2번 문제 ","조선 최고의 법전 경국대전은 어느 왕 시절에 편찬되었을까?",
            new string[]{"1. 세종","2. 성종","3. 영조", "4. 정조"},20,1),

            new QuizGen("3번 문제 ","첨성대는 어느 나라에서 건축하였는가?",
            new string[]{"1. 고구려","2. 백제","3. 신라" },20,2),

            new QuizGen("4번 문제 ","일제 강점기는 몇 년 동안 이어졌는가?",
            new string[]{"1. 30년","2. 35년","3. 40년"},20,1),

            new QuizGen("5번 문제 ","현재 대통령 포함 우리 나라에는 총 몇명의 대통령이 있었는가?",
            new string[]{"1. 18명","2. 19명","3. 20명"},20,2),


        });

        quizList.Add(Quiz.Riddle, new QuizGen[]
        {
            new QuizGen("1번 문제 ","대기업 회장이 살해당하기 전 벽에 \n\"ㄸ 뚜 ㅁ 뜨 뜨 \"\n라는 글을 남겼다. 범인은?",
            new string[]{"1. 비서","2. 장남","3. 아내","4. 친한 한식집 사장" },20,3),

            new QuizGen("2번 문제 ","아파트에서 한 아줌마가 뺑소니를 당하기 직전 \"노랑머리\"하고 외쳤다. 아파트 단지 수색으로 찾은 노랑머리를 한 용의자 4명 중 범인은?",
            new string[]{"1. 최근 이사 온 대학생","2. 분식집 맛집 주인","3. 부녀회장", "4. 경비 아저씨"},20,0),

            new QuizGen("3번 문제 ","어제가 내일이었으면 좋겠다. 그럼 오늘이 금요일일텐데... \n 그렇다면 오늘은 무슨 요일?",
            new string[]{"1. 수요일","2. 일요일","3. 금요일" },20,1),

            new QuizGen("4번 문제 ","의문의 다잉 메시지를 남기고 죽은 피해자. 피해자가 남긴 다잉 메시지는 \"모÷2\" 였다. 범인은 누구일까?",
            new string[]{"1. 김윤영(25세)피해자 학원 동기.피해자가 차였다.","2. 엄정현(29세)피해자 단골 마트 직원. 피해자 술친구.","3.김호영(26세)피해자 아랫집. 층간소음으로 자주 다툼.","4. 박용준(52세)피해자의 체육관 관장. 최근 잘 만나지 않음" },20,2),

            new QuizGen("5번 문제 ","모든 사람을 일어서게 하는 숫자는?",
            new string[]{"1. 100000000","2. 5","3. 154", "4. 16"},20,1),


        });
    }

    public void Awake()
    {
        InitQuiz();   
    }

    public void OpenQuiz()
    {
        Object quiz = Resources.Load("UI/UIQuiz");
        GameObject uiquiz = (GameObject)Instantiate(quiz);
        var quizui = uiquiz.GetComponent<UIQuiz>();
        

    }

}
