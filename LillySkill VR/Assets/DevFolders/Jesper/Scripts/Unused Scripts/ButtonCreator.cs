using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Timeline.AnimationPlayableAsset;

namespace JespersCode
{
    public class ButtonCreator : MonoBehaviour
    {
        private GameManager gameManager;
        private UIManager uiManager;
        private bool loopDone = false;
        [SerializeField]
        private GameObject buttonPrefab, panelToAttachButtonsTo;

        private GameObject button;

        private void Start()
        {
            SummaryPageText();
        }

        private void SummaryPageText()
        {
            if (loopDone == false)
            {
                for (int i = 0; i < gameManager.AnswerList.Count; i++)
                {                    
                    button = (GameObject)Instantiate(buttonPrefab);
                    button.transform.SetParent(panelToAttachButtonsTo.transform);//Setting button parent
                    button.GetComponent<Button>().onClick.AddListener(OnClick);//Setting what button does when clicked
                    //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button
                    button.transform.GetChild(0).GetComponent<Text>().text = gameManager.AnswerList[i];//Changing text
                    button.transform.localPosition =- new Vector3(0, 22f, 0f);
                }
                loopDone = true;
            }
        }

        void OnClick()
        {
            uiManager.uiPrefabCopyList[1].SetActive(true);
           
            Debug.Log("clicked!");
        }
    }
}

