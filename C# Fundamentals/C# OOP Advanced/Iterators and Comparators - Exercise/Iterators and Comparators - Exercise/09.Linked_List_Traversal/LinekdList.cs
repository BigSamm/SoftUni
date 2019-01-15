using System;
using System.Collections;
using System.Collections.Generic;

public class LinekdList : IEnumerable<int>
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public Node Head { get; private set; }
    public Node Tail { get; private set; }
    public int Count { get; private set; }

    //public void AddFirst(T item)
    //{
    //    Node old = this.Head;

    //    this.Head = new Node(item);
    //    this.Head.Next = old;

    //    if (this.IsEmpty())
    //        this.Tail = this.Head;

    //    this.Count++;
    //}

    public void Add(int item)
    {
        Node old = this.Tail;
        this.Tail = new Node(item);

        if (this.IsEmpty())
            this.Head = this.Tail;
        else
            old.Next = this.Tail;

        this.Count++;
    }

    public bool Remove(int item)
    {
        if (this.IsEmpty())
            return false;

        if (this.Head.Value == item)
        {
            this.Head = this.Head.Next;
            this.Count--;
            return true;
        }

        Node current = this.Head;
        while (current.Next != null)
        {
            Node next = current.Next;
            if (next.Value == item)
            {
                current.Next = next.Next;
                this.Count--;
                return true;
            }
            current = current.Next;
        }
        
        if (this.Tail.Value == item)
        {
            this.Tail = this.GetSecondToLast();
            this.Count--;
            return true;
        }

        return false;
    }

    //public T RemoveFirst()
    //{
    //    if (this.IsEmpty())
    //        throw new InvalidOperationException();

    //    T item = this.Head.Value;

    //    this.Head = this.Head.Next;

    //    this.Count--;

    //    if (this.IsEmpty())
    //        this.Tail = null;

    //    return item;
    //}

    //public T RemoveLast()
    //{
    //    if (this.IsEmpty())
    //        throw new InvalidOperationException();

    //    T item = this.Tail.Value;

    //    if (this.Count == 1)
    //    {
    //        this.Head = this.Tail = null;
    //    }
    //    else
    //    {
    //        Node newTail = this.GetSecondToLast();
    //        newTail.Next = null;
    //        this.Tail = newTail;
    //    }

    //    this.Count--;

    //    return item;
    //}

    private Node GetSecondToLast()
    {
        Node current = this.Head;
        while (current.Next.Next != null)
        {
            current = current.Next;
        }

        return current;
    }

    private bool IsEmpty()
    {
        if (this.Count == 0)
            return true;

        return false;
    }

    public IEnumerator<int> GetEnumerator()
    {
        Node current = this.Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}