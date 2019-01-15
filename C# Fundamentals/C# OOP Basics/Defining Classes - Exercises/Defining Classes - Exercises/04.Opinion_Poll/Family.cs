using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

    public List<Person> GetMembersMoreThan30Years()
    {
        var membersForPrint = this.members.Where(m => m.Age > 30).ToList();

        membersForPrint = membersForPrint.OrderBy(m => m.Name).ToList();

        return membersForPrint;
    }
}
