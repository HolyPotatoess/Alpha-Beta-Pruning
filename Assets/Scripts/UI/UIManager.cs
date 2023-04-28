using Chess;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_InputField depthInput;
    int depthValue;
    Search search;
    // Start is called before the first frame update

    public void updateDepth()
    {
        if(int.TryParse(depthInput.text, out int result))
        {
            Debug.Log($"{result}");
            if (result == 0)
            {
                depthValue = 0;
            }
            else
            {
                depthValue = result;
            }

        }
    }

    public int getDepth()
    {
        if (depthValue == 0)
        {
            return 0;
        }
        return depthValue;
    }

    public void setDepth(int depth)
    {
        this.depthValue = depth;    
    }
}
