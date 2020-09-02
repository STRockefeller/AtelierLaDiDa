# About Atelier LaDiDa

## Abstract

這個軟體是為了輔助鍊金術士(アトリエ)系列遊戲所撰。
軟體用於計算物品調和路徑，適合用於

1. 特性轉移
1. 找封閉路徑洗品質
1. 找封閉路徑洗Size

目前支援的作品包含

 * A17 蘇菲的鍊金工房 ソフィーのアトリエ ～不思議な本の錬金術士～ 中文版 日文版
 * A21 萊莎的鍊金工房 ライザのアトリエ　常闇の女王と秘密の隠れ家 中文版
 * A20 露露亞的鍊金工房 ルルアのアトリエ ～アーランドの錬金術士 4～ 中文版

* 預計會陸續新增

A17、A20、A21中文版資料庫內容參考巴哈鍊金版版上的試算表編輯修改而成。
A17日文版資料庫內容參考來源 https://omoteura.com/atelier_sophie/

## How to Use

![01](https://i.imgur.com/2FVOXrI.png)

![02](https://i.imgur.com/kvtJptU.png)

Selet series and click "Confirm"



![03](https://i.imgur.com/K719Jrb.png)

Specify the Source and Destination Item Name

Click "Calculate" and you will see the result

![04](https://i.imgur.com/PD6UQtu.png)

## Images

![05](https://i.imgur.com/wecRX4K.png)

![06](https://i.imgur.com/K1gqHtX.png)

![07](https://i.imgur.com/JgQyBYj.png)

![8](https://i.imgur.com/DX00DYY.png)

![09](https://i.imgur.com/H3T9P0E.png)

## Notice

>### 共通
> 1.    **不考慮**特性是否能附加在該物品上或能否在該物品上生效，如**軍神之力**無法附加在**使用道具**類別上的情形本軟體不會考慮進去。
> 1.    假設特性繼承數全開
> 1.    假設所有物品皆開放調和
> 1.    假設所有調和品增加類別的效果皆開啟

>### A17
>1.    武器以及防具不在調和品清單內，欲將特性轉移至武器或防具上請將目標物設定為**金屬**或**布料**
>2.    日文版目前只有物品名稱是日文，其他如物品類別、屬性等資訊仍是中文。

>### A20
>1.    我還沒玩過，所以不清楚可能發生的狀況

>### A21
>1.    不考慮變化配方
>1.    不考慮材料投入順序

## Update

* 2020/8/7 完成A17及A21中文版內容。
* 2020/8/7 修正ComboBox選項累加錯誤，完成A20中文版內容。
* 2020/8/10 修正A20中文版部分路徑無法被找出的問題。
* 2020/8/11 新增A17日文版內容
* 2020/8/18 剛學了點LinQ，試著將A17中文版的部分以LinQ改寫，已完成。功能沒變，但程式碼簡潔許多。
* 2020/9/2 學了更多LinQ，大規模改寫，將原本每一個資料庫一個Class的模式變更為共用相同的Class，新增查詢物品詳細資料的功能，新增從物品類別查詢物品的功能，新增從物品類別查詢原料中含有該類別物品的功能。