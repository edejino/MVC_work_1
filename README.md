# MVC 作業 第一次
* 請使用 "客戶資料" 這個資料庫做開發 (如附件檔案)
* 請實作出「客戶資料管理」、「客戶聯絡人管理」與「客戶銀行帳戶管理」等簡易 CRUD 功能 (盡量做各種功能出來)
* 在列表頁要實作「搜尋」功能
* 實作一個清單頁面，顯示欄位有「客戶名稱、聯絡人數量、銀行帳戶數量」共三個欄位，此功能要在資料庫中建立一個檢視表，並且匯入 EDMX。
* 主選單要有連結可以直接連到三個主要功能的列表頁。
* 對於 Create 與 Edit 表單要套用欄位驗證 (必填、Email格式、欄位長度限制等驗證)
* 刪除資料功能不能真的刪除資料庫中的資料，必須修改資料庫，加上一個「是否已刪除」欄位，資料庫中的該欄位為 bit 類型，0 代表未刪除，1 代表已刪除，且列表頁不得顯示已刪除的資料。
* 實作「客戶聯絡人」時，同一個客戶下的聯絡人，其 Email 不能重複。
* 實作一個「自訂輸入驗證屬性」可驗證「手機」的電話格式必須為 "\d{4}-\d{6}" 的格式 ( e.g. 0911-111111 )

# MVC 作業 第二次
* 延續上周作業加以延伸開發
* 改用 Repository Pattern 管理所有新刪查改(CRUD)等功能
* 修改所有的「刪除」邏輯，所有資料都不能真正被刪除，資料庫中也要新增「是否已刪除」欄位 (欄位要設定 bit 型態)
* 修改「客戶資料」表格，新增「客戶分類」欄位，可設定特定選項的分類
* 使用 NPOI 這個 NuGet 套件實作資料匯出功能，每個清單頁上都要有可以匯出 Excel 檔案的功能，要用到 FileResult 下載檔案
* 實作在「客戶資料」的詳細資料頁面，加上「客戶聯絡人」清單，並且可以讓客戶聯絡人清單支援「批次更新」功能，可批次修改「職稱、手機、電話」這三個欄位，其他欄位不允許修改

<b>注意事項：</b><br>
1. 請在你的 GitHub 建立一個獨立專案，並將本次作業上傳到 GitHub，並提交 GitHub 專案網址回來。<br>
2. 請到【[課程進度實作回報]】表單回報作業，並回報 GitHub 專案網址。<br>
   [課程進度實作回報]:http://bit.ly/ede-mvc
3. 請勿將資料庫加入版控，以免版控發生問題 (因為資料庫檔會被VS鎖定)<br>
4. 做不出來沒關係，請在回報進度時寫上你哪幾個功能無法完成，或實作時發生的疑問！<br>
