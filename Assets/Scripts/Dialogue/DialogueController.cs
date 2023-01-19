//using ProgressoMaker.UIPM;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//namespace ProgressoMaker.DialoguePM
//{
//    public class DialogueController : AbstractSingleton<DialogueController>
//    {
//        [Header("Content")]
//        [SerializeField] private ITalker talker;
//        [SerializeField] private string message;

//        [Header("Execution")]
//        [SerializeField] private bool isRunning;
//        [SerializeField] private bool isTyping;

//        public bool IsRunning()
//        {
//            return isRunning;
//        }

//        public void StartDialogue(ITalker talker, string message)
//        {
//            this.talker = talker;
//            this.message = message;

//            isRunning = true;
//            //UIController.Instance.ShowDialogue(talker, null, false);
//            Debug.LogWarning("NO DIALOGUE REFRESH");
//            StartCoroutine(TypeMessage());
//        }

//        public void Interaction()
//        {
//            if (isTyping)
//            {
//                StopAllCoroutines();
//                FinishTyping();
//            }
//            else
//            {
//                FinishDialogue();
//            }
//        }

//        private IEnumerator TypeMessage()
//        {
//            isTyping = true;
//            char[] charArray = message.ToCharArray();
//            string partialMessage = "";
//            foreach (char forChar in charArray)
//            {
//                partialMessage += forChar;
//                //UIController.Instance.ShowDialogue(talker, partialMessage, false);
//                Debug.LogWarning("NO DIALOGUE REFRESH");
//                yield return null;
//            }
//            FinishTyping();
//        }

//        private void FinishTyping()
//        {
//            //UIController.Instance.ShowDialogue(talker, message, true);
//            Debug.LogWarning("NO DIALOGUE REFRESH");
//            isTyping = false;
//        }

//        private void FinishDialogue()
//        {
//            UIController.Instance.LevelStart();
//            isRunning = false;
//        }
//    }
//}
