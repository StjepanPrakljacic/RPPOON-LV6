using System;
using System.Collections.Generic;
using System.Text;


namespace RPPOON_Lv6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notebook NOTES = new Notebook();
            //NOTES.AddNote(new Note("Poštovanje", "Stjepan Prkljacic"));
            //NOTES.AddNote(new Note("Kolegiji", "RPPOON"));
            //NOTES.AddNote(new Note("LV6", "Oblikovni obrasci: obrasci ponašanja"));
            //NOTES.AddNote(new Note("Početak:", "13.5.2020 u 15.00h"));
            //Iterator MyfirstIterator = new Iterator(NOTES);
            //MyfirstIterator.Current.Show();
            //MyfirstIterator.Next().Show();
            //while (MyfirstIterator.IsDone == false)
            //{
            //    MyfirstIterator.Current.Show();
            //    MyfirstIterator.Next();
            //}

            //Box Mybox = new Box();
            //Mybox.AddProduct(new Product("Rolex", 150));
            //Mybox.AddProduct(new Product("HoBBit Movie", 10));
            //BoxIterator iterator = new BoxIterator(Mybox);
            //for(Product prod = iterator.First(); iterator.IsDone == false; prod = iterator.Next())
            //{

            //    Console.WriteLine(prod.ToString());

            //}

            //CareTaker careTaker = new CareTaker();
            //ToDoItem exp1 = new ToDoItem("Title: ", "RPPOON", DateTime.Now);
            //ToDoItem exp2 = new ToDoItem("Title:", "Teorija Informacije", DateTime.Today.AddDays(1).AddHours(13.00).AddMinutes(45));
            //careTaker.AddState(exp1.StoreState());
            //Console.WriteLine(exp1.ToString());
            //careTaker.AddState(exp2.StoreState());
            //Console.WriteLine(exp2.ToString()); 
            //exp1.RestoreState(careTaker.GetFirstState());
            //exp2.RestoreState(careTaker.GetState(1));
            //Console.WriteLine(exp1);
            //Console.WriteLine(exp2);


            //BankCareTaker caretaker = new BankCareTaker();
            //BankAccount accaunt = new BankAccount("Stjepan Prakljacic", "Osijek", 0.4m);
            //Bank_Memento memento = new Bank_Memento(accaunt);
            //caretaker.PreviousState = memento;
            //Console.WriteLine(caretaker.PreviousState.OwnerName.ToString());
            //Console.WriteLine(caretaker.PreviousState.Balance.ToString());
            //accaunt.UpdateBalance(1.1m);
            //accaunt.UpdateBalance(0.1m);
            //memento.AddState(accaunt);
            //caretaker.PreviousState = memento;
            //Console.WriteLine(caretaker.PreviousState.Balance.ToString());

            //AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            //FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            //logger.Log("TestInfo", MessageType.INFO);
            //fileLogger.Log("Warning", MessageType.WARNING);
            //fileLogger.Log("ERRORRRRR", MessageType.ERROR);

            //StringChecker Stringdigitcheck = new StringDigitChecker();
            //string str = "test1string";
            //Console.WriteLine(Stringdigitcheck.Check(str));
            //StringChecker Stringuppercheck = new StringUpperCaseChecker();
            //Console.WriteLine(Stringuppercheck.Check(str));
            //StringChecker Stringlowercheck = new StringLowerCaseChecker();
            //Console.WriteLine(Stringlowercheck.Check(str));
            //StringChecker StringLengthcheck = new StringLengthChecker();
            //Console.WriteLine(StringLengthcheck.Check(str));

            StringUpperCaseChecker upperCaseChecker = new StringUpperCaseChecker();
            StringLowerCaseChecker lowerCaseChecker = new StringLowerCaseChecker();
            StringDigitChecker digitChecker = new StringDigitChecker();
            StringLengthChecker stringLength = new StringLengthChecker();
            PasswordValidator validator = new PasswordValidator(upperCaseChecker);
            validator.AddNext(lowerCaseChecker);
            validator.AddNext(digitChecker);
            validator.AddNext(stringLength);
            Console.WriteLine(validator.checkValidation("Iiiv5"));
            Console.WriteLine(validator.checkValidation("WW2"));


        }

    }
}
