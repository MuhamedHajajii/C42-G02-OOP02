using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encasoulation
{
    internal class Car
    {
        
        #region Properties

        // in the class the compiler will always generate a parameter less constructor if there is no consturactor
        // but if there is a constructor the compiler will no longer generate it

        public int Id { get; set; } // allcoate 4 bytes = 0
        public string Model { get; set; } // allocate 4 bytes for the reference = null
        public double speed { get; set; } // allocate 8 bytes = 0

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"CarId: {Id}\nModel: {Model}\nSpeed: {speed}";
        }
        #endregion

        #region Constructors

        // Empety parameter less constructor this is not necessary because the compiler will generate it by defult 

        //public Car()
        //{

        //}

        //// Constructor OverLoading
        //public Car(int id, string model, double speed)
        //{
        //    Id = id;
        //    Model = model;
        //    this.speed = speed;
        //}

        //public Car(int id, string model)
        //{
        //    this.Id = id;
        //    this.Model = model;
        //    this.speed = 290;
        //}

        //public Car(int id)
        //{
        //    this.Id=id;
        //    this.Model = "Audi";
        //    this.speed = 200;
        //}
        

        // Constructor Chaning
        public Car()
        {

        }
        public Car(int id, string model, double speed)
        {
            Console.WriteLine("First");
            Id = id;
            Model = model;
            this.speed = speed;
        }

        public Car(int id, string model):this(id,model,290) {
            Console.WriteLine("Second");
        }

        public Car(int id):this(id,"Audi",200) {
            Console.WriteLine("Third");
        
        }

        #endregion

    }
}
