Unity 作業製作流程與操作說明
1.	專案截圖
<img width="900" height="418" alt="image" src="https://github.com/user-attachments/assets/b2a4cda1-5d5b-4d38-ba58-2fbe8c8e18eb" />

2. GitHub 連結
https://github.com/Sakuya0417/1151VR-HW2-412262620--.git
3. YouTube 連結
https://youtu.be/IJ2SoosX2PE
4. 說明製作流程和相關操作
•	2D 專案與素材準備：在 Unity 中開啟 2D 專案，將準備好的 2D 人物圖片匯入 Assets 資料夾，並拖曳至 Scene (場景) 視窗中建立遊戲物件。
•	腳本建立與邏輯撰寫：新增 C# 腳本，利用 Vector3 陣列 (Array) 依序設定三個目標點的座標，分別對應「往前走」、「上跳高點」與「下跳終點」。
•	套用腳本：在 Hierarchy (層級) 視窗中選取該 2D 人物物件，將撰寫好的移動腳本拖曳掛載至角色身上，並於 Inspector 面板確認設定。
•	專案執行與測試 (Play Mode)：點擊編輯器正上方的「Play (播放)」按鈕，切換至 Game 視窗檢視專案執行畫面。確認人物順利依照陣列設定的 Vector 座標，完成往前走、上跳與下跳至終點的動作。檢視完畢後，再次點擊 Play 按鈕停止測試並返回編輯模式。
