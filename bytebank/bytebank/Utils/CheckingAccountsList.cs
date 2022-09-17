using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Accounts;

namespace bytebank.Utils
{
    public class CheckingAccountsList
    {
        private CheckingAccount[] _items = null;
        private int _nextPosition = 0;

        public CheckingAccountsList(int initialSize = 5)
        {
            _items = new CheckingAccount[initialSize];
        }

        public void Add(CheckingAccount account)
        {
            if (CheckCapacity(_nextPosition))
            {
                _items[_nextPosition] = account;
                _nextPosition++;
            }
            else
            {
                Console.WriteLine("The array is already full.");
            }
        }

        public void Remove(int position)
        {
            if (position < _items.Length)
            {
                _items[position] = null;
            }
            else
            {
                Console.WriteLine("The referenced position does not exist");
            }
        }
        private bool CheckCapacity(int size)
        {
            return _items.Length - 1 >= size;
        }

        public CheckingAccount getItemByIndex(int index)
        {
            if (index < 0 || index >= _items.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return _items[index];
        }

        public int Size
        {
            get
            {
                return _items.Length;
            }
        }

        public CheckingAccount this[int index]
        {
            get
            {
                return getItemByIndex(index);
            }
        }
    }
}
