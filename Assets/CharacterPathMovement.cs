using UnityEngine;

public class CharacterPathMovement : MonoBehaviour
{
    // 【規定條件 1：使用陣列】
    // 宣告一個 Vector3 的陣列，用來儲存角色要經過的所有路徑點
    public Vector3[] waypoints;
    
    public float moveSpeed = 5f;          // 移動速度
    private int currentPointIndex = 0;    // 目前正在前往的陣列索引值

    void Start()
    {
        // 初始化陣列大小為 3 個點
        waypoints = new Vector3[3];

        // 取得角色當前的起始位置 (假設從起始點出發)
        Vector3 startPos = transform.position;

        // 【規定條件 2：使用 Vector (Vector3)】
        // 設定第 0 個點：往前走 (X軸前進，Y軸不變)
        waypoints[0] = new Vector3(startPos.x + 3f, startPos.y, 0f);

        // 設定第 1 個點：往上跳 (X軸繼續前進，Y軸往上提升)
        waypoints[1] = new Vector3(startPos.x + 6f, startPos.y + 4f, 0f);

        // 設定第 2 個點：往下跳到終點 (X軸繼續前進，Y軸下降回地面或更低)
        waypoints[2] = new Vector3(startPos.x + 9f, startPos.y - 1f, 0f);
    }

    void Update()
    {
        // 檢查是否已經走完陣列中的所有點
        if (currentPointIndex < waypoints.Length)
        {
            // 取得目前要前往的目標點
            Vector3 targetPosition = waypoints[currentPointIndex];

            // 使用 Vector3.MoveTowards 計算從當前位置到目標位置的平滑移動
            transform.position = Vector3.MoveTowards(
                transform.position, 
                targetPosition, 
                moveSpeed * Time.deltaTime
            );

            // 檢查是否已經到達目標點 (距離小於 0.01 視為抵達)
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                // 抵達後，將索引 +1，準備前往陣列中的下一個點
                currentPointIndex++;
            }
        }
        else
        {
            // 當陣列索引超出範圍，代表已經走完全部路徑
            Debug.Log("已經成功抵達終點！");
        }
    }
}