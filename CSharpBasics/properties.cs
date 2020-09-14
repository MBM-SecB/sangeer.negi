class Person
{
    private int age=23;
    internal string name="enma";

    public int Age
    {
        get
        {
            return age;
        } 
        set
        {
         if( value>20 && value<30)   
         {
             age=value;
         }
        }
    } =23;
}    