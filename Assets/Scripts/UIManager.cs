using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    SlotArray slotArrayInstance;

    public Button lineBetButtonPositive;
    public Button lineBetButtonNegative;

    public Text lineText;
    public Text lineBetMultiplierText;
    public Text totalBetText;
    public Text winText;
    public Text totalBalanceText;

    public int winNumber; 
    public int totalBetNumber;
    int lineNumber = 0;
    int lineMutipliedBet = 0;
    public float totalBalance;

    public int lines;
    private float lineBet;
    public float totalBet;

    //.......................to read the count of the button..............................//
    int positiveButtonCount;
    int negativeButtonCount;

    [SerializeField] int lineMutiplier1 = 1;
    //[SerializeField] int lineMutiplier2 = 10;
    //[SerializeField] int lineMultiplier3 = 15;

    public float winNumberRef;

    public bool refSwitchNegative;

    public bool row1Multiplier = false;
    public bool row2Multiplier = false;
    public bool row3Multiplier = false;

    // Start is called before the first frame update
    void Start()
    {
        slotArrayInstance = FindObjectOfType<SlotArray>();

        lines = 0;
        totalBalance = 1000;
        lineBet = 0;

        //winNumber = winNumberRef;
        //totalBet = lines*lineBet;

        //totalBetText.text = totalBet.ToString();
        //totalBalance -= totalBetNumber;


        //winNumber = totalBetNumber + totalBalance;
        //Debug.Log(totalBalance);
    }

    // Update is called once per frame
    void Update()
    {
        #region HelloWorld
        ////winNumber = totalBalance + totalBetNumber;
        //totalBalanceText.text = totalBalance.ToString();        
        //winText.text = winNumberRef.ToString();
        ////Debug.Log(winNumberRef);
        ////Debug.Log(totalBetNumber);

        ////totalBalanceText.text = totalBalance.ToString();
        //if (totalBalance < 0)
        //{
        //    totalBalance = 0;
        //}

        //lineText.text = lineNumber.ToString();
        //if (lineNumber >= 3)
        //{
        //    lineNumber = 3;
        //}

        //if (lineNumber < 0)
        //{
        //    lineNumber = 0;
        //}

        //lineBetMultiplierText.text = lineMutipliedBet.ToString();

        //if (lineMutipliedBet > 15)
        //{
        //    lineMutipliedBet = 15;
        //}

        //if (lineMutipliedBet < 0)
        //{
        //    lineMutipliedBet = 0;
        //}

        //totalBetText.text = totalBetNumber.ToString();

        //totalBetNumber = lineNumber * lineMutipliedBet;
        //if (totalBetNumber >= 45)
        //{
        //    //this.gameObject.SetActive(false);
        //    lineBetButtonPositive.GetComponent<Button>().interactable = false;
        //}
        //if (totalBetNumber == 30)
        //{
        //    this.gameObject.SetActive(false);
        //    lineBetButtonPositive.GetComponent<Button>().interactable = false;
        //}

        //if (totalBetNumber == 15)
        //{
        //    //this.gameObject.SetActive(false);
        //    lineBetButtonPositive.GetComponent<Button>().interactable = false;
        //}
        //Debug.Log(totalBetNumber);
        #endregion
        totalBalanceText.text = totalBalance.ToString();
        winText.text = winNumberRef.ToString();

        if(lines == 1)
        {
            row1Multiplier = true;
        }
        if(lines == 2)
        {
            row2Multiplier = true;
        }
        if(lines == 3)
        {
            row3Multiplier = true;
        }
        //Debug.Log(lines);
        //Debug.Log(lineBet);
        //Debug.Log(lineMutipliedBet);
        //Debug.Log(totalBet);
        //if (refSwitchNegative == true)
        //{
        //    totalBalance -= totalBet;
        //}

        if(totalBalance < 0)
        {
            //Debug.Log("GameOver");
            SceneManager.LoadScene(0);
        }
    }

    public void UpdateTotalBalance(float totalScoreRef)
    {
        winNumberRef = totalScoreRef;
        totalBalance += totalScoreRef;

        //refSwitchNegative = switchNegative;
        //if(refSwitchNegative == true)
        //{
        //    totalBalance -= totalBet;
        //}

        if(slotArrayInstance.tripleThreeHotX01 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.doubleRedHotXPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.doubleRedHotXPoint;
        }

        if(slotArrayInstance.tripleThreeHotX12 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.doubleRedHotXPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.doubleRedHotXPoint;
        }

        if (slotArrayInstance.tripleThreeHotX20 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.doubleRedHotXPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.doubleRedHotXPoint;
        }

        if(slotArrayInstance.tripleHotSevenWin01 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.tripleHotSevenPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.tripleHotSevenPoint;
        }

        if (slotArrayInstance.tripleHotSevenWin12 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.tripleHotSevenPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.tripleHotSevenPoint;
        }

        if (slotArrayInstance.tripleHotSevenWin20 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.tripleHotSevenPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.tripleHotSevenPoint;
        }

        if (slotArrayInstance.doubleHotSevenWin01 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.doubleHotSevenPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.doubleHotSevenPoint;
        }

        if (slotArrayInstance.doubleHotSevenWin12 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.doubleHotSevenPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.doubleHotSevenPoint;
        }

        if (slotArrayInstance.doubleHotSevenWin20 == true)
        {
            totalBalance += totalScoreRef * slotArrayInstance.doubleHotSevenPoint;
            winNumberRef = totalScoreRef * slotArrayInstance.doubleHotSevenPoint;
        }
    }
    #region RoughTest
    //public int LineNumber()
    //{
    //    return lineNumber;
    //}

    //public void ButtonLineCountPositive()
    //{
    //    lineNumber++;
    //    //lineMutipliedBet += lineMutiplier1;

    //    //if(lineNumber == 3)
    //    //{
    //    //lineNumber = 3;
    //    //}
    //}

    //public void ButtonLineCountNegative()
    //{
    //    lineNumber--;
    //    //lineMutipliedBet -= lineMutiplier1;
    //}

    //public void LineBetButtonPositive()
    //{
    //    totalBalance -= totalBetNumber;
    //    lineMutipliedBet += 5;

    //    lineBetButtonNegative.GetComponent<Button>().interactable = true;

    //    positiveButtonCount++;

    //    if (positiveButtonCount >= 3)
    //    {
    //        lineBetButtonPositive.GetComponent<Button>().interactable = false;
    //    }
    //    //if(totalBetNumber > 45)
    //    //{
    //    //    //this.gameObject.SetActive(false);
    //    //    lineBetButtonPositive.GetComponent<Button>().interactable = false;
    //    //}

    //}

    //public void LineBetButtonNegative()
    //{
    //if (totalBalance < 100)
    //{
    //totalBalance += totalBetNumber;
    ////}
    //lineMutipliedBet -= 5;

    //lineBetButtonPositive.GetComponent<Button>().interactable = true;

    //negativeButtonCount++;

    //if (negativeButtonCount >= 3)
    //{
    //    lineBetButtonNegative.GetComponent<Button>().interactable = false;
    //}

    //if (totalBetNumber < 0)
    //{
    //    //this.gameObject.SetActive(false);
    //    lineBetButtonPositive.GetComponent<Button>().interactable = false;
    //}

    //}
    #endregion
    public void LineAdd()
    {
        lines = lines switch
        {
            0 => 1,
            1 => 2,
            2 => 3,
            3 => 3,
            _ => 0,
        };
        lineText.text = lines.ToString();
        UpdateTotalBet(lines, lineBet);
    }
    public void LineSubtract()
    {
        lines = lines switch
        {
            3 => 2,
            2 => 1,
            1 => 0,
            0 => 0,
            _ => 0,
        };
        lineText.text = lines.ToString();
        UpdateTotalBet(lines, lineBet);
        //UpdateBalance(totalbet);
    }
    public void LineBetAdd()
    {
        lineBet = lineBet switch
        {
            0 => 5,
            5 => 10,
            10 => 15,
            15 =>15,
            _ => 0,
        };
        lineBetMultiplierText.text = lineBet.ToString();
        UpdateTotalBet(lines, lineBet);
        //AddUpdateBalance(totalBet, totalBalance);
        //totalBalanceText.text = totalBalance.ToString();
    }
    public void LineBetSubtract()
    {
        lineBet = lineBet switch
        {
            15 => 10,
            10 => 5,
            5 => 0,
            0 =>0,
            _ => 0,
        };
        lineBetMultiplierText.text = lineBet.ToString();
        UpdateTotalBet(lines, lineBet);
    }

    //public void TotalBalanceAdd()
    //{
    //    totalBet = totalBalance switch
    //    {
    //        5 => 5,
    //        10 => 10,
    //        15 => 15,
    //        _ => 0,
    //    };
    //    totalBalanceText.text = totalBalance.ToString();
    //}

    //public void TotalBalanceSubtract()
    //{

    //}

    public void UpdateTotalBet(int lines,float linebet)
    {
        totalBet = lines * linebet;
        totalBetText.text = totalBet.ToString();
        //totalBalance = totalBet + totalBalance;
        //totalBalance = refhellototal + totalBet;
    }
}
