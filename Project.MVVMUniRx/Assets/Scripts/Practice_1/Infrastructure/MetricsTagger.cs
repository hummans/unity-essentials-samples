using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;

public class MetricsTagger : IMetricsTagger
{
    public void TagEvent(string metric)
    {
        Debug.Log($"Tagging '{metric}'");
    }

}
