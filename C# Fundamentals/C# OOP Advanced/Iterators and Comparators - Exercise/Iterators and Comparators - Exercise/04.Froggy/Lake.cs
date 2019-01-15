using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Lake : IEnumerable<int>
{
    private List<int> sortedStones;

    public Lake(int[] stones)
    {
        InitializeSortedStones(stones);
    }

    private void InitializeSortedStones(int[] stones)
    {
        var oddPositionStones = new List<int> { stones[0] };
        var evenPositionStones = new Stack<int>();
        for (int i = 1; i < stones.Length; i++)
        {
            if (i % 2 == 0)
                oddPositionStones.Add(stones[i]);
            else
                evenPositionStones.Push(stones[i]);
        }

        this.sortedStones = new List<int>(oddPositionStones);
        sortedStones.AddRange(evenPositionStones);
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.sortedStones.Count; i++)
        {
            yield return this.sortedStones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}