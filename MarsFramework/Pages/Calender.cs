using MarsFramework.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    public class Calender
    {
        public static void StartDate()
        {
            string day = "18";

            // /html/body/div[2]/div/div/table/tbody/tr[1]/td[1]/a
            ///html/body/div[2]/div/div/table/tbody/tr[1]/td[2]/a
            int Days = 7;
            string beforeXPath = "/html/body/div[2]/div/div/table/tbody/tr[";
            string afterXPath = "]/td[";
            Boolean Flag = false;
            string dayVal = null;
            //For loops
            for (int rownum = 1; rownum <= 7; rownum++)//Outer Loop
            {
                for (int colnum = 1; colnum <= Days; colnum++)//InnerLoop
                {
                    try
                    {
                        dayVal = Base.driver.FindElement(By.XPath(beforeXPath + rownum + afterXPath + colnum + "]/a")).Text;
                    }
                    catch (NoSuchElementException e)
                    {
                        Console.WriteLine("Enter a correct date");
                        Flag = false;
                    }

                    Console.WriteLine(dayVal);
                    if (dayVal.Equals(day))
                    {
                        Base.driver.FindElement(By.XPath(beforeXPath + rownum + afterXPath + colnum + "]/a")).Click();
                        Flag = true;
                        break;
                    }
                }
                if (Flag)
                {
                    break;
                }
            }


        }

        public static void EndDate()
        {
            int DayOfWeek = 7;
            String date = "30";
            string beforeXPath = "/html/body/div[10]/div/div/table/tbody/tr["; ///html/body/div[10]/div/div/table/tbody/tr[1]/td[1]/a
                                                                               ///html/body/div[10]/div/div/table/tbody/tr[1]/td[2]/a
            string afterXPath = "]/td[";
            Boolean flag = false;
            String dayVal = null;

            //Iterate the cells using for loops
            for (int rownum = 1; rownum <= 7; rownum++)
            {
                for (int colnum = 1; colnum <= DayOfWeek; colnum++)
                {
                    try
                    {
                        dayVal = Base.driver.FindElement(By.XPath(beforeXPath + rownum + afterXPath + colnum + "]/a")).Text;
                    }
                    catch (NoSuchElementException e)
                    {
                        Console.WriteLine("Enter a correct date");
                        flag = false;
                    }
                    Console.WriteLine(dayVal);
                    if (dayVal.Equals(date))
                    {
                        Base.driver.FindElement(By.XPath(beforeXPath + rownum + afterXPath + colnum + "]/a")).Click();
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }

            }
        }
    }
}
