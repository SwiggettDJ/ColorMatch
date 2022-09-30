using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDDataList colorDataListObj;
    private void Awake()
    {
        idObj = colorDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
    }
}
