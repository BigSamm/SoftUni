using System;
using System.Collections.Generic;
using System.Text;

public class Family
{
    private List<Person> members;

    public List<Person> Members
    {
        get { return this.members; }
        set { this.members = value; }
    }

    public Family()
    {
        this.Members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.Members.Add(member);
    }

    public Person GetOldestMember()
    {
        Person oldestMember = new Person();

        foreach (var member in this.members)
        {
            if (member.Age > oldestMember.Age)
                oldestMember = member;
        }

        return oldestMember;
    }
}
