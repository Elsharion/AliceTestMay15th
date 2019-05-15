using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AliceTestMay15th //part 2 quetion 3
{
    class TestFromGitQuestion1
    {
        List<int> list = new List<int>();

        public TestFromGitQuestion1()  //in github referred as MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                try
                {
                    list.Add(item);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ItemAlreadyExistException");
                }
                return true;
            }

            return false;
        }


        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                try
                {
                     list.Remove(item);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ItemNotFoundException");
                }
                return true;
            }

            return false;
        }

        public int Peek(int index)
        {
            try
            {
                  return list[index];
            }
            catch (Exception e)
            {
                Console.WriteLine("ItemNotFoundException");
                return list[index -1];
            }
        }

        public int this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                if (list[index] == value)
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }




    }
}
