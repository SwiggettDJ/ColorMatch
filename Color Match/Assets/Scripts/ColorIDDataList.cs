using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIdList;

    public ColorID currentColor;

    private int num;

    public void SetRandomColor()
    {
        num =  Random.Range(0,colorIdList.Count);
        currentColor = colorIdList[num];
    }
}
