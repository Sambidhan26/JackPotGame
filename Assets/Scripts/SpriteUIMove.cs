using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpriteUIMove : MonoBehaviour
{
    SlotArray slotArray;

    //public GameObject slotHolder1;

    [SerializeField]float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        slotArray = FindObjectOfType<SlotArray>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slotArray.StopRandom == false)
        {
            GetComponent<DOTweenAnimation>().DOPause();
        }

        if (slotArray.StopRandom == true)
        {
            GetComponent<DOTweenAnimation>().DOPlay();
        }
    }
}
