class Person
{
    private int age=23;
    internal string name="enma";
    private int age1 = 23;

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int value)
    {
        if (value > 20 && value < 30)
        {
            age = value;
        }
    }
}    