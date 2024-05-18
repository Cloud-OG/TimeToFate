using System.Collections;
using UnityEngine;

//通过序数order进行轮盘动画的控制

public class LotteryWheel : MonoBehaviour
{
    public SpriteRenderer[] triangleRenderers; // 存储所有三角形的SpriteRenderer组件
    public Color defaultColor;              // 默认颜色
    public Color highlightColor;            // 高亮颜色（红色）
    public bool IsEnd;
    private void Start()
    {
        // 初始化所有三角形的颜色
        foreach (var renderer in triangleRenderers)
        {
            renderer.color = defaultColor;
        }
    }

    public IEnumerator Spin(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            // 高亮当前索引的三角形
            int currentIndex = i % triangleRenderers.Length;
            triangleRenderers[currentIndex].color = highlightColor;
            
            // 等待一段时间，以便观察到动态效果
            yield return new WaitForSeconds(0.5f); // 这里设置为0.5秒

            // 重置当前三角形的颜色为默认颜色
            triangleRenderers[currentIndex].color = defaultColor;
        }

        IsEnd = true;
    }
}