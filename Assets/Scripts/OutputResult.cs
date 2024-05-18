using UnityEngine;

//获取要输出的字符串fateStr
public class OutputResult : MonoBehaviour
{
    public static string fateStr; 
    
    // Start is called before the first frame update
    void Start()
    {
        GetResult();
    }

    private static void GetResult()
    {
        switch (GetOrder.order % 6)
        {
            case 0://大安
                fateStr += "\n大吉\n阶段：身不动时\n五行：青龙木\n颜色：青\n方位：东\n数字：1，4，5\n意蕴：静止，心安，吉祥";
                break;
            case 1://留连
                fateStr += "\n小凶\n阶段：人未归时\n五行：腾蛇土\n颜色：暗\n方位：四方\n数字：2，7，8\n意蕴：喑味不明，延迟，纠缠，拖延，漫长";
                break;
            case 2://速喜
                fateStr += "\n中吉\n阶段：人即至时\n五行：朱雀火\n颜色：红\n方位：南\n数字：3，6，9\n意蕴：快速，喜庆，吉利，时机已到";
                break;
            case 3://赤口
                fateStr += "\n中凶\n阶段：官事凶时\n五行：白虎金\n颜色：白\n方位：西\n数字：4，1，2\n意蕴：不吉，惊恐，凶险，口舌是非";
                break;
            case 4://小吉
                fateStr += "\n小吉\n阶段：人来喜时\n五行：玄武水\n颜色：黄\n方位：北\n数字：5，3，8\n意蕴：和合，吉利";
                break;
            case 5://空亡
                fateStr += "\n大凶\n阶段：音信稀时\n五行：勾陈土\n颜色：黑\n方位：中央\n数字：6，5，10\n意蕴：不吉，无果，忧虑";
                break;
        }
    }
}
