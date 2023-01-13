using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    //SlotArray slotArray;
    SlotItems slotSpriteItem;
    //public SlotItems singleRedHot7;
    //public SlotItems doubleRedHot7;
    //public SlotItems tripleRedHot7;
    //public SlotItems whiteSeven;
    //public SlotItems blueSeven;
    //public SlotItems tripleHotX;
    //public SlotItems bonus;

    //public SlotItems 

    //public SlotItems[] slotItemsImageArray;
    //private SlotItems[] slotCount;
    public Sprite[] referenceSprite1;
    public Sprite[] referenceSprite2;
    public Sprite[] referenceSprite3;

    public string[] referenceString1;
    public string[] referenceString2;
    public string[] referenceString3;

    public Image[] referenceImage1;
    public Image[] referenceImage2;
    public Image[] referenceImage3;
    // Start is called before the first frame update
    void Start()
    {
        //slotArray = FindObjectOfType<SlotArray>();
        //referenceImage1[0] = slotArray.imageHolder1;
        //referenceImage1[1] = slotArray.imageHolder2;
        //referenceImage1[2] = slotArray.imageHolder3;

        //referenceImage2[0] = slotArray.imageHolder4;
        //referenceImage2[1] = slotArray.imageHolder5;
        //referenceImage2[2] = slotArray.imageHolder6;

        //referenceImage3[0] = slotArray.imageHolder7;
        //referenceImage3[1] = slotArray.imageHolder8;
        //referenceImage3[2] = slotArray.imageHolder9;
        //for (int i = 0; i < referenceString1.Length; i++)
        //{
        //    referenceString1[i] = referenceSprite1[i].ToString();
        //}
        //Debug.Log(referenceString1[0]);
        //if(referenceImage1 != null)
        //{
        //    return;
        //}
        //if (referenceImage2 != null)
        //{
        //    return;
        //}
        //if (referenceImage3 != null)
        //{
        //    return;
        //}
        //if(referenceImage1 != null)
        //{
        //    return;
        //}
        //for (int i = 0; i < slotSpriteItem.itemReferenceImage.Length; i++)
        //{
        //    referenceImage1[i] = slotSpriteItem.itemReferenceImage[i];
        //}

        //if (referenceImage2 != null)
        //{
        //    return;
        //}
        //for (int i = 0; i < slotSpriteItem.itemReferenceImage.Length; i++)
        //{
        //    referenceImage2[i] = slotSpriteItem.itemReferenceImage[i];
        //}

        //if (referenceImage3 != null)
        //{
        //    return;
        //}
        //for (int i = 0; i < slotSpriteItem.itemReferenceImage.Length; i++)
        //{
        //    referenceImage3[i] = slotSpriteItem.itemReferenceImage[i];
        //}

        if (referenceSprite1 != null)
        {
            return;
        }
        for (int i = 0; i < slotSpriteItem.itemImages.Length; i++)
        {
            referenceSprite1[i] = slotSpriteItem.itemImages[i];

            //Debug.Log(referenceSprite[i]);
        }

        if (referenceSprite2 != null)
        {
            return;
        }
        for (int i = 0; i < slotSpriteItem.itemImages.Length; i++)
        {
            referenceSprite2[i] = slotSpriteItem.itemImages[i];

            //Debug.Log(referenceSprite[i]);
        }

        if (referenceSprite3 != null)
        {
            return;
        }
        for (int i = 0; i < slotSpriteItem.itemImages.Length; i++)
        {
            referenceSprite3[i] = slotSpriteItem.itemImages[i];

            //Debug.Log(referenceSprite[i]);
        }

        //slotItemsArray = new SlotItems[] { singleRedHot7, doubleRedHot7 }; //tripleRedHot7 , whiteSeven , blueSeven , tripleHotX , bonus
        //slotCount = new SlotItems[] {0,1,2,3,4,5 };
        //slotItemsImageArray[0].itemImages = slotItemsImageArray[0].itemImages;
    }

    // Update is called once per frame
    void Update()
    {
        //if(referenceSprite1[1] == referenceSprite2[0] && referenceSprite3[0] == referenceSprite2[0])
        //{
        //    Debug.Log("Hello You Win");
        //}

        //if(referenceString1[1].ToString() == referenceString2[0].ToString() && referenceString2[0].ToString() == referenceString3[0].ToString())
        //{
        //    Debug.Log("Hello You Win");
        //}

        //if(Enumerable.ElementAt(referenceString1, referenceString1[1].Length) == Enumerable.ElementAt(referenceString2, referenceString2[0].Length) && Enumerable.ElementAt(referenceString2, referenceString2[0].Length) == Enumerable.ElementAt(referenceString3, referenceString3[0].va))
        //{
        //    Debug.Log("Hello You Win");
        //}
    }
}
