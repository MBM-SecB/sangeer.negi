using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()

        {
            //LINQ - Language INtegrated Query
            int[] numbers = { 12, 34, 23, 67, 445, 68, 10, 89, 26, 123, 43542 };


            //Method syntax
            // take number greater than 50 
            var result1 = numbers.Where(num => num > 50).Select(num => num);

            //Query expression Syntax
            // take number greater than 50 
            var result2 = from num in numbers
                          where num > 50
                          select num;


            //Restrictions -Where 
            // take number greater than 50 and less than 70 
            var result3 = from num in numbers
                          where num > 50 && num < 70
                          select num;


            //Projection - select 
            // take numbers which are even then square them
            var result4 = from num in numbers
                          where num % 2 == 0
                          select num * num;



            // Ordering-orderby, orderby descending
            //numbers in ascending order
            var result5 = from num in numbers
                          orderby num
                          select num;
            //numbers in descending order
            // var result5 = from num in numbers
            //               orderby num descending
            //               select num;


            //Partitioning:skip,take
            //takes first 5 element of array
            var result6 = numbers.Take(5);
            //skip first 5 element and takes later 5 elements in array
            // var result6 = numbers.Skip(5).Take(5);

            //Quantifiers-Any,All,Contains
            //check any element if it meets condition 
            var result7 = numbers.Any(num => num % 2 == 0);


            //check all elements if every elements meets condition
            var result8 = numbers.All(num => num % 2 == 0);

            //check if array has certain elements
            var result9 = numbers.Contains(23);

            //Generations
            var result10=Enumerable.Range(1,1000);
            var result11=Enumerable.Repeat("Hello World!",20);
        }


        void LearnLinqOnComplexCollection()
        {

            Country c1 = new Country("Nepal", "kathmandu", "Asia", 3242242434);
            Country c2 = new Country("India", "Delhi", "Asia", 7522242434,DateTime.Parse("1947/11/1"));
            Country c3 = new Country("England", "GB", "Europe", 1002242434);
            Country c4 = new Country("Bhutan", "Thimpu", "Asia", 324434);
            Country c5 = new Country("Russia", "Mosco", "Europe", 5242242434,DateTime.Parse("1907/11/1"));
            Country c6 = new Country("Australia", "Canberra", "Australia", 42242434,DateTime.Parse("1943/11/1"));

            List<Country> countries = new List<Country> { c1, c2, c3, c4, c5, c6 };

            //list  all asian country names
            var result1 = from country in countries
                          where country.Continent == "Asia"
                          select country.Name;
            //HW- create 20 country up to c20
            //HW-List all asian country names which are never been invaded
            var result2=from country in countries

            //Hw-List all Europian Country in ascending order that has population less than 500k
            var result3=from country in countries
        }
    }
}
