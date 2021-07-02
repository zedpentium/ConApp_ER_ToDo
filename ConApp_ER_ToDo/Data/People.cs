﻿using System;
using System.Collections.Generic;
using System.Text;
using ConApp_ER_ToDo.Model;

namespace ConApp_ER_ToDo.Data
{
    public class People
    {

        private static Person[] arrOfPersonObjects = new Person[0];


        public int Size()
        {
            return arrOfPersonObjects.Length;
        }

        public Person[] FindAll()
        {

            Person[] allPersonsFromPeepsArray = new Person[0];
            Array.Resize(ref allPersonsFromPeepsArray, Size());

            for (int i = 0; i < Size(); i++)
            {
                allPersonsFromPeepsArray[i] = arrOfPersonObjects[i];
            }

            return allPersonsFromPeepsArray;
        } 


        public Person FindById(int personId)
        { 
            Person foundObjectIndex = Array.Find(arrOfPersonObjects, idNr => idNr.PersonId == personId);

            return foundObjectIndex;
        }

        /* string item = "Eric";
        public void TestFindID()
        {
            int index = Array.FindIndex(arrOfPersonObjects, 0, Size(), Person.Equals(Person.personID);
            if (index != -1)
            {
                Console.WriteLine(String.Format("Element {0} is found at index {1}", item, index));
            }
            else
            {
                Console.WriteLine("Element not found in the given array.");
            }
        }*/

        public Person CreateNewPersonToArray(string firstName, string lastName)
        {
            Person newPersonInfo = new Person(firstName, lastName, PersonSequencer.NextPersonId());

            Array.Resize(ref arrOfPersonObjects, 1 + Size()); // adding 1 more element to array to make room for the newPersonInfo object

            arrOfPersonObjects[Size() - 1] = newPersonInfo;

            return newPersonInfo;

        }


        public void Clear()
        {
            Array.Resize(ref arrOfPersonObjects, 0);
            PersonSequencer.Reset();
        }

        





    }
}
