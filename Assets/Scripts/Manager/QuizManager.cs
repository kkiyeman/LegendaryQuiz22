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
            new QuizGen("1�� ���� ","23 x 37 = ?",
            new string[]{"1. 851","2. 436","3. 0","4. 1" },20,0),

            new QuizGen("2�� ���� ","4+8(3*7)/3-7*8 = ?",
            new string[]{"1. 252","2. 116","3. 4"},20,2),

            new QuizGen("3�� ���� ","57�� ����� ������?",
            new string[]{"1. 2��","2. 3��","3. 4��" },20,2),

            new QuizGen("4�� ���� ","���� ���� ���� Ȯ���� 11%��� ���� 3�� ���� ��� ���� Ȯ����?",
            new string[]{"1. 33%","2. 11%","3. 0.33%","4. 0.001331%" },20,3),

            new QuizGen("5�� ���� ","���� �ȿ� Quiz ������ �ϼ��� Ȯ����?",
            new string[]{"1. 0%","2. 100%"},20,1),


        });

        quizList.Add(Quiz.Science, new QuizGen[]
        {
            new QuizGen("1�� ���� ","���� �ٸ� ���� �ұݹ� A,B���� ���� 100g, 400g�� �۳��� �������� 8%�� �ұݹ��� �Ǿ��� ���� 400g,100g�� �۳��� �������� 14%�� �ұݹ��� �Ǿ���. A,B�� ���� ���� �۳��� ������ ��%�� �ұݹ��� �ɱ�?",
            new string[]{"1. 7","2. 9","3. 11","4. 13" },20,2),

            new QuizGen("2�� ���� ","�츮 ���� �ʿ��� ��Ҹ� ������ �ֱ� ���� ȣ���� �������ִ� ����� �����Դϱ�?",
            new string[]{"1. ����","2. �⵵","3. Ⱦ�渷", "4. ��"},20,3),

            new QuizGen("3�� ���� ","���� �� ���� ���� ��ü��?",
            new string[]{"1. 30�п� 50km�� �̵�","2. 3�ð��� 220km�� �̵�","3. 15�п� 20km�� �̵�" },20,0),

            new QuizGen("4�� ���� ","�¾�� 6��° �༺�� �̸���?",
            new string[]{"1. ����","2. ��","3. õ�ռ�","4. �伺 " },20,3),

            new QuizGen("5�� ���� ","������ �߿��� ������?",
            new string[]{"1. ���� ��ư��µ� �־� �ǿ����̱� �����̴�.","2. �����ٿ� ������ �ض�."},20,1),


        });

        quizList.Add(Quiz.History, new QuizGen[]
        {
            new QuizGen("1�� ���� ","����ȣ���� �Ͼ �⵵��?",
            new string[]{"1. 1588��","2. 1627��","3. 1636��","4. 1652��" },20,2),

            new QuizGen("2�� ���� ","���� �ְ��� ���� �汹������ ��� �� ������ �����Ǿ�����?",
            new string[]{"1. ����","2. ����","3. ����", "4. ����"},20,1),

            new QuizGen("3�� ���� ","÷����� ��� ���󿡼� �����Ͽ��°�?",
            new string[]{"1. ����","2. ����","3. �Ŷ�" },20,2),

            new QuizGen("4�� ���� ","���� ������� �� �� ���� �̾����°�?",
            new string[]{"1. 30��","2. 35��","3. 40��"},20,1),

            new QuizGen("5�� ���� ","���� ����� ���� �츮 ���󿡴� �� ����� ������� �־��°�?",
            new string[]{"1. 18��","2. 19��","3. 20��"},20,2),


        });

        quizList.Add(Quiz.Riddle, new QuizGen[]
        {
            new QuizGen("1�� ���� ","���� ȸ���� ���ش��ϱ� �� ���� \n\"�� �� �� �� �� \"\n��� ���� �����. ������?",
            new string[]{"1. ��","2. �峲","3. �Ƴ�","4. ģ�� �ѽ��� ����" },20,3),

            new QuizGen("2�� ���� ","����Ʈ���� �� ���ܸ��� ���Ҵϸ� ���ϱ� ���� \"����Ӹ�\"�ϰ� ���ƴ�. ����Ʈ ���� �������� ã�� ����Ӹ��� �� ������ 4�� �� ������?",
            new string[]{"1. �ֱ� �̻� �� ���л�","2. �н��� ���� ����","3. �γ�ȸ��", "4. ��� ������"},20,0),

            new QuizGen("3�� ���� ","������ �����̾����� ���ڴ�. �׷� ������ �ݿ������ٵ�... \n �׷��ٸ� ������ ���� ����?",
            new string[]{"1. ������","2. �Ͽ���","3. �ݿ���" },20,1),

            new QuizGen("4�� ���� ","�ǹ��� ���� �޽����� ����� ���� ������. �����ڰ� ���� ���� �޽����� \"���2\" ����. ������ �����ϱ�?",
            new string[]{"1. ������(25��)������ �п� ����.�����ڰ� ������.","2. ������(29��)������ �ܰ� ��Ʈ ����. ������ ��ģ��.","3.��ȣ��(26��)������ �Ʒ���. ������������ ���� ����.","4. �ڿ���(52��)�������� ü���� ����. �ֱ� �� ������ ����" },20,2),

            new QuizGen("5�� ���� ","��� ����� �Ͼ�� �ϴ� ���ڴ�?",
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
