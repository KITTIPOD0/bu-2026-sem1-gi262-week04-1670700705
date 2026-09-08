using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPExit : Identity
    {
        public GameObject YouWin;
        // กำหนดชื่อไอเท็มและจำนวนที่ต้องการใช้ในการเปิดทางออก

        public override bool Hit()
        {
            bool hasKey = mapGenerator.player.inventory.HasItem("Key",2);
            if (hasKey)
            {
                YouWin.SetActive(true);
            }
            else
            {
                Debug.Log("Need key :You have:" + mapGenerator.player.inventory.GetItemCount("Key"));
            }
            // ตรวจสอบว่าผู้เล่นมีไอเท็มที่ต้องการหรือไม่
            YouWin.SetActive(true);
            Debug.Log("You win");
            return true;
          
        }
    }
}