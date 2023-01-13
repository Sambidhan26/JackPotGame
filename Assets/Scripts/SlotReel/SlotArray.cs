using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SlotArray : MonoBehaviour
{
    UIManager uiManagerInstance;
    SpriteUIMove spriteInstance;
    SlotManager slotManager;
    Test testInstance;

    public Button middleButton;
    public Animator tripleThreeAnim;

    public Image imageHolder1;
    public Image imageHolder2;
    public Image imageHolder3;
    public Image imageHolder4;
    public Image imageHolder5;
    public Image imageHolder6;
    public Image imageHolder7;
    public Image imageHolder8;
    public Image imageHolder9;



    public GameObject slotHolder1;
    public GameObject slotHolder2;
    public GameObject slotHolder3;

    public GameObject slotSupportHolder1;
    public GameObject slotSupportHolder2;
    public GameObject slotSupportHolder3;

    public GameObject slotSupportHolder4;
    public GameObject slotSupportHolder5;
    public GameObject slotSupportHolder6;

    public float time;

    public float doubleRedHotXPoint = 4;
    public float tripleHotSevenPoint = 3;
    public float doubleHotSevenPoint = 2;
    //public float singleHotSevenPoint = 1;
    //public float singleBlueSevenPoint = 1;
    //public float singleWhiteSevenPoint = 1;

    private int countBonus;
    public bool countBonusBool = false;

    [SerializeField] bool stopRandom;
    public bool StopRandom
    {
        get { return stopRandom; }
        set { stopRandom = value; }
    }

    public bool switchTripleRedHot = false;
    //public bool switchTripleTripleHot = false;
    public bool switchTripleDoubleHot = false;

    public bool middleRowWin = false;

    public bool switchButton = false;

    //.......................................BOOL Triple3XHotWin........................................................// 
    public bool tripleThreeHotX01 = false;
    public bool tripleThreeHotX12 = false;
    public bool tripleThreeHotX20 = false;
    public bool tripleThreeHotSecondX01 = false;
    public bool tripleThreeHotSecondX12 = false;
    public bool tripleThreeHotSecondX20 = false;
    public bool tripleThreeHotThirdX01 = false;
    public bool tripleThreeHotThirdX12 = false;
    public bool tripleThreeHotThirdX20 = false;

    //.....................................BOOL Bonus Win............................................................//
    private bool bonusWin01 = false;
    private bool bonusWin12 = false;
    private bool bonusWin20 = false;

    //..................................BOOL TRIPLE HOT 7 WIN....................................................//
    public bool tripleHotSevenWin01 = false;
    public bool tripleHotSevenWin12 = false;
    public bool tripleHotSevenWin20 = false;

    //..................................BOOL DOUBLE HOT 7 WIN...............................................//
    public bool doubleHotSevenWin01 = false;
    public bool doubleHotSevenWin12 = false;
    public bool doubleHotSevenWin20 = false;

    //................................BOOL SINGLE HOT 7 WIN...............................................//
    private bool singleHotSevenWin01 = false;
    private bool singleHotSevenWin12 = false;
    private bool singleHotSevenWin20 = false;

    //...............................BOOL SINGLE 7 BLUE WIN...............................................//
    private bool singleSevenBlueWin01 = false;
    private bool singleSevenBlueWin12 = false;
    private bool singleSevenBlueWin20 = false;

    //...............................BOOL SINGLE 7 WHITE WIN..........................................//
    private bool singleSevenWhiteWin01 = false;
    private bool singleSevenWhiteWin12 = false;
    private bool singleSevenWhiteWin20 = false;

    private bool switchWinCondition = false;
    private void Awake()
    {
        //imageHolder1.GetComponent<DOTweenAnimation>().DOPause();
        //imageHolder4.GetComponent<DOTweenAnimation>().DOPause();
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPause();

    }

    #region Start
    // Start is called before the first frame update
    void Start()
    {
        uiManagerInstance = FindObjectOfType<UIManager>();
        spriteInstance = FindObjectOfType<SpriteUIMove>();
        slotManager = FindObjectOfType<SlotManager>();
        testInstance = FindObjectOfType<Test>();

        //imageHolder1.GetComponent<DOTweenAnimation>().DOPause();
        //imageHolder4.GetComponent<DOTweenAnimation>().DOPause();
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPause();

        imageHolder1.gameObject.SetActive(false);
        //imageHolder1.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder2.gameObject.SetActive(false);
        imageHolder3.gameObject.SetActive(false);

        imageHolder4.gameObject.SetActive(false);
        //imageHolder4.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder5.gameObject.SetActive(false);
        imageHolder6.gameObject.SetActive(false);

        imageHolder7.gameObject.SetActive(false);
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder8.gameObject.SetActive(false);
        imageHolder9.gameObject.SetActive(false);

        if (countBonusBool == true)
        {
            //BonusWin();
            //AutoSpinBonus();
            StartCoroutine("AutoSpinDisableSlotHolderColume");
            StartCoroutine("AutoSpinDisableSlotHolder");
            Debug.Log("COUNTBONUSBOOL");

        }

        //countBonus = 0;
    }
    #endregion

    #region Update
    // Update is called once per frame
    void Update()
    {
        tripleThreeAnim = GetComponent<Animator>();

        //Debug.Log(countBonus);
        imageHolder1.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder2.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder3.GetComponent<DOTweenAnimation>().DOPause();

        imageHolder4.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder5.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder6.GetComponent<DOTweenAnimation>().DOPause();

        imageHolder7.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder8.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder9.GetComponent<DOTweenAnimation>().DOPause();

        //if(countBonus == 3)
        //{
        //    countBonusBool = true;
        //}

        //if (switchButton == true && uiManagerInstance.row3Multiplier == true)
        //{
        //    if(countBonusBool == false)
        //    {
        //        BonusWin();
        //    }

        //}

        //if (switchButton == true && uiManagerInstance.row2Multiplier == true)
        //{
        //    if (countBonusBool == false)
        //    {
        //        BonusWin();
        //    }
        //}

        //if (switchButton == true && uiManagerInstance.row1Multiplier == true)
        //{
        //    if (countBonusBool == false)
        //    {
        //        BonusWin();
        //    }
        //}

        //if (countBonusBool == true)
        //{
        //    //BonusWin();
        //    //AutoSpinBonus();
        //    StartCoroutine("AutoSpinDisableSlotHolderColume");
        //    StartCoroutine("AutoSpinDisableSlotHolder");
        //    Debug.Log("COUNTBONUSBOOL");

        //}



        if (switchButton == true && uiManagerInstance.row3Multiplier == true && countBonusBool == false)
        {
            TripleThreexHotWin();
            BonusWin();
            TripleHotSevenWin();
            DoubleHotSevenWin();
            SingleHotSevenWin();
            SingleSevenBlueWin();
            SingleSevenWhiteWin();
            DiagonalWin();
            switchButton = false;
        }

        if(switchButton == true && uiManagerInstance.row2Multiplier == true && countBonusBool == false)
        {
            TripleRow2ThreexHotWin();
            BonusWin();
            TripleHotRow2SevenWin();
            DoubleHotRow2SevenWin();
            SingleHotRow2SevenWin();
            SingleSevenRow2BlueWin();
            SingleSevenRow2WhiteWin();
            switchButton = false;
        }

        if(switchButton == true && uiManagerInstance.row1Multiplier == true && countBonusBool == false)
        {
            TripleRow1ThreexHotWin();
            BonusWin();
            TripleHotRow1SevenWin();
            DoubleHotRow1SevenWin();
            SingleHotRow1SevenWin();
            SingleSevenRow1BlueWin();
            SingleSevenRow1WhiteWin();
            switchButton = false;
        }



        if(tripleThreeHotX01 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleThreeHotX12 == true)
        {
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleThreeHotX20 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleThreeHotSecondX01 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if (tripleThreeHotSecondX12 == true)
        {
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if (tripleThreeHotSecondX20 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleThreeHotThirdX01 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleThreeHotThirdX12 == true)
        {
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleThreeHotThirdX20 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(bonusWin01 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(bonusWin12 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(bonusWin20 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleHotSevenWin01 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleHotSevenWin12 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(tripleHotSevenWin20 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(doubleHotSevenWin01 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(doubleHotSevenWin12 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(doubleHotSevenWin20 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(singleHotSevenWin01 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(singleHotSevenWin12 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(singleHotSevenWin20 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(singleSevenBlueWin01 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(singleSevenBlueWin12 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(singleSevenBlueWin20 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if(singleSevenWhiteWin01 == true)
        {
            imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if (singleSevenWhiteWin12 == true)
        {
            imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        }

        if (singleSevenWhiteWin20 == true)
        {
            imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        }

    #endregion
    #region RoughTestLogic

        //if (slotManager.referenceImage1[1].name == slotManager.referenceSprite1[4].name)
        //{
        //    Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //}
        //if (slotManager.referenceImage1[2].name == slotManager.referenceSprite1[4].name)
        //{
        //    Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //}
        //...................................................................ROW WIN START.......................................................................//
        //if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceImage1[1].sprite.name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceImage1[2].sprite.name)
        //{
        //    Debug.Log("YOU WIN Hello World");
        //}

        //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceImage2[1].sprite.name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceImage2[2].sprite.name)
        //{
        //    Debug.Log("YOU WIN Hello World");
        //}

        //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceImage3[1].sprite.name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceImage3[2].sprite.name)
        //{
        //    Debug.Log("YOU WIN Hello World");
        //}
        //.........................................................................ROW WIN END..........................................................................//

        //.........................................................................BOUNS WIN START......................................................................//

        ////for (int i = 0; i < slotManager.referenceImage1.Length; i++)
        ////{
        //if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[2].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[2].name
        //    && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[2].name)
        //{
        //    //middleRowWin = true;
        //    //if (middleRowWin == true)
        //    //{
        //    Debug.Log("BONUS WIN");
        //    imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    //}
        //}

        //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite1[2].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite1[2].name
        //    && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite1[2].name)
        //{
        //    Debug.Log("BONUS WIN");
        //    imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //}

        //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite1[2].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite1[2].name
        //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite1[2].name)
        //{
        //    Debug.Log("BONUS WIN");
        //    imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //}
        ////}
        ////for (int i = 0; i < slotManager.referenceSprite1.Length; i++)
        ////{
        ////if (slotManager.referenceSprite1[2].name = slotManager.referenceSprite2[i].name || slotManager.referenceSprite1[2].name != slotManager.referenceSprite3[i].name)
        ////{
        ////    Debug.Log("BONUS WIN");
        ////}
        ////}


        //.............................................................BOUNS WIN END...............................................//

        //....................................................TRIPLE THREE RED HOT WINS START..............................................//
        //    //if (switchTripleTripleHot == true)
        //    //{
        //    //    if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
        //    //        && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
        //    //    {
        //    //        switchTripleTripleHot = false;
        //    //        //switchTripleDoubleHot = true;
        //    //        //switchTripleRedHot = true;
        //    //        Debug.Log("TRIPLE THREE HOT RED WIN");
        //    //    }

        //    //    if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name
        //    //        && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
        //    //    {
        //    //        switchTripleTripleHot = false;
        //    //        //switchTripleDoubleHot = true;
        //    //        //switchTripleRedHot = true;
        //    //        Debug.Log("TRIPLE THREE HOT RED WIN");
        //    //    }

        //    //    if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
        //    //        && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
        //    //    {
        //    //        switchTripleTripleHot = false;
        //    //        //switchTripleDoubleHot = true;
        //    //        //switchTripleRedHot = true;
        //    //        Debug.Log("TRIPLE THREE HOT RED WIN");
        //    //    }
        //    //    //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name
        //    //    //    && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name)
        //    //    //{
        //    //    //    Debug.Log("TRIPLE THREE HOT RED WIN");
        //    //    //}

        //    //    //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[2].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[2].name
        //    //    //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[2].name)
        //    //    //{
        //    //    //    Debug.Log("TRIPLE THREE  HOT RED WIN");
        //    //    //}
        //    //}

        //    //ROW1 START
        //    //if (switchTripleRedHot == false) //&& switchTripleTripleHot == false && && switchTripleDoubleHot == true
        //    //{
        //    if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //    }

        //    if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    }

        //    if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    }
        //    //ROW1 END

        //    //ROW2START
        //    if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    }

        //    if (slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    }

        //    if (slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    }
        //    //ROW2END

        //    //ROW3START
        //    if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[2].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[2].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();

        //    }

        //    if (slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[2].name && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[2].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //    }

        //    if (slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[2].name && slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[2].name)
        //    {
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = true;
        //        //switchTripleRedHot = true;
        //        //switchTripleDoubleHot = false;
        //        Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
        //        imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //        imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //    }
        //    //}
        ////}
        //    //ROW3END




        //........................SINGLE HOT 3X WIN...................//
        //if (switchTripleRedHot == false) //&& switchTripleTripleHot == false && switchTripleDoubleHot == false && switchTripleDoubleHot == false
        //{

        //    if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    }
        //    if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    }
        //    if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //        //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    }

        //    if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    }
        //    if (slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    }
        //    if (slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    }

        //    if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[2].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //    }
        //    if (slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[2].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //    }
        //    if (slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[2].name)
        //    {
        //        //switchTripleRedHot = false;
        //        //switchTripleTripleHot = true;
        //        //switchTripleTripleHot = false;
        //        //switchTripleDoubleHot = true;
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //    }
        //}


        //if (slotManager.referenceImage1[0].name == slotManager.referenceSprite1[4].name)
        //{
        //        Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //}
        //if (slotManager.referenceImage1[1].name == slotManager.referenceSprite2[6].name)
        //{
        //    Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //}
        //if (slotManager.referenceImage1[2].name == slotManager.referenceSprite3[2].name)
        //{
        //    Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //}
        //for (int i = 0; i < slotManager.referenceImage1.Length; i++)
        //{
        //for (int j = 0; j < slotManager.referenceSprite1.Length; j++)
        //{
        //if (slotManager.referenceImage1[0].name == slotManager.referenceSprite1[4].name)
        //{
        //    Debug.Log("YOU WON SINGLE TRIPLE X HOT BONUS");
        //}
        //}
        //}
        //......................................................TRIPLE RED HOT WINS END............................................................//

        //..........................................................TRIPLE SEVEN WIN.....................................................//

        //if(slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[6].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[6].name
        //    && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[6].name)
        //{
        //    Debug.Log("TRIPLE SEVEN WIN");
        //    imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 25;
        //}

        //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[2].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[2].name
        //    && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[2].name)
        //{
        //    Debug.Log("TRIPLE SEVEN WIN");
        //    //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 25;
        //}

        //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[4].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[4].name
        //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[4].name)
        //{
        //    Debug.Log("TRIPLE SEVEN WIN");
        //    imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 25;
        //}

        //.........................................................TRIPLE SEVEN END......................................................//

        //.........................................................DOUBLE SEVEN WINS START...................................................//
        //if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[0].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[0].name
        //    && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[0].name)
        //{
        //    Debug.Log("DOUBLE SEVEN WIN");
        //    imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 20;
        //}

        //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[3].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[3].name
        //    && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[3].name)
        //{
        //    Debug.Log("DOUBLE SEVEN WIN");
        //    //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 20;
        //}

        //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[1].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[1].name
        //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[1].name)
        //{
        //    Debug.Log("DOUBLE SEVEN WIN");
        //    imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 20;
        //}
        //............................................................DOUBLE SEVEN END........................................................//

        //.........................................................SINGLE SEVEN HOT WINS START...................................................//
        //if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[1].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[1].name
        //    && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[1].name)
        //{
        //    Debug.Log("SINGLE HOT SEVEN WIN");
        //    imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 15;
        //}

        //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[0].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[0].name
        //    && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[0].name)
        //{
        //    Debug.Log("SINGLE HOT SEVEN WIN");
        //    //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 15;
        //}

        //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[0].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[0].name
        //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[0].name)
        //{
        //    Debug.Log("SINGLE HOT SEVEN WIN");
        //    imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 15;
        //}
        //.........................................................SINGLE SEVEN HOT END.....................................................//

        //.........................................................SINGLE SEVEN BLUE WINS START...................................................//
        //if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[3].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[3].name
        //    && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[3].name)
        //{
        //    Debug.Log("SINGLE BLUE SEVEN WIN");
        //    imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 10;
        //}

        //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[6].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[6].name
        //    && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[6].name)
        //{
        //    Debug.Log("SINGLE BLUE SEVEN WIN");
        //    //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 10;
        //}

        //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[5].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[5].name
        //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[5].name)
        //{
        //    Debug.Log("SINGLE BLUE SEVEN WIN");
        //    imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 10;
        //}
        //.........................................................SINGLE SEVEN BLUE END.....................................................//

        //.........................................................SINGLE SEVEN WHITE WINS START...................................................//
        //if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[5].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[5].name
        //    && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[5].name)
        //{
        //    Debug.Log("SINGLE WHITE SEVEN WIN");
        //    imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 5;
        //}

        //if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[1].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[1].name
        //    && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[1].name)
        //{
        //    Debug.Log("SINGLE WHITE SEVEN WIN");
        //    //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 5;
        //}

        //if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[3].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[3].name
        //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[3].name)
        //{
        //    Debug.Log("SINGLE WHITE SEVEN WIN");
        //    imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
        //    imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
        //    uiManagerInstance.totalBalance += 5;
        //}
        //.........................................................SINGLE SEVEN WHITE END.....................................................//

        /////////////////////////.....................................................DIAGONAL MATCH WIN START........................................../////////////////////////////////
        //ROW3IMAGE1 , ROW1IMAGE2, ROW2IMAGE3
        //for (int i = 0; i < slotManager.referenceSprite3.Length; i++)
        //{
        //    if (slotManager.referenceSprite3[i].name == slotManager.referenceImage3[2].sprite.name && slotManager.referenceSprite3[i].name == slotManager.referenceImage2[1].sprite.name
        //        && slotManager.referenceSprite3[i].name == slotManager.referenceImage1[1].sprite.name)
        //    {
        //        Debug.Log("THIS IS TRU DIAGONAL SUCCESS");
        //    }

        //}

        //if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceImage2[2].sprite.name && slotManager.referenceImage2[2].sprite.name == slotManager.referenceImage3[0].sprite.name
        //    && slotManager.referenceImage3[0].sprite.name == slotManager.referenceImage1[1].sprite.name)
        //{
        //    Debug.Log("THIS IS ONE TRUE DIAGONAL SUCCESS");
        //}

        //if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceImage2[0].sprite.name && slotManager.referenceImage2[0].sprite.name == slotManager.referenceImage3[2].sprite.name
        //    && slotManager.referenceImage3[2].sprite.name == slotManager.referenceImage1[1].sprite.name)
        //{
        //    Debug.Log("THIS IS TWO TRUE DIAGONAL SUCCESS");
        //}

        ////////////////////////////.....................................................DIAGONAL MATCH WIN END........................................../////////////////////////////////

        //if (imageHolder1.sprite.name == imageHolder2.sprite.name && imageHolder2.sprite.name == imageHolder3.sprite.name)
        //{
        //    Debug.Log("You Win");
        //}
        //if (stopRandom == false && buttonClickTrue == true)//&& buttonClickTrue == true
        //{
        //for (int i = 0; i < slotImageArray1.Length; i++)
        //{
        //    imageHolder1.sprite = slotImageArray1[Random.Range(0, slotImageArray1.Length)];
        //}

        //for (int i = 0; i < slotImageArray2.Length; i++)
        //{
        //    imageHolder2.sprite = slotImageArray2[Random.Range(0, slotImageArray2.Length)];
        //}

        //for (int i = 0; i < slotImageArray3.Length; i++)
        //{
        //    imageHolder3.sprite = slotImageArray3[Random.Range(0, slotImageArray3.Length)];
        //}

        //StartCoroutine("DelayTime");
        //stopRandom = true;
        //}
    }
    #endregion
    #region TripleThreeXHotWin
    public void TripleThreexHotWin()
    {
        
            if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
            tripleThreeHotX01 = true;
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

            testInstance.PlayAnim();

        }

            if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
            tripleThreeHotX12 = true;
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                testInstance.PlayAnim();
        }

            if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
            tripleThreeHotX20 = true;
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                testInstance.PlayAnim();
        }
        

        //ROW1 START
        //if (switchTripleRedHot == false) //&& switchTripleTripleHot == false && && switchTripleDoubleHot == true
        //{
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX01 = true;
            //switchWinCondition = true;
 
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                testInstance.PlayAnim();
        }

        if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX12 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                testInstance.PlayAnim();
        }

        if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX20 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                testInstance.PlayAnim();
        }
        //ROW1 END

        //ROW2START
        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotSecondX01 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
 
                //testInstance.PlayAnim();
        }

        if (slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotSecondX12 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                //testInstance.PlayAnim();
        }

        if (slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //switchWinCondition = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotSecondX20 = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                //testInstance.PlayAnim();
        }
        //ROW2END

        //ROW3START
        if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[2].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[2].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //switchWinCondition = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            tripleThreeHotThirdX01 = true;
 
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);

                //testInstance.PlayAnim();

        }

        if (slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[2].name && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[2].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //switchWinCondition = true;
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            tripleThreeHotThirdX12 = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
                //testInstance.PlayAnim();
        }

        if (slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[2].name && slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[2].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //switchWinCondition = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            tripleThreeHotThirdX20 = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
                //testInstance.PlayAnim();
        }
        //}
        //}
        //ROW3END
    }


    #endregion

    #region DoubleThreeXHotWin

    #endregion

    public void TripleRow2ThreexHotWin()
    {
        
        
            if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
            tripleThreeHotX01 = true;
        }

            if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
            tripleThreeHotX12 = true;
        }

            if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
            tripleThreeHotX20 = true;
        }

        

        //ROW1 START
        //if (switchTripleRedHot == false) //&& switchTripleTripleHot == false && && switchTripleDoubleHot == true
        //{
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX01 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
        {

            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX12 = true;
            //switchWinCondition = true;
 
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX20 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
        //ROW1 END

        //ROW2START
        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name)
        {
            
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotSecondX01 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotSecondX12 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[5].name && slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[5].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //switchWinCondition = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotSecondX20 = true;
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
            //Instantiate(tripleThreeAnim, this.transform.position, Quaternion.identity);
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeXAnim");

            //}
            //switchButton = false;
        }
    }

    public void TripleRow1ThreexHotWin()
    {
       
        
            if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
                tripleThreeHotX01 = true;
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

            if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
                tripleThreeHotX12 = true;
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

            if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name
                && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
            {
                //switchTripleTripleHot = false;
                //switchTripleDoubleHot = true;
                //switchTripleRedHot = true;
                Debug.Log("TRIPLE THREE HOT RED WIN");
                tripleThreeHotX20 = true;
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
        

        //ROW1 START
        //if (switchTripleRedHot == false) //&& switchTripleTripleHot == false && && switchTripleDoubleHot == true
        //{
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX01 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX12 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[4].name && slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[4].name)
        {
            Debug.Log("YOU WON DOUBLE TRIPLE X HOT BONUS");
            //tripleThreeAnim.GetComponent<Animator>().enabled = true;
            //tripleThreeAnim.GetComponent<Animator>().Play("TripleThreeAnim");
            //tripleThreeAnim.Play("TripleThreeAnim");
            tripleThreeHotX20 = true;
            //switchWinCondition = true;

            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
        //ROW1 END
    }
    #region BonusWin
    public void BonusWin()
    {
        //for (int i = 0; i < slotManager.referenceImage1.Length; i++)
        //{
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[2].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[2].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[2].name)
        {
            //middleRowWin = true;
            //if (middleRowWin == true)
            //{
            middleButton.GetComponent<Button>().interactable = false;
            Debug.Log("BONUS WIN");
            bonusWin01 = true;
            countBonusBool = true;
            stopRandom = true;
            //switchWinCondition = true;

        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite1[2].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite1[2].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite1[2].name)
        {
            middleButton.GetComponent<Button>().interactable = false;
            Debug.Log("BONUS WIN");
            bonusWin12 = true;
            countBonusBool = true;
            stopRandom = true;
            //switchWinCondition = true;
        }

        if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite1[2].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite1[2].name
            && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite1[2].name)
        {
            middleButton.GetComponent<Button>().interactable = false;
            Debug.Log("BONUS WIN");
            bonusWin20 = true;
            countBonusBool = true;
            stopRandom = true;
            //switchWinCondition = true;
        }
        //}
        //for (int i = 0; i < slotManager.referenceSprite1.Length; i++)
        //{
        //if (slotManager.referenceSprite1[2].name = slotManager.referenceSprite2[i].name || slotManager.referenceSprite1[2].name != slotManager.referenceSprite3[i].name)
        //{
        //    Debug.Log("BONUS WIN");
        //}
        //}
    }
    #endregion

    private void AutoSpinBonus()
    {
        //StartCoroutine("ButtonClickFalse");
        //if (buttonClickTrue == true)
        //{
            Debug.Log("AUTO SPIN PLAY");
            //stopRandom = true;
            //countBonus++;
            //TripleThreexHotWin();
            //BonusWin();
            //TripleHotSevenWin();
            //DoubleHotSevenWin();
            //SingleHotSevenWin();
            //SingleSevenBlueWin();
            //SingleSevenWhiteWin();
            imageHolder1.sprite = slotManager.referenceSprite1[Random.Range(0, slotManager.referenceSprite1.Length)];
            imageHolder2.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            imageHolder3.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            for (int i = 0; i < slotManager.referenceString1.Length; i++)
            {
                slotManager.referenceString1[0] = imageHolder1.sprite.name;
                slotManager.referenceString1[1] = imageHolder2.sprite.name;
                slotManager.referenceString1[2] = imageHolder3.sprite.name;
            }
            for (int i = 0; i < slotManager.referenceImage1.Length; i++)
            {
                slotManager.referenceImage1[0] = imageHolder1;
                slotManager.referenceImage1[1] = imageHolder2;
                slotManager.referenceImage1[2] = imageHolder3;
            }

            imageHolder4.sprite = slotManager.referenceSprite1[Random.Range(0, slotManager.referenceSprite1.Length)];
            imageHolder5.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            imageHolder6.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            for (int i = 0; i < slotManager.referenceString2.Length; i++)
            {
                slotManager.referenceString2[0] = imageHolder4.sprite.name;
                slotManager.referenceString2[1] = imageHolder5.sprite.name;
                slotManager.referenceString2[2] = imageHolder6.sprite.name;
            }
            for (int i = 0; i < slotManager.referenceImage2.Length; i++)
            {
                slotManager.referenceImage2[0] = imageHolder4;
                slotManager.referenceImage2[1] = imageHolder5;
                slotManager.referenceImage2[2] = imageHolder6;
            }
            imageHolder7.sprite = slotManager.referenceSprite1[Random.Range(0, slotManager.referenceSprite1.Length)];
            imageHolder8.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            imageHolder9.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            for (int i = 0; i < slotManager.referenceString3.Length; i++)
            {
                slotManager.referenceString3[0] = imageHolder7.sprite.name;
                slotManager.referenceString3[1] = imageHolder8.sprite.name;
                slotManager.referenceString3[2] = imageHolder9.sprite.name;
            }
            for (int i = 0; i < slotManager.referenceImage3.Length; i++)
            {
                slotManager.referenceImage3[0] = imageHolder7;
                slotManager.referenceImage3[1] = imageHolder8;
                slotManager.referenceImage3[2] = imageHolder9;
            }

        //imageHolder4.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
        //imageHolder5.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
        //imageHolder6.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];

        //imageHolder7.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
        //imageHolder8.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
        //imageHolder9.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
        //switchTripleRedHot = false;
        //switchTripleTripleHot = false;
        //switchTripleDoubleHot = false;

        //StartCoroutine("AutoSpinDisableSlotHolder");
        //StartCoroutine("DelayTimeColumeOne");
        //StartCoroutine("DelayTimeColumeTwoBonus");
        //StartCoroutine("DelayTimeColumeThree");
        //}

    }

    #region TripleHotSevenWin
    public void TripleHotSevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[6].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[6].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[6].name)
        {
            Debug.Log("TRIPLE SEVEN WIN");
            tripleHotSevenWin01 = true;
            switchWinCondition = true;
            //switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[2].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[2].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[2].name)
        {
            Debug.Log("TRIPLE SEVEN WIN");
            tripleHotSevenWin12 = true;
            switchWinCondition = true;
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[4].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[4].name
            && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[4].name)
        {
            Debug.Log("TRIPLE SEVEN WIN");
            tripleHotSevenWin20 = true;
            switchWinCondition = true;
            //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(tripleHotSevenPoint);
        }
    }
    #endregion
    public void TripleHotRow2SevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[6].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[6].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[6].name)
        {
            Debug.Log("TRIPLE SEVEN WIN");
            tripleHotSevenWin01 = true;
            switchWinCondition = true;
            //switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[2].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[2].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[2].name)
        {
            Debug.Log("TRIPLE SEVEN WIN");
            tripleHotSevenWin12 = true;
            switchWinCondition = true;
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #region DoubleHotSevenWin
    public void TripleHotRow1SevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[6].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[6].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[6].name)
        {
            Debug.Log("TRIPLE SEVEN WIN");
            tripleHotSevenWin01 = true;
            switchWinCondition = true;
            //switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    public void DoubleHotSevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[0].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[0].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[0].name)
        {
            Debug.Log("DOUBLE SEVEN WIN");
            doubleHotSevenWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[3].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[3].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[3].name)
        {
            Debug.Log("DOUBLE SEVEN WIN");
            doubleHotSevenWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[1].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[1].name
            && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[1].name)
        {
            Debug.Log("DOUBLE SEVEN WIN");
            doubleHotSevenWin20 = true;
            switchWinCondition = true;
            //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #endregion
    public void DoubleHotRow2SevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[0].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[0].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[0].name)
        {
            Debug.Log("DOUBLE SEVEN WIN");
            doubleHotSevenWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[3].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[3].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[3].name)
        {
            Debug.Log("DOUBLE SEVEN WIN");
            doubleHotSevenWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    public void DoubleHotRow1SevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[0].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[0].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[0].name)
        {
            Debug.Log("DOUBLE SEVEN WIN");
            doubleHotSevenWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #region SingleHotSevenWin
    public void SingleHotSevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[1].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[1].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[1].name)
        {
            Debug.Log("SINGLE HOT SEVEN WIN");
            singleHotSevenWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[0].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[0].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[0].name)
        {
            Debug.Log("SINGLE HOT SEVEN WIN");
            singleHotSevenWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[0].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[0].name
            && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[0].name)
        {
            Debug.Log("SINGLE HOT SEVEN WIN");
            singleHotSevenWin20 = true;
            switchWinCondition = true;
            //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #endregion
    public void SingleHotRow2SevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[1].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[1].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[1].name)
        {
            Debug.Log("SINGLE HOT SEVEN WIN");
            singleHotSevenWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[0].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[0].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[0].name)
        {
            Debug.Log("SINGLE HOT SEVEN WIN");
            singleHotSevenWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #region SingleSevenBlueWin
    public void SingleHotRow1SevenWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[1].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[1].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[1].name)
        {
            Debug.Log("SINGLE HOT SEVEN WIN");
            singleHotSevenWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    public void SingleSevenBlueWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[3].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[3].name
           && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[3].name)
        {
            Debug.Log("SINGLE BLUE SEVEN WIN");
            singleSevenBlueWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[6].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[6].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[6].name)
        {
            Debug.Log("SINGLE BLUE SEVEN WIN");
            singleSevenBlueWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[5].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[5].name
            && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[5].name)
        {
            Debug.Log("SINGLE BLUE SEVEN WIN");
            singleSevenBlueWin20 = true;
            switchWinCondition = true;
            //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #endregion
    public void SingleSevenRow2BlueWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[3].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[3].name
          && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[3].name)
        {
            Debug.Log("SINGLE BLUE SEVEN WIN");
            singleSevenBlueWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[6].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[6].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[6].name)
        {
            Debug.Log("SINGLE BLUE SEVEN WIN");
            singleSevenBlueWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #region SingleSevenWhiteWin
    public void SingleSevenRow1BlueWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[3].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[3].name
          && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[3].name)
        {
            Debug.Log("SINGLE BLUE SEVEN WIN");
            singleSevenBlueWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    public void SingleSevenWhiteWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[5].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[5].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[5].name)
        {
            Debug.Log("SINGLE WHITE SEVEN WIN");
            singleSevenWhiteWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[1].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[1].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[1].name)
        {
            Debug.Log("SINGLE WHITE SEVEN WIN");
            singleSevenWhiteWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage3[0].sprite.name == slotManager.referenceSprite3[3].name && slotManager.referenceImage3[1].sprite.name == slotManager.referenceSprite3[3].name
            && slotManager.referenceImage3[2].sprite.name == slotManager.referenceSprite3[3].name)
        {
            Debug.Log("SINGLE WHITE SEVEN WIN");
            singleSevenWhiteWin20 = true;
            switchWinCondition = true;
            //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder8.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder9.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    #endregion
    public void SingleSevenRow2WhiteWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[5].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[5].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[5].name)
        {
            Debug.Log("SINGLE WHITE SEVEN WIN");
            singleSevenWhiteWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }

        if (slotManager.referenceImage2[0].sprite.name == slotManager.referenceSprite2[1].name && slotManager.referenceImage2[1].sprite.name == slotManager.referenceSprite2[1].name
            && slotManager.referenceImage2[2].sprite.name == slotManager.referenceSprite2[1].name)
        {
            Debug.Log("SINGLE WHITE SEVEN WIN");
            singleSevenWhiteWin12 = true;
            switchWinCondition = true;
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder5.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder6.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    public void SingleSevenRow1WhiteWin()
    {
        if (slotManager.referenceImage1[0].sprite.name == slotManager.referenceSprite1[5].name && slotManager.referenceImage1[1].sprite.name == slotManager.referenceSprite1[5].name
            && slotManager.referenceImage1[2].sprite.name == slotManager.referenceSprite1[5].name)
        {
            Debug.Log("SINGLE WHITE SEVEN WIN");
            singleSevenWhiteWin01 = true;
            switchWinCondition = true;
            //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder2.GetComponent<DOTweenAnimation>().DOPlay();
            //imageHolder3.GetComponent<DOTweenAnimation>().DOPlay();
            uiManagerInstance.UpdateTotalBalance(uiManagerInstance.totalBet);
        }
    }
    public void DiagonalWin()
    {
        /////////////////////////.....................................................DIAGONAL MATCH WIN START........................................../////////////////////////////////
        //ROW3IMAGE1 , ROW1IMAGE2, ROW2IMAGE3
        for (int i = 0; i < slotManager.referenceSprite3.Length; i++)
        {
            if (slotManager.referenceSprite3[i].name == slotManager.referenceImage3[2].sprite.name && slotManager.referenceSprite3[i].name == slotManager.referenceImage2[1].sprite.name
                && slotManager.referenceSprite3[i].name == slotManager.referenceImage1[1].sprite.name)
            {
                Debug.Log("THIS IS TRU DIAGONAL SUCCESS");
            }

        }

        if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceImage2[2].sprite.name && slotManager.referenceImage2[2].sprite.name == slotManager.referenceImage3[0].sprite.name
            && slotManager.referenceImage3[0].sprite.name == slotManager.referenceImage1[1].sprite.name)
        {
            Debug.Log("THIS IS ONE TRUE DIAGONAL SUCCESS");
        }

        if (slotManager.referenceImage1[1].sprite.name == slotManager.referenceImage2[0].sprite.name && slotManager.referenceImage2[0].sprite.name == slotManager.referenceImage3[2].sprite.name
            && slotManager.referenceImage3[2].sprite.name == slotManager.referenceImage1[1].sprite.name)
        {
            Debug.Log("THIS IS TWO TRUE DIAGONAL SUCCESS");
        }

        ////////////////////////////.....................................................DIAGONAL MATCH WIN END........................................../////////////////////////////////
    }

    //public void OffEnable()
    //{
    //    Invoke("DelayRandom", time);
    //}

    //public void OnEnable()
    //{
    //    enabled = true;
    //}

    //void DelayRandom()
    //{
    //    enabled = false;
    //}

    IEnumerator ResetScene()
    {
        yield return new WaitForSeconds(1.0f);
            //.......................................BOOL Triple3XHotWin........................................................// 
    tripleThreeHotX01 = false;
    tripleThreeHotX12 = false;
    tripleThreeHotX20 = false;
    tripleThreeHotSecondX01 = false;
    tripleThreeHotSecondX12 = false;
    tripleThreeHotSecondX20 = false;
    tripleThreeHotThirdX01 = false;
    tripleThreeHotThirdX12 = false;
    tripleThreeHotThirdX20 = false;

    //.....................................BOOL Bonus Win............................................................//
    bonusWin01 = false;
    bonusWin12 = false;
    bonusWin20 = false;

    //..................................BOOL TRIPLE HOT 7 WIN....................................................//
    tripleHotSevenWin01 = false;
    tripleHotSevenWin12 = false;
    tripleHotSevenWin20 = false;

    //..................................BOOL DOUBLE HOT 7 WIN...............................................//
    doubleHotSevenWin01 = false;
    doubleHotSevenWin12 = false;
    doubleHotSevenWin20 = false;

    //................................BOOL SINGLE HOT 7 WIN...............................................//
    singleHotSevenWin01 = false;
    singleHotSevenWin12 = false;
    singleHotSevenWin20 = false;

    //...............................BOOL SINGLE 7 BLUE WIN...............................................//
    singleSevenBlueWin01 = false;
    singleSevenBlueWin12 = false;
    singleSevenBlueWin20 = false;

    //...............................BOOL SINGLE 7 WHITE WIN..........................................//
    singleSevenWhiteWin01 = false;
    singleSevenWhiteWin12 = false;
    singleSevenWhiteWin20 = false;
    //imageHolder1.GetComponent<DOTweenAnimation>().DOPause();
    //imageHolder4.GetComponent<DOTweenAnimation>().DOPause();
    //imageHolder7.GetComponent<DOTweenAnimation>().DOPause();

    //stopRandom = false;
        //switchWinCondition = false;

        imageHolder1.gameObject.SetActive(false);
        //imageHolder1.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder2.gameObject.SetActive(false);
        //imageHolder2.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder3.gameObject.SetActive(false);

        //imageHolder4.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder4.gameObject.SetActive(false);
        imageHolder5.gameObject.SetActive(false);
        imageHolder6.gameObject.SetActive(false);

        imageHolder7.gameObject.SetActive(false);
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPause();
        imageHolder8.gameObject.SetActive(false);
        imageHolder9.gameObject.SetActive(false);

        slotHolder1.gameObject.SetActive(true);
        slotHolder2.gameObject.SetActive(true);
        slotHolder3.gameObject.SetActive(true);
        slotSupportHolder1.gameObject.SetActive(true);
        slotSupportHolder2.gameObject.SetActive(true);
        slotSupportHolder3.gameObject.SetActive(true);
        slotSupportHolder4.gameObject.SetActive(true);
        slotSupportHolder5.gameObject.SetActive(true);
        slotSupportHolder6.gameObject.SetActive(true);
        //SceneManager.LoadScene(0);
        uiManagerInstance.winNumberRef = 0;
        Debug.Log("ResetGame");
        //StartCoroutine("ButtonClickDelay");
        if (countBonusBool == false)
        {
            middleButton.GetComponent<Button>().interactable = true;
        }
        switchWinCondition = false;
    }

    public void ButtonOnClick()
    {
        Debug.Log("Button Click");
        switchButton = true;
        //stopRandom = true;

        if (switchWinCondition == false)
        {
            uiManagerInstance.totalBalance -= uiManagerInstance.totalBet;

        }
        //if (countBonusBool == false)
        //{
            StartCoroutine("ButtonClickFalse");
        //}
        //if (buttonClickTrue == true)
        //{
            Debug.Log("Button Inside Loop Click");
            //TripleThreexHotWin();
            //BonusWin();
            //TripleHotSevenWin();
            //DoubleHotSevenWin();
            //SingleHotSevenWin();
            //SingleSevenBlueWin();
            //SingleSevenWhiteWin();
            imageHolder1.sprite = slotManager.referenceSprite1[Random.Range(0, slotManager.referenceSprite1.Length)];
            imageHolder2.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            imageHolder3.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            for (int i = 0; i < slotManager.referenceString1.Length; i++)
            {
                slotManager.referenceString1[0] = imageHolder1.sprite.name;
                slotManager.referenceString1[1] = imageHolder2.sprite.name;
                slotManager.referenceString1[2] = imageHolder3.sprite.name;
            }
            for (int i = 0; i < slotManager.referenceImage1.Length; i++)
            {
                slotManager.referenceImage1[0] = imageHolder1;
                slotManager.referenceImage1[1] = imageHolder2;
                slotManager.referenceImage1[2] = imageHolder3;
            }

            imageHolder4.sprite = slotManager.referenceSprite1[Random.Range(0, slotManager.referenceSprite1.Length)];
            imageHolder5.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            imageHolder6.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            for (int i = 0; i < slotManager.referenceString2.Length; i++)
            {
                slotManager.referenceString2[0] = imageHolder4.sprite.name;
                slotManager.referenceString2[1] = imageHolder5.sprite.name;
                slotManager.referenceString2[2] = imageHolder6.sprite.name;
            }
            for (int i = 0; i < slotManager.referenceImage2.Length; i++)
            {
                slotManager.referenceImage2[0] = imageHolder4;
                slotManager.referenceImage2[1] = imageHolder5;
                slotManager.referenceImage2[2] = imageHolder6;
            }
            imageHolder7.sprite = slotManager.referenceSprite1[Random.Range(0, slotManager.referenceSprite1.Length)];
            imageHolder8.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            imageHolder9.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            for (int i = 0; i < slotManager.referenceString3.Length; i++)
            {
                slotManager.referenceString3[0] = imageHolder7.sprite.name;
                slotManager.referenceString3[1] = imageHolder8.sprite.name;
                slotManager.referenceString3[2] = imageHolder9.sprite.name;
            }
            for (int i = 0; i < slotManager.referenceImage3.Length; i++)
            {
                slotManager.referenceImage3[0] = imageHolder7;
                slotManager.referenceImage3[1] = imageHolder8;
                slotManager.referenceImage3[2] = imageHolder9;
            }

            //imageHolder4.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            //imageHolder5.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];
            //imageHolder6.sprite = slotManager.referenceSprite2[Random.Range(0, slotManager.referenceSprite2.Length)];

            //imageHolder7.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            //imageHolder8.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            //imageHolder9.sprite = slotManager.referenceSprite3[Random.Range(0, slotManager.referenceSprite3.Length)];
            switchTripleRedHot = false;
            //switchTripleTripleHot = false;
            switchTripleDoubleHot = false;
        //if (countBonusBool == false)
        //{
            StartCoroutine("DelayTimeColumeOne");
            StartCoroutine("DelayTimeColumeTwo");
            StartCoroutine("DelayTimeColumeThree");
        //}
        //}
            //StartCoroutine("ButtonClickDelay");
    }
    public void ButtonClickSecondMethod()
    {
        stopRandom = true;
    }

    IEnumerator DelayTimeColumeOne()
    {
        yield return new WaitForSeconds(0.5f);

        imageHolder1.gameObject.SetActive(true);
        imageHolder4.gameObject.SetActive(true);
        imageHolder7.gameObject.SetActive(true);


        slotHolder1.gameObject.SetActive(false);
        //slotHolder2.gameObject.SetActive(false);


        slotSupportHolder1.gameObject.SetActive(false);
        slotSupportHolder4.gameObject.SetActive(false);
        //slotSupportHolder2.gameObject.SetActive(false);
    }

    IEnumerator DelayTimeColumeTwo()
    {
        yield return new WaitForSeconds(1.0f);
        //imageHolder1.gameObject.SetActive(true);
        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        imageHolder2.gameObject.SetActive(true);
        //imageHolder3.gameObject.SetActive(true);
        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();

        //imageHolder4.gameObject.SetActive(true);
        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        imageHolder5.gameObject.SetActive(true);
        //imageHolder6.gameObject.SetActive(true);

        //imageHolder7.gameObject.SetActive(true);
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        imageHolder8.gameObject.SetActive(true);
        //imageHolder9.gameObject.SetActive(true);

        //slotHolder1.gameObject.SetActive(false);
        slotHolder2.gameObject.SetActive(false);
        //slotHolder3.gameObject.SetActive(false);

        //slotSuppotHolder1.gameObject.SetActive(false);
        slotSupportHolder2.gameObject.SetActive(false);
        slotSupportHolder5.gameObject.SetActive(false);
        //slotSupportHolder3.gameObject.SetActive(false);
        //stopRandom = true;
        StartCoroutine("ResetScene");
        Debug.Log("Switch True");

    }

    IEnumerator DelayTimeColumeTwoBonus()
    {
        yield return new WaitForSeconds(1.0f);
        //imageHolder1.gameObject.SetActive(true);
        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        imageHolder2.gameObject.SetActive(true);
        //imageHolder3.gameObject.SetActive(true);
        //imageHolder1.GetComponent<DOTweenAnimation>().DOPlay();
        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();

        //imageHolder4.gameObject.SetActive(true);
        //imageHolder4.GetComponent<DOTweenAnimation>().DOPlay();
        imageHolder5.gameObject.SetActive(true);
        //imageHolder6.gameObject.SetActive(true);

        //imageHolder7.gameObject.SetActive(true);
        //imageHolder7.GetComponent<DOTweenAnimation>().DOPlay();
        imageHolder8.gameObject.SetActive(true);
        //imageHolder9.gameObject.SetActive(true);

        //slotHolder1.gameObject.SetActive(false);
        slotHolder2.gameObject.SetActive(false);
        //slotHolder3.gameObject.SetActive(false);

        //slotSuppotHolder1.gameObject.SetActive(false);
        slotSupportHolder2.gameObject.SetActive(false);
        slotSupportHolder5.gameObject.SetActive(false);
        //slotSupportHolder3.gameObject.SetActive(false);
        //stopRandom = true;
        //StartCoroutine("ResetScene");
        //Debug.Log("Switch True");

    }

    IEnumerator DelayTimeColumeThree()
    {
        yield return new WaitForSeconds(1.5f);

        imageHolder3.gameObject.SetActive(true);
        imageHolder6.gameObject.SetActive(true);
        imageHolder9.gameObject.SetActive(true);


        slotHolder3.gameObject.SetActive(false);
        //slotHolder2.gameObject.SetActive(false);


        slotSupportHolder3.gameObject.SetActive(false);

        slotSupportHolder6.gameObject.SetActive(false);
        //slotSupportHolder2.gameObject.SetActive(false);
        //buttonClickTrue = true;
        //StartCoroutine("ButtonClickDelay");
    }

    IEnumerator ButtonClickFalse()
    {
        yield return new WaitForSeconds(0.1f);
        middleButton.GetComponent<Button>().interactable = false;
        //buttonClickTrue = false;
    }
    IEnumerator AutoSpinDisableSlotHolder()
    {
        yield return new WaitForSeconds(3.0f);
        //stopRandom = false;
        //buttonClickTrue = true;
        AutoSpinBonus();
        middleButton.GetComponent<Button>().interactable = true;
        stopRandom = true;
        countBonusBool = false;
    }
    IEnumerator AutoSpinDisableSlotHolderColume()
    {
        yield return new WaitForSeconds(2.0f);
        //stopRandom = false;
        //buttonClickTrue = true;
        //AutoSpinBonus();
        StartCoroutine("DelayTimeColumeOne");
        StartCoroutine("DelayTimeColumeTwoBonus");
        StartCoroutine("DelayTimeColumeThree");
    }



}
