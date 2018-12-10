using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //интерфейс
    interface INterfaceCalculator
    {
        //а - первый аргумент, b - второй аргумент
        void Put_A(double a); //сохранить а

        void Clear_A(); //отчистить

        double Multiplication(double b); //умножение

        double Division(double b); //деление

        double Sum(double b);   //суммирование

        double Subtraction(double b); //вычитание

        double SqrtX(double b); //корень из x

        double DegreeY(double b); //степень числа y

        double Sqrt(); //квадратный корень из x

        double Square(); //квадрат числа y

        double MemoryShow(); //показать содержимое регистра мамяти

        void Memory_Clear(); //стереть содержимое регистра мамяти

        //умножение, деление, прибавление или вычитание к регистру памяти
        void M_Multiplication(double b); //умножение

        void M_Division(double b); //деление

        void M_Sum(double b); // суммирование

        void M_Subtraction(double b); //вычитание
    }
}

