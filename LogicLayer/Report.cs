using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicLayer
{
    static public class Report
    {
        public static int DetermineRow(Person person)
        {
            if (person.Type == 0)
            {
                return 3;
            }
            else if (person.Type == 1)
            {
                if (person.Rank==10|| person.Rank == 11 || person.Rank == 12)
                {
                    return 4;
                }
                else if (person.Rank == 5 || person.Rank == 6 || person.Rank == 7)
                {
                    switch (person.Rank)
                    {
                        case 5:
                            {
                                return 5;
                            }
                        case 6:
                            {
                                return 6;
                            }
                        case 7:
                            {
                                return 7;
                            }
                        default:
                            return -1;
                    }
                }
                else if (person.Rank==4) return 8;
                else if (person.Rank == 0 || person.Rank == 1 || person.Rank == 2 || person.Rank == 3) return 9;
                else return -1;
            }
            else return -1;
        }
        //public int DetermineCol(Person person)
        //{
        //    switch (person.State)
        //    {
        //        default:
        //            break;
        //    }
        //}
    }
    public class FinalReport
    {
        public string Id { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public List<Person> Content { get; set; }

    }
    public class RowReport
    {
        public int Col { get; set; }
        public int Row { get; set; }
        public List<Person> Content { get; set; }
        public List<Person> BedeContent { get; set; }

    }
    public class PresentAbsentSum
    {
        public int Row { get; set; }
        public List<Person> Absent { get; set; }
        public List<Person> Present { get; set; }

    }
}
