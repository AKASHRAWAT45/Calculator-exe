using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Data.OleDb;
using System.Data.SqlClient;
using TestAutomationFX.Core;
using TestAutomationFX.UI;

namespace calculatornew
{
    [UITestFixture]
    public partial class TestFixture1 : UIMap
    {
        public TestFixture1()
        {
            InitializeComponent();
        }

        public TestFixture1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

       //  String str = "";
        //String str2 = "";

        [UITest()]
        public void autoamteadd()
    {
      

        string[] file = File.ReadAllLines("C:/Users/Akash.Rawat/Documents/Visual Studio 2012/Projects/calculatornew/caltest.txt");
           
         
         
     
        Button6.Click();
            int max = 0;
            int idx = 0;
           // while (max < file.Length - 1)
           // {
            try{

                for (int i = 0; i < file[max].Length & max <= file.Length - 1; i++)
                {
                    idx = i;
                    foreach (char str in file[max])
                    {

                        if (str == '=')
                        {
                            Button16.Click();

                            break;
                        }
                        else if (str == '1')
                        {
                            Button15.Click();


                        }
                        else if (str == '2')
                        {
                            Button14.Click();


                        }
                        else if (str == '3')
                        {
                            Button12.Click();


                        }
                        else if (str == '4')
                        {
                            Button10.Click();


                        }
                        else if (str == '5')
                        {
                            Button9.Click();


                        }
                        else if (str == '6')
                        {
                            Button7.Click();

                        }
                        else if (str == '7')
                        {
                            Button1.Click();


                        }
                        else if (str == '8')
                        {
                            Button2.Click();


                        }
                        else if (str == '9')
                        {
                            Button4.Click();


                        }
                        else if (str == '+')
                        {
                            Button18.Click();


                        }
                        else if (str == '-')
                        {
                            Button13.Click();


                        }
                        else if (str == '*')
                        {
                            Button8.Click();


                        }
                        else if (str == '/')
                        {
                            Button3.Click();


                        }
                        else if (str == 'C')
                        {
                            Button6.Click();


                        }
                    }
                    TextBox_Result.VerifyProperty("Text", file[max].Substring(file[max].IndexOf("=") + 1).ToString());
                    Button6.Click();
                    max++;
                }

                
               
            }

               
        //}
            catch(Exception e)
            {
                System.IO.StreamWriter file1 = new StreamWriter(@"E:\automationtestcases\calresult.txt");
                file1.Write("Failed  => ");
               
                file1.WriteLine();
                file1.Close();
            }
    }

        


    }
}

