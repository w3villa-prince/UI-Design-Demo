using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryBlock : MonoBehaviour
{
    public string Story;
    public string Option1Text;
    public string Option2Text;
    public StoryBlock Option1Block;
    public StoryBlock Option2Block;

    public StoryBlock(string story, string option1Text, string option2Text, StoryBlock option1Block = null, StoryBlock option2Block = null)
    {
        this.Story = story;
        this.Option1Text = option1Text;
        this.Option2Text = option2Text;
        this.Option1Block = option1Block;
        this.Option2Block = option2Block;

        // Debug.Log(option2Text + option1Text + story);
    }
}

public class GameManager : MonoBehaviour
{
    public TMP_Text mainText;
    public TMP_Text title;
    public Button option1;
    public Button option2;
    private StoryBlock currentBlock;

    //StoryBlock currentBlock;

    private static StoryBlock block6 = new StoryBlock("all Task here! ", "Enter", "Exit");
    private static StoryBlock block5 = new StoryBlock("List of task  ", "Home ", "Exit", block1, block3);
    private static StoryBlock block4 = new StoryBlock("Task list of today ", "Doing ", "Reading", block5, block6);
    private static StoryBlock block3 = new StoryBlock("Thanks For Use me  ", "Null", "Restart", block6, block3);
    private static StoryBlock block2 = new StoryBlock("Good Morning  ", "TodayTask", "Exit", block4, block3);
    private static StoryBlock block1 = new StoryBlock("Welcome Mr.Xyz ", "Enter", "Exit", block2, block3);

    private void Start()
    {
        currentBlock = GetComponent<StoryBlock>();
        DisplayBlock(block1);
    }

    private void DisplayBlock(StoryBlock block)
    {
        mainText.text = block.Story;
        title.text = "Hello  Mr.";
        option1.GetComponentInChildren<TMP_Text>().text = block.Option1Text;
        option2.GetComponentInChildren<TMP_Text>().text = block.Option2Text;
        currentBlock = block;
    }

    public void Button1Clicked()
    {
        DisplayBlock(currentBlock.Option1Block);
    }

    public void Button2Clicked()
    {
        DisplayBlock(currentBlock.Option2Block);
    }

    // Update is called once per frame
}
