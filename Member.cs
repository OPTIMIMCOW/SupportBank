namespace SupportBank 
{
    public class Member
    {
        public string Name { get; private set;}
        public double Total { get; set;}
        public Member(string name)
        {
            Name = name;
            Total = 0.0;
        }
    }
}