using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Model;
using Repository;

namespace Service
{
   public class UserService
   {

        UserRepository userRepository = new UserRepository();
      
        public void Save(User newPatient)
        {
            userRepository.Save(newPatient);
            MessageBox.Show("Successfully created new patient!");
        }
      
      public List<User> GetAll()
      {
            List<User> allEmployees = new List<User>(userRepository.GetAll());
            List<User> patients = new List<User>();

            foreach(User u in allEmployees)
            {
                if(u.Type=="patient")
                {
                    patients.Add(u);
                }
            }

            return patients;

      }
      
      public User Registration(String email, String password)
      {
         List<User> users = userRepository.GetAll();

         foreach (User u in users)
            {
                if ((u.Email == email) && (u.Password == password))
                {  
                    return u;
                }        
            }
            return null;
      }
      
      public Boolean IsJmbgValid(String jmbg)
      {
            User patient = userRepository.GetAll().SingleOrDefault(s => (s.Jmbg.Equals(jmbg)));
            if (patient != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean IsEmailValid(String email)
        {
            User patient = userRepository.GetAll().SingleOrDefault(s => (s.Email.Equals(email)));
            if (patient != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean CheckOwnedWeek(String email)
        {
            User user = new User();
            user = userRepository.getByEmail(email);
            int count = 0;
            DateTime sevenDays = DateTime.Today.AddDays(-7);

            foreach (Bill b in user.Bills)
            {
                if(b.DateTime>sevenDays)
                count+=b.MedicineAndQuantity.Count;   
            }

           if(count>50)
            {
                return false;
            }
            else
            { 
                return true;
            }
        }





      public Boolean CheckOwnedOne(String email, Dictionary<String, int> dictCart)
      {
            User user = new User();
            user = userRepository.getByEmail(email);

            foreach (KeyValuePair<string, int> countExisting in user.MedicineOwnedCounter)
            {
                foreach(KeyValuePair<string, int> countCart in dictCart)
                {
                    if(countExisting.Key==countCart.Key)
                    {
                        user.MedicineOwnedCounter[countExisting.Key] += dictCart[countCart.Key];
                    }
                }   

            }
    
            foreach (KeyValuePair<string, int> countExisting in user.MedicineOwnedCounter)
            {
                if (countExisting.Value > 5)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            return true; ////PORAZMISLITI U VEZI POVRATNE VREDNOSTI
      }



        public Dictionary<String, int> getOwnedMedicine(String email)
        {
            User user = new User();
            user = userRepository.getByEmail(email);
            Dictionary<String, int> MedicineOwned = new Dictionary<string, int>();
            
            foreach (Bill b in user.Bills)
            {
                foreach(String t in b.MedicineAndQuantity.Keys)
                {
                    if (MedicineOwned.Keys.FirstOrDefault(x => x==t)!=null)
                    {
                        MedicineOwned[t] += MedicineOwned[t];
                    }
                    else
                    {
                        MedicineOwned.Add(t, b.MedicineAndQuantity[t]);
                    }
                } 
            }

            return MedicineOwned;
        }

    }
}