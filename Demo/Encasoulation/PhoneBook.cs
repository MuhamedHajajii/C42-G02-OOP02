using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encasoulation
{
    internal struct PhoneBook
    {

        #region Properties
        int[] Numbers { get; set; }
        string[] Names { get; set; }
        public int Size { get; set; }

        #endregion

        #region Constructors
        // now this constructor will init the arrays with the fixed size of them
        public PhoneBook(int size)
        {
            this.Size = size;
            Names = new string[size];
            Numbers = new int[size];
        }

        #endregion

        #region Methods
        // Add Person To The NoteBook
        // this is not a protictive code every
        public void AddPerson(int position,string PersonName, int PhoneNumber)
        {
            if(Names is not null && Numbers is not null)
            {
                if(position <= this.Size)
                {
                    Names[position] = PersonName;
                    Numbers[position] = PhoneNumber;
                }
            }
        }



        #endregion

        #region Setter And Getter 
        public int GetPersonNumber(string PersonName)
        {
            if (this.Numbers is not null && this.Names is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == PersonName)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;

        }

        // in this case we use the break to avoid making the for loop to continu till the end of the length after it matches the condition of it 
        public void SetPersonNumber(string PersonName, int NewNumber)
        {
            if (Numbers is not null && Names is not null)
                for (int i = 0; i < Names.Length; i++)
                    if (Names[i] == PersonName)
                    {
                        this.Numbers[i] = NewNumber;
                        break;
                    }
        }
        #endregion

        #region Indexer
        // Indexer has parameters 
        // indexer name always is this
        //Note["Ali"] = 666;
        // it always named with this because this will be refer for the object or the variable you will create

        public int this[string name]
        {
            get
            {
                if (this.Numbers is not null && this.Names is not null)
                    for(int i = 0; i < this.Names.Length; i++)
                        if (this.Names[i] == name)
                            return this.Numbers[i];
                return 0;
            }
            set
            {
                 if(this.Names is not null && this.Numbers is not null)
                    for(int i = 0; i < this.Names.Length; i++)
                        if (this.Names[i]== name)
                        {
                            this.Numbers[i] = value;
                                break;
                        }
            }
        }
        // indexer overloading will deal with them with differenct parameters
        // get Only or Readonly indexer
        public string this[int i]
        {
            get
            {
                return $"in the index number {i} :: {Numbers[i]} :: {Names[i]}";
            }
        }

        #endregion

    }
}
