using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    class Numeros
    {
        List<int> _numeros;

        public IReadOnlyList<int> Lista => _numeros.AsReadOnly();

        public Numeros()
        {
            _numeros = new List<int>();
        }

        public static Numeros operator +(Numeros numeros, int numero)
        {
            numeros._numeros.Add(numero);
            return numeros;
        }

        public bool Exists(int val)
        {
            return this._numeros.IndexOf(val) != -1;
        }

        public bool Remove(int val)
        {
            int found = this._numeros.IndexOf(val);
            if (found != -1)
            {
                this._numeros.RemoveAt(found);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Highest()
        {
            int highest = int.MinValue;
            foreach (int num in this._numeros)
            {
                if (highest > num)
                {
                    highest = num;
                }
            }
            return highest;
        }

        public override string ToString()
        {
            if (this._numeros.Count < 1)
            {
                return "{ }";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");
            sb.Append(string.Join(", ", this._numeros));
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
