using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{
    GameObject cName;
    GameObject c2Name;
    GameObject c3Name;
    //public RuntimeAnimatorController anim;
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    var cName = transform.GetChild(0).GetComponent<Animator>().gameObject;
        //    cName.SetActive(true);
        //    cName.GetComponentInParent<Animator>().Play("3XWinAnim1");

        //    //anim = cName.GetComponent<RuntimeAnimatorController>();

        //    //Debug.LogError(cName.name);
        //}
        //PlayAnim();
    }

    public bool PlayAnim()
    {
        cName = transform.GetChild(0).GetComponent<Animator>().gameObject;
        c2Name = transform.GetChild(1).GetComponent<Animator>().gameObject;
        c3Name = transform.GetChild(2).GetComponent<Animator>().gameObject;
        cName.SetActive(true);
        c2Name.SetActive(true);
        c3Name.SetActive(true);
        cName.GetComponentInParent<Animator>().Play("3XWinAnim1");
        StartCoroutine("DelayAnimFalse");
        return true;
    }

    IEnumerator DelayAnimFalse()
    {
        yield return new WaitForSeconds(2.0f);
        cName.SetActive(false);
        c2Name.SetActive(false);
        c3Name.SetActive(false);
    }
}
