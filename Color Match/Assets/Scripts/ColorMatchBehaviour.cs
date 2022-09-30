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

    public void ChangeColor(SpriteRenderer cRenderer)
    {
        var newColor = idObj as ColorID;
        cRenderer.color = newColor.value;
    }
}
