// ﻿using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Xml.Serialization;

// namespace Multiple_inheritance
// {
//     interface IphoneBasic
//     {
//         void Calling();
//         void Receiving();
//         void Sendmessage();
//         void Endmessage();

    // }
    // class Iphonese : IphoneBasic
    // {
    //     public void Calling()
    //     {
    //         Console.WriteLine("IphoneSe is calling");
        // }
    //     public void Receiving()
    //     {
    //         Console.WriteLine("IphoneSe is receiving");
    //     }
    //     public void Sendmessage()
    //     {
    //         Console.WriteLine("IphoneSe is sending message"); 
    //     }
    //     public void Endmessage()
    //     {
    //         Console.WriteLine("IphoneSe is ending message");
    //     }
        
    // }
    // interface IphoneAdavnced
    // {
    //     void Faceid();
    //     void Vediocalling();
    //     void AirDrop();
    // }
    // class Iphon16 : IphoneBasic, IphoneAdavnced
    // {
    //     public void Calling()
    //     {
    //         Console.WriteLine("Iphon16 is calling");
    //     }
    //     public void Receiving()
    //     {
    //         Console.WriteLine("Iphon16 is receiving");
    //     }
    //     public void Sendmessage ()
    //     {
    //         Console.WriteLine("Iphon16 is sending message");
    //     }
    //     public void Endmessage()
    //     {
    //         Console.WriteLine("Iphon16 is ending message");
    //     }
    //     public void Faceid()
    //     {
    //         Console.WriteLine("Iphon16 has faceid");
    //     }
    //     public void Vediocalling()
    //     {
    //         Console.WriteLine("Iphon16 has vediocalling");
    //     }
    //     public void AirDrop()
    //     {
    //         Console.WriteLine("Iphon16 has AirDrop");
    //     }
    // }
 interface Ipaymentgetway
 {
     void processpayment();
 }
 class paypalgetway:Ipaymentgetway
 {
     public void processpayment()
     {
         Console.WriteLine(" Ipaymentgetway  payment processed through PayPal");
     }
 }
 interface Iupigetway
 {
     void processpayment();
 }
 class cretitcard:Iupigetway
 {
     public void processpayment()
     {
         Console.WriteLine(" Iupigetway  payment processed through credit card");
     }
     
 }
 interface Idepitcard
 {
            void processpayment();
 }

 class debittcard:Ipaymentgetway, Iupigetway, Idepitcard
 {
     public void processpayment()
     {
         Console.WriteLine(" debit card  payment processed through debit card");
     }
 }




    internal class Program
    {
        static void Main(string[] args)
        {
            // IphoneBasic obj=new Iphonese();
            // obj.Calling();
            // obj.Receiving();
            // obj.Sendmessage();
            // obj.Endmessage();
            // obj=new Iphon16();
            // obj.Calling();
            // obj.Receiving();
            // obj.Sendmessage();
            // obj.Endmessage();
            // IphoneAdavnced obj1=new Iphon16();
            // obj1.Faceid();
            // obj1.Vediocalling();
            // obj1.AirDrop();


            
            Ipaymentgetway obj = new paypalgetway();
            obj.processpayment();
            Iupigetway obj1 = new cretitcard();
            obj1.processpayment();
            Idepitcard obj2 = new debittcard();
            obj2.processpayment();
            Console.WriteLine("This is an example of multiple inheritance using interfaces in C#.");



        }
    }
}
