using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * @Modified: Group programming session
 * To Do: Fix bug
 * - There seems to be bugs with some of the question where the wrong answer is given
 * - Maybe due to flipping correct answer buttons, furtheremore there are null object occurances during in game performance
 */
public class MathProblems : MonoBehaviour
{
    public List<int> MathList = new List<int>();

    public Text firstNumber;
    public Text secondNumber;
    public Text answerOne;
    public Text answerTwo;
    public Text operatorText;
    public Text righOrWrongText;
    public GameObject dialoguePanel;
    public ScoreScript scoreScript; 


    public int randomFirstNum;
    public int randomSecNum;
    public int currAns;

    int randOperator;

    int firstNumbInQ;
    int secNumInQ;
    int ansOne;
    int ansTwo;
    int displayRandAns;
    int randomAnsPlacement;
 
    public bool playerIsClose;

    void Start()
    {
        righOrWrongText.text = "";
    }

    /*
     * Listens for Key press to open and close panel
     */
    void Update()
    {
        if (playerIsClose)
        {
            if (Input.GetKeyDown(KeyCode.E) && !dialoguePanel.activeInHierarchy)
            {
                dialoguePanel.SetActive(true);
                DiplayMathProblem();
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) && dialoguePanel.activeInHierarchy)
        {
            RemovePanel();
        }
    }


    /*
     * Displays math problem and randomises which problem to put out
     */
    public void DiplayMathProblem()
    {
        // generate random numbers 
        randomFirstNum = Random.Range(0, MathList.Count + 1);
        randomSecNum = Random.Range(0, MathList.Count + 1);

        firstNumbInQ = randomFirstNum;
        secNumInQ = randomSecNum;

        randOperator = Random.Range(0, 4);
        if(randOperator == 0)
        {
            ansOne = firstNumbInQ + secNumInQ;
            operatorText.text = "+";
        }
        if (randOperator == 1)
        {
            ansOne = firstNumbInQ - secNumInQ;
            operatorText.text = "-";
        }
        if (randOperator == 2)
        {
            ansOne = firstNumbInQ / secNumInQ;
            operatorText.text = "/";
        }
        if (randOperator == 3)
        {
            ansOne = firstNumbInQ * secNumInQ;
            operatorText.text = "x";
        }

       // ansOne = firstNumbInQ + secNumInQ; // always right answer


        displayRandAns = Random.Range(0, 2);//wrong ans to displa
        if(displayRandAns == 0)
        {  
            ansTwo = ansOne + Random.Range(1, 5);
        }
        else
        {
            ansTwo = ansOne - Random.Range(1, 5);
        }

        firstNumber.text = "" + firstNumbInQ;
        secondNumber.text = "" + secNumInQ;
        randomAnsPlacement = Random.Range(0, 2);
        if(randomAnsPlacement == 0)
        {
            answerOne.text = "" + ansOne; // button text becomes ansOne (correct ans)
            answerTwo.text = "" + ansTwo; // button text becomes random ans
            currAns = 0;
        }
        else
        {
            answerOne.text = "" + ansTwo;
            answerTwo.text = "" + ansOne;
            currAns = 1; // flip answer using 0 or 1 so correcct answer is not always in the correct spot 
        }

    }


    /*
     * Flips buttons and answer corresponding to it so the right answer is not always in the same spot
     */
    public void ButtonAnswerOne()
    {
        if(currAns == 0)
        {
            righOrWrongText.enabled = true;
            righOrWrongText.color = Color.blue;
            righOrWrongText.text = ("Correct");
            scoreScript.correctAnswer();
            Invoke("TurnOffText", 1);
            RemovePanel();


        }
        else
        {
            righOrWrongText.enabled = true;
            righOrWrongText.color = Color.red;
            righOrWrongText.text = ("Incorrect");
            Invoke("TurnOffText", 1);
        }
    }

    public void ButtonAnswerTwo()
    {
        if (currAns == 1)
        {
            righOrWrongText.enabled = true;
            righOrWrongText.color = Color.blue;
            righOrWrongText.text = ("Correct");
            scoreScript.correctAnswer();
            Invoke("TurnOffText", 1);
            RemovePanel();


        }
        else
        {
            righOrWrongText.enabled = true;
            righOrWrongText.color = Color.red;
            righOrWrongText.text = ("Incorrect");
            Invoke("TurnOffText", 1);
        }
    }

    /*
     * Removes text 
     */
    public void TurnOffText()
    {
        if(righOrWrongText != null)
            righOrWrongText.enabled = false;
        DiplayMathProblem();
    }

    /*
     * Collider of player checks if player is close to question point object 
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
           
        }
    }

    /*
     * Close panel
     */
    public void RemovePanel()
    {
        dialoguePanel.SetActive(false);
    }





}
