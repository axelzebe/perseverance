using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SkipButton : MonoBehaviour
{
    public Flowchart skipFc;
    public string skipBlock;
    public string skipBlock2;

    public void skipToExplanation()
    {
        skipFc.StopAllBlocks();
        skipFc.ExecuteBlock(skipBlock);
    }

    public void skipToQuestion()
    {
        skipFc.StopAllBlocks();
        skipFc.ExecuteBlock(skipBlock2);
    }
}
