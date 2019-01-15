using System;
using System.Collections.Generic;
using System.Text;

public class CustomList<T>
    where T : IComparable<T>
{
    private List<T> elements;

    public CustomList()
    {
        this.elements = new List<T>();
    }

    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public T Remove(int index)
    {
        var removedElement = this.elements[index];
        this.elements.RemoveAt(index);
        return removedElement;
    }

    public bool Contains(T element)
    {
        if (this.elements.Contains(element))
            return true;
        else
            return false;
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        var elementAtFirstIndex = this.elements[firstIndex];
        this.elements[firstIndex] = this.elements[secondIndex];
        this.elements[secondIndex] = elementAtFirstIndex;
    }

    public int CountGreaterThan(T element)
    {
        var greaterCount = 0;

        foreach (var item in this.elements)
        {
            var compareResult = item.CompareTo(element);
            if (compareResult > 0)
                greaterCount++;
        }

        return greaterCount;
    }

    public T Max()
    {
        var maxElement = this.elements[0];

        for (int i = 1; i < this.elements.Count; i++)
        {
            var element = this.elements[i];
            var compareResult = element.CompareTo(maxElement);
            if (compareResult > 0)
                maxElement = element;
        }

        return maxElement;
    }

    public T Min()
    {
        var minElement = this.elements[0];

        for (int i = 1; i < this.elements.Count; i++)
        {
            var element = this.elements[i];
            var compareResult = element.CompareTo(minElement);
            if (compareResult < 0)
                minElement = element;
        }

        return minElement;
    }

    public string Print()
    {
        var result = new StringBuilder();

        foreach (var element in this.elements)
        {
            result.Append(element + Environment.NewLine);
        }

        return result.ToString().TrimEnd();
    }
}