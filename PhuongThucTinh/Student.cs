﻿namespace PhuongThucTinh
{
    public class Student:Shap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }


        public static void Show()
        {
            Console.WriteLine("Phuong thuc tinh");
        }
    }
}
