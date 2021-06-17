
using Controller;
using Service;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    //UserController userController = new UserController();
    public class User
    {

        

        public String Jmbg { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String MobilePhone { get; set; }
        public String Type { get; set; }

        public Dictionary<String,int> OwnedMedicineCounter { get; set; }

        public List<Bill> Bills  {get; set;}
        //Dictionary<string, int> ownedMedicineCounter
        public User(string jmbg, string email, string password, string name, string surname, string mobilePhone, string type, Dictionary<string, int> ownedMedicineCounter)
        {
            Jmbg = jmbg;
            Email = email;
            Password = password;
            Name = name;
            Surname = surname;
            MobilePhone = mobilePhone;
            Type = type;
            //UserController userController = new UserController();
            OwnedMedicineCounter = ownedMedicineCounter ;
            Bills = new List<Bill>();
        }


        //public User(string jmbg, string email, string password, string name, string surname, string mobilePhone, string type)
        //{
        //    Jmbg = jmbg;
        //    Email = email;
        //    Password = password;
        //    Name = name;
        //    Surname = surname;
        //    MobilePhone = mobilePhone;
        //    Type = type;
        //    Bills = new List<Bill>();
        //   // MedicineOwnedCounter  = userController.getOwnedMedicine(email);

        //}









        public User()
        {

        }



      


       //public System.Collections.ArrayList GetBill()
       //{
       //   if (bill == null)
       //      bill = new System.Collections.ArrayList();
       //   return bill;
       //}


       //public void SetBill(System.Collections.ArrayList newBill)
       //{
       //   RemoveAllBill();
       //   foreach (Bill oBill in newBill)
       //      AddBill(oBill);
       //}


       //public void AddBill(Bill newBill)
       //{
       //   if (newBill == null)
       //      return;
       //   if (this.bill == null)
       //      this.bill = new System.Collections.ArrayList();
       //   if (!this.bill.Contains(newBill))
       //      this.bill.Add(newBill);
       //}


       //public void RemoveBill(Bill oldBill)
       //{
       //   if (oldBill == null)
       //      return;
       //   if (this.bill != null)
       //      if (this.bill.Contains(oldBill))
       //         this.bill.Remove(oldBill);
       //}


       //public void RemoveAllBill()
       //{
       //   if (bill != null)
       //      bill.Clear();
       //}
       

    }
}