using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; // 需要这个命名空间来使用UnityEvent

public class InputFieldHandler : MonoBehaviour
{
    public TMP_InputField tmpInputField; // 在Inspector中拖拽你的InputField
    public TMP_Text resultText; // 用于显示结果的Text组件
    public TMP_Text placeholder;
    public LotteryWheel LotteryWheel;
    
    // Start is called before the first frame update
    void Start()
    {
        // 订阅InputField的onEndEdit事件
        tmpInputField.onSelect.AddListener(OnInputFieldSelect);
        tmpInputField.onEndEdit.AddListener(OnInputFieldEndEdit);
    }

    // 当InputField结束编辑时调用的方法
    void OnInputFieldEndEdit(string inputText)
    {
        // 检查用户是否按下了回车键
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //加载轮盘动画
            StartCoroutine(LotteryWheel.Spin(GetOrder.order));
            //输出结果
            StartCoroutine(PrintFate());
        }
    }

    void OnInputFieldSelect(string a)
    {
        placeholder.text = String.Empty;
    }

    // OnDestroy是可选的，用于取消订阅事件
    void OnDestroy()   
    {
        if (tmpInputField != null)
        {
            tmpInputField.onEndEdit.RemoveListener(OnInputFieldEndEdit);
        }
    }

    IEnumerator PrintFate()
    {
        yield return new WaitForSeconds(GetOrder.order * 0.5f);
        // 将结果显示在UI上或其他用途
        resultText.text = OutputResult.fateStr;
    }
}